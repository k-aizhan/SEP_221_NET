namespace Socet_Server1
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
            btSocket = new Button();
            button1 = new Button();
            newText = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Top;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(254, 304);
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
            tbHost.Location = new Point(50, 324);
            tbHost.Name = "tbHost";
            tbHost.Size = new Size(175, 23);
            tbHost.TabIndex = 2;
            tbHost.Text = "127.0.0.1";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(50, 368);
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
            // btSocket
            // 
            btSocket.Location = new Point(73, 415);
            btSocket.Name = "btSocket";
            btSocket.Size = new Size(128, 23);
            btSocket.TabIndex = 5;
            btSocket.Text = "Socket Start";
            btSocket.UseVisualStyleBackColor = true;
            btSocket.Click += btSocket_Click;
            // 
            // button1
            // 
            button1.Location = new Point(73, 538);
            button1.Name = "button1";
            button1.Size = new Size(128, 28);
            button1.TabIndex = 6;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // newText
            // 
            newText.Location = new Point(32, 481);
            newText.Name = "newText";
            newText.Size = new Size(210, 23);
            newText.TabIndex = 7;
            newText.TextChanged += newText_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 628);
            Controls.Add(newText);
            Controls.Add(button1);
            Controls.Add(btSocket);
            Controls.Add(tbPort);
            Controls.Add(label1);
            Controls.Add(tbHost);
            Controls.Add(Host);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "SocetServer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label Host;
        private TextBox tbHost;
        private TextBox tbPort;
        private Label label1;
        private Button btSocket;
        private Button button1;
        private TextBox newText;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
