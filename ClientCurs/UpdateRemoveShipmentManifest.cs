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
    public partial class UpdateRemoveShipmentManifest : Form
    {
        public UpdateRemoveShipmentManifest()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (DataGridViewRow current = dataGridView1.Rows[e.RowIndex])
                {
                    textBox1.Text = current.Cells["RecordId"].Value.ToString();
                    comboBox1.SelectedValue = current.Cells["DestinationId"].Value.ToString();
                    comboBox2.SelectedValue = current.Cells["SenderId"].Value.ToString();
                    comboBox3.SelectedValue = current.Cells["ShipmentId"].Value.ToString();
                    comboBox4.SelectedValue = current.Cells["ShipmentTypeId"].Value.ToString();
                    textBox6.Text = current.Cells["AdditionalInfo"].Value.ToString();
                    comboBox5.SelectedValue = current.Cells["Status"].Value.ToString();
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataTable dt = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ShipmentManifest ORDER BY RecordId ASC", conn))
                        {
                            da.Fill(dt);
                        }
                    }
                    catch (System.InvalidOperationException)
                    {
                        MessageBox.Show("Не инициализировано подключение к БД.");
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Недостаточно прав для выполнения данной операции.");
                    }
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Data.value))
            {
                using (SqlCommand cmd = new SqlCommand("EXEC UpdateShipmentManifest '" + textBox1.Text + "', '" + comboBox1.SelectedValue + "', '" + comboBox2.SelectedValue + "', '" + comboBox3.SelectedValue + "', '" + comboBox4.SelectedValue + "','" + textBox6.Text + "','" + comboBox5.SelectedValue + "'", conn))
                {
                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        button1_Click(sender, e);
                        textBox1.Clear();
                        textBox6.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Data.value))
            {
                using (SqlCommand cmd = new SqlCommand("EXEC RemoveShipmentManifest '" + textBox1.Text + "'", conn))
                {
                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        button1_Click(sender, e);
                        textBox1.Clear();
                        textBox6.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void UpdateRemoveShipmentManifest_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursDBDataSet2.ShipmentManifest". При необходимости она может быть перемещена или удалена.
            this.shipmentManifestTableAdapter.Fill(this.cursDBDataSet2.ShipmentManifest);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursDBDataSet.ShipmentType". При необходимости она может быть перемещена или удалена.
            this.shipmentTypeTableAdapter.Fill(this.cursDBDataSet.ShipmentType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursDBDataSet1.MailShipment". При необходимости она может быть перемещена или удалена.
            this.mailShipmentTableAdapter.Fill(this.cursDBDataSet1.MailShipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursDBDataSet1.Senders". При необходимости она может быть перемещена или удалена.
            this.sendersTableAdapter.Fill(this.cursDBDataSet1.Senders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursDBDataSet1.Destination". При необходимости она может быть перемещена или удалена.
            this.destinationTableAdapter.Fill(this.cursDBDataSet1.Destination);

        }
    }
}
