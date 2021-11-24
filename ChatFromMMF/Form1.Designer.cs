namespace ChatFromMMF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startNewProcessButton = new System.Windows.Forms.Button();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.updateChatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startNewProcessButton
            // 
            this.startNewProcessButton.Location = new System.Drawing.Point(508, 12);
            this.startNewProcessButton.Name = "startNewProcessButton";
            this.startNewProcessButton.Size = new System.Drawing.Size(280, 174);
            this.startNewProcessButton.TabIndex = 0;
            this.startNewProcessButton.Text = "NewProcess";
            this.startNewProcessButton.UseVisualStyleBackColor = true;
            this.startNewProcessButton.Click += new System.EventHandler(this.startNewFormButton_Click);
            // 
            // chatTextBox
            // 
            this.chatTextBox.Location = new System.Drawing.Point(22, 12);
            this.chatTextBox.Multiline = true;
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.ReadOnly = true;
            this.chatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.chatTextBox.Size = new System.Drawing.Size(480, 404);
            this.chatTextBox.TabIndex = 1;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(584, 267);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(127, 27);
            this.nicknameTextBox.TabIndex = 2;
            this.nicknameTextBox.Text = "MyNick";
            this.nicknameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(508, 300);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(280, 27);
            this.messageTextBox.TabIndex = 3;
            this.messageTextBox.Text = "This text will be send in chat";
            this.messageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(508, 333);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(280, 83);
            this.sendMessageButton.TabIndex = 4;
            this.sendMessageButton.Text = "Send message";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // updateChatButton
            // 
            this.updateChatButton.Location = new System.Drawing.Point(508, 192);
            this.updateChatButton.Name = "updateChatButton";
            this.updateChatButton.Size = new System.Drawing.Size(278, 61);
            this.updateChatButton.TabIndex = 5;
            this.updateChatButton.Text = "Update Chat";
            this.updateChatButton.UseVisualStyleBackColor = true;
            this.updateChatButton.Click += new System.EventHandler(this.updateChatButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateChatButton);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.startNewProcessButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startNewProcessButton;
        private TextBox chatTextBox;
        private TextBox nicknameTextBox;
        private TextBox messageTextBox;
        private Button sendMessageButton;
        private Button updateChatButton;
    }
}