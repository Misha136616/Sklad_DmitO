
namespace Scladskoi_ychetPraktika
{
    partial class ProdykziaForm
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
            System.Windows.Forms.Label varietyLabel;
            System.Windows.Forms.Label weight_per_unitLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label sourceLabel;
            System.Windows.Forms.Label created_atLabel;
            System.Windows.Forms.Label washed_atLabel;
            System.Windows.Forms.Label packaged_atLabel;
            System.Windows.Forms.Label sold_atLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdykziaForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.butSortir = new System.Windows.Forms.Button();
            this.sold_atDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktik_PDataSet = new Scladskoi_ychetPraktika.Praktik_PDataSet();
            this.packaged_atDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.washed_atDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.created_atDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.weight_per_unitTextBox = new System.Windows.Forms.TextBox();
            this.varietyTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.btnDobav = new System.Windows.Forms.Button();
            this.btnYdal = new System.Windows.Forms.Button();
            this.btnObnov = new System.Windows.Forms.Button();
            this.productTableAdapter = new Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.productTableAdapter();
            this.tableAdapterManager = new Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.TableAdapterManager();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.btnOchist = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            varietyLabel = new System.Windows.Forms.Label();
            weight_per_unitLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            sourceLabel = new System.Windows.Forms.Label();
            created_atLabel = new System.Windows.Forms.Label();
            washed_atLabel = new System.Windows.Forms.Label();
            packaged_atLabel = new System.Windows.Forms.Label();
            sold_atLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktik_PDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(20, 33);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "name:";
            // 
            // varietyLabel
            // 
            varietyLabel.AutoSize = true;
            varietyLabel.Location = new System.Drawing.Point(20, 64);
            varietyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            varietyLabel.Name = "varietyLabel";
            varietyLabel.Size = new System.Drawing.Size(41, 13);
            varietyLabel.TabIndex = 10;
            varietyLabel.Text = "variety:";
            // 
            // weight_per_unitLabel
            // 
            weight_per_unitLabel.AutoSize = true;
            weight_per_unitLabel.Location = new System.Drawing.Point(19, 98);
            weight_per_unitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            weight_per_unitLabel.Name = "weight_per_unitLabel";
            weight_per_unitLabel.Size = new System.Drawing.Size(79, 13);
            weight_per_unitLabel.TabIndex = 11;
            weight_per_unitLabel.Text = "weight per unit:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(20, 127);
            categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(51, 13);
            categoryLabel.TabIndex = 12;
            categoryLabel.Text = "category:";
            // 
            // sourceLabel
            // 
            sourceLabel.AutoSize = true;
            sourceLabel.Location = new System.Drawing.Point(20, 152);
            sourceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sourceLabel.Name = "sourceLabel";
            sourceLabel.Size = new System.Drawing.Size(42, 13);
            sourceLabel.TabIndex = 13;
            sourceLabel.Text = "source:";
            // 
            // created_atLabel
            // 
            created_atLabel.AutoSize = true;
            created_atLabel.Location = new System.Drawing.Point(20, 177);
            created_atLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            created_atLabel.Name = "created_atLabel";
            created_atLabel.Size = new System.Drawing.Size(58, 13);
            created_atLabel.TabIndex = 14;
            created_atLabel.Text = "created at:";
            // 
            // washed_atLabel
            // 
            washed_atLabel.AutoSize = true;
            washed_atLabel.Location = new System.Drawing.Point(23, 208);
            washed_atLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            washed_atLabel.Name = "washed_atLabel";
            washed_atLabel.Size = new System.Drawing.Size(59, 13);
            washed_atLabel.TabIndex = 15;
            washed_atLabel.Text = "washed at:";
            // 
            // packaged_atLabel
            // 
            packaged_atLabel.AutoSize = true;
            packaged_atLabel.Location = new System.Drawing.Point(23, 240);
            packaged_atLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            packaged_atLabel.Name = "packaged_atLabel";
            packaged_atLabel.Size = new System.Drawing.Size(70, 13);
            packaged_atLabel.TabIndex = 17;
            packaged_atLabel.Text = "packaged at:";
            // 
            // sold_atLabel
            // 
            sold_atLabel.AutoSize = true;
            sold_atLabel.Location = new System.Drawing.Point(23, 273);
            sold_atLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sold_atLabel.Name = "sold_atLabel";
            sold_atLabel.Size = new System.Drawing.Size(41, 13);
            sold_atLabel.TabIndex = 19;
            sold_atLabel.Text = "sold at:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.butSortir);
            this.groupBox2.Controls.Add(sold_atLabel);
            this.groupBox2.Controls.Add(this.sold_atDateTimePicker);
            this.groupBox2.Controls.Add(packaged_atLabel);
            this.groupBox2.Controls.Add(this.packaged_atDateTimePicker);
            this.groupBox2.Controls.Add(washed_atLabel);
            this.groupBox2.Controls.Add(this.washed_atDateTimePicker);
            this.groupBox2.Controls.Add(created_atLabel);
            this.groupBox2.Controls.Add(this.created_atDateTimePicker);
            this.groupBox2.Controls.Add(sourceLabel);
            this.groupBox2.Controls.Add(this.sourceTextBox);
            this.groupBox2.Controls.Add(categoryLabel);
            this.groupBox2.Controls.Add(this.categoryTextBox);
            this.groupBox2.Controls.Add(weight_per_unitLabel);
            this.groupBox2.Controls.Add(this.weight_per_unitTextBox);
            this.groupBox2.Controls.Add(varietyLabel);
            this.groupBox2.Controls.Add(this.varietyTextBox);
            this.groupBox2.Controls.Add(nameLabel);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Controls.Add(this.btnDobav);
            this.groupBox2.Controls.Add(this.btnYdal);
            this.groupBox2.Controls.Add(this.btnObnov);
            this.groupBox2.Location = new System.Drawing.Point(493, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 566);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о Продукции";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 485);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(170, 17);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Сортировка по возрастанию";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 455);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(154, 17);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Сортировка по убыванию";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // butSortir
            // 
            this.butSortir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.butSortir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSortir.Location = new System.Drawing.Point(26, 523);
            this.butSortir.Name = "butSortir";
            this.butSortir.Size = new System.Drawing.Size(306, 28);
            this.butSortir.TabIndex = 21;
            this.butSortir.Text = "Сортировка";
            this.butSortir.UseVisualStyleBackColor = false;
            // 
            // sold_atDateTimePicker
            // 
            this.sold_atDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "sold_at", true));
            this.sold_atDateTimePicker.Location = new System.Drawing.Point(95, 273);
            this.sold_atDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sold_atDateTimePicker.Name = "sold_atDateTimePicker";
            this.sold_atDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.sold_atDateTimePicker.TabIndex = 20;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.praktik_PDataSet;
            // 
            // praktik_PDataSet
            // 
            this.praktik_PDataSet.DataSetName = "Praktik_PDataSet";
            this.praktik_PDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packaged_atDateTimePicker
            // 
            this.packaged_atDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "packaged_at", true));
            this.packaged_atDateTimePicker.Location = new System.Drawing.Point(95, 240);
            this.packaged_atDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.packaged_atDateTimePicker.Name = "packaged_atDateTimePicker";
            this.packaged_atDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.packaged_atDateTimePicker.TabIndex = 18;
            // 
            // washed_atDateTimePicker
            // 
            this.washed_atDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "washed_at", true));
            this.washed_atDateTimePicker.Location = new System.Drawing.Point(92, 208);
            this.washed_atDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.washed_atDateTimePicker.Name = "washed_atDateTimePicker";
            this.washed_atDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.washed_atDateTimePicker.TabIndex = 16;
            // 
            // created_atDateTimePicker
            // 
            this.created_atDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "created_at", true));
            this.created_atDateTimePicker.Location = new System.Drawing.Point(92, 177);
            this.created_atDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.created_atDateTimePicker.Name = "created_atDateTimePicker";
            this.created_atDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.created_atDateTimePicker.TabIndex = 15;
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "source", true));
            this.sourceTextBox.Location = new System.Drawing.Point(92, 152);
            this.sourceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(76, 20);
            this.sourceTextBox.TabIndex = 14;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(92, 127);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(76, 20);
            this.categoryTextBox.TabIndex = 13;
            // 
            // weight_per_unitTextBox
            // 
            this.weight_per_unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "weight_per_unit", true));
            this.weight_per_unitTextBox.Location = new System.Drawing.Point(100, 98);
            this.weight_per_unitTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weight_per_unitTextBox.Name = "weight_per_unitTextBox";
            this.weight_per_unitTextBox.Size = new System.Drawing.Size(76, 20);
            this.weight_per_unitTextBox.TabIndex = 12;
            // 
            // varietyTextBox
            // 
            this.varietyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "variety", true));
            this.varietyTextBox.Location = new System.Drawing.Point(71, 64);
            this.varietyTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.varietyTextBox.Name = "varietyTextBox";
            this.varietyTextBox.Size = new System.Drawing.Size(76, 20);
            this.varietyTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(59, 31);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(76, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // btnDobav
            // 
            this.btnDobav.BackColor = System.Drawing.Color.Lime;
            this.btnDobav.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDobav.Location = new System.Drawing.Point(26, 335);
            this.btnDobav.Name = "btnDobav";
            this.btnDobav.Size = new System.Drawing.Size(142, 41);
            this.btnDobav.TabIndex = 7;
            this.btnDobav.Text = "Добавить";
            this.btnDobav.UseVisualStyleBackColor = false;
            // 
            // btnYdal
            // 
            this.btnYdal.BackColor = System.Drawing.Color.Crimson;
            this.btnYdal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYdal.Location = new System.Drawing.Point(190, 335);
            this.btnYdal.Name = "btnYdal";
            this.btnYdal.Size = new System.Drawing.Size(142, 41);
            this.btnYdal.TabIndex = 9;
            this.btnYdal.Text = "Удалить";
            this.btnYdal.UseVisualStyleBackColor = false;
            // 
            // btnObnov
            // 
            this.btnObnov.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnObnov.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnObnov.Location = new System.Drawing.Point(26, 395);
            this.btnObnov.Name = "btnObnov";
            this.btnObnov.Size = new System.Drawing.Size(306, 41);
            this.btnObnov.TabIndex = 8;
            this.btnObnov.Text = "Обновить";
            this.btnObnov.UseVisualStyleBackColor = false;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.suppliesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(10, 93);
            this.productDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(464, 495);
            this.productDataGridView.TabIndex = 59;
            this.productDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "variety";
            this.dataGridViewTextBoxColumn3.HeaderText = "variety";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "weight_per_unit";
            this.dataGridViewTextBoxColumn4.HeaderText = "weight_per_unit";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn5.HeaderText = "category";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "source";
            this.dataGridViewTextBoxColumn6.HeaderText = "source";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "created_at";
            this.dataGridViewTextBoxColumn7.HeaderText = "created_at";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "washed_at";
            this.dataGridViewTextBoxColumn8.HeaderText = "washed_at";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "packaged_at";
            this.dataGridViewTextBoxColumn9.HeaderText = "packaged_at";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "sold_at";
            this.dataGridViewTextBoxColumn10.HeaderText = "sold_at";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Поисковая строка 🡳";
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSearch.Location = new System.Drawing.Point(10, 43);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(464, 29);
            this.txtProductSearch.TabIndex = 61;
            // 
            // btnOchist
            // 
            this.btnOchist.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOchist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOchist.Location = new System.Drawing.Point(394, 16);
            this.btnOchist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOchist.Name = "btnOchist";
            this.btnOchist.Size = new System.Drawing.Size(80, 22);
            this.btnOchist.TabIndex = 60;
            this.btnOchist.Text = "Отчистить";
            this.btnOchist.UseVisualStyleBackColor = false;
            // 
            // ProdykziaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 609);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.btnOchist);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProdykziaForm";
            this.Text = "Продукция";
            this.Load += new System.EventHandler(this.ProdykziaForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktik_PDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDobav;
        private System.Windows.Forms.Button btnYdal;
        private System.Windows.Forms.Button btnObnov;
        private Praktik_PDataSet praktik_PDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Praktik_PDataSetTableAdapters.productTableAdapter productTableAdapter;
        private Praktik_PDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button butSortir;
        private System.Windows.Forms.DateTimePicker sold_atDateTimePicker;
        private System.Windows.Forms.DateTimePicker packaged_atDateTimePicker;
        private System.Windows.Forms.DateTimePicker washed_atDateTimePicker;
        private System.Windows.Forms.DateTimePicker created_atDateTimePicker;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox weight_per_unitTextBox;
        private System.Windows.Forms.TextBox varietyTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Button btnOchist;
    }
}