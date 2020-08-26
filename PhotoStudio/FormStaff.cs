using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            dataGridViewRes.DataSource = temp;

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

        }

        private void buttonAddToDoneOrders_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddToMyOrders_Click(object sender, EventArgs e)
        {

        }
    }
}
