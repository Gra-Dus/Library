using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Библиотека
{
    public partial class BooksFormul : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=biblioteka.mdb;";
        private OleDbConnection myConnection = new OleDbConnection(connectString);

        static string persefona;
        public BooksFormul(string pers)
        {
            InitializeComponent();
            myConnection.Open();
            persefona = pers;
        }
        DataSet ds = new DataSet();
        
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        private void Books_Load(object sender, EventArgs e)
        {
            this.Text = persefona;
            string query = "SELECT Формуляр.datvud, Инвентаризация.kodI, Книги.nameB FROM(Читатели INNER JOIN(Книги INNER JOIN Формуляр ON Книги.KODK = Формуляр.KodK) ON Читатели.KODCH = Формуляр.KODCH) INNER JOIN Инвентаризация ON(Читатели.KODCH = Инвентаризация.KodCH) AND(Книги.KODK = Инвентаризация.KodK) WHERE(((Читатели.famCH) ='"+persefona+"')); ";
            command.Connection = myConnection;
            command.CommandText = query;
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            ds.Tables[0].Columns[0].ColumnName = "Дата выдачи";
            ds.Tables[0].Columns[1].ColumnName = "Инвентаризационный номер";
            ds.Tables[0].Columns[2].ColumnName = "Наименование книги";
            dataGridView1.DataSource = ds.Tables[0];
            button1.Text = "Вернуться";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            myConnection.Close();
            this.Dispose();
        }
    }
}
