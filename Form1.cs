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
        private static bool logged = false;

        public Form1()
        {
            InitializeComponent();
        }

        static async Task getAll()
        {
            try
            {
                json = await client.GetStringAsync("https://localhost:7180/customer/GetAllCustomers");
                Console.Write(json);
            } 
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.InnerException);
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
                json = await client.GetStringAsync("https://localhost:7180/customer/GetCustomerByName/" + name);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.InnerException);
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
                json = await client.GetStringAsync("https://localhost:7180/customer/GetCustomerById/" + number);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.InnerException);
            }
        }

        private async void btnGetAll_ClickAsync(object sender, EventArgs e)
        {
            await getAll();
            rtbOutput.Text += json;
            rtbOutput.Text += Environment.NewLine;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var value = tbGetByName.Text.ToString();
            await getByName(value);
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

        private async void btnGetByNumber_Click(object sender, EventArgs e)
        {
            string text = tbGetByNumber.Text.ToString();
            var value = Int32.Parse(text);
            await getByNumber(value);
            rtbOutput.Text += json;
            rtbOutput.Text += Environment.NewLine;
        }

        private void btnUpdateByNameToggle_Click(object sender, EventArgs e)
        {
            hideUpdateControls();
            makeUpdateControlsVisible();
            lblToggledUpdateByName.Visible = true;
            txtToggledUpdateByName.Visible = true;
            btnToggledUpdateByName.Visible = true;
        }

        private void makeUpdateControlsVisible()
        {
            lblName.Visible = true;
            lblPhoneNumber.Visible = true;
            lblAge.Visible = true;
            lblFavoritePizza.Visible = true;
            txtToggledName.Visible = true;
            txtToggledPhoneNumber.Visible = true;
            txtToggledAge.Visible = true;
            txtToggledFavoritePizza.Visible = true;
        }

        private void hideUpdateControls()
        {
            lblName.Visible = false;
            lblPhoneNumber.Visible = false;
            lblAge.Visible = false;
            lblFavoritePizza.Visible = false;
            txtToggledName.Visible = false;
            txtToggledPhoneNumber.Visible = false;
            txtToggledAge.Visible = false;
            txtToggledFavoritePizza.Visible = false;
            btnToggledUpdateByName.Visible = false;
            lblToggledUpdateByName.Visible = false;
            txtToggledUpdateByName.Visible = false;
            lblToggledUpdateByNumber.Visible = false;
            txtToggledUpdateByNumber.Visible = false;
            btnToggledUpdateByNumber.Visible = false;
            btnToggledAdd.Visible = false;
            lblToggledDelete.Visible = false;
            txtToggledDelete.Visible = false;
            btnToggledDelete.Visible = false;
            lblLogin.Visible = false;
            txtLogin.Visible = false;
            btnLoginTwo.Visible = false;
        }

        private void btnUpdateByNumberToggle_Click(object sender, EventArgs e)
        {
            hideUpdateControls();
            makeUpdateControlsVisible();
            lblToggledUpdateByNumber.Visible = true;
            txtToggledUpdateByNumber.Visible = true;
            btnToggledUpdateByNumber.Visible = true;
        }

        private void btnToggledUpdateByName_Click(object sender, EventArgs e)
        {
            //TODO: take in the values put in the text boxes and then send a put request with the data to the api
            var nameToUpdate = txtToggledUpdateByName.ToString();
            var newName = txtToggledName.Text.ToString();
            var newPhone = txtToggledPhoneNumber.Text.ToString();
            if (newPhone.Length != 10)
            {
                //entered a number that was too short/long
                rtbOutput.Text += "Phone number entered was too short ot long please try again";
                rtbOutput.Text += Environment.NewLine;
                return;
            }
            var newAge = txtToggledAge.Text.ToString();
            if (newAge.Length > 3 | (newAge.Length == 3 && (newAge.Substring(0, 2) != "12" && newAge.Substring(0, 2) != "11" && newAge.Substring(0, 2) != "10")))
            {
                //entered an age that was too large or unrealistic (someone older than 122 which is already unrealistic)
                rtbOutput.Text += "Invalid age was entered";
                rtbOutput.Text += Environment.NewLine;
                return;
            }
            var newPizza = txtToggledFavoritePizza.Text.ToString();
            updateCustomer(nameToUpdate, newName, newPhone, newAge, newPizza);
            hideUpdateControls();
            clearUpdateControls();
            lblToggledUpdateByName.Visible = false;
            txtToggledUpdateByName.Visible = false;
            btnToggledUpdateByName.Visible = false;
        }

        private void btnAddNewToggle_Click(object sender, EventArgs e)
        {
            hideUpdateControls();
            makeUpdateControlsVisible();
            btnToggledAdd.Visible = true;
        }

        private void btnDeleteToggle_Click(object sender, EventArgs e)
        {
            hideUpdateControls();
            lblToggledDelete.Visible = true;
            txtToggledDelete.Visible = true;
            btnToggledDelete.Visible = true;
        }

        private void btnToggledUpdateByNumber_Click(object sender, EventArgs e)
        {
            //TODO: take in the values put in the text boxes and then send a put request with the data to the api
            var numberToUpdate = txtToggledUpdateByNumber.Text.ToString();
            if (numberToUpdate.Length != 10)
            {
                //entered a number that was too short/long
                rtbOutput.Text += "Phone number entered was too short or long please try again";
                rtbOutput.Text += Environment.NewLine;
                return;
            }
            var newName = txtToggledName.Text.ToString();
            var newPhone = txtToggledPhoneNumber.Text.ToString();
            if (newPhone.Length != 10)
            {
                //entered a number that was too short/long
                rtbOutput.Text += "Phone number entered was too short ot long please try again";
                rtbOutput.Text += Environment.NewLine;
                return;
            }
            var newAge = txtToggledAge.Text.ToString();
            if (newAge.Length > 3 | (newAge.Length == 3 && (newAge.Substring(0, 2) != "12" && newAge.Substring(0, 2) != "11" && newAge.Substring(0, 2) != "10")))
            {
                //entered an age that was too large or unrealistic (someone older than 122 which is already unrealistic)
                rtbOutput.Text += "Invalid age was entered";
                rtbOutput.Text += Environment.NewLine;
                return;
            }
            var newPizza = txtToggledFavoritePizza.Text.ToString();
            updateCustomerByNumber(numberToUpdate, newName, newPhone, newAge, newPizza);
            hideUpdateControls();
            clearUpdateControls();
            lblToggledUpdateByNumber.Visible = false;
            txtToggledUpdateByNumber.Visible = false;
            btnToggledUpdateByNumber.Visible = false;
        }

        private void btnToggledAdd_Click(object sender, EventArgs e)
        {
            //TODO: take in the values put in the text boxes and then send a put request with the data to the api
            var newName = txtToggledName.Text.ToString();
            var newPhone = txtToggledPhoneNumber.Text.ToString();
            if (newPhone.Length != 10)
            {
                //entered a number that was too short/long
                rtbOutput.Text += "Phone number entered was too short ot long please try again";
                rtbOutput.Text += Environment.NewLine;
                return;
            }
            var newAge = txtToggledAge.Text.ToString();
            if (newAge.Length > 3 | (newAge.Length == 3 && (newAge.Substring(0, 2) != "12" && newAge.Substring(0, 2) != "11" && newAge.Substring(0, 2) != "10")))
            {
                //entered an age that was too large or unrealistic (someone older than 122 which is already unrealistic)
                rtbOutput.Text += "Invalid age was entered";
                rtbOutput.Text += Environment.NewLine;
                return;
            }
            var newPizza = txtToggledFavoritePizza.Text.ToString();
            addNewCustomer(newName, newPhone, newAge, newPizza);
            hideUpdateControls();
            clearUpdateControls();
            btnToggledAdd.Visible = false;
        }

        private void btnToggledDelete_Click(object sender, EventArgs e)
        {
            //TODO: take in the value put in the text box and then send a delete request
            var value = txtToggledDelete.Text.ToString();
            deleteByName(value);
            hideUpdateControls();
            clearUpdateControls();
            lblToggledDelete.Visible = false;
            txtToggledDelete.Visible = false;
            btnToggledDelete.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            hideUpdateControls();
            lblLogin.Visible = true;
            txtLogin.Visible = true;
            btnLoginTwo.Visible = true;
        }

        private void btnLoginTwo_Click(object sender, EventArgs e)
        {
            var value = txtLogin.Text.ToString();
            loginWithGuid(value);
            hideUpdateControls();
            if (value == "0f8fad5b-d9cb-469f-a165-70867728950e")
            {
                btnLogin.Visible = false;
                logged = true;
                btnAddNewToggle.Visible = true;
                btnUpdateByNameToggle.Visible = true;
                btnUpdateByNumberToggle.Visible = true;
                btnDeleteToggle.Visible = true;
            }      
        }

        static async Task loginWithGuid(string guid)
        {
            try
            {
                var values = new Dictionary<string, string>
                {
                    { "guid", guid}
                };
                var valuesConvert = JsonConvert.SerializeObject(values, Formatting.Indented);
                var stringContent = new StringContent(json);
                Console.WriteLine(valuesConvert);
                Console.WriteLine(stringContent);
                json = await client.GetStringAsync("https://localhost:7180/customer/Login/" + guid);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.InnerException);
            }
        }

        static async Task deleteByName(string name)
        {
            try
            {
                if(logged == true)
                {
                    var values = new Dictionary<string, string>
                    {
                        { "name", name}
                    };
                    var valuesConvert = JsonConvert.SerializeObject(values, Formatting.Indented);
                    var stringContent = new StringContent(json);
                    json = await client.GetStringAsync("https://localhost:7180/customer/DeleteByName/" + name + "/0f8fad5b-d9cb-469f-a165-70867728950e");
                }

            }
            catch
            {

            }
        }

        static async Task addNewCustomer(string name, string phoneNumber, string age, string pizza)
        {
            try
            {
                var values = new Dictionary<string, string>
                    {
                        { "Name", name},
                        { "PhoneNumber", phoneNumber},
                        { "Age", age},
                        { "FavoritePizza", pizza}
                    };
                var customer = JsonConvert.SerializeObject(values, Formatting.Indented);
                Console.WriteLine(customer);
                var requestContent = new StringContent(customer, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7180/customer/NewCustomer/", requestContent);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.InnerException);
            }
        }

        static async Task updateCustomer(string nameToUpdate, string name, string phoneNumber, string age, string pizza) 
        {
            try
            {
                var values = new Dictionary<string, string>
                    {
                        { "Name", name},
                        { "PhoneNumber", phoneNumber},
                        { "Age", age},
                        { "FavoritePizza", pizza}
                    };
                var customer = JsonConvert.SerializeObject(values, Formatting.Indented);
                Console.WriteLine(customer);
                var requestContent = new StringContent(customer, Encoding.UTF8, "application/json");
                var response = await client.PutAsync("https://localhost:7180/customer/UpdateByNameFromApp/" + nameToUpdate, requestContent);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

        static async Task updateCustomerByNumber(string numberToUpdate, string name, string phoneNumber, string age, string pizza)
        {
            try
            {
                var values = new Dictionary<string, string>
                    {
                        { "Name", name},
                        { "PhoneNumber", phoneNumber},
                        { "Age", age},
                        { "FavoritePizza", pizza}
                    };
                var customer = JsonConvert.SerializeObject(values, Formatting.Indented);
                Console.WriteLine(customer);
                var requestContent = new StringContent(customer, Encoding.UTF8, "application/json");
                var response = await client.PutAsync("https://localhost:7180/customer/UpdateByIdFromApp/" + numberToUpdate, requestContent);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

        private void clearUpdateControls()
        {
            txtToggledAge.Text = "";
            txtToggledDelete.Text = "";
            txtToggledFavoritePizza.Text = "";
            txtToggledName.Text = "";
            txtToggledPhoneNumber.Text = "";
            txtToggledUpdateByName.Text = "";
            txtToggledUpdateByNumber.Text = "";
        }

    }
}
