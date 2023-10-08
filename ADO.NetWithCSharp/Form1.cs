using ADO.NetWithCSharp.Business;
using ADO.NetWithCSharp.Models;
using System;

namespace ADO.NetWithCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PersonBusiness personBusiness = new PersonBusiness();
            List<Person> people = personBusiness.GetPeople();

            PeopleGridView.DataSource = null;
            PeopleGridView.DataSource = people;
            PeopleGridView.Refresh();
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
    }
}