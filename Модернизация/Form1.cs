using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Модернизация
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            авторBindingSource.DataSource = db.Автор.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Выдача_книг = new Form2();
            Выдача_книг.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Автор lich = (Автор)авторBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить данные? " + lich.Код_автора.ToString(),
                "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Автор.Remove(lich);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                авторBindingSource.DataSource = db.Автор.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 add = new Form10();
            add.db = db;
            DialogResult dr = add.ShowDialog();
            if (dr == DialogResult.OK)
            {
                авторBindingSource.DataSource = db.Автор.ToList();
            }
        }
    }
}
