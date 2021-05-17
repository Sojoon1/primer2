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
    public partial class Form7 : Form
    {
        Model1 db = new Model1();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            личныеданныеочитателяхBindingSource.DataSource = db.Личные_данные_о_читателях.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 Корзина_заказов = new Form6();
            Корзина_заказов.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 Темы = new Form8();
            Темы.Show();
        }
    }
}
