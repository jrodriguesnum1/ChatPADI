using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatLib;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;

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
            guiForm = new ChatClientForm();
            guiForm.join += Join;
            guiForm.sendMsgToServer += SendMsgToServer;
            Application.Run(guiForm);
        }

        private static IChatServer server = null;
        internal static ChatClientForm guiForm;

        static void Join(object sender, JoinEventArgs e)
        {
            TcpChannel channelServ = (TcpChannel)TcpChannelGenerator.GetChannel(Convert.ToInt32(e.Port), true);
            ChannelServices.RegisterChannel(channelServ, true);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ChatClient), Constants.REMOTE_CLIE_OBJ_NAME, WellKnownObjectMode.Singleton);

            TcpChannel channelClt = new TcpChannel();
            ChannelServices.RegisterChannel(channelClt, true);
            server = (IChatServer)Activator.GetObject(typeof(IChatServer), Constants.SERVER_URL);

            server.Join(e.Nickname, URLGenerator.generate(e.Port, Constants.REMOTE_CLIE_OBJ_NAME));
        }

        static void SendMsgToServer(object sender, MsgEventArgs e)
        {
            server.SendMsgToServer(e.Nickname, e.Msg);
        }
    }

    public class ChatClient : MarshalByRefObject, IChatClient
    {
        public void SendMsgToClient(string nickname, string msg)
        {
            Client.guiForm.addMsgToConv(nickname, msg);
        }
    }

    internal class MsgEventArgs : EventArgs
    {
        private string nickname;
        private string msg;

        public MsgEventArgs(string nickname, string msg)
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

    internal class JoinEventArgs : EventArgs
    {
        private string nickname;
        private string port;

        public JoinEventArgs(string nickname, string port)
        {
            this.nickname = nickname;
            this.port = port;
        }

        public string Nickname
        {
            get { return this.nickname; }
        }

        public string Port
        {
            get { return this.port; }
        }
    }
}
