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
    public partial class AddShipmentManifest : Form
    {
        public AddShipmentManifest()
        {
            InitializeComponent();
        }

        private void AddShipmentManifest_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursDBDataSet.ShipmentType". При необходимости она может быть перемещена или удалена.
            this.shipmentTypeTableAdapter.Fill(this.cursDBDataSet.ShipmentType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursDBDataSet1.MailShipment". При необходимости она может быть перемещена или удалена.
            this.mailShipmentTableAdapter.Fill(this.cursDBDataSet1.MailShipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursDBDataSet1.Destination". При необходимости она может быть перемещена или удалена.
            this.destinationTableAdapter.Fill(this.cursDBDataSet1.Destination);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursDBDataSet1.Senders". При необходимости она может быть перемещена или удалена.
            this.sendersTableAdapter.Fill(this.cursDBDataSet1.Senders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Data.value))
            {
                try
                {
                    conn.Open();
                    if ((textBox1.Text == "") || (textBox2.Text == ""))
                    {
                        throw new Exception("Переданы пустые строки.");
                    }
                    using (SqlCommand cmd = new SqlCommand("EXEC AddShipmentManifest '" + comboBox1.SelectedValue + "','" + comboBox2.SelectedValue + "','" + comboBox3.SelectedValue + "','" + comboBox4.SelectedValue + "','" + textBox1.Text + "','" + textBox2.Text + "'", conn))
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
