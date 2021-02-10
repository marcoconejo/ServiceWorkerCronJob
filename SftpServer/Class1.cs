using Renci.SshNet;
using System;

namespace SftpServer
{
    public class Class1
    {
        public SftpInfo sftpInfo { get; set; }
        public Class1()
        {
       
        }

        public void Main(string [] args)
        {
            using (SftpClient client = new SftpClient(new PrivateKeyConnectionInfo(sftpInfo.Hostname, sftpInfo.Username, sftpInfo.Keyfile)))
            {

            };
        }
    }
}
