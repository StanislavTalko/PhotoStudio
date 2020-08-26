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
    public partial class FormAuth : Form
    {
        public string connString = @"Data Source = LAPTOP-6GPC8CGO\SQLEXPRESS; Initial Catalog = PhotoStudio; Integrated Security = True";

        public FormAuth()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            String phone = textBoxPhone.Text;
            String password = textBoxPassword.Text;

            try {
                SqlConnection connection = new SqlConnection(connString);

                connection.Open();

                String checkStaff = "select ID_Staff from Staff where Phone = '" + phone + "' and Password = '" + password + "'";
                String checkClient = "select ID_Client from Client where Phone = '" + phone + "' and Password = '" + password + "'";


                using (SqlCommand command = new SqlCommand(checkStaff, connection))
                {
                    SqlDataReader staffReader = command.ExecuteReader();
                    if (staffReader.HasRows)
                    {
                        staffReader.Read();
                        int id = Convert.ToInt32(staffReader[0].ToString());
                        staffReader.Close();
                        Form staff = new FormStaff(id, this);
                        textBoxPhone.Clear();
                        textBoxPassword.Clear();
                        this.Hide();
                        staff.Show();
                    }
                    else
                    {
                        using (SqlCommand comm = new SqlCommand(checkClient, connection))
                        {
                            staffReader.Close();
                            SqlDataReader clientReader = comm.ExecuteReader();
                            if (clientReader.HasRows)
                            {
                                clientReader.Read();
                                int id = Convert.ToInt32(clientReader[0].ToString());
                                clientReader.Close();
                                Form client = new FormClient(id, this);
                                this.Hide();
                                client.Show();
                            }
                            else
                            {
                                staffReader.Close();
                                clientReader.Close();
                                MessageBox.Show("Пользователя не существует.");
                            }
                        }
                    }
                }
            } catch (SqlException)
            {
                MessageBox.Show("Отсутствует соединение с сервером.");
                
                return;
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Form registration = new FormRegistration(this);
            this.Hide();
            registration.Show();
        }
    }
}
