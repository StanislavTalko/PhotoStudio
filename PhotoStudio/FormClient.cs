using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PhotoStudio
{
    public partial class FormClient : Form
    {
        string connString = @"Data Source = LAPTOP-6GPC8CGO\SQLEXPRESS; Initial Catalog = PhotoStudio; Integrated Security = True";
        int id;
        Form formAuth;

        public FormClient(int id, Form formAuth)
        {
            InitializeComponent();
            this.id = id;
            this.formAuth = formAuth;
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "photoStudioDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.photoStudioDataSet.Service);
            string currentUser = "select FIO from Client where ID_Client = " + id;

            SqlConnection connection = new SqlConnection(connString);

            connection.Open();

            using (SqlCommand command = new SqlCommand(currentUser, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    labelCurrentUser.Text = reader[0].ToString();
                    reader.Close();
                }
            }

            connection.Close();

            dateTimePickerOrderDay.Format = DateTimePickerFormat.Custom;
            dateTimePickerOrderDay.MinDate = DateTime.Now;
            dateTimePickerOrderDay.MaxDate = DateTime.Now.AddDays(30);

            string currentPrice = "select Price from Service where Service_Name = " + "'" + comboBoxService.Text + "'";

            connection.Open();

            using (SqlCommand command = new SqlCommand(currentPrice, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    labelPrice.Text = reader[0].ToString();
                    reader.Close();
                }
            }
            connection.Close();
        }

        private void FormClient_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            this.Close();
            formAuth.Show();
        }

        private void comboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentPrice = "select Price from Service where Service_Name = " + "'" + comboBoxService.Text + "'";

            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            using (SqlCommand command = new SqlCommand(currentPrice, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    labelPrice.Text = reader[0].ToString();
                    reader.Close();
                }
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand my_command = new SqlCommand();
            String time = comboBoxTime.Text;
            int hour = Convert.ToInt32(time.Substring(0,2));
            int minute = Convert.ToInt32(time.Substring(3,2));
            DateTime selectedTime = new DateTime(
                dateTimePickerOrderDay.Value.Year, dateTimePickerOrderDay.Value.Month, 
                dateTimePickerOrderDay.Value.Day, hour, minute, 0);

            my_command.Connection = connection;
            my_command.CommandType = CommandType.StoredProcedure;
            my_command.CommandText = "NewOrder";

            my_command.Parameters.Add("@ID_Client", SqlDbType.Int);
            my_command.Parameters.Add("@Service_Name", SqlDbType.VarChar);
            my_command.Parameters.Add("@Order_Date", SqlDbType.DateTime);

            my_command.Parameters["@ID_Client"].Value = id;
            my_command.Parameters["@Service_Name"].Value = comboBoxService.Text;
            my_command.Parameters["@Order_Date"].Value = selectedTime;
            
            connection.Open();
            
            my_command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Запись успешно проведена");
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);
            
            SqlCommand my_command = new SqlCommand();
            
            my_command.Connection = connection;
            
            my_command.CommandType = CommandType.Text;
            if (checkBoxActual.Checked)
                my_command.CommandText = "SELECT * FROM ShowAllOrdersFromClientActual (@ID_Client)";
            else
                my_command.CommandText = "SELECT * FROM ShowAllOrdersFromClient (@ID_Client)";
            
            my_command.Parameters.Add("@ID_Client", SqlDbType.Int);
            my_command.Parameters["@ID_Client"].Value = id;
            
            connection.Open();
            
            var temp = new DataTable();
             
            temp.Load(my_command.ExecuteReader());
            
            dataGridViewMyOrders.DataSource = temp;
            
            connection.Close();
        }
    }
}
