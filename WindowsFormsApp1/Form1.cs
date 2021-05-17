using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_Start_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = "Loading..";
            btn_Start.Visible = false;
            if (tb_ID.Text.Length > 0)
            {
                using var client = new HttpClient();
                var response = await client.GetStringAsync("https://api.polytoria.com/v1/users/user?id=" + tb_ID.Text);
                dynamic json = JsonConvert.DeserializeObject(response);
                lbl_Message.Text = json.Username;
                btn_Start.Visible = true;
            }
            else
            {
                lbl_Message.Text = "enter the ID";
                btn_Start.Visible = true;
            }

        }

        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
