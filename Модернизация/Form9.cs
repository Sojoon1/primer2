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
    
    public partial class Form9 : Form
    {
        Model1 db = new Model1();
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            читателиBindingSource.DataSource = db.Читатели.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 Темы = new Form8();
            Темы.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 add = new Form11();
            add.db = db;
            DialogResult dr = add.ShowDialog();
            if (dr == DialogResult.OK)
            {
                читателиBindingSource.DataSource = db.Читатели.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Читатели lich = (Читатели)читателиBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить данные? " + lich.Код_читателя.ToString(),
                "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Читатели.Remove(lich);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                читателиBindingSource.DataSource = db.Читатели.ToList();
            }
        }
    }
}
