
namespace Модернизация
{
    partial class Form7
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
            this.кодчитателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.личныеданныеочитателяхBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеданныеочитателяхBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодчитателяDataGridViewTextBoxColumn,
            this.возрастDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.личныеданныеочитателяхBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(475, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(602, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(935, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // кодчитателяDataGridViewTextBoxColumn
            // 
            this.кодчитателяDataGridViewTextBoxColumn.DataPropertyName = "Код_читателя";
            this.кодчитателяDataGridViewTextBoxColumn.HeaderText = "Код_читателя";
            this.кодчитателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодчитателяDataGridViewTextBoxColumn.Name = "кодчитателяDataGridViewTextBoxColumn";
            this.кодчитателяDataGridViewTextBoxColumn.Width = 125;
            // 
            // возрастDataGridViewTextBoxColumn
            // 
            this.возрастDataGridViewTextBoxColumn.DataPropertyName = "Возраст";
            this.возрастDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.возрастDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.возрастDataGridViewTextBoxColumn.Name = "возрастDataGridViewTextBoxColumn";
            this.возрастDataGridViewTextBoxColumn.Width = 125;
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            this.полDataGridViewTextBoxColumn.Width = 125;
            // 
            // личныеданныеочитателяхBindingSource
            // 
            this.личныеданныеочитателяхBindingSource.DataSource = typeof(Модернизация.Личные_данные_о_читателях);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личные данные о читателях";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеданныеочитателяхBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодчитателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource личныеданныеочитателяхBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}