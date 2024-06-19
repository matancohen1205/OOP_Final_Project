using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class entrence_screen_pizza : Form
    {
        private Database databaseForm;
        public entrence_screen_pizza()
        {
            InitializeComponent();
            // Instantiate the Database form and assign it to databaseForm
            databaseForm = new Database();
            

        }
        private static class datamanager
        {
            private static List<User> users = new List<User>();
            public static List<User> Users
            {
                get { return users; }
                set { users = value; }
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Do you want to exit the system?", "Ordering System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_delivery_person_Click(object sender, EventArgs e)
        {
            string name = "matanshay"; // Predefined username
            string phonenumber = "12345"; // Predefined password
            string IDnumber = "54321";

            // Get the entered credentials
            string enteredName = txt_name.Text;
            string enteredPhoneNumber = txt_phone_number.Text;
            string enteredIDNumber = txt_ID_Number.Text;

            // Check if entered credentials match predefined static user
            if (enteredName == name && enteredPhoneNumber == phonenumber && enteredIDNumber == IDnumber)
            {
                // Successful login, perform actions related to delivery person
                MessageBox.Show("Delivery Person Logged In");
                // Create an instance of the Menu form
                Form ToDatabase = new Database();
                ToDatabase.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void btn_Customer_Click(object sender, EventArgs e)
        {
            // Ensure the users list is loaded with data from the XML file
            LoadUsersFromXML();

            string enteredName = txt_name.Text.Trim();
            string enteredPhoneNumber = txt_phone_number.Text.Trim();
            string enteredIDNumber = txt_ID_Number.Text.Trim();

            if (string.IsNullOrEmpty(enteredName) || string.IsNullOrEmpty(enteredPhoneNumber) || string.IsNullOrEmpty(enteredIDNumber))
            {
                MessageBox.Show("Please fill in all the required information.");
                return;
            }

            // Check if there is a user with the provided credentials
            User foundUser = datamanager.Users.FirstOrDefault(existingUser =>
                string.Equals(existingUser.Name.Trim(), enteredName, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(existingUser.PhoneNumber.Trim(), enteredPhoneNumber, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(existingUser.IDNumber.Trim(), enteredIDNumber, StringComparison.OrdinalIgnoreCase));

            if (foundUser != null)
            {
                string message = "Login Successful\n" + foundUser.benefits();
                MessageBox.Show(message, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields and proceed to the next form or other actions
                txt_name.Clear();
                txt_ID_Number.Clear();
                txt_phone_number.Clear();
                
                // Clear input fields
                txt_name.Clear();
                txt_ID_Number.Clear();
                txt_phone_number.Clear();

                // Proceed to the next form (replace Deliverysystem with the actual form name)
                MyDeliverySystem mydelivery = new MyDeliverySystem();
                mydelivery.Currentuser = foundUser;

                // Hide the current form
                this.Hide();

                // Show the next form
                mydelivery.Show();
                mydelivery.Activate();
            }
            else
            {
                MessageBox.Show("Invalid information. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadUsersFromXML()
        {
            // Load users data from the XML file into the users list
            if (File.Exists(databaseForm.xmlFileName))
            {
                datamanager.Users = databaseForm.userSerializer.DeserializeUsers();
            }
            
        }

        

       

      

       
    }
}
    