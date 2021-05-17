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
    public partial class Form6 : Form
    {
        Model1 db = new Model1();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            корзиназаказовBindingSource.DataSource = db.Корзина_заказов.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 Книги = new Form5();
            Книги.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 Личные_данные_о_читателях = new Form7();
            Личные_данные_о_читателях.Show();
        }
    }
}
