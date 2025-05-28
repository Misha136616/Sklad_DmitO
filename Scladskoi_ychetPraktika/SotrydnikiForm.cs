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

        private void btnDobav_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO raw_potato (name, variety, weight_per_unit, packaging_type, receiving_id, washed_at)
            VALUES (@Name, @Variety, @WeightPerUnit, @PackagingType, @ReceivingId, @WashedAt);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.CommandType = CommandType.Text;

                        if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                        {
                            MessageBox.Show("Введите название");
                            return;
                        }
                        command.Parameters.AddWithValue("@Name", nameTextBox.Text);

                        command.Parameters.AddWithValue("@Variety", varietyTextBox.Text);
                        command.Parameters.AddWithValue("@PackagingType", packaging_typeTextBox.Text);

                        if (!decimal.TryParse(weight_per_unitTextBox.Text, out decimal weight))
                        {
                            MessageBox.Show("Введите корректный вес");
                            return;
                        }
                        command.Parameters.AddWithValue("@WeightPerUnit", weight);

                        if (!int.TryParse(receiving_idTextBox.Text, out int receivingId))
                        {
                            MessageBox.Show("Введите корректный ID поступления");
                            return;
                        }
                        command.Parameters.AddWithValue("@ReceivingId", receivingId);

                        command.Parameters.AddWithValue("@WashedAt", washed_atDateTimePicker.Value);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Сырой картофель успешно добавлен");
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
            if (raw_potatoDataGridView.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show(
                    "Удалить выбранную запись сырого картофеля?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM raw_potato WHERE raw_potato_id = @RawPotatoId;";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                command.CommandType = CommandType.Text;

                                int id = Convert.ToInt32(raw_potatoDataGridView.CurrentRow.Cells["rid"].Value);
                                command.Parameters.AddWithValue("@RawPotatoId", id);

                                command.ExecuteNonQuery();
                                MessageBox.Show("Сырой картофель удалён");
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
            UPDATE raw_potato
            SET name = @Name,
                variety = @Variety,
                weight_per_unit = @WeightPerUnit,
                packaging_type = @PackagingType,
                receiving_id = @ReceivingId,
                washed_at = @WashedAt
            WHERE raw_potato_id = @RawPotatoId;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@RawPotatoId", raw_potatoDataGridView.CurrentRow.Cells["rid"].Value);
                        command.Parameters.AddWithValue("@Name", nameTextBox.Text);
                        command.Parameters.AddWithValue("@Variety", varietyTextBox.Text);
                        command.Parameters.AddWithValue("@WeightPerUnit", decimal.Parse(weight_per_unitTextBox.Text));
                        command.Parameters.AddWithValue("@PackagingType", packaging_typeTextBox.Text);
                        command.Parameters.AddWithValue("@ReceivingId", int.Parse(receiving_idTextBox.Text));
                        command.Parameters.AddWithValue("@WashedAt", washed_atDateTimePicker.Value);

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

        private void butSortir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                raw_potatoBindingSource.Sort = "name ASC";
            }
            else if (radioButton2.Checked)
            {
                raw_potatoBindingSource.Sort = "name DESC";
            }
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            raw_potatoBindingSource.Filter = string.Format("name LIKE '%{0}%'", txtProductSearch.Text);
        }

        private void btnDobav2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO clean_potato (raw_potato_id, order_id, quantity_sent_tons, packaging_type, category)
            VALUES (@RawPotatoId, @OrderId, @Quantity, @PackagingType, @Category);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.CommandType = CommandType.Text;

                        if (!int.TryParse(raw_potato_idTextBox.Text, out int rawId))
                        {
                            MessageBox.Show("Введите корректный ID сырого картофеля");
                            return;
                        }
                        command.Parameters.AddWithValue("@RawPotatoId", rawId);

                        if (!int.TryParse(order_idTextBox.Text, out int orderId))
                        {
                            MessageBox.Show("Введите корректный ID заказа");
                            return;
                        }
                        command.Parameters.AddWithValue("@OrderId", orderId);

                        if (!decimal.TryParse(quantity_sent_tonsTextBox.Text, out decimal quantity))
                        {
                            MessageBox.Show("Введите корректное количество");
                            return;
                        }
                        command.Parameters.AddWithValue("@Quantity", quantity);

                        command.Parameters.AddWithValue("@PackagingType", packaging_typeTextBox.Text);

                        if (string.IsNullOrWhiteSpace(categoryTextBox.Text) || !new[] { "стандарт", "нестандарт", "корм", "отход" }.Contains(categoryTextBox.Text))
                        {
                            MessageBox.Show("Введите корректную категорию (стандарт, нестандарт, корм, отход)");
                            return;
                        }
                        command.Parameters.AddWithValue("@Category", categoryTextBox.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись очищенного картофеля успешно добавлена");
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

        private void btnYdal2_Click(object sender, EventArgs e)
        {
            if (clean_potatoDataGridView.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show(
                    "Удалить выбранную запись очищенного картофеля?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM clean_potato WHERE clean_potato_id = @CleanPotatoId;";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                command.CommandType = CommandType.Text;

                                int id = Convert.ToInt32(clean_potatoDataGridView.CurrentRow.Cells["rcid"].Value);
                                command.Parameters.AddWithValue("@CleanPotatoId", id);

                                command.ExecuteNonQuery();
                                MessageBox.Show("Очищенный картофель удалён");
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

        private void btnObnov2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE clean_potato
            SET raw_potato_id = @RawPotatoId,
                order_id = @OrderId,
                quantity_sent_tons = @Quantity,
                packaging_type = @PackagingType,
                category = @Category
            WHERE clean_potato_id = @CleanPotatoId;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@CleanPotatoId", clean_potatoDataGridView.CurrentRow.Cells["rcid"].Value);
                        command.Parameters.AddWithValue("@RawPotatoId", int.Parse(raw_potato_idTextBox.Text));
                        command.Parameters.AddWithValue("@OrderId", int.Parse(order_idTextBox.Text));
                        command.Parameters.AddWithValue("@Quantity", decimal.Parse(quantity_sent_tonsTextBox.Text));
                        command.Parameters.AddWithValue("@PackagingType", packaging_typeTextBox.Text);
                        command.Parameters.AddWithValue("@Category", categoryTextBox.Text);

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

        private void butSortir2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                raw_potatoBindingSource.Sort = "category ASC";
            }
            else if (radioButton3.Checked)
            {
                raw_potatoBindingSource.Sort = "category DESC";
            }
        }
    }



        private void btnDobav_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string query = @"INSERT INTO suppliers (name, contact_info, region) 
                         VALUES (@Name, @ContactInfo, @Region)";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        // Проверка и добавление имени (обязательное поле)
                        if (!string.IsNullOrWhiteSpace(nameTextBox.Text))
                        {
                            sqlCommand.Parameters.AddWithValue("@Name", nameTextBox.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("Введите название поставщика");
                            return;
                        }

                        // Проверка и добавление контактной информации (не обязательное)
                        if (!string.IsNullOrWhiteSpace(contact_infoTextBox.Text))
                        {
                            sqlCommand.Parameters.AddWithValue("@ContactInfo", contact_infoTextBox.Text.Trim());
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@ContactInfo", DBNull.Value);
                        }

                        // Проверка и добавление региона (не обязательное)
                        if (!string.IsNullOrWhiteSpace(regionTextBox.Text))
                        {
                            sqlCommand.Parameters.AddWithValue("@Region", regionTextBox.Text.Trim());
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@Region", DBNull.Value);
                        }

                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Поставщик успешно добавлен");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении поставщика: {ex.Message}");
            }
        }

        private void btnYdal_Click(object sender, EventArgs e)
        {
            if (suppliersDataGridView.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите удалить поставщика?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM suppliers WHERE supplier_id = @SupplierId;";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                command.CommandType = CommandType.Text;

                                int supplierId = Convert.ToInt32(suppliersDataGridView.CurrentRow.Cells["supplier_id"].Value);
                                command.Parameters.AddWithValue("@SupplierId", supplierId);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Поставщик успешно удалён");
                                }
                                else
                                {
                                    MessageBox.Show("Поставщик не найден");
                                }
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
                MessageBox.Show("Выберите поставщика для удаления");
            }
        }

        private void btnObnov_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE suppliers
            SET name = @Name,
                contact_info = @ContactInfo,
                region = @Region
            WHERE supplier_id = @SupplierId;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@SupplierId", suppliersDataGridView.CurrentRow.Cells["id"].Value);
                        command.Parameters.AddWithValue("@Name", nameTextBox.Text);
                        command.Parameters.AddWithValue("@ContactInfo", contact_infoTextBox.Text);
                        command.Parameters.AddWithValue("@Region", regionTextBox.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Поставщик успешно обновлён");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при обновлении поставщика: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnOchist_Click(object sender, EventArgs e)
        {

        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            suppliersBindingSource.Filter = string.Format("Name LIKE '%{0}%'", txtProductSearch.Text);
        }

        private void btnDobav2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO receiving (supplier_id, received_date, variety, weight_tons, quality_notes)
            VALUES (@SupplierId, @ReceivedDate, @Variety, @WeightTons, @QualityNotes);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.CommandType = CommandType.Text;

                        if (!int.TryParse(supplier_idTextBox.Text, out int supplierId))
                        {
                            MessageBox.Show("Введите корректный ID поставщика");
                            return;
                        }
                        command.Parameters.AddWithValue("@SupplierId", supplierId);

                        if (DateTime.TryParse(received_dateDateTimePicker.Text, out DateTime receivedDate))
                            command.Parameters.AddWithValue("@ReceivedDate", receivedDate);
                        else
                            command.Parameters.AddWithValue("@ReceivedDate", DateTime.Now);

                        command.Parameters.AddWithValue("@Variety", varietyTextBox.Text);

                        if (!decimal.TryParse(weight_tonsTextBox.Text, out decimal weight))
                        {
                            MessageBox.Show("Введите корректный вес");
                            return;
                        }
                        command.Parameters.AddWithValue("@WeightTons", weight);

                        command.Parameters.AddWithValue("@QualityNotes", quality_notesTextBox.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Поставка успешно добавлена");
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

        private void btnYdal2_Click(object sender, EventArgs e)
        {
            if (receivingDataGridView.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите удалить запись о поставке?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM receiving WHERE receiving_id = @ReceivingId;";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                command.CommandType = CommandType.Text;

                                int receivingId = Convert.ToInt32(receivingDataGridView.CurrentRow.Cells["receiving_id"].Value);
                                command.Parameters.AddWithValue("@ReceivingId", receivingId);

                                command.ExecuteNonQuery();
                                MessageBox.Show("Запись о поставке удалена");
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
                MessageBox.Show("Выберите запись для удаления");
            }
        }

        private void btnObnov2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE receiving
            SET supplier_id = @SupplierId,
                received_date = @ReceivedDate,
                variety = @Variety,
                weight_tons = @WeightTons,
                quality_notes = @QualityNotes
            WHERE receiving_id = @ReceivingId;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@ReceivingId", receivingDataGridView.CurrentRow.Cells["idid"].Value);
                        command.Parameters.AddWithValue("@SupplierId", int.Parse(supplier_idTextBox.Text));
                        command.Parameters.AddWithValue("@ReceivedDate", DateTime.Parse(receivingDataGridView.Text));
                        command.Parameters.AddWithValue("@Variety", varietyTextBox.Text);
                        command.Parameters.AddWithValue("@WeightTons", decimal.Parse(weight_tonsTextBox.Text));
                        command.Parameters.AddWithValue("@QualityNotes", quality_notesTextBox.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Поставка успешно обновлена");
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

        private void butSortir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                suppliersBindingSource.Sort = "name ASC";
            }
            else if (radioButton2.Checked)
            {
                suppliersBindingSource.Sort = "name DESC";

            }
        }

        private void butSortir2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                receivingBindingSource.Sort = "variety ASC";
            }
            else if (radioButton3.Checked)
            {
                receivingBindingSource.Sort = "variety DESC";

            }
        }
    }

         */
    }
}
