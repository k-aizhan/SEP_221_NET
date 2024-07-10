using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Socet_Client
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void btSocket_Click(object sender, EventArgs e)
        {
            SendToServer();
        }

        async Task SendToServer()
        {
            await Task.Run(() =>
            {
                byte[] bytes = new byte[1024];
                var ip = Dns.GetHostEntry(tbHost.Text);
                var ad = ip.AddressList[0];
                var ep = new IPEndPoint(ad, int.Parse(tbPort.Text));
                Socket sender = new Socket(ad.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                sender.Connect(ep);
                byte[] msg = Encoding.UTF8.GetBytes(tbMessage.Text);
                int count = sender.Send(msg);
                count = sender.Receive(bytes);
                //listBox1.Items.Add("Получено от сервера " + Encoding.UTF8.GetString(bytes, 0, count));
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = listBox1.Text;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btFile_Click(object sender, EventArgs e)
        {
            ReadFile();
        }

        private async Task ReadFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;

            try
            {
                string fileText = await System.IO.File.ReadAllTextAsync(filename);
                textBox1.Text = fileText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}");
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            var ip = Dns.GetHostEntry(tbHost.Text);
            var ad = ip.AddressList[0];
            var ep = new IPEndPoint(ad, int.Parse(tbPort.Text));
            Socket sender2 = new Socket(ad.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            sender2.Connect(ep);
            string path = @"C:\Users\aizhan\Desktop\winform.txt";
            byte[] workBuff = File.ReadAllBytes(path);
            int count = sender2.Send(workBuff); 
            sender2.Shutdown(SocketShutdown.Both);
            sender2.Close();
        }
    }
}

