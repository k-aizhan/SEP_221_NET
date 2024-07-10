using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Socet_Server1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btSocket_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        async Task StartServer()
        {
            await Task.Run(() =>
            {
                var ip = Dns.GetHostEntry(tbHost.Text);
                var ad = ip.AddressList[0];
                var ep = new IPEndPoint(ad, int.Parse(tbPort.Text));
                Socket listener = new Socket(ad.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                listener.Bind(ep);
                listener.Listen(20);
                listBox1.Items.Add("Listen to " + ep);
                Socket handler;
                while (true)
                {
                    byte[] bytes = new byte[1024];
                    handler = listener.Accept();
                    string data = null;
                    int count = handler.Receive(bytes);
                    var st = Encoding.UTF8.GetString(bytes, 0, count);
                    listBox1.Items.Add(st);
                    data += Encoding.UTF8.GetString(bytes, 0, count);
                    string replay = "Получить сокет " + data;
                    byte[] response = Encoding.UTF8.GetBytes(replay);
                    handler.Send(response);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            });

        }

        private void newText_TextChanged(object sender, EventArgs e)
        {
            async Task StartServer()
            {
                await Task.Run(() =>
                {
                    newText.Text = string.Empty;
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendToServer();
        }

        private async Task SendToServer()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            try
            {
                await System.IO.File.WriteAllTextAsync(filename, newText.Text);
                MessageBox.Show("Файл сохранен");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the file: {ex.Message}");
            }
        }


        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}

