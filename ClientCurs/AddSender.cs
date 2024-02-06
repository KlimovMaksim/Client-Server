using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCurs
{
    public partial class AddSender : Form
    {
        public AddSender()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Data.value))
            {
                try
                {
                    conn.Open();
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
                    {
                        throw new Exception("Переданы пустые строки.");
                    }
                    using (SqlCommand cmd = new SqlCommand("EXEC AddSender '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'", conn))
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();

                            Form1 ff = (Form1)this.Owner;

                            ff.button1_Click(sender, e);

                            MessageBox.Show("Добавлено");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
