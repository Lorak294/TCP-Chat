namespace TCP_Server
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
            this.ServerIPLabel = new System.Windows.Forms.Label();
            this.ServerIPTextbox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ServerPrompt = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.ConnectedClientsLabel = new System.Windows.Forms.Label();
            this.ClientListBox = new System.Windows.Forms.ListBox();
            this.ServerPortTextBox = new System.Windows.Forms.TextBox();
            this.ServerPortLabel = new System.Windows.Forms.Label();
            this.ServerStopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.AutoSize = true;
            this.ServerIPLabel.Location = new System.Drawing.Point(35, 33);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(55, 15);
            this.ServerIPLabel.TabIndex = 0;
            this.ServerIPLabel.Text = "Server IP:";
            // 
            // ServerIPTextbox
            // 
            this.ServerIPTextbox.Location = new System.Drawing.Point(103, 30);
            this.ServerIPTextbox.Name = "ServerIPTextbox";
            this.ServerIPTextbox.ReadOnly = true;
            this.ServerIPTextbox.Size = new System.Drawing.Size(299, 23);
            this.ServerIPTextbox.TabIndex = 1;
            this.ServerIPTextbox.Text = "127.0.0.1";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(408, 30);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(106, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ServerPrompt
            // 
            this.ServerPrompt.Location = new System.Drawing.Point(103, 96);
            this.ServerPrompt.Multiline = true;
            this.ServerPrompt.Name = "ServerPrompt";
            this.ServerPrompt.ReadOnly = true;
            this.ServerPrompt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ServerPrompt.Size = new System.Drawing.Size(411, 209);
            this.ServerPrompt.TabIndex = 3;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(103, 311);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(411, 23);
            this.MessageTextBox.TabIndex = 5;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(35, 313);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(56, 15);
            this.MessageLabel.TabIndex = 4;
            this.MessageLabel.Text = "Message:";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(419, 340);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(95, 23);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ConnectedClientsLabel
            // 
            this.ConnectedClientsLabel.AutoSize = true;
            this.ConnectedClientsLabel.Location = new System.Drawing.Point(520, 33);
            this.ConnectedClientsLabel.Name = "ConnectedClientsLabel";
            this.ConnectedClientsLabel.Size = new System.Drawing.Size(107, 15);
            this.ConnectedClientsLabel.TabIndex = 7;
            this.ConnectedClientsLabel.Text = "Connected Clients:";
            // 
            // ClientListBox
            // 
            this.ClientListBox.FormattingEnabled = true;
            this.ClientListBox.ItemHeight = 15;
            this.ClientListBox.Location = new System.Drawing.Point(520, 59);
            this.ClientListBox.Name = "ClientListBox";
            this.ClientListBox.Size = new System.Drawing.Size(150, 304);
            this.ClientListBox.TabIndex = 8;
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Location = new System.Drawing.Point(103, 60);
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.Size = new System.Drawing.Size(299, 23);
            this.ServerPortTextBox.TabIndex = 10;
            this.ServerPortTextBox.Text = "2157";
            // 
            // ServerPortLabel
            // 
            this.ServerPortLabel.AutoSize = true;
            this.ServerPortLabel.Location = new System.Drawing.Point(35, 63);
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(67, 15);
            this.ServerPortLabel.TabIndex = 9;
            this.ServerPortLabel.Text = "Server Port:";
            // 
            // ServerStopButton
            // 
            this.ServerStopButton.Location = new System.Drawing.Point(408, 59);
            this.ServerStopButton.Name = "ServerStopButton";
            this.ServerStopButton.Size = new System.Drawing.Size(106, 24);
            this.ServerStopButton.TabIndex = 11;
            this.ServerStopButton.Text = "Stop";
            this.ServerStopButton.UseVisualStyleBackColor = true;
            this.ServerStopButton.Click += new System.EventHandler(this.ServerStopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 382);
            this.Controls.Add(this.ServerStopButton);
            this.Controls.Add(this.ServerPortTextBox);
            this.Controls.Add(this.ServerPortLabel);
            this.Controls.Add(this.ClientListBox);
            this.Controls.Add(this.ConnectedClientsLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ServerPrompt);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ServerIPTextbox);
            this.Controls.Add(this.ServerIPLabel);
            this.Name = "Form1";
            this.Text = "TCP/IP Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ServerIPLabel;
        private TextBox ServerIPTextbox;
        private Button StartButton;
        private TextBox ServerPrompt;
        private TextBox MessageTextBox;
        private Label MessageLabel;
        private Button SendButton;
        private Label ConnectedClientsLabel;
        private ListBox ClientListBox;
        private TextBox ServerPortTextBox;
        private Label ServerPortLabel;
        private Button ServerStopButton;
    }
}