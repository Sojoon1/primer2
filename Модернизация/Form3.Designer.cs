
namespace Модернизация
{
    partial class Form3
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
            this.коджурналаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествостраницDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.журналыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.журналыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.коджурналаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.количествостраницDataGridViewTextBoxColumn,
            this.датавыпускаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.журналыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(408, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(701, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(889, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // коджурналаDataGridViewTextBoxColumn
            // 
            this.коджурналаDataGridViewTextBoxColumn.DataPropertyName = "Код_журнала";
            this.коджурналаDataGridViewTextBoxColumn.HeaderText = "Код_журнала";
            this.коджурналаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.коджурналаDataGridViewTextBoxColumn.Name = "коджурналаDataGridViewTextBoxColumn";
            this.коджурналаDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествостраницDataGridViewTextBoxColumn
            // 
            this.количествостраницDataGridViewTextBoxColumn.DataPropertyName = "Количество_страниц";
            this.количествостраницDataGridViewTextBoxColumn.HeaderText = "Количество_страниц";
            this.количествостраницDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествостраницDataGridViewTextBoxColumn.Name = "количествостраницDataGridViewTextBoxColumn";
            this.количествостраницDataGridViewTextBoxColumn.Width = 125;
            // 
            // датавыпускаDataGridViewTextBoxColumn
            // 
            this.датавыпускаDataGridViewTextBoxColumn.DataPropertyName = "Дата_выпуска";
            this.датавыпускаDataGridViewTextBoxColumn.HeaderText = "Дата_выпуска";
            this.датавыпускаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датавыпускаDataGridViewTextBoxColumn.Name = "датавыпускаDataGridViewTextBoxColumn";
            this.датавыпускаDataGridViewTextBoxColumn.Width = 125;
            // 
            // журналыBindingSource
            // 
            this.журналыBindingSource.DataSource = typeof(Модернизация.Журналы);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журналы";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.журналыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn коджурналаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествостраницDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource журналыBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}