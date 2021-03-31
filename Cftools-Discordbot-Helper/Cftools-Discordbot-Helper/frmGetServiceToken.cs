using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace Cftools_Discordbot_Helper
{
    public partial class frmGetServiceToken : Form
    {
        public class Token
        {
            public string service_id { get; set; }
            public string token { get; set; }
            public string token_id { get; set; }
            public string token_type { get; set; }
        }

        public class Root
        {
            public bool status { get; set; }
            public List<Token> tokens { get; set; }
        }

        public class JwtToken
        {
            public string access_token { get; set; }
            public string refresh_token { get; set; }
            public bool status { get; set; }
        }

        public frmGetServiceToken()
        {
            InitializeComponent();
            this.pnlTop.MouseMove += new MouseEventHandler(pnlMove);
        }
        #region Move Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void pnlMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Point loc1 = MousePosition;
                this.Location = loc1;
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using my bot, this tool will allow you to get the service token to make the Discord bot to work with your CFTools Enabled server.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {
            if (checktxtdone())
                btnGetServiceToken.Enabled = true;
            else
                btnGetServiceToken.Enabled = false;
        }

        private Boolean checktxtdone()
        {
            if (txtClient.Text.Trim().Length != 0 && txtUserAgent.Text.Trim().Length != 0 && txtSecret.Text.Trim().Length != 0)
                return true;
            else return false;
        }

        private void txtUserAgent_TextChanged(object sender, EventArgs e)
        {
            if (checktxtdone())
                btnGetServiceToken.Enabled = true;
            else
                btnGetServiceToken.Enabled = false;
        }

        private void txtSecret_TextChanged(object sender, EventArgs e)
        {
            if (checktxtdone())
                btnGetServiceToken.Enabled = true;
            else
                btnGetServiceToken.Enabled = false;
        }



        async private void btnGetServiceToken_Click(object sender, EventArgs e)
        {
            var json = JsonConvert.SerializeObject(new { secret = ComputeStringToSha256Hash(txtSecret.Text) });
            var data = new StringContent(json);
            var http = new HttpClient();
            http.DefaultRequestHeaders.Add("Client-ID", txtClient.Text);
            http.DefaultRequestHeaders.Add("User-Agent", txtUserAgent.Text);
            var response = http.PostAsync("https://cfapi.de/auth/login", data);
            var responseString = await response.Result.Content.ReadAsStringAsync();
            JwtToken myDeserializedClass = JsonConvert.DeserializeObject<JwtToken>(responseString);
            http.DefaultRequestHeaders.Add("Authorization", "Bearer " + myDeserializedClass.access_token);
            response = http.GetAsync("https://cfapi.de/v1/servicetokens");
            responseString = await response.Result.Content.ReadAsStringAsync();
            Root ServiceToken = JsonConvert.DeserializeObject<Root>(responseString);
            Clipboard.SetData(DataFormats.Text, (Object)ServiceToken.tokens[0].token);
            MessageBox.Show("Your Service Token has been added to your clipboard, now you can paste your Service token on the discord Settings.json folder");
        }

        static string ComputeStringToSha256Hash(string plainText)
        {
            // Create a SHA256 hash from string   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Computing Hash - returns here byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainText));

                // now convert byte array to a string   
                StringBuilder stringbuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    stringbuilder.Append(bytes[i].ToString("x2"));
                }
                return stringbuilder.ToString();
            }
        }
    }
}
