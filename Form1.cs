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
    public partial class MainForm : Form
    {
        Timer timer = new Timer();
        private Point MouseHook;
        public MainForm()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(ChangeBalanceButton, "Пополнение баланса");
            toolTip.SetToolTip(ExitPictureBox, "Выйти из приложения");
            toolTip.SetToolTip(ExitAccountButton, "Выйти из аккаунта");
        }

        private void MovingApplication(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                MouseHook = e.Location;

            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            MovingApplication(e);
        }
        private void HeaderPanel_MouseMove_1(object sender, MouseEventArgs e)
        {
            MovingApplication(e);
        }
        private void FunctionPanel_MouseMove(object sender, MouseEventArgs e)
        {
            MovingApplication(e);
        }

        private void ChangeSizeForm(EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized && this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                return;
            }

            this.WindowState = FormWindowState.Normal;
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            ChangeSizeForm(e);
        }
        private void HeaderPanel_DoubleClick_1(object sender, EventArgs e)
        {
            ChangeSizeForm(e);
        }
        private void FunctionPanel_DoubleClick(object sender, EventArgs e)
        {
            ChangeSizeForm(e);
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ComboMarka()
        {
            const string sql = "datasource=localhost;port=3306;username=root;password=root;database=proizcement";

            DataTable tableMarka = new DataTable();

            MySqlConnection con = new MySqlConnection(sql);

            con.Open();

            string combo = "SELECT marka,info,price FROM `markandinfo`";

            MySqlCommand connection = new MySqlCommand(combo, con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(connection);

            adapter.Fill(tableMarka);

            MarkaComboBox.DataSource = tableMarka;
            MarkaComboBox.DisplayMember = "marka";

            con.Close();

            MarkaComboBox.SelectedIndex = -1;
        }

        public void ComboSize()
        {
            const string sql = "datasource=localhost;port=3306;username=root;password=root;database=proizcement";

            DataTable table = new DataTable();

            MySqlConnection con = new MySqlConnection(sql);

            con.Open();

            string combo = "SELECT size,price FROM `size`";

            MySqlCommand connection = new MySqlCommand(combo, con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(connection);

            adapter.Fill(table);

            SizeComboBox.DataSource = table;
            SizeComboBox.DisplayMember = "size";

            con.Close();

            SizeComboBox.SelectedIndex = -1;
        }

        public void ComboQuantity()
        {
            const string sql = "datasource=localhost;port=3306;username=root;password=root;database=proizcement";

            DataTable table = new DataTable();

            MySqlConnection con = new MySqlConnection(sql);

            con.Open();

            string combo = "SELECT quantity,price FROM `quantity`";

            MySqlCommand connection = new MySqlCommand(combo, con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(connection);

            adapter.Fill(table);

            QuantityComboBox.DataSource = table;
            QuantityComboBox.DisplayMember = "quantity";

            con.Close();

            QuantityComboBox.SelectedIndex = -1;
        }

        public void ComboCity()
        {
            const string sql = "datasource=localhost;port=3306;username=root;password=root;database=proizcement";

            DataTable table = new DataTable();

            MySqlConnection con = new MySqlConnection(sql);

            con.Open();

            string combo = "SELECT city,distance,price FROM `city`";

            MySqlCommand connection = new MySqlCommand(combo, con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(connection);

            adapter.Fill(table);

            CityComboBox.DataSource = table;
            CityComboBox.DisplayMember = "city";

            con.Close();

            CityComboBox.SelectedIndex = -1;
        }

        private void MarkaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MarkaComboBox.SelectedIndex == -1)
            {
                InfoLabel.Text = "";
                MainInfoLabel.Text = "";
                return;
            }

                DataOrder.Marka = (MarkaComboBox.SelectedItem as DataRowView).Row.ItemArray[0].ToString();
                InfoLabel.Text = (MarkaComboBox.SelectedItem as DataRowView).Row.ItemArray[1].ToString();
                DataOrder.MarkaPrice = (MarkaComboBox.SelectedItem as DataRowView).Row.ItemArray[2].ToString();

            Refresher();
        }

        private void SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SizeComboBox.SelectedIndex == -1)
            {
                InfoLabel.Text = "";
                MainInfoLabel.Text = "";
                return;
            }
                DataOrder.Size = (SizeComboBox.SelectedItem as DataRowView).Row.ItemArray[0].ToString();
                DataOrder.SizePrice = (SizeComboBox.SelectedItem as DataRowView).Row.ItemArray[1].ToString();

            Refresher();
        }

        private void QuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QuantityComboBox.SelectedIndex == -1)
            {
                MainInfoLabel.Text = "";
                return;
            }
                DataOrder.Quantity = (QuantityComboBox.SelectedItem as DataRowView).Row.ItemArray[0].ToString();
                DataOrder.QuantityPrice = (QuantityComboBox.SelectedItem as DataRowView).Row.ItemArray[1].ToString();

            Refresher();
        }

        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CityComboBox.SelectedIndex == -1)
            {
                MainInfoLabel.Text = "";
                return;
            }
                DataOrder.City = (CityComboBox.SelectedItem as DataRowView).Row.ItemArray[0].ToString();
                DataOrder.Distance = (CityComboBox.SelectedItem as DataRowView).Row.ItemArray[1].ToString();
                DataOrder.CityyPrice = (CityComboBox.SelectedItem as DataRowView).Row.ItemArray[2].ToString();
                

            Refresher();
        }

        private void ExitAccountButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите выйти из аккаунта?", "Обязательная проверка", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AvtorrizationForm AF = new AvtorrizationForm();
                this.Hide();
                AF.Show();
                return;
            }

        }

        public void Refresher()
        {
            timer.Tick += new EventHandler(RefreshLabel);
            timer.Interval = 10;
            timer.Start();
        }

        public void RefreshLabel(object sender, EventArgs e)
        {
            DataOrder.Sum = Convert.ToDouble(DataOrder.MarkaPrice) * Convert.ToDouble(DataOrder.SizePrice) * Convert.ToDouble(DataOrder.QuantityPrice) + Convert.ToDouble(DataOrder.CityyPrice);

            if (MarkaComboBox.SelectedIndex == -1 || SizeComboBox.SelectedIndex == -1 || QuantityComboBox.SelectedIndex == -1 || CityComboBox.SelectedIndex == -1)
                return;

            MainInfoLabel.Text = " Марка цемента: " + DataOrder.Marka + "\n" +
            " Размер мешков: " + DataOrder.Size + " кг." + "\n" +
            " Количество мешков: " + DataOrder.Quantity + "\n" +
            " Город: " + DataOrder.City + "\n" +
            " Расстояние: " + DataOrder.Distance + " км." + "\n" +
            " Стоимость: " + DataOrder.Sum;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ComboMarka();
            ComboSize();
            ComboQuantity();
            ComboCity();
            Refresher();
        }

        private void ChangeBalanceButton_Click(object sender, EventArgs e)
        {
            if (CashTextBox.Text == "")
                return;

            DataOrder.Balance = Convert.ToDouble(CashTextBox.Text);

            BalanceLabel.Text = " Баланс: " + DataOrder.Balance + " Рублей.";
        }

        private void CashTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (DataOrder.Balance >= DataOrder.Sum)
            {
                MessageBox.Show("Покупка прошла успешно!");
                DataOrder.Balance = DataOrder.Balance - DataOrder.Sum;

                BalanceLabel.Text = " Баланс: " + DataOrder.Balance + " Рублей.";

                FunctionalPanel.Enabled = false;
            }  
        }
    }
}
