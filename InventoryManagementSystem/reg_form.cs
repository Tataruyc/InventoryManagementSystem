using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class reg_form : Form
    {
        public reg_form()
        {
            InitializeComponent();


            nameText.Text = "Введите имя";
            nameText.ForeColor = Color.Gray;

            surnameText.Text = "Введите фамилию";
            surnameText.ForeColor = Color.Gray;

            companyName.Text = "Введите компанию";
            companyName.ForeColor = Color.Gray;

            loginText.Text = "Введите логин";
            loginText.ForeColor = Color.Gray;

            passwordText.Text = "Введите пароль";
            passwordText.ForeColor = Color.Gray;
        }

        private void nameText_Enter(object sender, EventArgs e)
        {
            if (nameText.Text == "Введите имя")
            {
                nameText.Text = "";
                nameText.ForeColor = Color.Black;
            }
        }

        private void nameText_Leave(object sender, EventArgs e)
        {
            if (nameText.Text == "")
            {
                nameText.Text = "Введите имя";
                nameText.ForeColor = Color.Gray;
            }
        }

        private void surnameText_Enter(object sender, EventArgs e)
        {
            if (surnameText.Text == "Введите фамилию")
            {
                surnameText.Text = "";
                surnameText.ForeColor = Color.Black;
            }
        }

        private void surnameText_Leave(object sender, EventArgs e)
        {
            if (surnameText.Text == "")
            {
                surnameText.Text = "Введите фамилию";
                surnameText.ForeColor = Color.Gray;
            }
        }

        private void companyName_Enter(object sender, EventArgs e)
        {
            if (companyName.Text == "Введите компанию")
            {
                companyName.Text = "";
                companyName.ForeColor = Color.Black;
            }
        }

        private void companyName_Leave(object sender, EventArgs e)
        {
            if (companyName.Text == "")
            {
                companyName.Text = "Введите компанию";
                companyName.ForeColor = Color.Gray;
            }
        }

        private void loginText_Enter(object sender, EventArgs e)
        {
            if (loginText.Text == "Введите логин")
            {
                loginText.Text = "";
                loginText.ForeColor = Color.Black;
            }
        }

        private void loginText_Leave(object sender, EventArgs e)
        {
            if (loginText.Text == "")
            {
                loginText.Text = "Введите логин";
                loginText.ForeColor = Color.Gray;
            }
        }

        private void passwordText_Enter(object sender, EventArgs e)
        {
            if (passwordText.Text == "Введите пароль")
            {
                passwordText.Text = "";
                passwordText.PasswordChar = '*';
                passwordText.ForeColor = Color.Black;
            }
        }

        private void passwordText_Leave(object sender, EventArgs e)
        {
            if (passwordText.Text == "")
            {
                passwordText.PasswordChar = '\0';
                passwordText.Text = "Введите пароль";
                passwordText.ForeColor = Color.Gray;
            }
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            if (nameText.Text == "Введите пароль")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (surnameText.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (companyName.Text == "Введите компанию")
            {
                MessageBox.Show("Введите компанию");
                return;
            }
            if (loginText.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
            }
            if (passwordText.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (isUserExists())
                return;

            DB db = new DB();

            SqlCommand command = new SqlCommand("insert into UsersInformation(Name, Surname, Company, Password, Login) values(@uN, @uS, @uC, @uP, @uL)", db.genConnectionDB());


            string userName = nameText.Text;
            string userSurname = surnameText.Text;
            string userCompany = companyName.Text;
            string userLogin = loginText.Text;
            string userPassword = passwordText.Text;

            command.Parameters.Add("@uN", SqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@uS", SqlDbType.VarChar).Value = userSurname;
            command.Parameters.Add("@uC", SqlDbType.VarChar).Value = userCompany;
            command.Parameters.Add("@uP", SqlDbType.VarChar).Value = userPassword;
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = userLogin;

            db.openConnectionDB();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан!");
                this.Close();
                login_form logForm = new login_form();
                logForm.Show();
            }
            else
            {
                MessageBox.Show("Не удалось создать аккаунт!");
            }

            db.closeConnectionDB();
        }

        private Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("select * from UsersInformation where Login = @uL", db.genConnectionDB());

            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginText.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Логин уже занят, введите другой");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form login = new login_form();
            login.Show();
        }
    }
}
