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
    public partial class RegisterForm : Form
    {
        private Point MouseHook;
        public RegisterForm()
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

        private void HeaderRegister_MouseMove(object sender, MouseEventArgs e)
        {
            MovingApplication(e);
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            MovingApplication(e);
        }

        private void HeaderLabel_MouseMove(object sender, MouseEventArgs e)
        {
            MovingApplication(e);
        }

        private void guna2ShadowPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            MovingApplication(e);
        }

        private void ChangeFormOnAvtorization_Click(object sender, EventArgs e)
        {
            AvtorrizationForm AF = new AvtorrizationForm();
            AF.Show();
            this.Hide();
        }

        private void RegisterButtob_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || SurnameTextBox.Text == "" || LoginTextBox.Text == "" || PasswordTextBox.Text == "")
                return;

            Database db = new Database();
            MySqlCommand command = new MySqlCommand("INSERT INTO `clients` (`name`, `surname`, `login`, `password`) VALUES (@name, @surname, @login, @password)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginTextBox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordTextBox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameTextBox.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = SurnameTextBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                MainForm Main = new MainForm();
                Main.Show();
                return;
            }
            MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();
        }

        private void ExitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FunctionPanel_MouseMove(object sender, MouseEventArgs e)
        {
            MovingApplication(e);
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitSymbols(e);
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitSymbols(e);
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitSymbols(e);
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitSymbols(e);
        }
    }
}
