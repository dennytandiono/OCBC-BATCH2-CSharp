using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class Register : Form
    {

        Config db = new Config();
        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string username = usernameTextbox.Text;
            string password = passTextbox.Text;
            bool isInvalid = name.Equals("") || username.Equals("") || password.Equals("");

            if (isInvalid)
            {
                nameTextBox.Focus();
                MessageBox.Show("Data harus diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string msg = "Ingin register data?";
            string caption = "Information";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(msg, caption, buttons);

            if (result == DialogResult.Yes)
            {
                db.Execute("INSERT INTO user_info (names, username, password) VALUES "
                    + "('" + nameTextBox.Text + "', '" + usernameTextbox.Text + "', '" + passTextbox.Text + "')"
                );
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
