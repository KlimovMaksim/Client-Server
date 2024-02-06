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
    public partial class UpdateRemoveSender : Form
    {
        public UpdateRemoveSender()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (DataGridViewRow current = dataGridView1.Rows[e.RowIndex]) 
                {
                    textBox1.Text = current.Cells["SenderId"].Value.ToString();
                    textBox2.Text = current.Cells["Name"].Value.ToString();
                    textBox3.Text = current.Cells["Address"].Value.ToString();
                    textBox4.Text = current.Cells["Email"].Value.ToString();
                    textBox5.Text = current.Cells["PhoneNumber"].Value.ToString();
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
                        using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Senders ORDER BY SenderId ASC", conn))
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
                using (SqlCommand cmd = new SqlCommand("EXEC UpdateSender '"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"', '"+textBox4.Text+"', '"+textBox5.Text+"'", conn))
                {
                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        button1_Click(sender, e);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
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
                using (SqlCommand cmd = new SqlCommand("EXEC RemoveSender '" + textBox1.Text + "'", conn))
                {
                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        button1_Click(sender, e);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
