using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib
{
    public interface IChatServer
    {
        public void Join(string nickname, string url);
        public void SendMsgToServer(string nickname, string msg);
    }

    public interface IChatClient
    {
        public void SendMsgToClient(string msg);
    }
}
