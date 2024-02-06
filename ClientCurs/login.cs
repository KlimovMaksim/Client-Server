using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientCurs
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            adressDB.Text = "localhost";
            databaseName.Text = "CursDB";
            userLogin.Text = "cursAdminLogin";
            userPassword.Text = "?iAzv?fYD5O9";

            userPassword.PasswordChar = '*';
        }

        private void connButton_Click(object sender, EventArgs e)
        {
            using (conn = new System.Data.SqlClient.SqlConnection(
                "Server=" + adressDB.Text + ";" +
                "Database=" + databaseName.Text + ";" +
                "uid=" + userLogin.Text + ";" +
                "pwd=" + userPassword.Text + ";"))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Cоединено");

                    Data.value = "Server=" + adressDB.Text + ";" +
                        "Database=" + databaseName.Text + ";" +
                        "uid=" + userLogin.Text + ";" +
                        "pwd=" + userPassword.Text + ";";

                    this.Close();
                }
                catch (Exception help)
                {
                    MessageBox.Show(help.Message);
                }
            }
        }
    }
}
