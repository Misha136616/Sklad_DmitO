using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scladskoi_ychetPraktika
{
    public partial class SotrydnikiForm : Form
    {
        public SotrydnikiForm()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.praktik_PDataSet);

        }

        private void SotrydnikiForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktik_PDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.praktik_PDataSet.employees);

        }
        /*
         private bool validateEmployee()
        {
            return !string.IsNullOrWhiteSpace(full_nameTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(positionTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(salary_typeTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(hours_workedTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(salaryTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(login_credentialsTextBox.Text);
        }
        private void btnDobav_Click(object sender, EventArgs e)
        {
            if (validateEmployee())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
INSERT INTO employees 
(full_name, position, salary_type, hours_worked, salary, login_credentials)
VALUES (@FullName, @Position, @SalaryType, @HoursWorked, @Salary, @LoginCredentials)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();

                            cmd.Parameters.AddWithValue("@FullName", full_nameTextBox.Text);
                            cmd.Parameters.AddWithValue("@Position", positionTextBox.Text);
                            cmd.Parameters.AddWithValue("@SalaryType", salary_typeTextBox.Text);

                            if (decimal.TryParse(hours_workedTextBox.Text, out decimal hours))
                                cmd.Parameters.AddWithValue("@HoursWorked", hours);
                            else
                                cmd.Parameters.AddWithValue("@HoursWorked", DBNull.Value);

                            if (decimal.TryParse(salaryTextBox.Text, out decimal salary))
                                cmd.Parameters.AddWithValue("@Salary", salary);
                            else
                                cmd.Parameters.AddWithValue("@Salary", DBNull.Value);

                            cmd.Parameters.AddWithValue("@LoginCredentials", login_credentialsTextBox.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Сотрудник успешно добавлен");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при добавлении: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля корректно");
            }
        }

        private void btnYdal_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.CurrentRow != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM employees WHERE id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            cmd.Parameters.AddWithValue("@Id", employeesDataGridView.CurrentRow.Cells["id"].Value);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Сотрудник удалён");
                            employeesBindingSource.RemoveCurrent(); 
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка удаления: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для удаления");
            }
        }

        private void btnObnov_Click(object sender, EventArgs e)
        {
            if (validateEmployee())
            {
                if (employeesDataGridView.CurrentRow == null)
                {
                    MessageBox.Show("Выберите сотрудника для обновления");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
UPDATE employees 
SET full_name = @FullName, 
    position = @Position, 
    salary_type = @SalaryType,
    hours_worked = @HoursWorked, 
    salary = @Salary, 
    login_credentials = @LoginCredentials
WHERE id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            cmd.Parameters.AddWithValue("@Id", employeesDataGridView.CurrentRow.Cells["id"].Value);
                            cmd.Parameters.AddWithValue("@FullName", full_nameTextBox.Text);
                            cmd.Parameters.AddWithValue("@Position", positionTextBox.Text);
                            cmd.Parameters.AddWithValue("@SalaryType", salary_typeTextBox.Text);

                            if (decimal.TryParse(hours_workedTextBox.Text, out decimal hours))
                                cmd.Parameters.AddWithValue("@HoursWorked", hours);
                            else
                                cmd.Parameters.AddWithValue("@HoursWorked", DBNull.Value);

                            if (decimal.TryParse(salaryTextBox.Text, out decimal salary))
                                cmd.Parameters.AddWithValue("@Salary", salary);
                            else
                                cmd.Parameters.AddWithValue("@Salary", DBNull.Value);

                            cmd.Parameters.AddWithValue("@LoginCredentials", login_credentialsTextBox.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Данные сотрудника обновлены");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка обновления: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Незаполненные или неверные поля");
            }
        }

        private void butSortir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                employeesBindingSource.Sort = "full_name ASC";
            }
            else if (radioButton2.Checked)
            {
                employeesBindingSource.Sort = "full_name DESC";
            }
        }

        private void btnOchist_Click(object sender, EventArgs e)
        {
            txtProductSearch.Clear();
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            employeesBindingSource.Filter = string.Format("full_name LIKE '%{0}%'", txtProductSearch.Text);
        }
    }
         */
    }
}
