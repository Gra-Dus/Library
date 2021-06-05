using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Library
{
    public partial class Authors : Form
    {
        string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=biblioteka.mdb";
        private OleDbConnection myConnection;
        public Authors(Form1 ParentForm)
        {
            InitializeComponent();
            DoubleBuffer DoubleBuffer = new DoubleBuffer();
            DoubleBuffer.SetDoubleBuffered(dataGridView1, true);
            myConnection = new OleDbConnection(connectString);
        }

        private void Authors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Разделы". При необходимости она может быть перемещена или удалена.
            this.разделыTableAdapter.Fill(this.bibliotekaDataSet.Разделы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Авторы". При необходимости она может быть перемещена или удалена.
            this.авторыTableAdapter.Fill(this.bibliotekaDataSet.Авторы);
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand();
            string name = textBox1.Text;
            cmd.CommandText = " INSERT INTO Авторы(fioA) VALUES('" + name + "')";
            cmd.Connection = myConnection;
            cmd.ExecuteNonQuery();
            myConnection.Close();
            this.авторыTableAdapter.Fill(this.bibliotekaDataSet.Авторы);
        }

        private void Authors_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            GC.Collect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эти записи?", "Удаление записей", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    myConnection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "DELETE FROM Авторы WHERE KODA = @ind";
                    cmd.Connection = myConnection;
                    String s = dataGridView1[0, item.Index].Value.ToString();
                    cmd.Parameters.AddWithValue("@ind", s);
                    cmd.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(item.Index);
                    myConnection.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
         myConnection.Open();
         OleDbCommand cmd = new OleDbCommand();
         cmd.CommandText = "UPDATE Авторы SET fioA=@fio WHERE KODA = @id";
         cmd.Connection = myConnection;
         //String s = dataGridView1[0, item.Index].Value.ToString();
         cmd.Parameters.AddWithValue("@fio",textBox3.Text);
         cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox2.Text));
         cmd.ExecuteNonQuery();
         myConnection.Close(); 
        }
    }
}
