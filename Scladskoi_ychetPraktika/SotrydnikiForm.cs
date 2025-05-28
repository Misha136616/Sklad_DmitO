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

        /*
         
         private void btnDobav_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO orders (client_id, destination, order_type, status, created_at, processed_at, shipped_at, is_accepted, accepted_at, quantity, packaging_type, total_price)
            VALUES (@ClientId, @Destination, @OrderType, @Status, @CreatedAt, @ProcessedAt, @ShippedAt, @IsAccepted, @AcceptedAt, @Quantity, @PackagingType, @TotalPrice);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.CommandType = CommandType.Text;

                        if (!int.TryParse(client_idTextBox.Text, out int clientId))
                        {
                            MessageBox.Show("Введите корректный ID клиента");
                            return;
                        }
                        command.Parameters.AddWithValue("@ClientId", clientId);

                        command.Parameters.AddWithValue("@Destination", destinationTextBox.Text);

                        if (order_typeComboBox.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите тип заказа");
                            return;
                        }
                        command.Parameters.AddWithValue("@OrderType", order_typeComboBox.SelectedItem.ToString());

                        if (statusComboBox.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите статус");
                            return;
                        }
                        command.Parameters.AddWithValue("@Status", statusComboBox.SelectedItem.ToString());

                        command.Parameters.AddWithValue("@CreatedAt", created_atDateTimePicker.Value);
                        command.Parameters.AddWithValue("@ProcessedAt", processed_atDateTimePicker.Value);
                        command.Parameters.AddWithValue("@ShippedAt", shipped_atDateTimePicker.Value);
                        command.Parameters.AddWithValue("@IsAccepted", is_acceptedCheckBox.Checked);
                        command.Parameters.AddWithValue("@AcceptedAt", accepted_atDateTimePicker.Value);

                        if (!decimal.TryParse(quantityTextBox.Text, out decimal quantity))
                        {
                            MessageBox.Show("Введите корректное количество");
                            return;
                        }
                        command.Parameters.AddWithValue("@Quantity", quantity);

                        command.Parameters.AddWithValue("@PackagingType", packaging_typeTextBox.Text);

                        if (!decimal.TryParse(total_priceTextBox.Text, out decimal totalPrice))
                        {
                            MessageBox.Show("Введите корректную цену");
                            return;
                        }
                        command.Parameters.AddWithValue("@TotalPrice", totalPrice);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Заказ успешно добавлен");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при добавлении заказа: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnYdal_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите удалить заказ?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM orders WHERE order_id = @OrderId;";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                command.CommandType = CommandType.Text;

                                int orderId = Convert.ToInt32(ordersDataGridView.CurrentRow.Cells["order_id"].Value);
                                command.Parameters.AddWithValue("@OrderId", orderId);

                                command.ExecuteNonQuery();
                                MessageBox.Show("Заказ успешно удалён");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при удалении: " + ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ для удаления");
            }
        }

        private void btnObnov_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE orders
            SET client_id = @ClientId,
                destination = @Destination,
                order_type = @OrderType,
                status = @Status,
                created_at = @CreatedAt,
                processed_at = @ProcessedAt,
                shipped_at = @ShippedAt,
                is_accepted = @IsAccepted,
                accepted_at = @AcceptedAt,
                quantity = @Quantity,
                packaging_type = @PackagingType,
                total_price = @TotalPrice
            WHERE order_id = @OrderId;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@OrderId", ordersDataGridView.CurrentRow.Cells["order_id"].Value);
                        command.Parameters.AddWithValue("@ClientId", int.Parse(client_idTextBox.Text));
                        command.Parameters.AddWithValue("@Destination", destinationTextBox.Text);
                        command.Parameters.AddWithValue("@OrderType", order_typeComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Status", statusComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@CreatedAt", created_atDateTimePicker.Value);
                        command.Parameters.AddWithValue("@ProcessedAt", processed_atDateTimePicker.Value);
                        command.Parameters.AddWithValue("@ShippedAt", shipped_atDateTimePicker.Value);
                        command.Parameters.AddWithValue("@IsAccepted", is_acceptedCheckBox.Checked);
                        command.Parameters.AddWithValue("@AcceptedAt", accepted_atDateTimePicker.Value);
                        command.Parameters.AddWithValue("@Quantity", decimal.Parse(quantityTextBox.Text));
                        command.Parameters.AddWithValue("@PackagingType", packaging_typeTextBox.Text);
                        command.Parameters.AddWithValue("@TotalPrice", decimal.Parse(total_priceTextBox.Text));

                        command.ExecuteNonQuery();
                        MessageBox.Show("Заказ успешно обновлён");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при обновлении заказа: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnSortir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ordersBindingSource.Sort = "destination ASC";
            }
            else if (radioButton2.Checked)
            {
                ordersBindingSource.Sort = "destination DESC";
            }
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            ordersBindingSource.Filter = string.Format("destination LIKE '%{0}%'", txtProductSearch.Text);
        }
    }
         private void btnDobav_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO supplies (name, unit, quantity_available, quantity_used, last_updated_at)
            VALUES (@Name, @Unit, @QtyAvailable, @QtyUsed, @UpdatedAt);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.CommandType = CommandType.Text;

                        if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                        {
                            MessageBox.Show("Введите название материала");
                            return;
                        }
                        command.Parameters.AddWithValue("@Name", nameTextBox.Text);

                        command.Parameters.AddWithValue("@Unit", unitTextBox.Text);

                        if (!decimal.TryParse(quantity_availableTextBox.Text, out decimal available))
                        {
                            MessageBox.Show("Введите корректное доступное количество");
                            return;
                        }
                        command.Parameters.AddWithValue("@QtyAvailable", available);

                        if (!decimal.TryParse(quantity_usedTextBox.Text, out decimal used))
                        {
                            MessageBox.Show("Введите корректное использованное количество");
                            return;
                        }
                        command.Parameters.AddWithValue("@QtyUsed", used);

                        if (DateTime.TryParse(last_updated_atDateTimePicker.Text, out DateTime updated))
                        {
                            command.Parameters.AddWithValue("@UpdatedAt", updated);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                        }

                        command.ExecuteNonQuery();
                        MessageBox.Show("Материал успешно добавлен");
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

        private void btnYdal_Click(object sender, EventArgs e)
        {
            if (suppliesDataGridView.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show(
                    "Удалить выбранный материал?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM supplies WHERE supply_id = @SupplyId;";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                command.CommandType = CommandType.Text;

                                int id = Convert.ToInt32(suppliesDataGridView.CurrentRow.Cells["sid"].Value);
                                command.Parameters.AddWithValue("@SupplyId", id);

                                command.ExecuteNonQuery();
                                MessageBox.Show("Материал удалён");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при удалении: " + ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }

        private void btnObnov_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE supplies
            SET name = @Name,
                unit = @Unit,
                quantity_available = @QtyAvailable,
                quantity_used = @QtyUsed,
                last_updated_at = @UpdatedAt
            WHERE supply_id = @SupplyId;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@SupplyId", suppliesDataGridView.CurrentRow.Cells["sid"].Value);
                        command.Parameters.AddWithValue("@Name", nameTextBox.Text);
                        command.Parameters.AddWithValue("@Unit", unitTextBox.Text);
                        command.Parameters.AddWithValue("@QtyAvailable", decimal.Parse(quantity_availableTextBox.Text));
                        command.Parameters.AddWithValue("@QtyUsed", decimal.Parse(quantity_usedTextBox.Text));
                        command.Parameters.AddWithValue("@UpdatedAt", DateTime.Parse(last_updated_atDateTimePicker.Text));

                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно обновлена");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при обновлении: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

        }

        private void btnSortir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                suppliesBindingSource.Sort = "name ASC";
            }
            else if (radioButton2.Checked)
            {
                suppliesBindingSource.Sort = "name DESC";
            }
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            suppliesBindingSource.Filter = string.Format("name LIKE '%{0}%'", txtProductSearch.Text);
        }
    }

         */
    }
}
