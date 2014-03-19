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
        void join(string nickname, string url);
        void sendMsgToServer(string nickname, string msg);
    }

    public interface IChatClient
    {
        void sendMsgToClient(string nickname, string msg);
    }

    public static class Constants
    {
        public const int SERVICE_SERV_PORT = 9999;
        public const int SERVICE_CLIE_PORT = 8888;
        public const string REMOTE_SERV_OBJ_NAME = "ChatServer";
        public const string REMOTE_CLIE_OBJ_NAME = "ChatClient";
        public const string SERVER_URL = "tcp://localhost:9999/ChatServer";
    }
}
