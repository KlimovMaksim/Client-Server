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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (DataTable currTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter currAdapter = new SqlDataAdapter("SELECT sm.*\r\nFROM ShipmentManifest sm\r\nWHERE sm.SenderId = ALL (\r\n    SELECT s.SenderId\r\n    FROM Senders s\r\n    WHERE s.Email LIKE '%@.com'\r\n);\r\n", conn))
                        {
                            currAdapter.Fill(currTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    task3DataGridView1.DataSource = currTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(DataTable currTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter currAdapter = new SqlDataAdapter("SELECT \r\n\tsm.RecordId AS '№ Записи',\r\n\td.Name AS 'Получатель',\r\n\ts.Name AS 'Отправитель',\r\n\tst.ShipmentTypeName AS 'Тип отправления',\r\n\tIIF (sm.AdditionalInfo IS NULL, 'Отсутствует', sm.AdditionalInfo) AS 'Пояснение',\r\n\tCASE Status\r\n\t\tWHEN 0 THEN 'Отправлено'\r\n\t\tWHEN 1 THEN 'Выдано'\r\n\t\tELSE 'Ошибка'\r\n\tEND AS 'Статус отправления'\r\nFROM ShipmentManifest AS sm\r\nLEFT JOIN Destination AS d \r\n\tON sm.DestinationId =  d.DestinationId\r\nLEFT JOIN Senders AS s \r\n\tON sm.SenderId = s.SenderId\r\nLEFT JOIN ShipmentType AS st \r\n\tON sm.ShipmentTypeId = st.ShipmentType\r\nLEFT JOIN MailShipment AS ms \r\n\tON sm.ShipmentId = ms.ShipmentId", conn))
                        {
                            currAdapter.Fill(currTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    task3DataGridView1.DataSource = currTable;
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
                        using (SqlDataAdapter currAdapter = new SqlDataAdapter("USE CursDB;\r\nSELECT * FROM ShipmentTracking", conn))
                        {
                            currAdapter.Fill(currTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    task3DataGridView1.DataSource = currTable;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (DataTable currTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter currAdapter = new SqlDataAdapter("SELECT\r\n    st.ShipmentTypeName AS 'Тип отправления',\r\n    (SELECT AVG(ms.Weight) FROM MailShipment ms WHERE ms.ShipmentTypeId = st.ShipmentType) AS 'Средний вес'\r\nFROM ShipmentType st;", conn))
                        {
                            currAdapter.Fill(currTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    task3DataGridView1.DataSource = currTable;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (DataTable currTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter currAdapter = new SqlDataAdapter("SELECT sm.*\r\nFROM (\r\n    SELECT ShipmentId\r\n    FROM MailShipment\r\n    WHERE Weight > 3\r\n) AS HeavyShipments\r\nJOIN ShipmentManifest sm ON HeavyShipments.ShipmentId = sm.ShipmentId;\r\n", conn))
                        {
                            currAdapter.Fill(currTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    task3DataGridView1.DataSource = currTable;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (DataTable currTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter currAdapter = new SqlDataAdapter("SELECT DISTINCT s.*\r\nFROM Senders s\r\nWHERE EXISTS (\r\n    SELECT 1\r\n    FROM ShipmentManifest sm\r\n    JOIN MailShipment ms ON sm.ShipmentId = ms.ShipmentId\r\n    WHERE sm.SenderId = s.SenderId\r\n    AND ms.Weight > 10\r\n);\r\n", conn))
                        {
                            currAdapter.Fill(currTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    task3DataGridView1.DataSource = currTable;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (DataTable currTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter currAdapter = new SqlDataAdapter("SELECT s.SenderID, s.Name AS SenderName\r\nFROM Senders s\r\nWHERE (\r\n    SELECT AVG(ms.Weight)\r\n    FROM ShipmentManifest sm\r\n    JOIN MailShipment ms ON sm.ShipmentId = ms.ShipmentId\r\n    WHERE sm.SenderId = s.SenderID\r\n) > (\r\n    SELECT AVG(ms.Weight)\r\n    FROM MailShipment ms\r\n);\r\n", conn))
                        {
                            currAdapter.Fill(currTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    task3DataGridView1.DataSource = currTable;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (DataTable currTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter currAdapter = new SqlDataAdapter("SELECT \r\n    s.SenderID, \r\n    s.Name AS SenderName,\r\n    (SELECT COUNT(*) FROM ShipmentManifest sm WHERE sm.SenderId = s.SenderId) AS TotalShipments\r\nFROM Senders s;\r\n", conn))
                        {
                            currAdapter.Fill(currTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    task3DataGridView1.DataSource = currTable;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (DataTable currTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter currAdapter = new SqlDataAdapter("SELECT *\r\nFROM MailShipment ms\r\nJOIN ShipmentManifest sm ON ms.ShipmentId = sm.ShipmentId\r\nWHERE sm.Status = 1\r\n    AND Weight > (\r\n        SELECT AVG(ms2.Weight)\r\n        FROM MailShipment ms2\r\n    );\r\n", conn))
                        {
                            currAdapter.Fill(currTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    task3DataGridView1.DataSource = currTable;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (DataTable currTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter currAdapter = new SqlDataAdapter("SELECT st.ShipmentType, st.ShipmentTypeName, AVG(ms.Weight) AS AverageWeight\r\nFROM ShipmentType st\r\nJOIN MailShipment ms ON st.ShipmentType = ms.ShipmentTypeId\r\nGROUP BY st.ShipmentType, st.ShipmentTypeName\r\nHAVING AVG(ms.Weight) > 0.5;\r\n", conn))
                        {
                            currAdapter.Fill(currTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    task3DataGridView1.DataSource = currTable;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (DataTable currTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter currAdapter = new SqlDataAdapter("SELECT *\r\nFROM ShipmentManifest sm\r\nWHERE sm.ShipmentId = ANY (\r\n    SELECT ms.ShipmentId\r\n    FROM MailShipment ms\r\n    WHERE ms.Weight > 5\r\n);\r\n", conn))
                        {
                            currAdapter.Fill(currTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    task3DataGridView1.DataSource = currTable;
                }
            }
        }
    }
}
