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
        public void SendMsgToClient(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
