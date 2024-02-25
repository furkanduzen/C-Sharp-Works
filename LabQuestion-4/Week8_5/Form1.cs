
using System.Data.SQLite;
using System.IO;
namespace Week8_5
{
    public partial class Form1 : Form
    {
        public string dbName = "vp.db";
        public Form1()
        {

            InitializeComponent();
        }

        public void createDatabase()
        {
            if (!File.Exists(dbName))
            {
                // Create a new database
                SQLiteConnection.CreateFile(dbName);
                //Step-1 : Create a connection to DB
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    connection.Open();

                    //Step-2 : Create a Command Object to run your query on the DB
                    SQLiteCommand command = new SQLiteCommand("CREATE TABLE first_table(number1 INTEGER NOT NULL)", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                //MessageBox.Show("You have already created the database");
            }

        }


        public void getNumbersFromDB()
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName);
            connection.Open();
            try
            {
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "Select * from first_table";
                SQLiteDataReader dataReader = command.ExecuteReader();

                if (!dataReader.HasRows)
                {
                    //Data reader has no rows / records
                    dataReader.Close();
                    connection.Close();
                    return;
                }


                while (dataReader.Read())
                {
                    int n1 = dataReader.GetInt32(0);
                    comboBox1.Items.Add(n1);
                }

                dataReader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error : " + exc.Message);
            }

            connection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            createDatabase();
            getNumbersFromDB();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNumber.Text);

            SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName);
            connection.Open();
            try
            {
                for (int i = 0; i < n1; i++)
                {
                    SQLiteCommand command = new SQLiteCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO first_table(number1) VALUES(@number1)";
                    command.Parameters.AddWithValue("@number1", i);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show(n1 + " Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
                return;

            int selectedNumber = int.Parse(comboBox1.SelectedItem.ToString());

            
            SQLiteConnection connection = new SQLiteConnection(@"Data Source = "+dbName);
            connection.Open();
            try
            {
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "DELETE FROM first_table where number1=@number1";
                command.Parameters.AddWithValue("@number1",selectedNumber);
                command.ExecuteNonQuery();

                comboBox1.Items.Remove(selectedNumber);
                comboBox1.SelectedIndex = 0;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : "+ex.Message);
            }
            connection.Close();



        }
    }
}