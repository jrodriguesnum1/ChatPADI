using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class ChatClientForm : Form
    {
        private string nickname;
        delegate void AddMsgToConvDelegate(string nickname, string msg);
        internal event EventHandler<JoinEventArgs> join;
        internal event EventHandler<MsgEventArgs> sendMsgToServer;

        public ChatClientForm()
        {
            InitializeComponent();
            this.nickname = null;
        }

        public void addMsgToConv(string nickname, string msg)
        {
            if (this.textBoxConv.InvokeRequired)
            {
                this.textBoxConv.Invoke(new AddMsgToConvDelegate(addMsgToConv), new object[] { nickname, msg });
            }
            else
            {
                this.textBoxConv.AppendText(nickname + ": " + msg + "\r\n");
            }
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            if (this.textBoxNick.TextLength != 0 && this.textBoxPort.TextLength != 0)
            {
                this.nickname = this.textBoxNick.Text;

                EventHandler<JoinEventArgs> joinHandle = this.join;

                if (joinHandle != null)
                {
                    joinHandle(this, new JoinEventArgs(this.nickname, this.textBoxPort.Text));
                }

                this.textBoxConv.AppendText("<Joined converstion>\r\n");
            }
            else
            {
                this.textBoxConv.AppendText("<Couldn't join conversation: Nickname or port undefined>\r\n");
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (this.textBoxMsg.TextLength != 0 && this.nickname != null)
            {
                string msg = this.textBoxMsg.Text;
                EventHandler<MsgEventArgs> sendMsgToServerHandle = this.sendMsgToServer;

                if (sendMsgToServerHandle != null)
                {
                    sendMsgToServerHandle(this, new MsgEventArgs(this.nickname, msg));
                }
                this.textBoxMsg.Text = "";
                this.textBoxConv.AppendText("You: " + msg + "\r\n");
            }
        }
    }
}
