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
    public partial class Form4 : Form
    {
        Model1 db = new Model1();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            издательствоBindingSource.DataSource = db.Издательство.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Журналы = new Form3();
            Журналы.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 Книги = new Form5();
            Книги.Show();
        }
    }
}
