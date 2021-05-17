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
    public partial class Form8 : Form
    {
        Model1 db = new Model1();
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            темыBindingSource.DataSource = db.Темы.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 Личные_данные_о_читателях = new Form7();
            Личные_данные_о_читателях.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 Читатели = new Form9();
            Читатели.Show();
        }
    }
}
