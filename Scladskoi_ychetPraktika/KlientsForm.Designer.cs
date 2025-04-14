
namespace Scladskoi_ychetPraktika
{
    partial class KlientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label contact_infoLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label client_typeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlientsForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktik_PDataSet = new Scladskoi_ychetPraktika.Praktik_PDataSet();
            this.btnDobav = new System.Windows.Forms.Button();
            this.btnYdal = new System.Windows.Forms.Button();
            this.btnObnov = new System.Windows.Forms.Button();
            this.clientsTableAdapter = new Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.clientsTableAdapter();
            this.tableAdapterManager = new Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.TableAdapterManager();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contact_infoTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.client_typeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.btnOchist = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.butSortir = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            contact_infoLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            client_typeLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktik_PDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.butSortir);
            this.groupBox2.Controls.Add(client_typeLabel);
            this.groupBox2.Controls.Add(this.client_typeTextBox);
            this.groupBox2.Controls.Add(addressLabel);
            this.groupBox2.Controls.Add(this.addressTextBox);
            this.groupBox2.Controls.Add(contact_infoLabel);
            this.groupBox2.Controls.Add(this.contact_infoTextBox);
            this.groupBox2.Controls.Add(nameLabel);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Controls.Add(this.btnDobav);
            this.groupBox2.Controls.Add(this.btnYdal);
            this.groupBox2.Controls.Add(this.btnObnov);
            this.groupBox2.Location = new System.Drawing.Point(707, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(484, 538);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о Клиентах";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.praktik_PDataSet;
            // 
            // praktik_PDataSet
            // 
            this.praktik_PDataSet.DataSetName = "Praktik_PDataSet";
            this.praktik_PDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDobav
            // 
            this.btnDobav.BackColor = System.Drawing.Color.Lime;
            this.btnDobav.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDobav.Location = new System.Drawing.Point(34, 262);
            this.btnDobav.Margin = new System.Windows.Forms.Padding(4);
            this.btnDobav.Name = "btnDobav";
            this.btnDobav.Size = new System.Drawing.Size(189, 50);
            this.btnDobav.TabIndex = 7;
            this.btnDobav.Text = "Добавить";
            this.btnDobav.UseVisualStyleBackColor = false;
            // 
            // btnYdal
            // 
            this.btnYdal.BackColor = System.Drawing.Color.Crimson;
            this.btnYdal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYdal.Location = new System.Drawing.Point(253, 262);
            this.btnYdal.Margin = new System.Windows.Forms.Padding(4);
            this.btnYdal.Name = "btnYdal";
            this.btnYdal.Size = new System.Drawing.Size(189, 50);
            this.btnYdal.TabIndex = 9;
            this.btnYdal.Text = "Удалить";
            this.btnYdal.UseVisualStyleBackColor = false;
            // 
            // btnObnov
            // 
            this.btnObnov.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnObnov.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnObnov.Location = new System.Drawing.Point(34, 330);
            this.btnObnov.Margin = new System.Windows.Forms.Padding(4);
            this.btnObnov.Name = "btnObnov";
            this.btnObnov.Size = new System.Drawing.Size(408, 50);
            this.btnObnov.TabIndex = 8;
            this.btnObnov.Text = "Обновить";
            this.btnObnov.UseVisualStyleBackColor = false;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.suppliesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(13, 108);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.RowHeadersWidth = 51;
            this.clientsDataGridView.RowTemplate.Height = 24;
            this.clientsDataGridView.Size = new System.Drawing.Size(671, 453);
            this.clientsDataGridView.TabIndex = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "contact_info";
            this.dataGridViewTextBoxColumn3.HeaderText = "contact_info";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn4.HeaderText = "address";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "client_type";
            this.dataGridViewTextBoxColumn5.HeaderText = "client_type";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(31, 46);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 17);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(84, 46);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 10;
            // 
            // contact_infoLabel
            // 
            contact_infoLabel.AutoSize = true;
            contact_infoLabel.Location = new System.Drawing.Point(31, 88);
            contact_infoLabel.Name = "contact_infoLabel";
            contact_infoLabel.Size = new System.Drawing.Size(85, 17);
            contact_infoLabel.TabIndex = 10;
            contact_infoLabel.Text = "contact info:";
            // 
            // contact_infoTextBox
            // 
            this.contact_infoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "contact_info", true));
            this.contact_infoTextBox.Location = new System.Drawing.Point(123, 85);
            this.contact_infoTextBox.Name = "contact_infoTextBox";
            this.contact_infoTextBox.Size = new System.Drawing.Size(100, 22);
            this.contact_infoTextBox.TabIndex = 11;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(31, 134);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(63, 17);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(100, 134);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 22);
            this.addressTextBox.TabIndex = 12;
            // 
            // client_typeLabel
            // 
            client_typeLabel.AutoSize = true;
            client_typeLabel.Location = new System.Drawing.Point(31, 177);
            client_typeLabel.Name = "client_typeLabel";
            client_typeLabel.Size = new System.Drawing.Size(76, 17);
            client_typeLabel.TabIndex = 12;
            client_typeLabel.Text = "client type:";
            // 
            // client_typeTextBox
            // 
            this.client_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_type", true));
            this.client_typeTextBox.Location = new System.Drawing.Point(113, 177);
            this.client_typeTextBox.Name = "client_typeTextBox";
            this.client_typeTextBox.Size = new System.Drawing.Size(100, 22);
            this.client_typeTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Поисковая строка 🡳";
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSearch.Location = new System.Drawing.Point(13, 52);
            this.txtProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(618, 34);
            this.txtProductSearch.TabIndex = 67;
            // 
            // btnOchist
            // 
            this.btnOchist.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOchist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOchist.Location = new System.Drawing.Point(525, 19);
            this.btnOchist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOchist.Name = "btnOchist";
            this.btnOchist.Size = new System.Drawing.Size(106, 27);
            this.btnOchist.TabIndex = 66;
            this.btnOchist.Text = "Отчистить";
            this.btnOchist.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(34, 438);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(217, 21);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Сортировка по возрастанию";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 401);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(197, 21);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Сортировка по убыванию";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // butSortir
            // 
            this.butSortir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.butSortir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSortir.Location = new System.Drawing.Point(34, 485);
            this.butSortir.Margin = new System.Windows.Forms.Padding(4);
            this.butSortir.Name = "butSortir";
            this.butSortir.Size = new System.Drawing.Size(408, 34);
            this.butSortir.TabIndex = 32;
            this.butSortir.Text = "Сортировка";
            this.butSortir.UseVisualStyleBackColor = false;
            // 
            // KlientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 579);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.btnOchist);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KlientsForm";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.KlientsForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktik_PDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDobav;
        private System.Windows.Forms.Button btnYdal;
        private System.Windows.Forms.Button btnObnov;
        private Praktik_PDataSet praktik_PDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Praktik_PDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private Praktik_PDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox client_typeTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contact_infoTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Button btnOchist;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button butSortir;
    }
}