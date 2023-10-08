using ADO.NetWithCSharp.Business;
using ADO.NetWithCSharp.Models;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace ADO.NetWithCSharp
{
    public partial class Form1 : Form
    {
        public delegate void ButtonClickEventHandler(object sender, EventArgs e);

        // Define the custom event using the delegate type
        public event ButtonClickEventHandler ButtonClicked;

        public Form1()
        {
            InitializeComponent();

            PersonBusiness personBusiness = new PersonBusiness();
            List<Person> people = personBusiness.GetPeople();

            PeopleGridView.DataSource = null;
            PeopleGridView.DataSource = people;
            PeopleGridView.Refresh();

            // Subscribe to the custom event
            ButtonClicked += Form1_ButtonClicked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int randomNumber = random.Next(1, 5000000);
            Person person = new Person()
            {
                Id= randomNumber,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
            };
            PersonBusiness personBusiness = new PersonBusiness();
            personBusiness.InsertPerson(person);

            List<Person> people = personBusiness.GetPeople();

            PeopleGridView.DataSource = null;
            PeopleGridView.DataSource = people;
            PeopleGridView.Refresh();

            ClearForm();
        }

        private void ClearForm()
        {
            firstNameTextBox.Text = null;
            lastNameTextBox.Text = null;
            phoneNumberTextBox.Text = null;
        }

        private void callApiButton_Click_1(object sender, EventArgs e)
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users?page=2", Method.Get);
            RestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ReqresApiResponse result = JsonConvert.DeserializeObject<ReqresApiResponse>(response.Content);

                PeopleGridView.DataSource = null;
                PeopleGridView.DataSource = result.data;
                PeopleGridView.Refresh();
            }
            ClearForm();
        }

        private void PeopleGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void PeopleGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = 0;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users?page=2", Method.Get);
            var response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ReqresApiResponse result = JsonConvert.DeserializeObject<ReqresApiResponse>(response.Content);

                // Assuming PeopleGridView is a DataGridView
                PeopleGridView.Invoke((Action)(() =>
                {
                    PeopleGridView.DataSource = null;
                    PeopleGridView.DataSource = result.data;
                    PeopleGridView.Refresh();
                }));
            }

            ClearForm();
        }

        // Method to raise the custom event
        protected virtual void OnButtonClicked(EventArgs e)
        {
            // Check if there are subscribers to the event
            ButtonClicked?.Invoke(this, e);
        }

        private void Form1_ButtonClicked(object sender, EventArgs e)
        {
            // Handle the custom event
            label1.Text = "Button Clicked!";
        }
    }
}