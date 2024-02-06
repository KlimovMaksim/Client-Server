namespace ClientCurs
{
    partial class AddShipmentManifest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cursDBDataSet1 = new ClientCurs.CursDBDataSet1();
            this.sendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sendersTableAdapter = new ClientCurs.CursDBDataSet1TableAdapters.SendersTableAdapter();
            this.destinationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destinationTableAdapter = new ClientCurs.CursDBDataSet1TableAdapters.DestinationTableAdapter();
            this.mailShipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mailShipmentTableAdapter = new ClientCurs.CursDBDataSet1TableAdapters.MailShipmentTableAdapter();
            this.cursDBDataSet = new ClientCurs.CursDBDataSet();
            this.cursDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipmentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipmentTypeTableAdapter = new ClientCurs.CursDBDataSetTableAdapters.ShipmentTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cursDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailShipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Тип отправления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Отправление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Отправитель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Получатель";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(41, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.destinationBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.ValueMember = "DestinationId";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.sendersBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(41, 105);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 21);
            this.comboBox2.TabIndex = 33;
            this.comboBox2.ValueMember = "SenderId";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.mailShipmentBindingSource;
            this.comboBox3.DisplayMember = "Weight";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(41, 165);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(185, 21);
            this.comboBox3.TabIndex = 34;
            this.comboBox3.ValueMember = "ShipmentId";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.shipmentTypeBindingSource;
            this.comboBox4.DisplayMember = "ShipmentTypeName";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(41, 231);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(185, 21);
            this.comboBox4.TabIndex = 35;
            this.comboBox4.ValueMember = "ShipmentType";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 299);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 362);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 20);
            this.textBox2.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Дополнительная информация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(37, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Статус";
            // 
            // cursDBDataSet1
            // 
            this.cursDBDataSet1.DataSetName = "CursDBDataSet1";
            this.cursDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sendersBindingSource
            // 
            this.sendersBindingSource.DataMember = "Senders";
            this.sendersBindingSource.DataSource = this.cursDBDataSet1;
            // 
            // sendersTableAdapter
            // 
            this.sendersTableAdapter.ClearBeforeFill = true;
            // 
            // destinationBindingSource
            // 
            this.destinationBindingSource.DataMember = "Destination";
            this.destinationBindingSource.DataSource = this.cursDBDataSet1;
            // 
            // destinationTableAdapter
            // 
            this.destinationTableAdapter.ClearBeforeFill = true;
            // 
            // mailShipmentBindingSource
            // 
            this.mailShipmentBindingSource.DataMember = "MailShipment";
            this.mailShipmentBindingSource.DataSource = this.cursDBDataSet1;
            // 
            // mailShipmentTableAdapter
            // 
            this.mailShipmentTableAdapter.ClearBeforeFill = true;
            // 
            // cursDBDataSet
            // 
            this.cursDBDataSet.DataSetName = "CursDBDataSet";
            this.cursDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursDBDataSetBindingSource
            // 
            this.cursDBDataSetBindingSource.DataSource = this.cursDBDataSet;
            this.cursDBDataSetBindingSource.Position = 0;
            // 
            // shipmentTypeBindingSource
            // 
            this.shipmentTypeBindingSource.DataMember = "ShipmentType";
            this.shipmentTypeBindingSource.DataSource = this.cursDBDataSet;
            // 
            // shipmentTypeTableAdapter
            // 
            this.shipmentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // AddShipmentManifest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AddShipmentManifest";
            this.Text = "AddShipmentManifest";
            this.Load += new System.EventHandler(this.AddShipmentManifest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailShipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CursDBDataSet1 cursDBDataSet1;
        private System.Windows.Forms.BindingSource sendersBindingSource;
        private CursDBDataSet1TableAdapters.SendersTableAdapter sendersTableAdapter;
        private System.Windows.Forms.BindingSource destinationBindingSource;
        private CursDBDataSet1TableAdapters.DestinationTableAdapter destinationTableAdapter;
        private System.Windows.Forms.BindingSource mailShipmentBindingSource;
        private CursDBDataSet1TableAdapters.MailShipmentTableAdapter mailShipmentTableAdapter;
        private System.Windows.Forms.BindingSource cursDBDataSetBindingSource;
        private CursDBDataSet cursDBDataSet;
        private System.Windows.Forms.BindingSource shipmentTypeBindingSource;
        private CursDBDataSetTableAdapters.ShipmentTypeTableAdapter shipmentTypeTableAdapter;
    }
}