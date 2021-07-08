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
using System.Text.RegularExpressions;

namespace GregorioRheginald_SuperKiwiStore
{
    public partial class FormLogin : Form
    {
        List<string> user = new List<string>();
        List<string> password = new List<string>();
        List<string> title = new List<string>();
        public FormLogin()
        {
            InitializeComponent();

            const string path = @".\employeedetail.txt";
            string[] lineOfContents = File.ReadAllLines(path);
            foreach (string line in lineOfContents)
            {
                string[] itemn = line.Split('|');


                user.Add(itemn[0]);
                password.Add(itemn[1]);
                title.Add(itemn[2]);
            }

            //get the information of users from the text file
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user.Contains(txtuser.Text) && password.Contains(txtpass.Text)) // Check information have been entered correctly

            {
                if (password[Array.IndexOf(user.ToArray(), txtuser.Text)] == txtpass.Text)
                {

                    if (title[Array.IndexOf(user.ToArray(), txtuser.Text)] == "admin")
                    {
                        this.Hide();
                        User af = new Admin(txtuser.Text, txtpass.Text, "admin");
                        ((Admin)af).OpenadminMain();

                       
                    }

                    else if (title[Array.IndexOf(user.ToArray(), txtuser.Text)] == "sales staff")
                    {
                        this.Hide();
                        User sst = new Staff(txtuser.Text, txtpass.Text, "admin");
                        ((Staff)sst).Openstaffmain();

                       
                    }

                    else
                    {
                        MessageBox.Show("You don't have access.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                //Confirm the title and open the main form accessible to that title.


            }
            else
            {
                MessageBox.Show("The Username and Password is incorrect.");
            }




        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            string correctformat = "Correct Format";
            string incorrectformat = "Wrong Format";
            var regexItem = new Regex("^[a-zA-Z0-9._]{3,}@[a-z0-9]");



            if (regexItem.IsMatch(Convert.ToString(txtuser.Text)))
            {
                admindash.Text = correctformat;
            }

            else
            {
                admindash.Text = incorrectformat;
            }

            if (string.IsNullOrEmpty(txtuser.Text))
            {
                admindash.Text = "-";
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            string passlengthyes = "password is in character range";
            string passlengthno = "password is not in character range";
            var regexItem = new Regex("^[a-zA-Z0-9  ]*$");

            if (txtpass.Text.Length >= 8)
            {
                passdash.Text = passlengthyes;
            }
            else
            {
                passdash.Text = passlengthno;
            }

            if (regexItem.IsMatch(Convert.ToString(txtpass.Text)))
            {
                passdash.Text = "password must contain special character";
            }

            if (string.IsNullOrEmpty(txtpass.Text))
            {
                passdash.Text = "-";
            }
        }
    }
}
