namespace Socet_Client
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
            listBox1 = new ListBox();
            Host = new Label();
            tbHost = new TextBox();
            tbPort = new TextBox();
            label1 = new Label();
            btSocketClient = new Button();
            tbMessage = new TextBox();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btFile = new Button();
            saveFileDialog1 = new SaveFileDialog();
            btSend = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Top;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(331, 244);
            listBox1.TabIndex = 0;
            // 
            // Host
            // 
            Host.AutoSize = true;
            Host.Location = new Point(12, 324);
            Host.Name = "Host";
            Host.Size = new Size(32, 15);
            Host.TabIndex = 1;
            Host.Text = "Host";
            // 
            // tbHost
            // 
            tbHost.Location = new Point(75, 324);
            tbHost.Name = "tbHost";
            tbHost.Size = new Size(175, 23);
            tbHost.TabIndex = 2;
            tbHost.Text = "127.0.0.1";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(75, 368);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(175, 23);
            tbPort.TabIndex = 4;
            tbPort.Text = "8080";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 372);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 3;
            label1.Text = "Port";
            // 
            // btSocketClient
            // 
            btSocketClient.Location = new Point(75, 452);
            btSocketClient.Name = "btSocketClient";
            btSocketClient.Size = new Size(175, 23);
            btSocketClient.TabIndex = 5;
            btSocketClient.Text = "Socket Send";
            btSocketClient.UseVisualStyleBackColor = true;
            btSocketClient.Click += btSocket_Click;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(75, 413);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(175, 23);
            tbMessage.TabIndex = 7;
            tbMessage.Text = "Hello world";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 417);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "Message";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // btFile
            // 
            btFile.Location = new Point(75, 542);
            btFile.Name = "btFile";
            btFile.Size = new Size(175, 23);
            btFile.TabIndex = 8;
            btFile.Text = "Посмотреть";
            btFile.UseVisualStyleBackColor = true;
            btFile.Click += btFile_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // btSend
            // 
            btSend.Location = new Point(75, 499);
            btSend.Name = "btSend";
            btSend.Size = new Size(175, 23);
            btSend.TabIndex = 9;
            btSend.Text = "Отправить на сервер";
            btSend.UseVisualStyleBackColor = true;
            btSend.Click += btSend_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 264);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 23);
            textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 592);
            Controls.Add(textBox1);
            Controls.Add(btSend);
            Controls.Add(btFile);
            Controls.Add(tbMessage);
            Controls.Add(label2);
            Controls.Add(btSocketClient);
            Controls.Add(tbPort);
            Controls.Add(label1);
            Controls.Add(tbHost);
            Controls.Add(Host);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "SocetClient";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label Host;
        private TextBox tbHost;
        private TextBox tbPort;
        private Label label1;
        private Button btSocketClient;
        private TextBox tbMessage;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private Button btFile;
        private SaveFileDialog saveFileDialog1;
        private Button btSend;
        private TextBox textBox1;
    }
}
