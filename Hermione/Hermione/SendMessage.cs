using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermione
{
    public partial class SendMessage : Form
    {
        public SendMessage()
        {
            InitializeComponent();
        }

        private void SendMessage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String token = tokenBox.Text;
            String id = idBox.Text;
            String message = messageBox.Text;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discord.com/api/v9/channels/" + id + "/messages");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers["authorization"] = token;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"content\":\"" + message +"\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tokenBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
