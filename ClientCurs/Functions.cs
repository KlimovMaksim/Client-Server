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
    public partial class Functions : Form
    {
        public Functions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataTable currTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter currAdapter = new SqlDataAdapter("select Name, ShipmentTypeName, Weight\r\nfrom Senders\r\njoin ShipmentManifest sm on sm.SenderId = Senders.SenderId\r\njoin MailShipment ms on ms.ShipmentId = sm.ShipmentId\r\njoin ShipmentType st on st.ShipmentType = sm.ShipmentTypeId\r\nwhere ms.Weight > dbo.TotalWeightBySender("+ textBox1.Text+ ")", conn))
                        {
                            currAdapter.Fill(currTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    dataGridView1.DataSource = currTable;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DataTable currTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter currAdapter = new SqlDataAdapter("select * from dbo.ShipmentsBySender("+ textBox1.Text+ ")", conn))
                        {
                            currAdapter.Fill(currTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    dataGridView1.DataSource = currTable;
                }
            }
        }
    }
}
