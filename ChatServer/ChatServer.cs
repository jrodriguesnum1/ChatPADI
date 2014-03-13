using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatLib;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.Collections;

namespace ChatServer
{
    class Server
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(9999);
            ChannelServices.RegisterChannel(channel, true);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ChatServer), "ChatServer", WellKnownObjectMode.Singleton);
            Console.WriteLine("Press <enter> to exit");
            Console.ReadLine();
        }
    }

    public class ChatServer : MarshalByRefObject, IChatServer
    {
        private Hashtable users = new Hashtable();

        public void Join(string nickname, string url)
        {
            this.users.Add(nickname, url);
        }

        public void SendMsgToServer(string nickname, string msg)
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, true);

            foreach (DictionaryEntry userPair in users)
            {
                if (!userPair.Key.Equals(nickname))
                {
                    IChatClient client = (IChatClient) Activator.GetObject(typeof(IChatClient), (string) userPair.Value);
                    client.SendMsgToClient(msg);
                }
            }
        }
    }
}
