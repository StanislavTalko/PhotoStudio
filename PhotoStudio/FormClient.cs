using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

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

            doRefresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            Application.Restart();
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

            //Если выбранное время на этот день меньше текущего на 2 часа, то записаться нельзя
            if (selectedTime <= DateTime.Now.AddHours(2))
            {
                MessageBox.Show("Запись осуществляется не позднее чем за 2 часа до выполнения заказа. \nВыберите другое время.");
                return;
            }

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

            String findOrderId = "SELECT ID_log FROM Log JOIN Service ON Log.ID_Service = Service.ID_Service" +
                " WHERE Log.Due_Date = " + "'" + selectedTime + "' and Log.ID_Client = " + id +
                " and Service.Service_Name = " + "'" + comboBoxService.Text + "'";

            connection.Open();

            using (SqlCommand command = new SqlCommand(findOrderId, connection))
            {
                SqlDataReader idReader = command.ExecuteReader();
                if (idReader.HasRows)
                {
                    idReader.Read();
                    int logId = Convert.ToInt32(idReader[0].ToString());
                    MessageBox.Show("Номер заказа: " + logId);
                    DirectoryInfo dirInfo = new DirectoryInfo(@"D:\English\Profession\Projects\PhotoStudio\Photo\" + logId);
                    if (!dirInfo.Exists)
                    {
                        dirInfo.Create();
                    }
                    idReader.Close();
                }
                connection.Close();
            }
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

        private void doRefresh()
        {
            SqlConnection connection = new SqlConnection(connString);

            SqlCommand my_command = new SqlCommand();

            my_command.Connection = connection;

            my_command.CommandType = CommandType.Text;
            if (checkBoxActual.Checked)
            {
                my_command.CommandText = "SELECT Service.Service_Name AS 'Услуга', Log.Due_Date AS 'Время' " +
                    "FROM Log JOIN Client ON Log.ID_Client = Client.ID_Client JOIN Service ON Log.ID_Service = Service.ID_Service " +
                    "WHERE Log.ID_Client = " + id + " and Log.Due_Date >= " + DateTime.Now;
            }
            else
            {
                my_command.CommandText = "SELECT Service.Service_Name AS 'Услуга', Log.Due_Date AS 'Время' " +
                    "FROM Log JOIN Client ON Log.ID_Client = Client.ID_Client JOIN Service ON Log.ID_Service = Service.ID_Service " +
                    "WHERE Log.ID_Client = " + id;
            }

            connection.Open();

            var temp = new DataTable();

            temp.Load(my_command.ExecuteReader());

            dataGridViewMyOrders.DataSource = temp;

            connection.Close();
        }

        private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonOpenSelectedOrder_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand my_command = new SqlCommand();
            my_command.Connection = connection;
            my_command.CommandType = CommandType.Text;
            String selectedOrder = "SELECT ID_Log FROM Log JOIN Service ON Log.ID_Service = Service.ID_Service " +
                "WHERE ID_Client = " + id + " AND " + 
                "Service.Service_Name = " +  "'" + dataGridViewMyOrders[0, dataGridViewMyOrders.CurrentRow.Index].Value.ToString() + "' AND " +
                "Log.Due_Date = " + "'" +  dataGridViewMyOrders[1, dataGridViewMyOrders.CurrentRow.Index].Value.ToString() + "'";

            connection.Open();

            using (SqlCommand command = new SqlCommand(selectedOrder, connection))
            {
                SqlDataReader idReader = command.ExecuteReader();
                if (idReader.HasRows)
                {
                    idReader.Read();
                    int logId = Convert.ToInt32(idReader[0].ToString());
                    Process.Start(@"D:\English\Profession\Projects\PhotoStudio\Photo\" + logId);
                    idReader.Close();
                }
                connection.Close();
            }
        }
    }
}
