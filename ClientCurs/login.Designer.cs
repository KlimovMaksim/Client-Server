using System.Data.SqlClient;

namespace ClientCurs
{
    partial class login
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
            this.adressDB = new System.Windows.Forms.TextBox();
            this.databaseName = new System.Windows.Forms.TextBox();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DBName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.connButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adressDB
            // 
            this.adressDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressDB.Location = new System.Drawing.Point(64, 74);
            this.adressDB.Name = "adressDB";
            this.adressDB.Size = new System.Drawing.Size(261, 26);
            this.adressDB.TabIndex = 0;
            // 
            // databaseName
            // 
            this.databaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.databaseName.Location = new System.Drawing.Point(64, 171);
            this.databaseName.Name = "databaseName";
            this.databaseName.Size = new System.Drawing.Size(261, 26);
            this.databaseName.TabIndex = 1;
            // 
            // userLogin
            // 
            this.userLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLogin.Location = new System.Drawing.Point(64, 253);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(261, 26);
            this.userLogin.TabIndex = 2;
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPassword.Location = new System.Drawing.Point(64, 339);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(261, 26);
            this.userPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Адрес сервера БД";
            // 
            // DBName
            // 
            this.DBName.AutoSize = true;
            this.DBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DBName.Location = new System.Drawing.Point(63, 139);
            this.DBName.Name = "DBName";
            this.DBName.Size = new System.Drawing.Size(67, 20);
            this.DBName.TabIndex = 5;
            this.DBName.Text = "Имя БД";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(63, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя пользователя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(63, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль";
            // 
            // connButton
            // 
            this.connButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connButton.Location = new System.Drawing.Point(113, 392);
            this.connButton.Name = "connButton";
            this.connButton.Size = new System.Drawing.Size(151, 30);
            this.connButton.TabIndex = 8;
            this.connButton.Text = "Соединить";
            this.connButton.UseVisualStyleBackColor = true;
            this.connButton.Click += new System.EventHandler(this.connButton_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.connButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DBName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.databaseName);
            this.Controls.Add(this.adressDB);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SqlConnection conn;

        private System.Windows.Forms.TextBox adressDB;
        private System.Windows.Forms.TextBox databaseName;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DBName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button connButton;
    }
}