using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatLib;

namespace ChatClient
{
    
    static class Client
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChatClientForm());
        }
    }

    public class ChatClient : MarshalByRefObject, IChatClient
    {
        public static event EventHandler<ReceivedMsgEventArgs> ReceivedMsg;

        public void SendMsgToClient(string nickname, string msg)
        {
            EventHandler<ReceivedMsgEventArgs> rcvMsgHandle = ReceivedMsg;

            if (rcvMsgHandle != null)
            {
                rcvMsgHandle(this, new ReceivedMsgEventArgs(nickname, msg));
            }

        }
    }

    public class ReceivedMsgEventArgs : EventArgs
    {
        private string nickname;
        private string msg;

        public ReceivedMsgEventArgs(string nickname, string msg)
        {
            this.nickname = nickname;
            this.msg = msg;
        }

        public string Nickname
        {
            get { return this.nickname; }
        }

        public string Msg
        {
            get { return this.msg; }
        }
    }
}
