namespace ClientCurs
{
    partial class AddMailShipment
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cursDBDataSet = new ClientCurs.CursDBDataSet();
            this.shipmentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipmentTypeTableAdapter = new ClientCurs.CursDBDataSetTableAdapters.ShipmentTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cursDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.shipmentTypeBindingSource;
            this.comboBox1.DisplayMember = "ShipmentTypeName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "ShipmentType";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(34, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 28);
            this.button3.TabIndex = 21;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(34, 232);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(158, 20);
            this.textBox11.TabIndex = 20;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(34, 166);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(158, 20);
            this.textBox10.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(30, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Цена";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(30, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Вес";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(30, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Тип посылки";
            // 
            // cursDBDataSet
            // 
            this.cursDBDataSet.DataSetName = "CursDBDataSet";
            this.cursDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // AddMailShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "AddMailShipment";
            this.Text = "AddMailShipment";
            this.Load += new System.EventHandler(this.AddMailShipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private CursDBDataSet cursDBDataSet;
        private System.Windows.Forms.BindingSource shipmentTypeBindingSource;
        private CursDBDataSetTableAdapters.ShipmentTypeTableAdapter shipmentTypeTableAdapter;
    }
}