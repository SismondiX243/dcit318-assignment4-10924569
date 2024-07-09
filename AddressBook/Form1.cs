using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Retrieve the entered information from textboxes
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phoneNumber = txtPhone.Text.Trim();

            // Validate if required fields are not empty
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter the correct credentials.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If validation passes, show a success message
            MessageBox.Show("Save successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally clear the textboxes after saving
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
