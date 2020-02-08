using DnsClient;
using DnsClient.Protocol;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PrimS.Telnet;
using Entities;
//using System.Net.Sockets;
namespace Services
{
    public class CheckService
    {
        public string _website;
        public string _emailaddres;
        string _result;
        public Emails _emails;
        public CheckService(Emails email) {
            
            _emailaddres = email.email;
            _emails = email;
            _website = _emailaddres.Split("@")[1];
        }
        public Emails getAllEmailDetails()
        {
            isExist();
            return _emails;
        }
        public bool isDomainExist()
        {
            string website = _website;
            _emails.emailDomain = website;
            if(!string.IsNullOrEmpty(website))
            {
                ArrayList ips = new ArrayList();
                try
                {
                    foreach (IPAddress ip in Dns.GetHostAddresses(website))
                    {
                        if (ip != null && ip + "" != "")
                        {
                            ips.Add(ip.ToString());
                        }

                    }

                }
                catch(Exception)
                {
                    return false;
                }
                
                if(ips!=null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }
        public dynamic getAllDetails()
        {
            var lookup = new LookupClient();
            var record = lookup.Query(_website + "", QueryType.ANY).Answers;
            return record;
        }
        private string getMxRecord()
        {
            string website = _website;
            var lookup = new LookupClient();
            var a=lookup.Query(website + "", QueryType.MX).Answers.ToList();
            try
            {
                //return lookup.Query(website + "", QueryType.ANY).Answers.MxRecords().FirstOrDefault().Exchange.Original;
                _emails.emailMx = lookup.Query(website + "", QueryType.MX).Answers.MxRecords().FirstOrDefault().Exchange.Original;

                return _emails.emailMx;
            }
            catch(Exception)
            {
                _emails.emailMx = "";

                return "";
            }
            
        }   
        public string getMxList()
        {
            return getMxRecord();
        }
        public string getMailUser()
        {
            
            return "";
        }
        public string isExist()
        {
            if(isDomainExist())
            {
                string mxvalue=getMxList();
                if (!string.IsNullOrEmpty(mxvalue))
                {
                    userCheck(mxvalue);
                    
                   
                }
                else
                {
                    _result= "550 Mx Adresi Mevcut Değil";
                }

            }
            else
            {
                _result="550 Böyle bir Web adresi bulunamadı";

            }

            _emails.emailStatus = (!string.IsNullOrEmpty(_result) && _result.Length >= 2 ? _result.Substring(0, 3) : "550");
            _emails.emailStatusDetail = (!string.IsNullOrEmpty(_result) ? _result : "550 Bu adres bulunamadı");
            return _result;
        }
        public async Task userCheck(string server,int port=25,int TimeOutMs=2000)
        {
            try
            {

                //TelNetManager telnet = new TelNetManager(server,port);
                string result = "";
                //telnet.write("Helo hi");
                
                //result = telnet.read();
                //telnet.write("mail from:<denememailadresi@gmail.com>");
                //result = telnet.read();
                //telnet.write("rcpt to:<" + _emailaddres + ">");
                //result = telnet.read();
                //telnet.write("quit");

                MinimalisticTelnet.TelnetConnection telnet1 = new MinimalisticTelnet.TelnetConnection(server,port);

                telnet1.WriteLine("Helo hi");

                telnet1.Read();
                result = telnet1.Read();
                telnet1.WriteLine("mail from:<denememailadresi@gmail.com>"); 
                result = telnet1.Read();
                telnet1.WriteLine("rcpt to:<" + _emailaddres + ">");
                result = telnet1.Read();
                telnet1.WriteLine("quit");

                #region
                //Client client = new Client(server, port, new System.Threading.CancellationToken());


                ////await client.TryLoginAsync("username", "password", TimeoutMs);
                /////////////////////////////

                //string result = "";
                //await client.WriteLine("Helo hi");

                //result = client.ReadAsync().Result;
                //await client.WriteLine("mail from:<denememailadresi@gmail.com>");
                //result = client.ReadAsync().Result;
                //await client.WriteLine("rcpt to:<" + _emailaddres + ">");
                //result = client.ReadAsync().Result;
                //await client.WriteLine("quit");


                //string response = await client.TerminatedReadAsync(">", TimeSpan.FromMilliseconds(TimeOutMs));
                //client.Dispose();
                #endregion

                _result = result;

            }
            catch (Exception ex)
            {

            }
                
        }

    }

}
