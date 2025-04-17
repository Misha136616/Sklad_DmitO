using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scladskoi_ychetPraktika
{
    public partial class VhodFormcs : Form
    {
        public VhodFormcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("user.txt"))
            {
                MessageBox.Show("Файл пользователя не найден.");
                return;
            }

            string[] lines = File.ReadAllLines("user.txt");
            if (lines.Length < 2)
            {
                MessageBox.Show("Файл пользователя повреждён.");
                return;
            }

            string savedUsername = lines[0];
            string savedPasswordHash = lines[1];

            string enteredUsername = textBox1.Text;
            string enteredPasswordHash = GlobalFunction.CalculateMD5Hash(textBox2.Text);

            if (enteredUsername == savedUsername && enteredPasswordHash == savedPasswordHash)
            {
                MessageBox.Show("Успешный вход!");
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }

            //для запомнинания
            /*
            if (Properties.Settings.Default.Username!= string.Empty)
            {
                textBox1.Text = Properties.Settings.Default.Username;
                textBox2.Text = Properties.Settings.Default.Password;
            }*/
        }

        private void VhodFormcs_Load(object sender, EventArgs e)
        {
            string filePath = "user.txt";


            if (!File.Exists(filePath))
            {
                string defaultUsername = "grigoryevS";
                string defaultPassword = "admin";
                string passwordHash = GlobalFunction.CalculateMD5Hash(defaultPassword);

                File.WriteAllText(filePath, defaultUsername + "\n" + passwordHash);
                MessageBox.Show("Создан файл пользователя по умолчанию.");
            }

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length >= 1)
            {
                textBox1.Text = lines[0];
            }
        }
    }
}
