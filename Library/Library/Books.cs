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
    public partial class Books : Form
    {
        string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=biblioteka.mdb";
        private OleDbConnection myConnection;
        OleDbDataReader dr;
        public Books(Form1 ParentForm)
        {
            InitializeComponent();
            DoubleBuffer DoubleBuffer = new DoubleBuffer();
            DoubleBuffer.SetDoubleBuffered(dataGridView, true);
            myConnection = new OleDbConnection(connectString);
        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Издательства". При необходимости она может быть перемещена или удалена.
            this.издательстваTableAdapter.Fill(this.bibliotekaDataSet.Издательства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Авторы". При необходимости она может быть перемещена или удалена.
            this.авторыTableAdapter.Fill(this.bibliotekaDataSet.Авторы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Разделы". При необходимости она может быть перемещена или удалена.
            this.разделыTableAdapter.Fill(this.bibliotekaDataSet.Разделы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.bibliotekaDataSet.Книги);
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
 
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = myConnection;
            string str = "SELECT KODR FROM Разделы WHERE [razdel] LIKE  @razdel ";
            cmd.CommandText = str;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@razdel", RazdelBox.Text);
            dr = cmd.ExecuteReader();
            List<string> res = new List<string>();
            if (dr.Read())
            {
                res.Add(dr["KODR"].ToString());
            }
            else
            {
                OleDbCommand command = new OleDbCommand();
                command.CommandText = "INSERT INTO Разделы (razdel) VALUES (@razdel)";
                command.Connection = myConnection;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@razdel", RazdelBox.Text);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT @@IDENTITY";
                int lastId = Convert.ToInt32(command.ExecuteScalar());
                res.Add(lastId.ToString());
                command.Dispose();
            }
            cmd.Dispose();
            dr.Close();

            string query1 = "INSERT INTO Авторы (fioA) VALUES (@fioA)";
            OleDbCommand cmd1 = new OleDbCommand();
            cmd1.Connection = myConnection;
            string str1 = "SELECT KODA FROM Авторы WHERE [fioA] LIKE  @fioA ";
            cmd1.CommandText = str1;
            cmd1.Parameters.AddWithValue("@fioA", AuthorBox.Text);
            dr = cmd1.ExecuteReader();
            List<string> res1 = new List<string>();
            if (dr.Read())
            {
                res1.Add(dr["KODA"].ToString());
            }
            else
            {
                OleDbCommand command = new OleDbCommand(query1, myConnection);
                command.Parameters.AddWithValue("@fioA", AuthorBox.Text);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT @@IDENTITY";
                int lastId = Convert.ToInt32(command.ExecuteScalar());
                res1.Add(lastId.ToString());
                command.Dispose();
            }
            cmd1.Dispose();
            dr.Close();

            string query2 = "INSERT INTO Издательства (izd) VALUES (@izd)";
            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.Connection = myConnection;
            string str2 = "SELECT KODI FROM Издательства WHERE [izd] LIKE  @izd ";
            cmd2.CommandText = str2;
            cmd2.Parameters.AddWithValue("@izd", IzdBox.Text);
            dr = cmd2.ExecuteReader();
            List<string> res2 = new List<string>();
            if (dr.Read())
            {
                res2.Add(dr["KODI"].ToString());
            }
            else
            {
                OleDbCommand command = new OleDbCommand(query2, myConnection);
                command.Parameters.AddWithValue("@izd", IzdBox.Text);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT @@IDENTITY";
                
                int lastId = Convert.ToInt32(command.ExecuteScalar());
                res2.Add(lastId.ToString());
                command.Dispose();
            }
            cmd2.Dispose();
            dr.Close();

            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.CommandText = " INSERT INTO Книги(YDK,invKB,nameB,yearB,KODR,KODA,KODI) VALUES(@YDK,@invKB,@nameB,@yearB,@KODR,@KODA,@KODI)";
            //cmd3.CommandText = "INSERT INTO Книги (YDK,invKB,nameB,yearB,KODR,KODA,KODI) VALUES (@YDK,@invKB,@nameB,@yearB,(KODR IN (SELECT KODR FROM Разделы WHERE razdel LIKE @razdel)),(KODA IN (SELECT KODA FROM Авторы WHERE fioA LIKE @fioA)),(KODI IN (SELECT KODI FROM Издательства WHERE izd LIKE @izd))";
            //cmd3.CommandText = "INSERT INTO Книги  SELECT (@YDK,@invKB,@nameB,@yearB, (SELECT KODR FROM Разделы WHERE razdel=@razdel), (SELECT KODA FROM Авторы WHERE fioA = @fioA), (SELECT KODI FROM Издательства WHERE izd = @izd))";
            //cmd3.CommandText = "INSERT INTO Книги  @YDK,@invKB,@nameB,@yearB,(SELECT KODR FROM Разделы WHERE razdel=@razdel), (SELECT KODA FROM Авторы WHERE fioA = @fioA), (SELECT KODI FROM Издательства WHERE izd = @izd)";



            //"AND KODR IN (SELECT KODR FROM Разделы WHERE razdel LIKE '%'+@razdel+'%') " +
            //"AND KODA IN (SELECT KODA FROM Авторы WHERE fioA LIKE '%'+@fioA+'%') " +
            //"AND KODI IN (SELECT KODI FROM Издательства WHERE izd LIKE '%'+@izd+'%') ";
            cmd3.Connection = myConnection;
            cmd3.Parameters.AddWithValue("@YDK", YDKBox.Text);
            cmd3.Parameters.AddWithValue("@invKB", InvBox.Text);
            cmd3.Parameters.AddWithValue("@nameB", NameBox.Text);
            cmd3.Parameters.AddWithValue("@yearB", YearBox.Text);
            //cmd3.Parameters.AddWithValue("@razdel", RazdelBox.Text);
            //cmd3.Parameters.AddWithValue("@fioA", AuthorBox.Text);
            //cmd3.Parameters.AddWithValue("@izd", IzdBox.Text);

            cmd3.Parameters.AddWithValue("@KODR", res[0]);
            cmd3.Parameters.AddWithValue("@KODA", res1[0]);
            cmd3.Parameters.AddWithValue("@KODI", res2[0]);
            cmd3.ExecuteNonQuery();
            cmd3.Dispose();
            myConnection.Close();
            res.Clear();
            res1.Clear();
            res2.Clear();
            GC.Collect();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Издательства". При необходимости она может быть перемещена или удалена.
            this.издательстваTableAdapter.Fill(this.bibliotekaDataSet.Издательства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Авторы". При необходимости она может быть перемещена или удалена.
            this.авторыTableAdapter.Fill(this.bibliotekaDataSet.Авторы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Разделы". При необходимости она может быть перемещена или удалена.
            this.разделыTableAdapter.Fill(this.bibliotekaDataSet.Разделы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.bibliotekaDataSet.Книги);
        }

        private void Books_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // книгиBindingSource.Filter = "nameB=\'"+textBox1.Text+"\'";
            int count = 0;
            myConnection.Open();
            OleDbCommand cmd = myConnection.CreateCommand();

            string query = "SELECT * FROM Книги WHERE nameB LIKE '%'+@nameB+'%' AND yearB LIKE '%'+@yearB+'%' AND YDK LIKE '%'+@YDK+'%' AND invKB LIKE '%'+@invKB+'%' " +
                "AND KODR IN (SELECT KODR FROM Разделы WHERE razdel LIKE '%'+@razdel+'%') " +
                "AND KODA IN (SELECT KODA FROM Авторы WHERE fioA LIKE '%'+@fioA+'%') " +
                "AND KODI IN (SELECT KODI FROM Издательства WHERE izd LIKE '%'+@izd+'%') ";
                
            
            cmd.Parameters.AddWithValue("@razdel", textBox6.Text);
            cmd.Parameters.AddWithValue("@fioA", textBox3.Text);
            cmd.Parameters.AddWithValue("@izd", textBox7.Text);
            cmd.Parameters.AddWithValue("@nameB", textBox2.Text);
            cmd.Parameters.AddWithValue("@yearB", textBox4.Text);
            cmd.Parameters.AddWithValue("@YDK", textBox1.Text);
            cmd.Parameters.AddWithValue("@invKB", textBox5.Text);

            cmd.CommandText = query;

            cmd.Connection = myConnection;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView.DataSource = dt;
            myConnection.Close();
            if (count == 0)
            {
                MessageBox.Show("чывп");
            }
            /// if (textBox1.Text != "")
            ///  {
            ///     query = query + " and invKB=@inv ";
            ///     cmd.Parameters.AddWithValue("@inv", textBox1.Text);
            /// }

            /// if (textBox3.Text != "")
            ///  {
            // OleDbCommand command = new OleDbCommand();
            //command.CommandText = "SELECT KODA FROM Авторы WHERE fioA LIKE  @fioA+'%' or fioA LIKE  '%'+@fioA+'%' ";
            //command.Parameters.AddWithValue("@fioA", textBox3.Text);
            //command.Connection = myConnection;
            //dr = command.ExecuteReader();
            //List<string> resA = new List<string>();
            // while (dr.Read())
            // {
            //     resA.Add(dr["KODA"].ToString());
            //     MessageBox.Show(dr["KODA"].ToString());
            //     
            // }
            ///      query = query + " AND KODA IN (SELECT KODA FROM Авторы WHERE fioA LIKE '%'+@fioA+'%')";
            ///     cmd.Parameters.AddWithValue("@fioA", textBox3.Text);
            /// }

            /// if (textBox4.Text != "")
            /// {
            ///     query = query + "and invKB=@YDK ";
            ///     cmd.Parameters.AddWithValue("@YDK", textBox4.Text);
            /// }
            /// if (textBox5.Text != "")
            /// {
            ///    query = query + "and invKB=@YDK ";
            ///     cmd.Parameters.AddWithValue("@YDK", textBox5.Text);
            /// }
            ///if (textBox6.Text != "")
            ///{
            //OleDbCommand command = new OleDbCommand();
            //command.CommandText = "SELECT KODR FROM Книги WHERE razdel LIKE  @razdel+'%' or razdel LIKE  '%'+@razdel+'%' ";
            //command.Parameters.AddWithValue("@razdel", textBox6.Text);
            //command.Connection = myConnection;
            //dr = command.ExecuteReader();
            //List<string> resA = new List<string>();
            //while (dr.Read())
            //{
            //    resA.Add(dr["KODR"].ToString());
            //    MessageBox.Show(dr["KODR"].ToString());
            //}

            ///   query = query + " AND KODR IN (SELECT KODR FROM Разделы WHERE razdel LIKE '%'+@razdel+'%')";
            ///   cmd.Parameters.AddWithValue("@razdel", textBox6.Text);
            //cmd.Parameters.AddWithValue("@KODR", resA[0]);
            /// }
            ///if (textBox7.Text != "")
            ///{
            //query = query + "AND razdel LIKE  '%'+@razdel+'%'";          
            /// }


           // this.авторыTableAdapter.Fill(this.bibliotekaDataSet.Авторы);
        }
    }
}
