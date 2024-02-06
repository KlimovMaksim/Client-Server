using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClientCurs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соединитьсяСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendersDataGridView = new System.Windows.Forms.DataGridView();
            this.destinationDataGridView = new System.Windows.Forms.DataGridView();
            this.mailShipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.shipmentTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.shipmentManifestDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tasl3Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailShipmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentManifestDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1676, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.соединитьсяСБДToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // соединитьсяСБДToolStripMenuItem
            // 
            this.соединитьсяСБДToolStripMenuItem.Name = "соединитьсяСБДToolStripMenuItem";
            this.соединитьсяСБДToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.соединитьсяСБДToolStripMenuItem.Text = "Соединиться с БД";
            this.соединитьсяСБДToolStripMenuItem.Click += new System.EventHandler(this.соединитьсяСБДToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // sendersDataGridView
            // 
            this.sendersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sendersDataGridView.Location = new System.Drawing.Point(12, 55);
            this.sendersDataGridView.Name = "sendersDataGridView";
            this.sendersDataGridView.Size = new System.Drawing.Size(595, 189);
            this.sendersDataGridView.TabIndex = 1;
            // 
            // destinationDataGridView
            // 
            this.destinationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.destinationDataGridView.Location = new System.Drawing.Point(613, 55);
            this.destinationDataGridView.Name = "destinationDataGridView";
            this.destinationDataGridView.Size = new System.Drawing.Size(572, 189);
            this.destinationDataGridView.TabIndex = 2;
            // 
            // mailShipmentDataGridView
            // 
            this.mailShipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mailShipmentDataGridView.Location = new System.Drawing.Point(12, 278);
            this.mailShipmentDataGridView.Name = "mailShipmentDataGridView";
            this.mailShipmentDataGridView.Size = new System.Drawing.Size(595, 213);
            this.mailShipmentDataGridView.TabIndex = 3;
            // 
            // shipmentTypeDataGridView
            // 
            this.shipmentTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipmentTypeDataGridView.Location = new System.Drawing.Point(613, 278);
            this.shipmentTypeDataGridView.Name = "shipmentTypeDataGridView";
            this.shipmentTypeDataGridView.Size = new System.Drawing.Size(572, 213);
            this.shipmentTypeDataGridView.TabIndex = 4;
            // 
            // shipmentManifestDataGridView
            // 
            this.shipmentManifestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipmentManifestDataGridView.Location = new System.Drawing.Point(12, 524);
            this.shipmentManifestDataGridView.Name = "shipmentManifestDataGridView";
            this.shipmentManifestDataGridView.Size = new System.Drawing.Size(1173, 214);
            this.shipmentManifestDataGridView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Senders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(609, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "MailShipment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(609, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ShipmentType";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ShipmentManifest";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1191, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "Показать/Обновить все данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tasl3Button
            // 
            this.tasl3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tasl3Button.Location = new System.Drawing.Point(1191, 120);
            this.tasl3Button.Name = "tasl3Button";
            this.tasl3Button.Size = new System.Drawing.Size(235, 29);
            this.tasl3Button.TabIndex = 12;
            this.tasl3Button.Text = "Запросы из пункта 3";
            this.tasl3Button.UseVisualStyleBackColor = true;
            this.tasl3Button.Click += new System.EventHandler(this.tasl3Button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1191, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Функции";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1191, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 31);
            this.button4.TabIndex = 15;
            this.button4.Text = "Добавить отправителя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1191, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 31);
            this.button5.TabIndex = 16;
            this.button5.Text = "Добавить получателя";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(1432, 231);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(235, 68);
            this.button6.TabIndex = 17;
            this.button6.Text = "Добавить данные об отправлении";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(1432, 305);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(235, 31);
            this.button7.TabIndex = 18;
            this.button7.Text = "Добавить опись";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(1191, 305);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(235, 31);
            this.button8.TabIndex = 19;
            this.button8.Text = "Добавить тип отправления";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1191, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 31);
            this.button3.TabIndex = 20;
            this.button3.Text = "Изменить отправителя";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(1191, 418);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(235, 31);
            this.button9.TabIndex = 21;
            this.button9.Text = "Изменить получателя";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(1191, 455);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(235, 31);
            this.button10.TabIndex = 22;
            this.button10.Text = "Изменить тип отправления";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(1432, 381);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(235, 68);
            this.button11.TabIndex = 23;
            this.button11.Text = "Изменить данные об отправлении";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(1432, 455);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(235, 31);
            this.button12.TabIndex = 24;
            this.button12.Text = "Изменить опись";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(1432, 120);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(235, 29);
            this.button13.TabIndex = 25;
            this.button13.Text = "Транзакция";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(1432, 154);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(235, 29);
            this.button14.TabIndex = 26;
            this.button14.Text = "Курсор";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 749);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tasl3Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shipmentManifestDataGridView);
            this.Controls.Add(this.shipmentTypeDataGridView);
            this.Controls.Add(this.mailShipmentDataGridView);
            this.Controls.Add(this.destinationDataGridView);
            this.Controls.Add(this.sendersDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailShipmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentManifestDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private login logwin;
        private Task3 task3;
        private Functions functions;
        private Transaction transaction;

        private AddSender addSender;
        private AddDestination addDestination;
        private AddMailShipment addMailShipment;
        private AddShipmentType addShipmentType;
        private AddShipmentManifest addShipmentManifest;

        private UpdateRemoveSender updateRemoveSender;
        private UpdateRemoveDestination updateRemoveDestination;
        private UpdateRemoveShipmentType updateRemoveShipmentType;
        private UpdateRemoveMailShipment updateRemoveMailShipment;
        private UpdateRemoveShipmentManifest updateRemoveShipmentManifest;

        public void updateAllTables()
        {
            using (DataTable senderTable = new DataTable())
            using (DataTable destinationTable = new DataTable())
            using (DataTable mailShipmentTable = new DataTable())
            using (DataTable shipmentTypeTable = new DataTable())
            using (DataTable shipmentManifestTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    try
                    {
                        using (SqlDataAdapter senderDA = new SqlDataAdapter("SELECT * FROM Senders ORDER BY SenderId ASC", conn))
                        using (SqlDataAdapter destinationDA = new SqlDataAdapter("SELECT * FROM Destination ORDER BY DestinationId ASC", conn))
                        using (SqlDataAdapter mailShipmentDA = new SqlDataAdapter("SELECT * FROM MailShipment ORDER BY ShipmentId ASC", conn))
                        using (SqlDataAdapter shipmentTypeDA = new SqlDataAdapter("SELECT * FROM ShipmentType ORDER BY ShipmentType ASC", conn))
                        using (SqlDataAdapter shipmentManifestDA = new SqlDataAdapter("SELECT * FROM ShipmentManifest ORDER BY RecordId ASC", conn))
                        {
                            senderDA.Fill(senderTable);
                            destinationDA.Fill(destinationTable);
                            mailShipmentDA.Fill(mailShipmentTable);
                            shipmentTypeDA.Fill(shipmentTypeTable);
                            shipmentManifestDA.Fill(shipmentManifestTable);
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
                    sendersDataGridView.DataSource = senderTable;
                    destinationDataGridView.DataSource = destinationTable;
                    mailShipmentDataGridView.DataSource = mailShipmentTable;
                    shipmentTypeDataGridView.DataSource = shipmentTypeTable;
                    shipmentManifestDataGridView.DataSource = shipmentManifestTable;
                }
            }
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соединитьсяСБДToolStripMenuItem;
        private System.Windows.Forms.DataGridView sendersDataGridView;
        private System.Windows.Forms.DataGridView destinationDataGridView;
        private System.Windows.Forms.DataGridView mailShipmentDataGridView;
        private System.Windows.Forms.DataGridView shipmentTypeDataGridView;
        private System.Windows.Forms.DataGridView shipmentManifestDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private Button tasl3Button;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button3;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Button button13;
        private Button button14;
    }
}

