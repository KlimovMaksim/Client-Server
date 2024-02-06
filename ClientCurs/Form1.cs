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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void соединитьсяСБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logwin = new login();
            logwin.ShowDialog();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            updateAllTables();
        }

        private void tasl3Button_Click(object sender, EventArgs e)
        {
            if (Data.value == null)
            {
                MessageBox.Show("Не инициализировано подключение к БД.");
            }
            else
            {
                task3 = new Task3();
                task3.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Data.value == null)
            {
                MessageBox.Show("Не инициализировано подключение к БД.");
            }
            else
            {
                functions = new Functions();
                functions.ShowDialog();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (Data.value == null)
            {
                MessageBox.Show("Не инициализировано подключение к БД.");
            }
            else
            {
                addSender = new AddSender();
                addSender.Owner = this;
                addSender.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Data.value == null)
            {
                MessageBox.Show("Не инициализировано подключение к БД.");
            }
            else
            {
                addDestination = new AddDestination();
                addDestination.Owner = this;
                addDestination.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Data.value == null)
            {
                MessageBox.Show("Не инициализировано подключение к БД.");
            }
            else
            {
                addMailShipment = new AddMailShipment();
                addMailShipment.Owner = this;
                addMailShipment.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Data.value == null)
            {
                MessageBox.Show("Не инициализировано подключение к БД.");
            }
            else
            {
                addShipmentType = new AddShipmentType();
                addShipmentType.Owner = this;
                addShipmentType.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Data.value == null)
            {
                MessageBox.Show("Не инициализировано подключение к БД.");
            }
            else
            {
                addShipmentManifest = new AddShipmentManifest();
                addShipmentManifest.Owner = this;
                addShipmentManifest.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Data.value == null)
            {
                MessageBox.Show("Не инициализировано подключение к БД.");
            }
            else
            {
                updateRemoveSender = new UpdateRemoveSender();
                updateRemoveSender.Owner = this;
                updateRemoveSender.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Data.value == null)
            {
                MessageBox.Show("Не инициализировано подключение к БД.");
            }
            else
            {
                updateRemoveDestination = new UpdateRemoveDestination();
                updateRemoveDestination.Owner = this;
                updateRemoveDestination.ShowDialog();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Data.value == null)
            {
                MessageBox.Show("Не инициализировано подключение к БД.");
            }
            else
            {
                updateRemoveShipmentType = new UpdateRemoveShipmentType();
                updateRemoveShipmentType.Owner = this;
                updateRemoveShipmentType.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Data.value == null)
            {
                MessageBox.Show("Не инициализировано подключение к БД.");
            }
            else
            {
                updateRemoveMailShipment = new UpdateRemoveMailShipment();
                updateRemoveMailShipment.Owner = this;
                updateRemoveMailShipment.ShowDialog();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Data.value == null)
            {
                MessageBox.Show("Не инициализировано подключение к БД.");
            }
            else
            {
                updateRemoveShipmentManifest = new UpdateRemoveShipmentManifest();
                updateRemoveShipmentManifest.Owner = this;
                updateRemoveShipmentManifest.ShowDialog();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Data.value == null)
            {
                MessageBox.Show("Не инициализировано подключение к БД.");
            }
            else
            {
                transaction = new Transaction();
                transaction.Owner = this;
                transaction.ShowDialog();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Data.value))
            {
                using (SqlCommand cmd = new SqlCommand("EXEC Cursor_update", conn))
                {
                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        this.button1_Click(sender, e);

                        MessageBox.Show("Курсор сработал");
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
