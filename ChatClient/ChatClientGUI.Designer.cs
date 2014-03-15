namespace ChatClient
{
    partial class ChatClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonJoin = new System.Windows.Forms.Button();
            this.textBoxConv = new System.Windows.Forms.TextBox();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(732, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxPort.Location = new System.Drawing.Point(736, 106);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(132, 26);
            this.textBoxPort.TabIndex = 1;
            // 
            // buttonJoin
            // 
            this.buttonJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonJoin.Location = new System.Drawing.Point(736, 138);
            this.buttonJoin.Name = "buttonJoin";
            this.buttonJoin.Size = new System.Drawing.Size(133, 46);
            this.buttonJoin.TabIndex = 2;
            this.buttonJoin.Text = "Join";
            this.buttonJoin.UseVisualStyleBackColor = true;
            this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click);
            // 
            // textBoxConv
            // 
            this.textBoxConv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxConv.Location = new System.Drawing.Point(28, 54);
            this.textBoxConv.Multiline = true;
            this.textBoxConv.Name = "textBoxConv";
            this.textBoxConv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConv.Size = new System.Drawing.Size(698, 359);
            this.textBoxConv.TabIndex = 3;
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxMsg.Location = new System.Drawing.Point(28, 435);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(698, 26);
            this.textBoxMsg.TabIndex = 4;
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonSend.Location = new System.Drawing.Point(733, 435);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(132, 26);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conversation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(732, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nickname";
            // 
            // textBoxNick
            // 
            this.textBoxNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxNick.Location = new System.Drawing.Point(736, 54);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(129, 26);
            this.textBoxNick.TabIndex = 8;
            // 
            // ChatClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 494);
            this.Controls.Add(this.textBoxNick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMsg);
            this.Controls.Add(this.textBoxConv);
            this.Controls.Add(this.buttonJoin);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label1);
            this.Name = "ChatClientForm";
            this.Text = "Chat Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonJoin;
        private System.Windows.Forms.TextBox textBoxConv;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNick;
    }
}

