namespace TCP_Client
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
            this.ServerIPTextBox = new System.Windows.Forms.TextBox();
            this.ClientPrompt = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.ServerPortTextBox = new System.Windows.Forms.TextBox();
            this.ServerPortLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.AutoSize = true;
            this.ServerIPLabel.Location = new System.Drawing.Point(30, 36);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(100, 15);
            this.ServerIPLabel.TabIndex = 0;
            this.ServerIPLabel.Text = "Server IP Address:";
            // 
            // ServerIPTextBox
            // 
            this.ServerIPTextBox.Location = new System.Drawing.Point(139, 33);
            this.ServerIPTextBox.Name = "ServerIPTextBox";
            this.ServerIPTextBox.Size = new System.Drawing.Size(174, 23);
            this.ServerIPTextBox.TabIndex = 1;
            // 
            // ClientPrompt
            // 
            this.ClientPrompt.Location = new System.Drawing.Point(30, 91);
            this.ClientPrompt.Multiline = true;
            this.ClientPrompt.Name = "ClientPrompt";
            this.ClientPrompt.ReadOnly = true;
            this.ClientPrompt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ClientPrompt.Size = new System.Drawing.Size(508, 243);
            this.ClientPrompt.TabIndex = 2;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(92, 340);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(446, 23);
            this.MessageTextBox.TabIndex = 4;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(30, 343);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(56, 15);
            this.MessageLabel.TabIndex = 3;
            this.MessageLabel.Text = "Message:";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(30, 62);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(508, 23);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(463, 369);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Location = new System.Drawing.Point(406, 33);
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.Size = new System.Drawing.Size(132, 23);
            this.ServerPortTextBox.TabIndex = 8;
            // 
            // ServerPortLabel
            // 
            this.ServerPortLabel.AutoSize = true;
            this.ServerPortLabel.Location = new System.Drawing.Point(319, 36);
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(81, 15);
            this.ServerPortLabel.TabIndex = 7;
            this.ServerPortLabel.Text = "Server Port nr:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 408);
            this.Controls.Add(this.ServerPortTextBox);
            this.Controls.Add(this.ServerPortLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ClientPrompt);
            this.Controls.Add(this.ServerIPTextBox);
            this.Controls.Add(this.ServerIPLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ServerIPLabel;
        private TextBox ServerIPTextBox;
        private TextBox ClientPrompt;
        private TextBox MessageTextBox;
        private Label MessageLabel;
        private Button ConnectButton;
        private Button SendButton;
        private TextBox ServerPortTextBox;
        private Label ServerPortLabel;
    }
}