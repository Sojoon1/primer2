
namespace Модернизация
{
    partial class Form8
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
            this.кодтемыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодкнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиетемыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.темыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодтемыDataGridViewTextBoxColumn,
            this.кодкнигиDataGridViewTextBoxColumn,
            this.названиетемыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.темыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(471, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(890, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // кодтемыDataGridViewTextBoxColumn
            // 
            this.кодтемыDataGridViewTextBoxColumn.DataPropertyName = "Код_темы";
            this.кодтемыDataGridViewTextBoxColumn.HeaderText = "Код_темы";
            this.кодтемыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодтемыDataGridViewTextBoxColumn.Name = "кодтемыDataGridViewTextBoxColumn";
            this.кодтемыDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодкнигиDataGridViewTextBoxColumn
            // 
            this.кодкнигиDataGridViewTextBoxColumn.DataPropertyName = "Код_книги";
            this.кодкнигиDataGridViewTextBoxColumn.HeaderText = "Код_книги";
            this.кодкнигиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодкнигиDataGridViewTextBoxColumn.Name = "кодкнигиDataGridViewTextBoxColumn";
            this.кодкнигиDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиетемыDataGridViewTextBoxColumn
            // 
            this.названиетемыDataGridViewTextBoxColumn.DataPropertyName = "Название_темы";
            this.названиетемыDataGridViewTextBoxColumn.HeaderText = "Название_темы";
            this.названиетемыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиетемыDataGridViewTextBoxColumn.Name = "названиетемыDataGridViewTextBoxColumn";
            this.названиетемыDataGridViewTextBoxColumn.Width = 125;
            // 
            // темыBindingSource
            // 
            this.темыBindingSource.DataSource = typeof(Модернизация.Темы);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Темы";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.темыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодтемыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиетемыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource темыBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}