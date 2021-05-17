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
    public partial class Form3 : Form
    {
        Model1 db = new Model1();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            журналыBindingSource.DataSource = db.Журналы.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Выдача_книг = new Form2();
            Выдача_книг.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Издательство = new Form4();
            Издательство.Show();
        }
    }
}
