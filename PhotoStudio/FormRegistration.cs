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
    public partial class FormRegistration : Form
    {
        public string connString = @"Data Source = LAPTOP-6GPC8CGO\SQLEXPRESS; Initial Catalog = PhotoStudio; Integrated Security = True";
        Form formAuth;

        public FormRegistration(Form formAuth)
        {
            InitializeComponent();
            this.formAuth = formAuth;
        }

        private void FormRegistration_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            String name = textBoxFirstName.Text;
            String surname = textBoxSurname.Text;
            String patronymic = textBoxPatronymic.Text;
            String fio = surname + " " + name + " " + patronymic;
            String phone = textBoxPhone.Text;
            String password = textBoxPassword.Text;

            SqlConnection connection = new SqlConnection(connString);
            SqlCommand my_command = new SqlCommand();

            my_command.Connection = connection;
            my_command.CommandType = CommandType.StoredProcedure;
            my_command.CommandText = "NewClient";

            my_command.Parameters.Add("@FIO", SqlDbType.VarChar);
            my_command.Parameters.Add("@Phone", SqlDbType.VarChar);
            my_command.Parameters.Add("@Password", SqlDbType.VarChar);

            my_command.Parameters["@FIO"].Value = fio;
            my_command.Parameters["@Phone"].Value = phone;
            my_command.Parameters["@Password"].Value = password;
            
            connection.Open();
            
            my_command.ExecuteNonQuery();

            String checkClient = "select ID_Client from Client where Phone = '" + phone + "' and Password = '" + password + "'";

            using (SqlCommand comm = new SqlCommand(checkClient, connection))
            {

                SqlDataReader clientReader = comm.ExecuteReader();
                if (clientReader.HasRows)
                {
                    clientReader.Read();
                    int id = Convert.ToInt32(clientReader[0].ToString());
                    clientReader.Close();
                    Form client = new FormClient(id, formAuth);
                    client.Show();
                    this.Close();
                    connection.Close();
                }
                else connection.Close();
            }

        }

        private void buttonBackToAuth_Click(object sender, EventArgs e)
        {
            this.Close();
            formAuth.Show();
        }
    }
}
