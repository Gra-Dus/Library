using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Библиотека
{
    public partial class formular : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=biblioteka.mdb;";
        private OleDbConnection myConnection = new OleDbConnection(connectString);
        static dynamic persefona;
        
        public formular(string pers)
        {
            InitializeComponent();
            myConnection.Open();
            persefona = pers;
        }
        public formular(bool add)
        {
            InitializeComponent();
            myConnection.Open();
            persefona = add;
        }
      public OleDbCommand command = new OleDbCommand();
        OleDbDataReader reader;
        string query;
        void load(string pers)
        {
            query = "SELECT Группы.groupaCH FROM Группы INNER JOIN Читатели ON Группы.KODG = Читатели.KODG WHERE(((Читатели.famCH) ='" + pers + "')); ";
            command.Connection = myConnection;
            command.CommandText = query;
            textBox1.Text = command.ExecuteScalar().ToString();
            query = "SELECT famCH, ImOtchCh, yearCH, obraz, mesto, uchzav, addressCH, passportCH, seriaCh, kem_vudCH, data_zapCH FROM Читатели WHERE (((Читатели.famCH) ='" + pers + "'));   ";
            command.CommandText = query;
            reader = command.ExecuteReader();
            string[] data = new string[11];
            while (reader.Read())
            {
                for (int i = 0; i < 11; i++)
                {
                    data[i] = reader[i].ToString();
                }
            }
            textBox2.Text = data[0];
            textBox3.Text = data[1];
            textBox4.Text = data[2];
            textBox5.Text = data[3];
            textBox6.Text = data[4];
            textBox7.Text = data[5];
            textBox8.Text = data[6];
            textBox9.Text = data[7];
            textBox10.Text = data[8];
            textBox11.Text = data[9];
            textBox12.Text = data[10];
            reader.Close();
        }
        void load(bool add)
        {

        }
        private void formular_Load(object sender, EventArgs e)
        {
            load(persefona);
           button3.Text = "Сохранить";
        }
        Form frm;
        private void button2_Click(object sender, EventArgs e)
        {
            frm = Application.OpenForms[0];
            frm.Show();
            this.Dispose();
        }
        Form books;
        private void button1_Click(object sender, EventArgs e)
        {
            
                books = new BooksFormul(persefona);
            books.Show();
            this.Dispose();

        }
        void upad(string persefona)
        {
            command.Connection = myConnection;
            query = "SELECT Группы.KODG FROM Группы WHERE (((Группы.groupaCH) = '" + textBox1.Text + "'))";
            command.CommandText = query;
            string kodg = command.ExecuteScalar().ToString();
            query = "UPDATE Читатели SET famCH = '" + textBox2.Text + "' WHERE (((Читатели.famCH) ='" + persefona + "')); ";
            command.CommandText = query;
            command.ExecuteNonQuery();
            query = "UPDATE Читатели SET ImOtchCH = '" + textBox3.Text + "' WHERE (((Читатели.famCH) ='" + persefona + "')); ";
            command.CommandText = query;
            command.ExecuteNonQuery();
            query = "UPDATE Читатели SET obraz = '" + textBox5.Text + "' WHERE (((Читатели.famCH) ='" + persefona + "')); ";
            command.CommandText = query;
            command.ExecuteNonQuery();
            query = "UPDATE Читатели SET mesto = '" + textBox6.Text + "' WHERE (((Читатели.famCH) ='" + persefona + "')); ";
            command.CommandText = query;
            command.ExecuteNonQuery();
            query = "UPDATE Читатели SET uchzav = '" + textBox7.Text + "' WHERE (((Читатели.famCH) ='" + persefona + "')); ";
            command.CommandText = query;
            command.ExecuteNonQuery();
            query = "UPDATE Читатели SET addressCH = '" + textBox8.Text + "' WHERE (((Читатели.famCH) ='" + persefona + "')); ";
            command.CommandText = query;
            command.ExecuteNonQuery();
            query = "UPDATE Читатели SET passportCH = '" + textBox9.Text + "' WHERE (((Читатели.famCH) ='" + persefona + "')); ";
            command.CommandText = query;
            command.ExecuteNonQuery();
            query = "UPDATE Читатели SET seriaCH = '" + textBox10.Text + "' WHERE (((Читатели.famCH) ='" + persefona + "')); ";
            command.CommandText = query;
            command.ExecuteNonQuery();
            query = "UPDATE Читатели SET kem_vudCH = '" + textBox11.Text + "' WHERE (((Читатели.famCH) ='" + persefona + "')); ";
            command.CommandText = query;
            command.ExecuteNonQuery();
            query = "UPDATE Читатели SET KODG = '" + int.Parse(kodg) + "' WHERE (((Читатели.famCH) ='" + persefona + "')); ";
            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        void upad(bool add)
        {
            command.Connection = myConnection;
            query = "SELECT Группы.KODG FROM Группы WHERE (((Группы.groupaCH) = '" + textBox1.Text + "'))";
            command.CommandText = query;
            string kodg = command.ExecuteScalar().ToString();
            query = "INSERT INTO Читатели (KODG, famCH, ImOthcCH, yearCH, obraz, mesto, uchzav, addressCH, passportCH, seriaCH, kem_vudCH, data_zapCH) VALUES('"+kodg+"''"+textBox2.Text+ "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + DateTime.Today + "' );";
            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            upad(persefona);

        }

        private void formular_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            myConnection.Close();
        }
    }
}
