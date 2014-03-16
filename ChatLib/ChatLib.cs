using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib
{
    public interface IChatServer
    {
        void Join(string nickname, string url);
        void SendMsgToServer(string nickname, string msg);
    }

    public interface IChatClient
    {
        void SendMsgToClient(string nickname, string msg);
    }

    public class TcpChannelGenerator
    {
        public static IChannel GetChannel(int tcpPort, bool isSecure)
        {
            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = TypeFilterLevel.Full;
            IDictionary propBag = new Hashtable();
            propBag["port"] = tcpPort;
            propBag["typeFilterLevel"] = TypeFilterLevel.Full;
            propBag["name"] = Guid.NewGuid().ToString();
            if (isSecure)
            {
                propBag["secure"] = isSecure;
                propBag["impersonate"] = false;
            }
            return new TcpChannel(propBag, null, serverProv);
        }
    }

    public static class Constants
    {
        public const int SERVICE_SERV_PORT = 9999;
        public const int SERVICE_CLIE_PORT = 8888;
        public const string REMOTE_SERV_OBJ_NAME = "ChatServer";
        public const string REMOTE_CLIE_OBJ_NAME = "ChatClient";
        public const string SERVER_URL = "tcp://192.168.1.85:9999/ChatServer";
    }
}
