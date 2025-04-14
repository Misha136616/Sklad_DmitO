
namespace Scladskoi_ychetPraktika
{
    partial class ZakaziForm
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
            System.Windows.Forms.Label client_idLabel;
            System.Windows.Forms.Label order_typeLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label created_atLabel;
            System.Windows.Forms.Label processed_atLabel;
            System.Windows.Forms.Label shipped_atLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label packaging_typeLabel;
            System.Windows.Forms.Label packaging_weightLabel;
            System.Windows.Forms.Label gross_weightLabel;
            System.Windows.Forms.Label net_weightLabel;
            System.Windows.Forms.Label price_per_unitLabel;
            System.Windows.Forms.Label total_priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZakaziForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDobav = new System.Windows.Forms.Button();
            this.btnYdal = new System.Windows.Forms.Button();
            this.btnObnov = new System.Windows.Forms.Button();
            this.praktik_PDataSet = new Scladskoi_ychetPraktika.Praktik_PDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.TableAdapterManager();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.client_idTextBox = new System.Windows.Forms.TextBox();
            this.order_typeTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.created_atDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.processed_atDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipped_atDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.packaging_typeTextBox = new System.Windows.Forms.TextBox();
            this.packaging_weightTextBox = new System.Windows.Forms.TextBox();
            this.gross_weightTextBox = new System.Windows.Forms.TextBox();
            this.net_weightTextBox = new System.Windows.Forms.TextBox();
            this.price_per_unitTextBox = new System.Windows.Forms.TextBox();
            this.total_priceTextBox = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.butSortir = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.btnOchist = new System.Windows.Forms.Button();
            client_idLabel = new System.Windows.Forms.Label();
            order_typeLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            created_atLabel = new System.Windows.Forms.Label();
            processed_atLabel = new System.Windows.Forms.Label();
            shipped_atLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            packaging_typeLabel = new System.Windows.Forms.Label();
            packaging_weightLabel = new System.Windows.Forms.Label();
            gross_weightLabel = new System.Windows.Forms.Label();
            net_weightLabel = new System.Windows.Forms.Label();
            price_per_unitLabel = new System.Windows.Forms.Label();
            total_priceLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.praktik_PDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.butSortir);
            this.groupBox2.Controls.Add(total_priceLabel);
            this.groupBox2.Controls.Add(this.total_priceTextBox);
            this.groupBox2.Controls.Add(price_per_unitLabel);
            this.groupBox2.Controls.Add(this.price_per_unitTextBox);
            this.groupBox2.Controls.Add(net_weightLabel);
            this.groupBox2.Controls.Add(this.net_weightTextBox);
            this.groupBox2.Controls.Add(gross_weightLabel);
            this.groupBox2.Controls.Add(this.gross_weightTextBox);
            this.groupBox2.Controls.Add(packaging_weightLabel);
            this.groupBox2.Controls.Add(this.packaging_weightTextBox);
            this.groupBox2.Controls.Add(packaging_typeLabel);
            this.groupBox2.Controls.Add(this.packaging_typeTextBox);
            this.groupBox2.Controls.Add(quantityLabel);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(shipped_atLabel);
            this.groupBox2.Controls.Add(this.shipped_atDateTimePicker);
            this.groupBox2.Controls.Add(processed_atLabel);
            this.groupBox2.Controls.Add(this.processed_atDateTimePicker);
            this.groupBox2.Controls.Add(created_atLabel);
            this.groupBox2.Controls.Add(this.created_atDateTimePicker);
            this.groupBox2.Controls.Add(statusLabel);
            this.groupBox2.Controls.Add(this.statusTextBox);
            this.groupBox2.Controls.Add(order_typeLabel);
            this.groupBox2.Controls.Add(this.order_typeTextBox);
            this.groupBox2.Controls.Add(client_idLabel);
            this.groupBox2.Controls.Add(this.client_idTextBox);
            this.groupBox2.Controls.Add(this.btnDobav);
            this.groupBox2.Controls.Add(this.btnYdal);
            this.groupBox2.Controls.Add(this.btnObnov);
            this.groupBox2.Location = new System.Drawing.Point(1160, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(517, 822);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о Заказах";
            // 
            // btnDobav
            // 
            this.btnDobav.BackColor = System.Drawing.Color.Lime;
            this.btnDobav.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDobav.Location = new System.Drawing.Point(54, 564);
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
            this.btnYdal.Location = new System.Drawing.Point(273, 564);
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
            this.btnObnov.Location = new System.Drawing.Point(54, 632);
            this.btnObnov.Margin = new System.Windows.Forms.Padding(4);
            this.btnObnov.Name = "btnObnov";
            this.btnObnov.Size = new System.Drawing.Size(408, 50);
            this.btnObnov.TabIndex = 8;
            this.btnObnov.Text = "Обновить";
            this.btnObnov.UseVisualStyleBackColor = false;
            // 
            // praktik_PDataSet
            // 
            this.praktik_PDataSet.DataSetName = "Praktik_PDataSet";
            this.praktik_PDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.praktik_PDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.suppliesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.Location = new System.Drawing.Point(13, 110);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidth = 51;
            this.ordersDataGridView.RowTemplate.Height = 24;
            this.ordersDataGridView.Size = new System.Drawing.Size(1128, 735);
            this.ordersDataGridView.TabIndex = 61;
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Location = new System.Drawing.Point(49, 49);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new System.Drawing.Size(60, 17);
            client_idLabel.TabIndex = 9;
            client_idLabel.Text = "client id:";
            // 
            // client_idTextBox
            // 
            this.client_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "client_id", true));
            this.client_idTextBox.Location = new System.Drawing.Point(122, 46);
            this.client_idTextBox.Name = "client_idTextBox";
            this.client_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.client_idTextBox.TabIndex = 10;
            // 
            // order_typeLabel
            // 
            order_typeLabel.AutoSize = true;
            order_typeLabel.Location = new System.Drawing.Point(49, 87);
            order_typeLabel.Name = "order_typeLabel";
            order_typeLabel.Size = new System.Drawing.Size(77, 17);
            order_typeLabel.TabIndex = 10;
            order_typeLabel.Text = "order type:";
            // 
            // order_typeTextBox
            // 
            this.order_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_type", true));
            this.order_typeTextBox.Location = new System.Drawing.Point(141, 84);
            this.order_typeTextBox.Name = "order_typeTextBox";
            this.order_typeTextBox.Size = new System.Drawing.Size(100, 22);
            this.order_typeTextBox.TabIndex = 11;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(49, 127);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(50, 17);
            statusLabel.TabIndex = 11;
            statusLabel.Text = "status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "status", true));
            this.statusTextBox.Location = new System.Drawing.Point(122, 127);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 22);
            this.statusTextBox.TabIndex = 12;
            // 
            // created_atLabel
            // 
            created_atLabel.AutoSize = true;
            created_atLabel.Location = new System.Drawing.Point(50, 170);
            created_atLabel.Name = "created_atLabel";
            created_atLabel.Size = new System.Drawing.Size(76, 17);
            created_atLabel.TabIndex = 12;
            created_atLabel.Text = "created at:";
            // 
            // created_atDateTimePicker
            // 
            this.created_atDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "created_at", true));
            this.created_atDateTimePicker.Location = new System.Drawing.Point(144, 165);
            this.created_atDateTimePicker.Name = "created_atDateTimePicker";
            this.created_atDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.created_atDateTimePicker.TabIndex = 13;
            // 
            // processed_atLabel
            // 
            processed_atLabel.AutoSize = true;
            processed_atLabel.Location = new System.Drawing.Point(49, 208);
            processed_atLabel.Name = "processed_atLabel";
            processed_atLabel.Size = new System.Drawing.Size(94, 17);
            processed_atLabel.TabIndex = 13;
            processed_atLabel.Text = "processed at:";
            // 
            // processed_atDateTimePicker
            // 
            this.processed_atDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "processed_at", true));
            this.processed_atDateTimePicker.Location = new System.Drawing.Point(160, 208);
            this.processed_atDateTimePicker.Name = "processed_atDateTimePicker";
            this.processed_atDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.processed_atDateTimePicker.TabIndex = 14;
            // 
            // shipped_atLabel
            // 
            shipped_atLabel.AutoSize = true;
            shipped_atLabel.Location = new System.Drawing.Point(50, 252);
            shipped_atLabel.Name = "shipped_atLabel";
            shipped_atLabel.Size = new System.Drawing.Size(78, 17);
            shipped_atLabel.TabIndex = 14;
            shipped_atLabel.Text = "shipped at:";
            // 
            // shipped_atDateTimePicker
            // 
            this.shipped_atDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "shipped_at", true));
            this.shipped_atDateTimePicker.Location = new System.Drawing.Point(144, 247);
            this.shipped_atDateTimePicker.Name = "shipped_atDateTimePicker";
            this.shipped_atDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.shipped_atDateTimePicker.TabIndex = 15;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(50, 287);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(62, 17);
            quantityLabel.TabIndex = 15;
            quantityLabel.Text = "quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(122, 284);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityTextBox.TabIndex = 16;
            // 
            // packaging_typeLabel
            // 
            packaging_typeLabel.AutoSize = true;
            packaging_typeLabel.Location = new System.Drawing.Point(49, 325);
            packaging_typeLabel.Name = "packaging_typeLabel";
            packaging_typeLabel.Size = new System.Drawing.Size(108, 17);
            packaging_typeLabel.TabIndex = 17;
            packaging_typeLabel.Text = "packaging type:";
            // 
            // packaging_typeTextBox
            // 
            this.packaging_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "packaging_type", true));
            this.packaging_typeTextBox.Location = new System.Drawing.Point(163, 325);
            this.packaging_typeTextBox.Name = "packaging_typeTextBox";
            this.packaging_typeTextBox.Size = new System.Drawing.Size(100, 22);
            this.packaging_typeTextBox.TabIndex = 18;
            // 
            // packaging_weightLabel
            // 
            packaging_weightLabel.AutoSize = true;
            packaging_weightLabel.Location = new System.Drawing.Point(50, 367);
            packaging_weightLabel.Name = "packaging_weightLabel";
            packaging_weightLabel.Size = new System.Drawing.Size(121, 17);
            packaging_weightLabel.TabIndex = 19;
            packaging_weightLabel.Text = "packaging weight:";
            // 
            // packaging_weightTextBox
            // 
            this.packaging_weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "packaging_weight", true));
            this.packaging_weightTextBox.Location = new System.Drawing.Point(187, 364);
            this.packaging_weightTextBox.Name = "packaging_weightTextBox";
            this.packaging_weightTextBox.Size = new System.Drawing.Size(100, 22);
            this.packaging_weightTextBox.TabIndex = 20;
            // 
            // gross_weightLabel
            // 
            gross_weightLabel.AutoSize = true;
            gross_weightLabel.Location = new System.Drawing.Point(49, 404);
            gross_weightLabel.Name = "gross_weightLabel";
            gross_weightLabel.Size = new System.Drawing.Size(91, 17);
            gross_weightLabel.TabIndex = 21;
            gross_weightLabel.Text = "gross weight:";
            // 
            // gross_weightTextBox
            // 
            this.gross_weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "gross_weight", true));
            this.gross_weightTextBox.Location = new System.Drawing.Point(160, 401);
            this.gross_weightTextBox.Name = "gross_weightTextBox";
            this.gross_weightTextBox.Size = new System.Drawing.Size(100, 22);
            this.gross_weightTextBox.TabIndex = 22;
            // 
            // net_weightLabel
            // 
            net_weightLabel.AutoSize = true;
            net_weightLabel.Location = new System.Drawing.Point(49, 440);
            net_weightLabel.Name = "net_weightLabel";
            net_weightLabel.Size = new System.Drawing.Size(76, 17);
            net_weightLabel.TabIndex = 23;
            net_weightLabel.Text = "net weight:";
            // 
            // net_weightTextBox
            // 
            this.net_weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "net_weight", true));
            this.net_weightTextBox.Location = new System.Drawing.Point(131, 437);
            this.net_weightTextBox.Name = "net_weightTextBox";
            this.net_weightTextBox.Size = new System.Drawing.Size(100, 22);
            this.net_weightTextBox.TabIndex = 24;
            // 
            // price_per_unitLabel
            // 
            price_per_unitLabel.AutoSize = true;
            price_per_unitLabel.Location = new System.Drawing.Point(49, 477);
            price_per_unitLabel.Name = "price_per_unitLabel";
            price_per_unitLabel.Size = new System.Drawing.Size(95, 17);
            price_per_unitLabel.TabIndex = 25;
            price_per_unitLabel.Text = "price per unit:";
            // 
            // price_per_unitTextBox
            // 
            this.price_per_unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "price_per_unit", true));
            this.price_per_unitTextBox.Location = new System.Drawing.Point(150, 474);
            this.price_per_unitTextBox.Name = "price_per_unitTextBox";
            this.price_per_unitTextBox.Size = new System.Drawing.Size(100, 22);
            this.price_per_unitTextBox.TabIndex = 26;
            // 
            // total_priceLabel
            // 
            total_priceLabel.AutoSize = true;
            total_priceLabel.Location = new System.Drawing.Point(51, 512);
            total_priceLabel.Name = "total_priceLabel";
            total_priceLabel.Size = new System.Drawing.Size(74, 17);
            total_priceLabel.TabIndex = 27;
            total_priceLabel.Text = "total price:";
            // 
            // total_priceTextBox
            // 
            this.total_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "total_price", true));
            this.total_priceTextBox.Location = new System.Drawing.Point(131, 509);
            this.total_priceTextBox.Name = "total_priceTextBox";
            this.total_priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.total_priceTextBox.TabIndex = 28;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(54, 733);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(217, 21);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Сортировка по возрастанию";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(54, 696);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(197, 21);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Сортировка по убыванию";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // butSortir
            // 
            this.butSortir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.butSortir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSortir.Location = new System.Drawing.Point(54, 780);
            this.butSortir.Margin = new System.Windows.Forms.Padding(4);
            this.butSortir.Name = "butSortir";
            this.butSortir.Size = new System.Drawing.Size(408, 34);
            this.butSortir.TabIndex = 29;
            this.butSortir.Text = "Сортировка";
            this.butSortir.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "client_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "client_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "order_type";
            this.dataGridViewTextBoxColumn3.HeaderText = "order_type";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn4.HeaderText = "status";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "created_at";
            this.dataGridViewTextBoxColumn5.HeaderText = "created_at";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "processed_at";
            this.dataGridViewTextBoxColumn6.HeaderText = "processed_at";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "shipped_at";
            this.dataGridViewTextBoxColumn7.HeaderText = "shipped_at";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "packaging_type";
            this.dataGridViewTextBoxColumn9.HeaderText = "packaging_type";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "packaging_weight";
            this.dataGridViewTextBoxColumn10.HeaderText = "packaging_weight";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "gross_weight";
            this.dataGridViewTextBoxColumn11.HeaderText = "gross_weight";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "net_weight";
            this.dataGridViewTextBoxColumn12.HeaderText = "net_weight";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "price_per_unit";
            this.dataGridViewTextBoxColumn13.HeaderText = "price_per_unit";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "total_price";
            this.dataGridViewTextBoxColumn14.HeaderText = "total_price";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Поисковая строка 🡳";
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSearch.Location = new System.Drawing.Point(13, 55);
            this.txtProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(618, 34);
            this.txtProductSearch.TabIndex = 64;
            // 
            // btnOchist
            // 
            this.btnOchist.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOchist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOchist.Location = new System.Drawing.Point(525, 22);
            this.btnOchist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOchist.Name = "btnOchist";
            this.btnOchist.Size = new System.Drawing.Size(106, 27);
            this.btnOchist.TabIndex = 63;
            this.btnOchist.Text = "Отчистить";
            this.btnOchist.UseVisualStyleBackColor = false;
            // 
            // ZakaziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 858);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.btnOchist);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZakaziForm";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.ZakaziForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.praktik_PDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDobav;
        private System.Windows.Forms.Button btnYdal;
        private System.Windows.Forms.Button btnObnov;
        private Praktik_PDataSet praktik_PDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Praktik_PDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private Praktik_PDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox total_priceTextBox;
        private System.Windows.Forms.TextBox price_per_unitTextBox;
        private System.Windows.Forms.TextBox net_weightTextBox;
        private System.Windows.Forms.TextBox gross_weightTextBox;
        private System.Windows.Forms.TextBox packaging_weightTextBox;
        private System.Windows.Forms.TextBox packaging_typeTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.DateTimePicker shipped_atDateTimePicker;
        private System.Windows.Forms.DateTimePicker processed_atDateTimePicker;
        private System.Windows.Forms.DateTimePicker created_atDateTimePicker;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox order_typeTextBox;
        private System.Windows.Forms.TextBox client_idTextBox;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button butSortir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Button btnOchist;
    }
}