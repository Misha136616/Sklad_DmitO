
namespace Scladskoi_ychetPraktika
{
    partial class RasMatForm
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
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label quantity_availableLabel;
            System.Windows.Forms.Label quantity_usedLabel;
            System.Windows.Forms.Label last_updated_atLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RasMatForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDobav = new System.Windows.Forms.Button();
            this.btnYdal = new System.Windows.Forms.Button();
            this.btnObnov = new System.Windows.Forms.Button();
            this.praktik_PDataSet = new Scladskoi_ychetPraktika.Praktik_PDataSet();
            this.suppliesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliesTableAdapter = new Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.suppliesTableAdapter();
            this.tableAdapterManager = new Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.TableAdapterManager();
            this.suppliesDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.btnOchist = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.quantity_availableTextBox = new System.Windows.Forms.TextBox();
            this.quantity_usedTextBox = new System.Windows.Forms.TextBox();
            this.last_updated_atDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.butSortir = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            quantity_availableLabel = new System.Windows.Forms.Label();
            quantity_usedLabel = new System.Windows.Forms.Label();
            last_updated_atLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.praktik_PDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.butSortir);
            this.groupBox2.Controls.Add(last_updated_atLabel);
            this.groupBox2.Controls.Add(this.last_updated_atDateTimePicker);
            this.groupBox2.Controls.Add(quantity_usedLabel);
            this.groupBox2.Controls.Add(this.quantity_usedTextBox);
            this.groupBox2.Controls.Add(quantity_availableLabel);
            this.groupBox2.Controls.Add(this.quantity_availableTextBox);
            this.groupBox2.Controls.Add(unitLabel);
            this.groupBox2.Controls.Add(this.unitTextBox);
            this.groupBox2.Controls.Add(nameLabel);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Controls.Add(this.btnDobav);
            this.groupBox2.Controls.Add(this.btnYdal);
            this.groupBox2.Controls.Add(this.btnObnov);
            this.groupBox2.Location = new System.Drawing.Point(738, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(484, 573);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о Расходных материалов";
            // 
            // btnDobav
            // 
            this.btnDobav.BackColor = System.Drawing.Color.Lime;
            this.btnDobav.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDobav.Location = new System.Drawing.Point(34, 280);
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
            this.btnYdal.Location = new System.Drawing.Point(253, 280);
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
            this.btnObnov.Location = new System.Drawing.Point(34, 348);
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
            // suppliesBindingSource
            // 
            this.suppliesBindingSource.DataMember = "supplies";
            this.suppliesBindingSource.DataSource = this.praktik_PDataSet;
            // 
            // suppliesTableAdapter
            // 
            this.suppliesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.suppliesTableAdapter = this.suppliesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // suppliesDataGridView
            // 
            this.suppliesDataGridView.AutoGenerateColumns = false;
            this.suppliesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.suppliesDataGridView.DataSource = this.suppliesBindingSource;
            this.suppliesDataGridView.Location = new System.Drawing.Point(13, 99);
            this.suppliesDataGridView.Name = "suppliesDataGridView";
            this.suppliesDataGridView.RowHeadersWidth = 51;
            this.suppliesDataGridView.RowTemplate.Height = 24;
            this.suppliesDataGridView.Size = new System.Drawing.Size(703, 496);
            this.suppliesDataGridView.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Поисковая строка 🡳";
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSearch.Location = new System.Drawing.Point(13, 48);
            this.txtProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(618, 34);
            this.txtProductSearch.TabIndex = 67;
            // 
            // btnOchist
            // 
            this.btnOchist.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOchist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOchist.Location = new System.Drawing.Point(525, 15);
            this.btnOchist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOchist.Name = "btnOchist";
            this.btnOchist.Size = new System.Drawing.Size(106, 27);
            this.btnOchist.TabIndex = 66;
            this.btnOchist.Text = "Отчистить";
            this.btnOchist.UseVisualStyleBackColor = false;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "unit";
            this.dataGridViewTextBoxColumn3.HeaderText = "unit";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quantity_available";
            this.dataGridViewTextBoxColumn4.HeaderText = "quantity_available";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantity_used";
            this.dataGridViewTextBoxColumn5.HeaderText = "quantity_used";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "last_updated_at";
            this.dataGridViewTextBoxColumn6.HeaderText = "last_updated_at";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(31, 43);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 17);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(88, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 10;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(31, 77);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(35, 17);
            unitLabel.TabIndex = 10;
            unitLabel.Text = "unit:";
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "unit", true));
            this.unitTextBox.Location = new System.Drawing.Point(88, 77);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(100, 22);
            this.unitTextBox.TabIndex = 11;
            // 
            // quantity_availableLabel
            // 
            quantity_availableLabel.AutoSize = true;
            quantity_availableLabel.Location = new System.Drawing.Point(31, 119);
            quantity_availableLabel.Name = "quantity_availableLabel";
            quantity_availableLabel.Size = new System.Drawing.Size(122, 17);
            quantity_availableLabel.TabIndex = 11;
            quantity_availableLabel.Text = "quantity available:";
            // 
            // quantity_availableTextBox
            // 
            this.quantity_availableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "quantity_available", true));
            this.quantity_availableTextBox.Location = new System.Drawing.Point(164, 119);
            this.quantity_availableTextBox.Name = "quantity_availableTextBox";
            this.quantity_availableTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantity_availableTextBox.TabIndex = 12;
            // 
            // quantity_usedLabel
            // 
            quantity_usedLabel.AutoSize = true;
            quantity_usedLabel.Location = new System.Drawing.Point(31, 158);
            quantity_usedLabel.Name = "quantity_usedLabel";
            quantity_usedLabel.Size = new System.Drawing.Size(97, 17);
            quantity_usedLabel.TabIndex = 12;
            quantity_usedLabel.Text = "quantity used:";
            // 
            // quantity_usedTextBox
            // 
            this.quantity_usedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "quantity_used", true));
            this.quantity_usedTextBox.Location = new System.Drawing.Point(134, 158);
            this.quantity_usedTextBox.Name = "quantity_usedTextBox";
            this.quantity_usedTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantity_usedTextBox.TabIndex = 13;
            // 
            // last_updated_atLabel
            // 
            last_updated_atLabel.AutoSize = true;
            last_updated_atLabel.Location = new System.Drawing.Point(31, 202);
            last_updated_atLabel.Name = "last_updated_atLabel";
            last_updated_atLabel.Size = new System.Drawing.Size(106, 17);
            last_updated_atLabel.TabIndex = 13;
            last_updated_atLabel.Text = "last updated at:";
            // 
            // last_updated_atDateTimePicker
            // 
            this.last_updated_atDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.suppliesBindingSource, "last_updated_at", true));
            this.last_updated_atDateTimePicker.Location = new System.Drawing.Point(143, 202);
            this.last_updated_atDateTimePicker.Name = "last_updated_atDateTimePicker";
            this.last_updated_atDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.last_updated_atDateTimePicker.TabIndex = 14;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(34, 465);
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
            this.radioButton1.Location = new System.Drawing.Point(34, 428);
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
            this.butSortir.Location = new System.Drawing.Point(34, 512);
            this.butSortir.Margin = new System.Windows.Forms.Padding(4);
            this.butSortir.Name = "butSortir";
            this.butSortir.Size = new System.Drawing.Size(408, 34);
            this.butSortir.TabIndex = 32;
            this.butSortir.Text = "Сортировка";
            this.butSortir.UseVisualStyleBackColor = false;
            // 
            // RasMatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 618);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.btnOchist);
            this.Controls.Add(this.suppliesDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RasMatForm";
            this.Text = "Расходные материалы";
            this.Load += new System.EventHandler(this.RasMatForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.praktik_PDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDobav;
        private System.Windows.Forms.Button btnYdal;
        private System.Windows.Forms.Button btnObnov;
        private Praktik_PDataSet praktik_PDataSet;
        private System.Windows.Forms.BindingSource suppliesBindingSource;
        private Praktik_PDataSetTableAdapters.suppliesTableAdapter suppliesTableAdapter;
        private Praktik_PDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView suppliesDataGridView;
        private System.Windows.Forms.DateTimePicker last_updated_atDateTimePicker;
        private System.Windows.Forms.TextBox quantity_usedTextBox;
        private System.Windows.Forms.TextBox quantity_availableTextBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Button btnOchist;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button butSortir;
    }
}