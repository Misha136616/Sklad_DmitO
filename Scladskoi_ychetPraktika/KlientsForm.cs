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
    public partial class KlientsForm : Form
    {
        public KlientsForm()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.praktik_PDataSet);

        }

        private void KlientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktik_PDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.praktik_PDataSet.clients);

        }

        /*
         private bool validateClient()
        {
            // Проверяем, что все текстовые поля не пустые
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(contact_infoTextBox.Text) && !string.IsNullOrWhiteSpace(addressTextBox.Text) &&
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
    }
         */
    }
}
