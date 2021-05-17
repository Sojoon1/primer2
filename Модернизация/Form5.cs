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
    public partial class Form5 : Form
    {
        Model1 db = new Model1();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            книгиBindingSource.DataSource = db.Книги.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Издательство = new Form4();
            Издательство.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 Корзина_заказов = new Form6();
            Корзина_заказов.Show();
        }
    }
}
