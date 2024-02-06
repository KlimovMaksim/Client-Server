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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientCurs
{
    public partial class AddShipmentType : Form
    {
        public AddShipmentType()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Data.value))
            {
                try
                {
                    conn.Open();
                    if ((textBox15.Text == "") || (textBox14.Text == "") || (textBox13.Text == "") || (textBox12.Text == ""))
                    {
                        throw new Exception("Переданы пустые строки.");
                    }
                    using (SqlCommand cmd = new SqlCommand("EXEC AddShipmentType '" + textBox15.Text + "','" + textBox14.Text + "','" + textBox13.Text + "','" + textBox12.Text + "'", conn))
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
