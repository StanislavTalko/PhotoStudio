using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PhotoStudio
{
    public partial class FormStaff : Form
    {
        int id;
        string connString = @"Data Source = LAPTOP-6GPC8CGO\SQLEXPRESS; Initial Catalog = PhotoStudio; Integrated Security = True";
        Form formAuth;
        static string currentPosition;

        public FormStaff(int id, Form formAuth)
        {
            InitializeComponent();
            this.id = id;
            this.formAuth = formAuth;
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            buttonStaffList.Hide();

            string currentUser = "select FIO from Staff where ID_Staff = " + id;

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

           string selectCurrentPosition = "select Position from Staff where ID_Staff = " + id;

           using (SqlCommand command = new SqlCommand(selectCurrentPosition, connection))
           {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader[0].ToString().Equals("Администратор"))
                    buttonStaffList.Show();
                    currentPosition = reader[0].ToString();
                }
           }

           connection.Close();

           doRefresh();
        }

        private void FormStaff_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            this.Close();
            formAuth.Show();
        }

        private void buttonNewStaff_Click(object sender, EventArgs e)
        {
        }

        private void buttonStaffList_Click(object sender, EventArgs e)
        {
            Form staffList = new FormStaffList();
            staffList.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            doRefresh();
        }

        private void doRefresh()
        {
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand my_command = new SqlCommand();

            my_command.Connection = connection;
            my_command.CommandType = System.Data.CommandType.Text;
            my_command.CommandText = "SELECT * FROM ShowMyOrders (@ID_Staff)";
            my_command.Parameters.Add("@ID_Staff", SqlDbType.Int);
            my_command.Parameters["@ID_Staff"].Value = id;
            
            connection.Open();

            var temp = new DataTable();
            temp.Load(my_command.ExecuteReader());
            dataGridViewMyOrders.DataSource = temp;

            connection.Close();

            if (currentPosition.Equals("Администратор"))
            {
                my_command.CommandType = System.Data.CommandType.Text;
                my_command.CommandText = "SELECT * FROM ShowAllOrdersFromAdministrator ()";

                connection.Open();

                var table = new DataTable();
                table.Load(my_command.ExecuteReader());
                dataGridViewAllOrders.DataSource = table;

                connection.Close();
            }
            else
            {
                my_command.CommandType = System.Data.CommandType.Text;
                my_command.CommandText = "SELECT * FROM ShowAllOrdersFromPhotographer ()";

                connection.Open();

                var table = new DataTable();
                table.Load(my_command.ExecuteReader());
                dataGridViewAllOrders.DataSource = table;

                connection.Close();
            }

            my_command.CommandType = System.Data.CommandType.Text;
            my_command.CommandText = "SELECT * FROM ShowAllDoneOrders(@ID_Staff)";

            connection.Open();

            var doneTable = new DataTable();
            doneTable.Load(my_command.ExecuteReader());
            dataGridViewDoneOrders.DataSource = doneTable;

            connection.Close();
        }

        private void buttonDeleteFromMyOrders_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);

            String selectedDate = dataGridViewMyOrders[2, dataGridViewMyOrders.CurrentRow.Index].Value.ToString().Replace(".", "-");
            String selectedService = dataGridViewMyOrders[1, dataGridViewMyOrders.CurrentRow.Index].Value.ToString();
            String delete = "UPDATE Log SET ID_Staff = null FROM Log JOIN Service ON Log.ID_Service = Service.ID_Service"  +
                " WHERE Log.Due_Date = " + "'" + selectedDate + "' and ID_Staff = " + id +
                " and Service.Service_Name = " + "'" + selectedService + "'";           

            using (SqlCommand command = new SqlCommand(delete, connection))
            {
                connection.Open();

                DialogResult result = MessageBox.Show(
                    "Вы действительно хотите удалить данный заказ из своего списка заказов?",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    connection.Close();
                    doRefresh();
                }
                this.TopMost = true;

                connection.Close();
            }
        }

        private void buttonAddToDoneOrders_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddToMyOrders_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);

            String selectedDate = dataGridViewAllOrders[2, dataGridViewAllOrders.CurrentRow.Index].Value.ToString().Replace(".", "-");
            String selectedService = dataGridViewAllOrders[1, dataGridViewAllOrders.CurrentRow.Index].Value.ToString();
            String addToMyOrders = "UPDATE Log SET ID_Staff = " + id + " FROM Log JOIN Service ON Log.ID_Service = Service.ID_Service" +
                " WHERE Log.Due_Date = " + "'" + selectedDate + "'" + " and Service.Service_Name = " + "'" + selectedService + "'";

            using (SqlCommand command = new SqlCommand(addToMyOrders, connection))
            {
                connection.Open();

                DialogResult result = MessageBox.Show(
                    "Вы действительно хотите взять данный заказ себе?",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    connection.Close();
                    doRefresh();
                }
                this.TopMost = true;

                connection.Close();
            }
        }
    }
}
