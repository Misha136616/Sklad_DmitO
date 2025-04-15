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
    public partial class ProdykziaForm : Form
    {
        public ProdykziaForm()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.praktik_PDataSet);

        }

        private void ProdykziaForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktik_PDataSet.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.praktik_PDataSet.product);

        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*
         private bool ValidateProduct()
        {
            // Проверка обязательных текстовых полей
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Поле 'Название' обязательно для заполнения.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(categoryTextBox.Text))
            {
                MessageBox.Show("Поле 'Категория' обязательно для заполнения.");
                return false;
            }

            // Проверка, соответствует ли категория допустимым значениям
            var validCategories = new List<string> { "стандарт", "нестандарт", "корм", "отход" };
            if (!validCategories.Contains(categoryTextBox.Text.Trim().ToLower()))
            {
                MessageBox.Show("Категория должна быть одной из: стандарт, нестандарт, корм, отход.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(sourceTextBox.Text))
            {
                MessageBox.Show("Поле 'Источник' обязательно для заполнения.");
                return false;
            }

            var validSources = new List<string> { "ФУДАГРОТРЕЙД", "сторонний поставщик" };
            if (!validSources.Contains(sourceTextBox.Text.Trim()))
            {
                MessageBox.Show("Источник должен быть: ФУДАГРОТРЕЙД или сторонний поставщик.");
                return false;
            }

            // Проверка корректности decimal-значения
            if (!string.IsNullOrWhiteSpace(weight_per_unitTextBox.Text) && !decimal.TryParse(weight_per_unitTextBox.Text, out _))
            {
                MessageBox.Show("Введите корректный вес в числовом формате (например: 2.50).");
                return false;
            }

            return true;
        }

        private void ProdykziaForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prdoDataSet.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.prdoDataSet.product);

        }

        private void btnDobav_Click(object sender, EventArgs e)
        {
            if (ValidateProduct())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO product 
                (name, variety, weight_per_unit, category, source, washed_at, packaged_at, sold_at)
                VALUES 
                (@Name, @Variety, @Weight, @Category, @Source, @WashedAt, @PackagedAt, @SoldAt);";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();

                            sqlCommand.Parameters.AddWithValue("@Name", nameTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Variety", string.IsNullOrWhiteSpace(varietyTextBox.Text) ? (object)DBNull.Value : varietyTextBox.Text);

                            if (decimal.TryParse(weight_per_unitTextBox.Text, out decimal weight))
                                sqlCommand.Parameters.AddWithValue("@Weight", weight);
                            else
                                sqlCommand.Parameters.AddWithValue("@Weight", DBNull.Value);

                            sqlCommand.Parameters.AddWithValue("@Category", categoryTextBox.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@Source", sourceTextBox.Text.Trim());

                            sqlCommand.Parameters.AddWithValue("@WashedAt", washed_atDateTimePicker.Checked ? washed_atDateTimePicker.Value : (object)DBNull.Value);
                            sqlCommand.Parameters.AddWithValue("@PackagedAt", packaged_atDateTimePicker.Checked ? packaged_atDateTimePicker.Value : (object)DBNull.Value);
                            sqlCommand.Parameters.AddWithValue("@SoldAt", sold_atDateTimePicker.Checked ? sold_atDateTimePicker.Value : (object)DBNull.Value);

                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Продукт успешно добавлен");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при добавлении продукта: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnYdal_Click(object sender, EventArgs e)
        {
            if (productDataGridView.CurrentRow != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM product WHERE id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            int id = Convert.ToInt32(productDataGridView.CurrentRow.Cells["id"].Value);
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Продукт успешно удалён");
                            productBindingSource.RemoveCurrent(); // если используешь BindingSource
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при удалении продукта: " + ex.Message);
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
                MessageBox.Show("Выберите продукт для удаления");
            }
        }

        private void btnObnov_Click(object sender, EventArgs e)
        {
            if (ValidateProduct()) // твоя функция валидации
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
UPDATE product 
SET 
    name = @Name,
    variety = @Variety,
    weight_per_unit = @Weight,
    category = @Category,
    source = @Source,
    washed_at = @WashedAt,
    packaged_at = @PackagedAt,
    sold_at = @SoldAt
WHERE id = @Id";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;

                            sqlCommand.Parameters.AddWithValue("@Id", productDataGridView.CurrentRow.Cells["id"].Value);
                            sqlCommand.Parameters.AddWithValue("@Name", nameTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Variety", string.IsNullOrWhiteSpace(varietyTextBox.Text) ? (object)DBNull.Value : varietyTextBox.Text);

                            if (decimal.TryParse(weight_per_unitTextBox.Text, out decimal weight))
                                sqlCommand.Parameters.AddWithValue("@Weight", weight);
                            else
                                sqlCommand.Parameters.AddWithValue("@Weight", DBNull.Value);

                            sqlCommand.Parameters.AddWithValue("@Category", categoryTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Source", sourceTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@WashedAt", washed_atDateTimePicker.Checked ? washed_atDateTimePicker.Value : (object)DBNull.Value);
                            sqlCommand.Parameters.AddWithValue("@PackagedAt", packaged_atDateTimePicker.Checked ? packaged_atDateTimePicker.Value : (object)DBNull.Value);
                            sqlCommand.Parameters.AddWithValue("@SoldAt", sold_atDateTimePicker.Checked ? sold_atDateTimePicker.Value : (object)DBNull.Value);

                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Продукт успешно обновлён");

                            productBindingSource.EndEdit(); // если ты используешь BindingSource
                            LoadProducts(); // автоперезагрузка
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка обновления продукта: " + ex.Message);
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
                productBindingSource.Sort = "name ASC";
            }
            else if (radioButton2.Checked)
            {
                productBindingSource.Sort = "name DESC";
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
                string query = "SELECT * FROM product";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    try
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        productDataGridView.DataSource = table;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
                    }
                }
            }
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            productBindingSource.Filter = string.Format("name LIKE '%{0}%'", txtProductSearch.Text);
        }
    }
         */
    }
}
