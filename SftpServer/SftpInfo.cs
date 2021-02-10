using System;
using System.Collections.Generic;
using System.Text;
using Renci.SshNet

namespace SftpServer
{
    public class SftpInfo
    {
        public string Username { get; set; }
        public string Hostname { get; set; }
        public PrivateKeyFile Keyfile { get; set; }
    }
}
