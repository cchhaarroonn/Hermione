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
    public partial class SpamMessage : Form
    {
        public SpamMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String token = tokenBox.Text;
            String id = idBox.Text;
            String message = messageBox.Text;
            int iterations = iterationsTrack.Value;
            int interval = intervalTrack.Value;
            for (int i = 0; i<iterations; i++) {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discord.com/api/v9/channels/" + id + "/messages");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.Headers["authorization"] = token;

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"content\":\"" + message + "\"}";

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
                Thread.Sleep(interval);
            }
        }
    }
}
