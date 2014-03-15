using System;
using System.Collections.Generic;
using System.Linq;
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
}
