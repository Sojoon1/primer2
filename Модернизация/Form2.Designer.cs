
namespace Модернизация
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.крдвыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодчитателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодкнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выдачакнигBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачакнигBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.крдвыдачиDataGridViewTextBoxColumn,
            this.кодчитателяDataGridViewTextBoxColumn,
            this.кодкнигиDataGridViewTextBoxColumn,
            this.датазаказаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.выдачакнигBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(473, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(715, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(930, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // крдвыдачиDataGridViewTextBoxColumn
            // 
            this.крдвыдачиDataGridViewTextBoxColumn.DataPropertyName = "Крд_выдачи";
            this.крдвыдачиDataGridViewTextBoxColumn.HeaderText = "Крд_выдачи";
            this.крдвыдачиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.крдвыдачиDataGridViewTextBoxColumn.Name = "крдвыдачиDataGridViewTextBoxColumn";
            this.крдвыдачиDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодчитателяDataGridViewTextBoxColumn
            // 
            this.кодчитателяDataGridViewTextBoxColumn.DataPropertyName = "Код_читателя";
            this.кодчитателяDataGridViewTextBoxColumn.HeaderText = "Код_читателя";
            this.кодчитателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодчитателяDataGridViewTextBoxColumn.Name = "кодчитателяDataGridViewTextBoxColumn";
            this.кодчитателяDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодкнигиDataGridViewTextBoxColumn
            // 
            this.кодкнигиDataGridViewTextBoxColumn.DataPropertyName = "Код_книги";
            this.кодкнигиDataGridViewTextBoxColumn.HeaderText = "Код_книги";
            this.кодкнигиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодкнигиDataGridViewTextBoxColumn.Name = "кодкнигиDataGridViewTextBoxColumn";
            this.кодкнигиDataGridViewTextBoxColumn.Width = 125;
            // 
            // датазаказаDataGridViewTextBoxColumn
            // 
            this.датазаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата_заказа";
            this.датазаказаDataGridViewTextBoxColumn.HeaderText = "Дата_заказа";
            this.датазаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датазаказаDataGridViewTextBoxColumn.Name = "датазаказаDataGridViewTextBoxColumn";
            this.датазаказаDataGridViewTextBoxColumn.Width = 125;
            // 
            // выдачакнигBindingSource
            // 
            this.выдачакнигBindingSource.DataSource = typeof(Модернизация.Выдача_книг);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдача книг";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачакнигBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn крдвыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодчитателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датазаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource выдачакнигBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}