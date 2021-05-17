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
    public partial class Form10 : Form
    {
        public Model1 db { get; set; }
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                textBox4.Text == "")
            {
                MessageBox.Show("Одно из важных полей не заполнено!");
                return;
            }
            Автор lich = new Автор();
          
            lich.Код_автора = textBox1.Text;
            lich.ФИО = textBox2.Text;
            lich.Пол = textBox5.Text;
            lich.Стиль_написания = textBox3.Text;
            lich.Псевдоним = textBox4.Text;

            db.Автор.Add(lich);

            db.SaveChanges();

            DialogResult = DialogResult.OK;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
