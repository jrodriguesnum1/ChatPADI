using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatLib;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;

namespace ChatServer
{
    class Server
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(9999);
            ChannelServices.RegisterChannel(channel, true);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(IChatServer), "ChatServer", WellKnownObjectMode.Singleton);
            Console.WriteLine("Press <enter> to exit");
            Console.ReadLine();
        }
    }

    public class ChatServer : MarshalByRefObject, IChatServer
    {
        public bool Join(string nickname, string url)
        {
            throw new NotImplementedException();
        }

        public bool SendMsgToServer(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
