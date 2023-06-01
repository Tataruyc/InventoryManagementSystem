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
    public partial class login_form : Form
    {
        public static string userLog;

        public login_form()
        {
            InitializeComponent();

            loginText.Text = "Логин";
            loginText.ForeColor = Color.Gray;

            PasswordText.Text = "Пароль";
            PasswordText.ForeColor = Color.Gray;

            string userLogin = loginText.Text;
        }

        private void loginText_Enter(object sender, EventArgs e)
        {
            if (loginText.Text == "Логин")
            {
                loginText.Text = "";
                loginText.ForeColor = Color.Black;
            }
        }

        private void loginText_Leave(object sender, EventArgs e)
        {
            if (loginText.Text == "")
            {
                loginText.Text = "Логин";
                loginText.ForeColor = Color.Gray;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text == "Пароль")
            {
                PasswordText.Text = "";
                PasswordText.PasswordChar = '*';
                PasswordText.ForeColor = Color.Black;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (PasswordText.Text == "")
            {
                PasswordText.PasswordChar = '\0';
                PasswordText.Text = "Пароль";
                PasswordText.ForeColor = Color.Gray;
            }
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            string loginUser = loginText.Text;
            string passUser = PasswordText.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("select * from UsersInformation where Login = @uN  and Password = @uL ", db.genConnectionDB());

            SqlDataAdapter adapter = new SqlDataAdapter();

            command.Parameters.Add("@uN", SqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                userLog = loginText.Text;
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            reg_form newRegForm = new reg_form();
            newRegForm.Show();
        }

    }
}
