using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProizvodstvennayaPrakrtika
{
    public partial class AvtorrizationForm : Form
    {
        private Point MouseHook;
        public AvtorrizationForm()
        {
            InitializeComponent();
        }

        private void MovingApplication(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                MouseHook = e.Location;

            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        public void LimitSymbols(KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (number == 13)
            {
                e.Handled = true;
            }
        }

        private void HeaderLabel_MouseMove(object sender, MouseEventArgs e)
        {
            MovingApplication(e);
        }

        private void AvtorrizationForm_MouseMove(object sender, MouseEventArgs e)
        {
            MovingApplication(e);
        }

        private void MainRegisterPanel_MouseMove(object sender, MouseEventArgs e)
        {
            MovingApplication(e);
        }

        private void HeaderLabel_MouseMove_1(object sender, MouseEventArgs e)
        {
            MovingApplication(e);
        }

        private void FunctionPanel_MouseMove(object sender, MouseEventArgs e)
        {
            MovingApplication(e);
        }

        private void ChangeFormOnRegistration_Click(object sender, EventArgs e)
        {
            RegisterForm RF = new RegisterForm();
            RF.Show();
            this.Hide();
        }

        private void AvtorizationButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "" || PasswordTextBox.Text == "")
                return;

            String loginUser = LoginTextBox.Text;
            String passUser = PasswordTextBox.Text;

            Database db = new Database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients` WHERE `login` = @Login AND `password` = @Password", db.getConnection());

            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm Main = new MainForm();
                Main.Show();
                DataClients.Login = loginUser;
                DataClients.Password = passUser;
                return;  
            }

            MessageBox.Show("Такого аккаунта не существует!");
        }

        private void ExitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitSymbols(e);
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitSymbols(e);
        }
    }
}
