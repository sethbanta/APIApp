using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace APIApp
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private static String json = null;

        public Form1()
        {
            InitializeComponent();
        }

        static async Task getAll()
        {
            try
            {
                json = await client.GetStringAsync("https://localhost:7180/customer");
                Console.Write(json);
            } 
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

        static async Task getByName(string name)
        {
            try
            {
                var values = new Dictionary<string, string>
                {
                    { "name", name}
                };
                var valuesConvert = JsonConvert.SerializeObject(values, Formatting.Indented);
                var stringContent = new StringContent(json);
                json = await client.GetStringAsync("https://localhost:7180/customer/" + name);
            }
            catch
            {

            }
        }

        static async Task getByNumber(int number)
        {
            try
            {
                var values = new Dictionary<string, int>
                {
                    {"phonenumber", number }
                };
                var valuesConvert = JsonConvert.SerializeObject(values, Formatting.Indented);
                var stringContent = new StringContent(json);
                json = await client.GetStringAsync("https://localhost:7180/customer/" + number);
            }
            catch
            {

            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            getAll();
            rtbOutput.Text += json;
            rtbOutput.Text += Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value = tbGetByName.Text.ToString();
            getByName(value);
            rtbOutput.Text += json;
            rtbOutput.Text += Environment.NewLine;
        }

        private void btnClearRtb_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
        }

        private void tbGetByNumber_TextChanged(object sender, EventArgs e)
        {
            //created this by accident and if i delete it, it destroys the design preview in visual studio
        }

        private void btnGetByNumber_Click(object sender, EventArgs e)
        {
            string text = tbGetByNumber.Text.ToString();
            var value = Int32.Parse(text);
            getByNumber(value);
            rtbOutput.Text += json;
            rtbOutput.Text += Environment.NewLine;
        }
    }
}
