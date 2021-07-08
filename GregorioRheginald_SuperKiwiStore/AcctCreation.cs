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
    public partial class AcctCreation : Form
    {
        List<usernpassw> uspw = new List<usernpassw>();

        string[] titles = { "admin", "sales staff" };
        public AcctCreation()
        {
            InitializeComponent();
        }

        private void btnacctcreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusercreate.Text) && string.IsNullOrEmpty(txtpasscreate.Text) && string.IsNullOrEmpty(cmbacctcreate.Text))
            {
                MessageBox.Show("Please fill in values for Email, Password and title");

            }
            else if (string.IsNullOrEmpty(txtusercreate.Text))
            {
                MessageBox.Show("Please fill in values for Email");
            }

            else if (string.IsNullOrEmpty(txtpasscreate.Text))
            {
                MessageBox.Show("Please fill in values for Password");
            }

            else if (string.IsNullOrEmpty(cmbacctcreate.Text))
            {
                MessageBox.Show("Please fill in values for title");
            }

            else
            {
                
                var userregex = new Regex("^[a-zA-Z0-9._]{3,}@[a-z0-9.]");
                var passregex = new Regex("(?=.*[a-z])(?=.*[A-Z])(?=.*[._!@#$%^&*()]).{8,}$");
                var numregex = new Regex(@".*\d.*\d");

                if (userregex.IsMatch(Convert.ToString(txtusercreate.Text)) && passregex.IsMatch(Convert.ToString(txtpasscreate.Text))
                    && numregex.IsMatch(Convert.ToString(txtpasscreate.Text)))
                {
                    List<string> cuser = new List<string>();
                    List<string> cpass = new List<string>();
                    List<string> ctitle = new List<string>();
                    usernpassw up = new usernpassw
                    {
                        name = txtusercreate.Text,
                        password = txtpasscreate.Text,
                        title = cmbacctcreate.Text


                    };

                    const string path = @".\employeedetail.txt";
                    string[] lineOfContents = File.ReadAllLines(path);
                    foreach (string line in lineOfContents)
                    {
                        string[] itemn = line.Split('|');


                        cuser.Add(itemn[0]);
                        cpass.Add(itemn[1]);
                        ctitle.Add(itemn[2]);
                    }

                    int matchIndex = cuser.IndexOf(txtusercreate.Text);


                    if (matchIndex == -1)
                    {
                        try


                        {

                            using (StreamWriter IW = File.AppendText(@".\employeedetail.txt"))
                            {
                                IW.WriteLine(up.name + "|" + up.password + "|" + up.title);
                                IW.Close();
                            }
                        }
                        catch (Exception h)
                        {
                            MessageBox.Show("Exception: " + h.Message); //creates an exception if file creation ended up getting corrupted 
                        }
                        finally
                        {
                            MessageBox.Show("Item Added succesfully!");
                        }


                    }

                    else
                    {

                        MessageBox.Show("Please change your username, similar found on database");

                    }

                }

                else
                {
                    MessageBox.Show("Please check the Syntax of all items ");
                }
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AcctCreation_Load(object sender, EventArgs e)
        {
            cmbacctcreate.Items.AddRange(titles);
        }

        private void txtusercreate_TextChanged(object sender, EventArgs e)
        {
            string correctformat = "Correct Format";
            string incorrectformat = "Wrong Format";
            var regexItem = new Regex("^[a-zA-Z0-9._]{3,}@[a-z0-9]");



            if (regexItem.IsMatch(Convert.ToString(txtusercreate.Text)))
            {
                usercreatedash.Text = correctformat;
            }

            else
            {
                usercreatedash.Text = incorrectformat;
            }

            if (string.IsNullOrEmpty(txtusercreate.Text))
            {
                usercreatedash.Text = "-";
            }
        }

        private void txtpasscreate_TextChanged(object sender, EventArgs e)
        {
            string passlengthyes = "password is in character range";
            string passlengthno = "password is not in character range";
            var regexItem = new Regex("^[a-zA-Z][0-9]*$");

            if (txtpasscreate.Text.Length >= 8)
            {
                PassCreateDash.Text = passlengthyes;
            }
            else
            {
                PassCreateDash.Text = passlengthno;
            }

            if (regexItem.IsMatch(Convert.ToString(txtpasscreate.Text)))
            {
                PassCreateDash.Text = "password must contain special character";
            }

            if (string.IsNullOrEmpty(txtpasscreate.Text))
            {
                PassCreateDash.Text = "-";
            }
        }
    }
}