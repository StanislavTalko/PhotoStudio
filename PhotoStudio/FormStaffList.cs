using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PhotoStudio
{
    public partial class FormStaffList : Form
    {
        public FormStaffList()
        {
            InitializeComponent();
        }

        private void FormStaffList_Load(object sender, EventArgs e)
        {
            // уTODO: данная строка кода позволяет загрузить данные в таблицу "photoStudioDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.photoStudioDataSet.Staff);
        } 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonNewStaff_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            String FIO = "delete from Staff where FIO = " + "'" + comboBoxCheckFIO.Text + "'";

            string connString = @"Data Source = LAPTOP-6GPC8CGO\SQLEXPRESS; Initial Catalog = PhotoStudio; Integrated Security = True";
            SqlConnection connection = new SqlConnection(connString);

            connection.Open();
            using (SqlCommand command = new SqlCommand(FIO, connection))
            {
                DialogResult result = MessageBox.Show(
                    "Вы действительно хотите удалить указанного сотрудника " + comboBoxCheckFIO.Text + "?",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly);
            
                if (result == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник удален из базы.");
                    connection.Close();
                    this.Close();
                    Form form = new FormStaffList();
                    form.Show();
                }
                this.TopMost = true;
            }

            
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = LAPTOP-6GPC8CGO\SQLEXPRESS; Initial Catalog = PhotoStudio; Integrated Security = True";

            String name = textBoxFirstName.Text;
            String surname = textBoxSurname.Text;
            String patronymic = textBoxPatronymic.Text;
            String fio = surname + " " + name + " " + patronymic;
            double salary = Convert.ToDouble(textBoxSalary.Text);
            String position = comboBoxPosition.Text;
            String phone = textBoxPhone.Text;
            String password = textBoxPassword.Text;

            SqlConnection connection = new SqlConnection(connString);
            SqlCommand my_command = new SqlCommand();

            my_command.Connection = connection;
            my_command.CommandType = CommandType.StoredProcedure;
            my_command.CommandText = "NewStaff";

            my_command.Parameters.Add("@FIO", SqlDbType.VarChar);
            my_command.Parameters.Add("@Phone", SqlDbType.VarChar);
            my_command.Parameters.Add("@Position", SqlDbType.VarChar);
            my_command.Parameters.Add("@Salary", SqlDbType.Decimal);
            my_command.Parameters.Add("@Password", SqlDbType.VarChar);

            my_command.Parameters["@FIO"].Value = fio;
            my_command.Parameters["@Phone"].Value = phone;
            my_command.Parameters["@Position"].Value = position;
            my_command.Parameters["@Salary"].Value = salary;
            my_command.Parameters["@Password"].Value = password;

            connection.Open();
 
            my_command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Сотрудник добавлен в базу.");

            this.Close();
            Form form = new FormStaffList();
            form.Show();
        }
    }
}
