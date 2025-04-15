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
    public partial class ZakaziForm : Form
    {
        public ZakaziForm()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.praktik_PDataSet);

        }

        private void ZakaziForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktik_PDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.praktik_PDataSet.orders);

        }
        /*
         private bool validateClient()
        {
            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(client_idTextBox.Text) ||
                string.IsNullOrWhiteSpace(order_typeTextBox.Text) ||
                string.IsNullOrWhiteSpace(statusTextBox.Text) ||
                string.IsNullOrWhiteSpace(quantityTextBox.Text) ||
                string.IsNullOrWhiteSpace(packaging_typeTextBox.Text) ||
                string.IsNullOrWhiteSpace(packaging_weightTextBox.Text) ||
                string.IsNullOrWhiteSpace(gross_weightTextBox.Text) ||
                string.IsNullOrWhiteSpace(net_weightTextBox.Text) ||
                string.IsNullOrWhiteSpace(price_per_unitTextBox.Text) ||
                string.IsNullOrWhiteSpace(total_priceTextBox.Text))
            {
                return false;
            }

            // Проверка числовых полей
            if (!decimal.TryParse(quantityTextBox.Text, out _) ||
                !decimal.TryParse(packaging_weightTextBox.Text, out _) ||
                !decimal.TryParse(gross_weightTextBox.Text, out _) ||
                !decimal.TryParse(net_weightTextBox.Text, out _) ||
                !decimal.TryParse(price_per_unitTextBox.Text, out _) ||
                !decimal.TryParse(total_priceTextBox.Text, out _))
            {
                MessageBox.Show("Некорректные числовые значения");
                return false;
            }

            // Проверка допустимых значений для полей с ограничениями
            var validOrderTypes = new[] { "продажа", "услуга" };
            var validStatuses = new[] { "новый", "в процессе", "выполнен" };
            var validPackagingTypes = new[] { "биг-бэг", "сетка", "домики" };

            if (!validOrderTypes.Contains(order_typeTextBox.Text))
            {
                MessageBox.Show("Недопустимое значение для типа заказа");
                return false;
            }

            if (!validStatuses.Contains(statusTextBox.Text))
            {
                MessageBox.Show("Недопустимое значение для статуса");
                return false;
            }

            if (!validPackagingTypes.Contains(packaging_typeTextBox.Text))
            {
                MessageBox.Show("Недопустимое значение для типа упаковки");
                return false;
            }

            return true;
        }

        private void ZakaziForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prdoDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.prdoDataSet.orders);

        }

        private void btnDobav_Click(object sender, EventArgs e)
        {
            if (validateClient())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO orders (
                    client_id, order_type, status, created_at, processed_at, shipped_at,
                    quantity, packaging_type, packaging_weight, gross_weight, net_weight,
                    price_per_unit, total_price
                )
                VALUES (
                    @ClientId, @OrderType, @Status, @CreatedAt, @ProcessedAt, @ShippedAt,
                    @Quantity, @PackagingType, @PackagingWeight, @GrossWeight, @NetWeight,
                    @PricePerUnit, @TotalPrice
                );";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;

                            // Добавление параметров
                            sqlCommand.Parameters.AddWithValue("@ClientId", int.Parse(client_idTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@OrderType", order_typeTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Status", statusTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@CreatedAt", created_atDateTimePicker.Value);
                            sqlCommand.Parameters.AddWithValue("@ProcessedAt", processed_atDateTimePicker.Value);
                            sqlCommand.Parameters.AddWithValue("@ShippedAt", shipped_atDateTimePicker.Value);
                            sqlCommand.Parameters.AddWithValue("@Quantity", decimal.Parse(quantityTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@PackagingType", packaging_typeTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@PackagingWeight", decimal.Parse(packaging_weightTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@GrossWeight", decimal.Parse(gross_weightTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@NetWeight", decimal.Parse(net_weightTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@PricePerUnit", decimal.Parse(price_per_unitTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@TotalPrice", decimal.Parse(total_priceTextBox.Text));

                            // Выполнение запроса
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Заказ успешно добавлен");

                            // Обновление DataGridView
                            this.ordersTableAdapter.Fill(this.prdoDataSet.orders);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка добавления заказа: " + ex.Message);
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
            if (ordersDataGridView.CurrentRow != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM orders WHERE id = @OrderId";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;

                            // Получение ID выбранной строки из DataGridView
                            int orderId = Convert.ToInt32(ordersDataGridView.CurrentRow.Cells["id"].Value);
                            sqlCommand.Parameters.AddWithValue("@OrderId", orderId);

                            // Выполнение запроса
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Заказ успешно удален");

                            // Обновление DataGridView
                            this.ordersTableAdapter.Fill(this.prdoDataSet.orders);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка удаления заказа: " + ex.Message);
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
                MessageBox.Show("Выберите заказ для удаления");
            }
        }

        private void btnObnov_Click(object sender, EventArgs e)
        {
            if (validateClient())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                UPDATE orders 
                SET 
                    client_id = @ClientId,
                    order_type = @OrderType,
                    status = @Status,
                    created_at = @CreatedAt,
                    processed_at = @ProcessedAt,
                    shipped_at = @ShippedAt,
                    quantity = @Quantity,
                    packaging_type = @PackagingType,
                    packaging_weight = @PackagingWeight,
                    gross_weight = @GrossWeight,
                    net_weight = @NetWeight,
                    price_per_unit = @PricePerUnit,
                    total_price = @TotalPrice
                WHERE id = @OrderId;";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;

                            // Получение ID выбранной строки из DataGridView
                            int orderId = Convert.ToInt32(ordersDataGridView.CurrentRow.Cells["id"].Value);
                            sqlCommand.Parameters.AddWithValue("@OrderId", orderId);

                            // Добавление параметров
                            sqlCommand.Parameters.AddWithValue("@ClientId", int.Parse(client_idTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@OrderType", order_typeTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Status", statusTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@CreatedAt", created_atDateTimePicker.Value);
                            sqlCommand.Parameters.AddWithValue("@ProcessedAt", processed_atDateTimePicker.Value);
                            sqlCommand.Parameters.AddWithValue("@ShippedAt", shipped_atDateTimePicker.Value);
                            sqlCommand.Parameters.AddWithValue("@Quantity", decimal.Parse(quantityTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@PackagingType", packaging_typeTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@PackagingWeight", decimal.Parse(packaging_weightTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@GrossWeight", decimal.Parse(gross_weightTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@NetWeight", decimal.Parse(net_weightTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@PricePerUnit", decimal.Parse(price_per_unitTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@TotalPrice", decimal.Parse(total_priceTextBox.Text));

                            // Выполнение запроса
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Заказ успешно обновлен");

                            // Обновление DataGridView
                            this.ordersTableAdapter.Fill(this.prdoDataSet.orders);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка обновления заказа: " + ex.Message);
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

        private void butSortir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ordersBindingSource.Sort = "total_price ASC";
            }
            else if (radioButton2.Checked)
            {
                ordersBindingSource.Sort = "total_price DESC";
            }
        }

        private void btnOchist_Click(object sender, EventArgs e)
        {
            txtProductSearch.Clear();
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProductSearch.Text))
            {
                string filter = string.Format(
                    "order_type LIKE '%{0}%' OR status LIKE '%{0}%' OR CONVERT(created_at, 'System.String') LIKE '%{0}%'",
                    txtProductSearch.Text
                );
                ordersBindingSource.Filter = filter;
            }
            else
            {
                ordersBindingSource.Filter = string.Empty;
            }
        }
    }
         */
    }
}
