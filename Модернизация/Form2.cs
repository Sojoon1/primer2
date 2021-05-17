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
    public partial class Form2 : Form
    {
        Model1 db = new Model1();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            выдачакнигBindingSource.DataSource = db.Выдача_книг.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Автор = new Form1();
            Автор.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Журналы = new Form3();
            Журналы.Show();
        }
    
    }
}
