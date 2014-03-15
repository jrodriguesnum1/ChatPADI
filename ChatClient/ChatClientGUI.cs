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

        public ChatClientForm()
        {
            InitializeComponent();
            ChatClient.ReceivedMsg += this.addMsgToConv;
        }

        private void addMsgToConv(object sender, ReceivedMsgEventArgs e)
        {
            this.textBoxConv.AppendText(e.Nickname + " says: " + e.Msg + "\r\n");
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            if (this.textBoxNick.TextLength != 0)
            {

            }
            else
            {
                this.textBoxConv.AppendText("<Couldn't join conversation: Nickname undefined>\r\n");
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (this.textBoxMsg.TextLength != 0)
            {

            }
        }
    }
}
