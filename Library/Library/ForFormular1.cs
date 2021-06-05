using System;
using System.Drawing;
using System.Windows.Forms;
using Library;
namespace Библиотека
{
    public partial class Forformular1 : Form
    {
        public Forformular1(Form1 ParentForm)
        {
            InitializeComponent();
        }

        // int[,] a;
        private void main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "readerDataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.readerDataSet.Читатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groupDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.groupDataSet.Группы);

            читателиBindingSource.Filter = "KODG=" + (comboBox1.SelectedIndex + 1).ToString();
            //  this.WindowState = FormWindowState.Maximized;
            label1.Text = "Группа";
            label2.Text = "Фамилия";
            button1.Text = "Посмотреть";
            button2.Text = "Добавить нового читателя";
            /*
                        a = new int[6, 2];
                        a[0, 0] = button1.Location.X;
                        a[0, 1] = button1.Location.Y;
                        a[1, 0] = button2.Location.X;
                        a[1, 1] = button2.Location.Y;
                        a[2, 0] = label1.Location.X;
                        a[2, 1] = label1.Location.Y;
                        a[3, 0] = label2.Location.X;
                        a[3, 1] = label2.Location.Y;
                        a[4, 0] = comboBox1.Location.X;
                        a[4, 1] = comboBox1.Location.Y;
                        a[5, 0] = comboBox2.Location.X;
                        a[5, 1] = comboBox2.Location.Y;
                       */
        }
        private void main_ClientSizeChanged(object sender, EventArgs e)
        {/*
           button1.Location = sizechangerbtn(a[0,0],a[0,1],this.Size.Width,this.Size.Height);
       button2.Location = sizechangerbtn(a[1,0],a[1,1],this.Size.Width,this.Size.Height);
       label1.Location = sizechangerbtn(a[2,0],a[2,1],this.Size.Width,this.Size.Height);
       label2.Location = sizechangerbtn(a[3,0],a[3,1],this.Size.Width,this.Size.Height);
       comboBox1.Location = sizechangerbtn(a[4,0],a[4,1],this.Size.Width,this.Size.Height);
       comboBox2.Location = sizechangerbtn(a[5,0],a[5,1],this.Size.Width,this.Size.Height);
       */
        }
        Point sizechangerbtn(dynamic butx, dynamic buty, dynamic Wsize, dynamic Hsize)
        {
            float procentX = Wsize * 100 / 512;
            float procentY = Hsize * 100 / 512;
            int x = int.Parse((Math.Round(butx * procentX / 100)).ToString());
            int y = int.Parse((Math.Round(buty * procentY / 100)).ToString());
            Point p = new Point(x, y);
            return p;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            читателиBindingSource.Filter = "KODG=" + (comboBox1.SelectedIndex + 1).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sel = comboBox2.Text;
            formular fort = new formular(sel);
            fort.Show();

        }

        private void main_Enter(object sender, EventArgs e)
        {

        }

        private void main_Activated(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.readerDataSet.Clear();
            this.читателиTableAdapter.Fill(readerDataSet.Читатели);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formular fort = new formular(true);
            fort.Show();
        }
    }
}
