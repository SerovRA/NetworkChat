namespace chatClient
{
    partial class chatForm
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
            this.enterChat = new System.Windows.Forms.Button();
            this.gui_userName = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.chat_msg = new System.Windows.Forms.TextBox();
            this.chat_send = new System.Windows.Forms.Button();
            this.gui_chat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterChat
            // 
            this.enterChat.Location = new System.Drawing.Point(527, 9);
            this.enterChat.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.enterChat.Name = "enterChat";
            this.enterChat.Size = new System.Drawing.Size(287, 51);
            this.enterChat.TabIndex = 0;
            this.enterChat.Text = "Войти в чат";
            this.enterChat.UseVisualStyleBackColor = true;
            this.enterChat.Click += new System.EventHandler(this.enterChat_Click);
            // 
            // gui_userName
            // 
            this.gui_userName.AutoSize = true;
            this.gui_userName.Location = new System.Drawing.Point(23, 20);
            this.gui_userName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.gui_userName.Name = "gui_userName";
            this.gui_userName.Size = new System.Drawing.Size(242, 29);
            this.gui_userName.TabIndex = 1;
            this.gui_userName.Text = "Введите ваше имя: ";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(280, 11);
            this.userName.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(228, 35);
            this.userName.TabIndex = 2;
            // 
            // chatBox
            // 
            this.chatBox.Enabled = false;
            this.chatBox.Location = new System.Drawing.Point(28, 321);
            this.chatBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(1217, 423);
            this.chatBox.TabIndex = 3;
            this.chatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatBox_KeyDown);
            // 
            // chat_msg
            // 
            this.chat_msg.Enabled = false;
            this.chat_msg.Location = new System.Drawing.Point(28, 767);
            this.chat_msg.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.chat_msg.Name = "chat_msg";
            this.chat_msg.Size = new System.Drawing.Size(916, 35);
            this.chat_msg.TabIndex = 4;
            this.chat_msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chat_msg_KeyDown);
            // 
            // chat_send
            // 
            this.chat_send.Enabled = false;
            this.chat_send.Location = new System.Drawing.Point(964, 763);
            this.chat_send.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.chat_send.Name = "chat_send";
            this.chat_send.Size = new System.Drawing.Size(287, 51);
            this.chat_send.TabIndex = 5;
            this.chat_send.Text = "Отправить";
            this.chat_send.UseVisualStyleBackColor = true;
            this.chat_send.Click += new System.EventHandler(this.chat_send_Click);
            // 
            // gui_chat
            // 
            this.gui_chat.AutoSize = true;
            this.gui_chat.Location = new System.Drawing.Point(28, 286);
            this.gui_chat.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.gui_chat.Name = "gui_chat";
            this.gui_chat.Size = new System.Drawing.Size(61, 29);
            this.gui_chat.TabIndex = 6;
            this.gui_chat.Text = "Чат:";
            // 
            // chatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 859);
            this.Controls.Add(this.gui_chat);
            this.Controls.Add(this.chat_send);
            this.Controls.Add(this.chat_msg);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.gui_userName);
            this.Controls.Add(this.enterChat);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "chatForm";
            this.Text = "OnlineChat";
            this.Load += new System.EventHandler(this.chatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterChat;
        private System.Windows.Forms.Label gui_userName;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.TextBox chat_msg;
        private System.Windows.Forms.Button chat_send;
        private System.Windows.Forms.Label gui_chat;
    }
}

