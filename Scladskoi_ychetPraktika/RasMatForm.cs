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
    public partial class RasMatForm : Form
    {
        public RasMatForm()
        {
            InitializeComponent();
        }

        private void suppliesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.praktik_PDataSet);

        }

        private void RasMatForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktik_PDataSet.supplies". При необходимости она может быть перемещена или удалена.
            this.suppliesTableAdapter.Fill(this.praktik_PDataSet.supplies);

        }
        /*
                 private bool validateClient()
        {
            // Проверяем, что все текстовые поля не пустые
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                !string.IsNullOrWhiteSpace(contact_infoTextBox.Text) ||
                !string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                !string.IsNullOrWhiteSpace(client_typeTextBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void KlientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prdoDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.prdoDataSet.clients);
            
        }

        

        private void btnDobav_Click(object sender, EventArgs e)
        {
            if (validateClient()) 
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    string query = @"
            INSERT INTO clients (name, contact_info, address, client_type)
            VALUES (@Name, @ContactInfo, @Address, @ClientType);";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;

                            // Добавление параметров
                            sqlCommand.Parameters.AddWithValue("@Name", nameTextBox.Text); 
                            sqlCommand.Parameters.AddWithValue("@ContactInfo", contact_infoTextBox.Text); 
                            sqlCommand.Parameters.AddWithValue("@Address", addressTextBox.Text);
                            if (client_typeTextBox.Text != null)
                            {
                                sqlCommand.Parameters.AddWithValue("@ClientType", client_typeTextBox.Text.ToString());
                            }
                            else
                            {
                                MessageBox.Show("Выберите тип клиента из списка");
                                return; 
                            }

                            // Выполнение запроса
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Клиент успешно добавлен");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка добавления клиента: " + ex.Message);
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
                MessageBox.Show("Незаполненные поля или неверный формат данных");
            }
        }

        private void btnYdal_Click(object sender, EventArgs e)
        {
            if (clientsDataGridView.CurrentRow != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM clients WHERE id = @Id";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@Id", clientsDataGridView.CurrentRow.Cells["id"].Value);
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Клиент успешно удален");
                            clientsBindingSource.RemoveCurrent();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка удаления клиента: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnObnov_Click(object sender, EventArgs e)
        {
            if (validateClient())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
UPDATE clients 
SET name = @Name, contact_info = @ContactInfo, address = @Address, client_type = @ClientType
WHERE id = @Id";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;

                            sqlCommand.Parameters.AddWithValue("@Id", clientsDataGridView.CurrentRow.Cells["id"].Value);
                            sqlCommand.Parameters.AddWithValue("@Name", nameTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@ContactInfo", contact_infoTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Address", addressTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@ClientType", client_typeTextBox.Text.ToString());

                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Данные клиента успешно обновлены");
                            clientsBindingSource.EndEdit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка обновления клиента: " + ex.Message);
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
                MessageBox.Show("Незаполненные поля или неверный формат данных");
            }
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            clientsBindingSource.Filter = string.Format("name LIKE '%{0}%'", txtProductSearch.Text);
        }

        private void butSortir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                clientsBindingSource.Sort = "name ASC";
            }
            else if (radioButton2.Checked)
            {
                clientsBindingSource.Sort = "name DESC";
            }
        }

        private void btnOchist_Click(object sender, EventArgs e)
        {
            txtProductSearch.Clear();
        }
        private void LoadProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM clients";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    try
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        clientsDataGridView.DataSource = table;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
                    }
                }
            }
        }
    }
         */

        /*
         private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            financeBindingSource.Filter = string.Format("income LIKE '%{0}%'", txtProductSearch.Text);
        }

        private void btnOchist_Click(object sender, EventArgs e)
        {
            txtProductSearch.Clear();
        }

        private void btnOtch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDobav_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        INSERT INTO finance (order_id, income, expenses, date)
        VALUES (@OrderId, @Income, @Expenses, @Date);";

                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        sqlCommand.CommandType = CommandType.Text;

                        // Добавление параметров
                        if (int.TryParse(order_idTextBox.Text, out int orderId))
                        {
                            sqlCommand.Parameters.AddWithValue("@OrderId", orderId);
                        }
                        else
                        {
                            MessageBox.Show("Введите корректный ID заказа");
                            return;
                        }

                        if (decimal.TryParse(incomeTextBox.Text, out decimal income))
                        {
                            sqlCommand.Parameters.AddWithValue("@Income", income);
                        }
                        else
                        {
                            MessageBox.Show("Введите корректный доход");
                            return;
                        }

                        if (decimal.TryParse(expensesTextBox.Text, out decimal expenses))
                        {
                            sqlCommand.Parameters.AddWithValue("@Expenses", expenses);
                        }
                        else
                        {
                            MessageBox.Show("Введите корректные расходы");
                            return;
                        }

                        // Если дата не указана, используем текущую
                        if (DateTime.TryParse(dateDateTimePicker.Text, out DateTime date))
                        {
                            sqlCommand.Parameters.AddWithValue("@Date", date);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@Date", DateTime.Now);
                        }

                        // Выполнение запроса
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Финансовая запись успешно добавлена");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при добавлении записи в finance: " + ex.Message);
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
            if (financeDataGridView.CurrentRow != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM clients WHERE finance_id  = @Id";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@Id", financeDataGridView.CurrentRow.Cells["id"].Value);
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Клиент успешно удален");
                            financeBindingSource.RemoveCurrent();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка удаления клиента: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnObnov_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        UPDATE finance
        SET order_id = @OrderId,
            income = @Income,
            expenses = @Expenses,
            date = @Date
        WHERE finance_id = @FinanceId;";

                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        sqlCommand.CommandType = CommandType.Text;

                        // Параметры

                        if (!int.TryParse(order_idTextBox.Text, out int orderId))
                        {
                            MessageBox.Show("Введите корректный ID заказа");
                            return;
                        }
                        sqlCommand.Parameters.AddWithValue("@OrderId", orderId);

                        if (!decimal.TryParse(incomeTextBox.Text, out decimal income))
                        {
                            MessageBox.Show("Введите корректный доход");
                            return;
                        }
                        sqlCommand.Parameters.AddWithValue("@Income", income);

                        if (!decimal.TryParse(expensesTextBox.Text, out decimal expenses))
                        {
                            MessageBox.Show("Введите корректные расходы");
                            return;
                        }
                        sqlCommand.Parameters.AddWithValue("@Expenses", expenses);

                        if (DateTime.TryParse(dateDateTimePicker.Text, out DateTime date))
                        {
                            sqlCommand.Parameters.AddWithValue("@Date", date);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@Date", DateTime.Now);
                        }

                        // Выполнение
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Финансовая запись успешно обновлена");
                        }
                        else
                        {
                            MessageBox.Show("Запись с таким ID не найдена");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при обновлении записи: " + ex.Message);
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
                financeBindingSource.Sort = "income ASC";
            }
            else if (radioButton2.Checked)
            {
                financeBindingSource.Sort = "income DESC";
            }
        }
    }
         
         */

        /*
          private void btnDobav_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = @"
            INSERT INTO clients (name, contact_info, address, client_type)
            VALUES (@Name, @ContactInfo, @Address, @ClientType);";

                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        sqlCommand.CommandType = CommandType.Text;

                        // Добавление параметров
                        sqlCommand.Parameters.AddWithValue("@Name", nameTextBox.Text);
                        sqlCommand.Parameters.AddWithValue("@ContactInfo", contact_infoTextBox.Text);
                        sqlCommand.Parameters.AddWithValue("@Address", addressTextBox.Text);
                        if (client_typeTextBox.Text != null)
                        {
                            sqlCommand.Parameters.AddWithValue("@ClientType", client_typeTextBox.Text.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Выберите тип клиента из списка");
                            return;
                        }

                        // Выполнение запроса
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Клиент успешно добавлен");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления клиента: " + ex.Message);
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
            if (clientsDataGridView.CurrentRow != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM clients WHERE client_id  = @Id";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@Id", clientsDataGridView.CurrentRow.Cells["id"].Value);
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Клиент успешно удален");
                            clientsBindingSource.RemoveCurrent();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка удаления клиента: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnObnov_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
UPDATE clients 
SET name = @Name, contact_info = @ContactInfo, address = @Address, client_type = @ClientType
WHERE client_id  = @Id";

                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        sqlCommand.CommandType = CommandType.Text;

                        sqlCommand.Parameters.AddWithValue("@Id", clientsDataGridView.CurrentRow.Cells["id"].Value);
                        sqlCommand.Parameters.AddWithValue("@Name", nameTextBox.Text);
                        sqlCommand.Parameters.AddWithValue("@ContactInfo", contact_infoTextBox.Text);
                        sqlCommand.Parameters.AddWithValue("@Address", addressTextBox.Text);
                        sqlCommand.Parameters.AddWithValue("@ClientType", client_typeTextBox.Text.ToString());

                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Данные клиента успешно обновлены");
                        clientsBindingSource.EndEdit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка обновления клиента: " + ex.Message);
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
                clientsBindingSource.Sort = "name ASC";
            }
            else if (radioButton2.Checked)
            {
                clientsBindingSource.Sort = "name DESC";
            }
        }

        private void btnOchist_Click(object sender, EventArgs e)
        {
            txtProductSearch.Clear();
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            clientsBindingSource.Filter = string.Format("name LIKE '%{0}%'", txtProductSearch.Text);
        }
    }
}
         
         */
    }
}
