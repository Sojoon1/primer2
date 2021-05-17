
namespace Модернизация
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.кодавтораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стильнаписанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.псевдонимDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.читателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодавтораDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.стильнаписанияDataGridViewTextBoxColumn,
            this.псевдонимDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.авторBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(402, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(861, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1123, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(763, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 59);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // кодавтораDataGridViewTextBoxColumn
            // 
            this.кодавтораDataGridViewTextBoxColumn.DataPropertyName = "Код_автора";
            this.кодавтораDataGridViewTextBoxColumn.HeaderText = "Код_автора";
            this.кодавтораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодавтораDataGridViewTextBoxColumn.Name = "кодавтораDataGridViewTextBoxColumn";
            this.кодавтораDataGridViewTextBoxColumn.Width = 125;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.Width = 125;
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            this.полDataGridViewTextBoxColumn.Width = 125;
            // 
            // стильнаписанияDataGridViewTextBoxColumn
            // 
            this.стильнаписанияDataGridViewTextBoxColumn.DataPropertyName = "Стиль_написания";
            this.стильнаписанияDataGridViewTextBoxColumn.HeaderText = "Стиль_написания";
            this.стильнаписанияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стильнаписанияDataGridViewTextBoxColumn.Name = "стильнаписанияDataGridViewTextBoxColumn";
            this.стильнаписанияDataGridViewTextBoxColumn.Width = 125;
            // 
            // псевдонимDataGridViewTextBoxColumn
            // 
            this.псевдонимDataGridViewTextBoxColumn.DataPropertyName = "Псевдоним";
            this.псевдонимDataGridViewTextBoxColumn.HeaderText = "Псевдоним";
            this.псевдонимDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.псевдонимDataGridViewTextBoxColumn.Name = "псевдонимDataGridViewTextBoxColumn";
            this.псевдонимDataGridViewTextBoxColumn.Width = 125;
            // 
            // авторBindingSource
            // 
            this.авторBindingSource.DataSource = typeof(Модернизация.Автор);
            // 
            // читателиBindingSource
            // 
            this.читателиBindingSource.DataSource = typeof(Модернизация.Читатели);
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataSource = typeof(Модернизация.Книги);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource читателиBindingSource;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодавтораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стильнаписанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn псевдонимDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource авторBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

