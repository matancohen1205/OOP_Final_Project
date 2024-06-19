using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApplication3
{
    public partial class Database : Form
    {
        public List<User> users = new List<User>();
        public string xmlFileName = "users.xml";
        public UserSerializer userSerializer;
            public Database()
            {
            InitializeComponent();
            userSerializer = new UserSerializer(xmlFileName, typeof(List<User>)); // Add this line
            LoadUsers();
            }
       

        private void btn_back_Click(object sender, EventArgs e)
        {

            // Create an instance of the Menu form
            Form Toentrence = new entrence_screen_pizza();

            // Show the Menu form
            Toentrence.Show();

            // hide the current form if needed
            this.Hide();
           
        }

        
           private void LoadUsers()
           {
               if (File.Exists(xmlFileName))
               {
                   users = userSerializer.DeserializeUsers();
                   UpdateDataGridView();
               }
           } 

        public void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string phoneNumber = txt_Phone_Number.Text;
            string idNumber = txt_ID_Number.Text;

            if (cmb_member.SelectedItem != null)
            {
                string membershipType = cmb_member.SelectedItem.ToString();

                User newUser;

                switch (membershipType.ToLower())
                {
                    case "friend":
                        newUser = new friend();
                        break;
                    case "gold":
                        newUser = new gold();
                        break;
                    case "premium":
                        newUser = new premium();
                        break;
                    case "delivery":
                        newUser = new delivery();
                        break;
                    default:
                        newUser = new User(name, phoneNumber, idNumber, "guest"); // Default to guest if the type is not recognized
                        break;
                }

                // Set the user's properties
                newUser.Name = name;
                newUser.PhoneNumber = phoneNumber;
                newUser.IDNumber = idNumber;

                users.Add(newUser);

                userSerializer.SerializeUsers(users);
                UpdateDataGridView();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please select a membership type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddUserToDatabase(string name, string phoneNumber, string idNumber, string password, string membershipType)
        {
            User newUser = new User(name, phoneNumber, idNumber, membershipType);
            users.Add(newUser);

            // Serialize and save the updated list to the XML file
            userSerializer.SerializeUsers(users);

            // Update the DataGridView to reflect the changes
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            dataGridView.Rows.Clear();

            foreach (User user in users)
            {
                dataGridView.Rows.Add(user.Name, user.PhoneNumber, user.IDNumber, user.MembershipType);
            }
        } 
        


        private void ClearInputFields()
        {
            txt_Name.Clear();
            txt_Phone_Number.Clear();
            txt_ID_Number.Clear();
            cmb_member.SelectedIndex = -1;
        }

       

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected user's data from the DataGridView
                string name = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string phoneNumber = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string idNumber = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string membershipType = dataGridView.SelectedRows[0].Cells[3].Value.ToString();

                // Find the corresponding user in the users list and remove it
                User userToRemove = users.Find(u =>
                    u.Name == name &&
                    u.PhoneNumber == phoneNumber &&
                    u.IDNumber == idNumber &&
                    u.MembershipType == membershipType);

                if (userToRemove != null)
                {
                    users.Remove(userToRemove);

                    // Serialize and save the updated list to the XML file
                    userSerializer.SerializeUsers(users);

                    // Remove the selected row from the DataGridView
                    dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
                }
                else
                {
                    MessageBox.Show("Error: Unable to find the selected user in the list.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }
        }


        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the edited cell's value
                object editedValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Update the corresponding user in the users list
                User userToUpdate = users[e.RowIndex];

                switch (e.ColumnIndex)
                {
                    case 0:
                        userToUpdate.Name = editedValue.ToString();
                        break;
                    case 1:
                        userToUpdate.PhoneNumber = editedValue.ToString();
                        break;
                    case 2:
                        userToUpdate.IDNumber = editedValue.ToString();
                        break;
                    case 3:
                        // Determine the membership type entered
                        string membershipType = editedValue.ToString().ToLower();

                        // Create a new user instance of the appropriate type based on the membership type
                        User newUser;

                        switch (membershipType)
                        {
                            case "friend":
                                newUser = new friend();
                                break;
                            case "gold":
                                newUser = new gold();
                                break;
                            case "premium":
                                newUser = new premium();
                                break;
                            case "delivery":
                                newUser = new delivery();
                                break;
                            default:
                                // Handle invalid membership type
                                newUser = new User();
                                break;
                        }

                        // Copy the properties from the existing user to the new user
                        newUser.Name = userToUpdate.Name;
                        newUser.PhoneNumber = userToUpdate.PhoneNumber;
                        newUser.IDNumber = userToUpdate.IDNumber;

                        // Replace the existing user in the list with the new user
                        users[e.RowIndex] = newUser;
                        break;
                }

                // Serialize and save the updated list to the XML file
                userSerializer.SerializeUsers(users);
            }
        }


       
    }
    //Orgenize the serelization into groups to the xml
    [XmlInclude(typeof(premium))]
    [XmlInclude(typeof(gold))]
    [XmlInclude(typeof(friend))]
    [XmlInclude(typeof(delivery))]
    public class User
    {
        public static int count = 0;
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string IDNumber { get; set; }
        public string MembershipType { get; set; } = "guest";

        public virtual string benefits()
        {
            count++;
            if (count == 1)
            {
                MessageBox.Show("Guest to guest == guest!", "Guest Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return MembershipType;
        }

        public User()
        {
            // Initialize any properties if necessary
        }
        public User(string name, string phoneNumber, string idNumber, string membershipType)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            IDNumber = idNumber;
            MembershipType = membershipType;
        }

    }
    public class friend : User//inheritance proccess
    {
        public friend()
        {
            MembershipType = "friend";
        }
        public override string benefits()

        {
            count++;
            if (count==1)
                MessageBox.Show("Welcome back, Friend!", "Friend Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return MembershipType;
        }
    }
    public class gold : friend
    {
        public gold()
        {
            MembershipType = "gold";
        }
        public override string benefits()
        {
            count++;
            if (count == 1)
                MessageBox.Show("You are gold to us, enjoy 25% off!", "Gold Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return MembershipType;
        }
    }
    public class premium : friend
    {
        public premium()
        {
            MembershipType = "premium";
        }
        public override string benefits()
        {
            count++;
            if (count == 1)
                MessageBox.Show("You are premium to us, enjoy 50% off!", "Premium Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            return MembershipType;
        }
    }
    public class delivery : User
    {
        public delivery()
        {
            MembershipType = "delivery";
        }
        public override string benefits()
        {
            count++;
            if (count == 1)
                MessageBox.Show("Enjoy your launch break!", "Delivery Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return MembershipType;
        }

    }
    


    public class UserSerializer//serializer proccess
    {
        private string fileName;
        private Type serializedType;

        public UserSerializer(string fileName, Type serializedType)
        {
            this.fileName = fileName;
            this.serializedType = serializedType;
        }

        public void SerializeUsers(List<User> users)//Keep the data everytime
        {
            XmlSerializer serializer = new XmlSerializer(serializedType);
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(fileStream, users);
            }
        }

        public List<User> DeserializeUsers()//Add new data to the list
        {
            XmlSerializer serializer = new XmlSerializer(serializedType);
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                return (List<User>)serializer.Deserialize(fileStream);
            }
        }
    }
}


