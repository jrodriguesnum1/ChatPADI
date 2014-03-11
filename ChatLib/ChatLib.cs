using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib
{
    public interface IChatServer
    {
        public bool Join(string nickname, string url);
        public bool SendMsgToServer(string msg);
    }

    public interface IChatClient
    {
        public bool SendMsgToClient(string msg);
    }
}
