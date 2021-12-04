namespace WinBD
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
            this.odbcCommand1 = new System.Data.Odbc.OdbcCommand();
            this.odbcConnection1 = new System.Data.Odbc.OdbcConnection();
            this.SuspendLayout();
            // 
            // odbcCommand1
            // 
            this.odbcCommand1.CommandText = "SELECT * FROM Поставщики";
            this.odbcCommand1.Connection = this.odbcConnection1;
            // 
            // odbcConnection1
            // 
            this.odbcConnection1.ConnectionString = "Dsn=MS Access Database";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.Odbc.OdbcCommand odbcCommand1;
        private System.Data.Odbc.OdbcConnection odbcConnection1;
    }
}

