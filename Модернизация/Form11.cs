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
    public partial class Form11 : Form
    {
        public Model1 db { get; set; }
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Одно из важных полей не заполнено!");
                return;
            }
            Читатели lich = new Читатели();

            lich.Код_читателя = Convert.ToInt32(textBox1.Text); ;
            lich.Фамилия = textBox2.Text;
            lich.Имя = textBox3.Text;
            lich.Отчество = textBox4.Text;
            lich.Адрес = textBox5.Text;
            lich.Домашний_телефон = textBox6.Text;
            

            db.Читатели.Add(lich);

            db.SaveChanges();

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
