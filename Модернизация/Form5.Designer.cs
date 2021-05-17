
namespace Модернизация
{
    partial class Form5
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
            this.кодкнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодиздательстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объемDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годизданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодкнигиDataGridViewTextBoxColumn,
            this.авторDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.кодиздательстваDataGridViewTextBoxColumn,
            this.объемDataGridViewTextBoxColumn,
            this.годизданияDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.книгиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(197, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1241, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1200, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // кодкнигиDataGridViewTextBoxColumn
            // 
            this.кодкнигиDataGridViewTextBoxColumn.DataPropertyName = "Код_книги";
            this.кодкнигиDataGridViewTextBoxColumn.HeaderText = "Код_книги";
            this.кодкнигиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодкнигиDataGridViewTextBoxColumn.Name = "кодкнигиDataGridViewTextBoxColumn";
            this.кодкнигиDataGridViewTextBoxColumn.Width = 125;
            // 
            // авторDataGridViewTextBoxColumn
            // 
            this.авторDataGridViewTextBoxColumn.DataPropertyName = "Автор";
            this.авторDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.авторDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.авторDataGridViewTextBoxColumn.Name = "авторDataGridViewTextBoxColumn";
            this.авторDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодиздательстваDataGridViewTextBoxColumn
            // 
            this.кодиздательстваDataGridViewTextBoxColumn.DataPropertyName = "Код_издательства";
            this.кодиздательстваDataGridViewTextBoxColumn.HeaderText = "Код_издательства";
            this.кодиздательстваDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодиздательстваDataGridViewTextBoxColumn.Name = "кодиздательстваDataGridViewTextBoxColumn";
            this.кодиздательстваDataGridViewTextBoxColumn.Width = 125;
            // 
            // объемDataGridViewTextBoxColumn
            // 
            this.объемDataGridViewTextBoxColumn.DataPropertyName = "Объем";
            this.объемDataGridViewTextBoxColumn.HeaderText = "Объем";
            this.объемDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.объемDataGridViewTextBoxColumn.Name = "объемDataGridViewTextBoxColumn";
            this.объемDataGridViewTextBoxColumn.Width = 125;
            // 
            // годизданияDataGridViewTextBoxColumn
            // 
            this.годизданияDataGridViewTextBoxColumn.DataPropertyName = "Год_издания";
            this.годизданияDataGridViewTextBoxColumn.HeaderText = "Год_издания";
            this.годизданияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.годизданияDataGridViewTextBoxColumn.Name = "годизданияDataGridViewTextBoxColumn";
            this.годизданияDataGridViewTextBoxColumn.Width = 125;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.Width = 125;
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataSource = typeof(Модернизация.Книги);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодиздательстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объемDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годизданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}