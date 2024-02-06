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
    public partial class AddMailShipment : Form
    {
        public AddMailShipment()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Data.value))
            {
                try
                {
                    conn.Open();
                    if ((textBox10.Text == "") || (textBox11.Text == ""))
                    {
                        throw new Exception("Переданы пустые строки.");
                    }
                    using (SqlCommand cmd = new SqlCommand("EXEC AddMailShipment '" + comboBox1.SelectedValue + "','" + textBox10.Text + "','" + textBox11.Text + "'", conn))
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

        private void AddMailShipment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursDBDataSet.ShipmentType". При необходимости она может быть перемещена или удалена.
            this.shipmentTypeTableAdapter.Fill(this.cursDBDataSet.ShipmentType);

        }
    }
}
