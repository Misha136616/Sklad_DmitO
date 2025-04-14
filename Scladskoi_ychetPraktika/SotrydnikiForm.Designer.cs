
namespace Scladskoi_ychetPraktika
{
    partial class SotrydnikiForm
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
            System.Windows.Forms.Label full_nameLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label salary_typeLabel;
            System.Windows.Forms.Label hours_workedLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label login_credentialsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SotrydnikiForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDobav = new System.Windows.Forms.Button();
            this.btnYdal = new System.Windows.Forms.Button();
            this.btnObnov = new System.Windows.Forms.Button();
            this.praktik_PDataSet = new Scladskoi_ychetPraktika.Praktik_PDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.employeesTableAdapter();
            this.tableAdapterManager = new Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.TableAdapterManager();
            this.full_nameTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.salary_typeTextBox = new System.Windows.Forms.TextBox();
            this.hours_workedTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.login_credentialsTextBox = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.butSortir = new System.Windows.Forms.Button();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.btnOchist = new System.Windows.Forms.Button();
            full_nameLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            salary_typeLabel = new System.Windows.Forms.Label();
            hours_workedLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            login_credentialsLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.praktik_PDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.butSortir);
            this.groupBox2.Controls.Add(login_credentialsLabel);
            this.groupBox2.Controls.Add(this.login_credentialsTextBox);
            this.groupBox2.Controls.Add(salaryLabel);
            this.groupBox2.Controls.Add(this.salaryTextBox);
            this.groupBox2.Controls.Add(hours_workedLabel);
            this.groupBox2.Controls.Add(this.hours_workedTextBox);
            this.groupBox2.Controls.Add(salary_typeLabel);
            this.groupBox2.Controls.Add(this.salary_typeTextBox);
            this.groupBox2.Controls.Add(positionLabel);
            this.groupBox2.Controls.Add(this.positionTextBox);
            this.groupBox2.Controls.Add(full_nameLabel);
            this.groupBox2.Controls.Add(this.full_nameTextBox);
            this.groupBox2.Controls.Add(this.btnDobav);
            this.groupBox2.Controls.Add(this.btnYdal);
            this.groupBox2.Controls.Add(this.btnObnov);
            this.groupBox2.Location = new System.Drawing.Point(850, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(484, 609);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о Сотрудниках";
            // 
            // btnDobav
            // 
            this.btnDobav.BackColor = System.Drawing.Color.Lime;
            this.btnDobav.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDobav.Location = new System.Drawing.Point(34, 316);
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
            this.btnYdal.Location = new System.Drawing.Point(253, 316);
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
            this.btnObnov.Location = new System.Drawing.Point(34, 384);
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
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.praktik_PDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.suppliesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Scladskoi_ychetPraktika.Praktik_PDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // full_nameLabel
            // 
            full_nameLabel.AutoSize = true;
            full_nameLabel.Location = new System.Drawing.Point(31, 48);
            full_nameLabel.Name = "full_nameLabel";
            full_nameLabel.Size = new System.Drawing.Size(69, 17);
            full_nameLabel.TabIndex = 9;
            full_nameLabel.Text = "full name:";
            // 
            // full_nameTextBox
            // 
            this.full_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "full_name", true));
            this.full_nameTextBox.Location = new System.Drawing.Point(106, 48);
            this.full_nameTextBox.Name = "full_nameTextBox";
            this.full_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.full_nameTextBox.TabIndex = 10;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(31, 89);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(61, 17);
            positionLabel.TabIndex = 10;
            positionLabel.Text = "position:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "position", true));
            this.positionTextBox.Location = new System.Drawing.Point(106, 89);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 22);
            this.positionTextBox.TabIndex = 11;
            // 
            // salary_typeLabel
            // 
            salary_typeLabel.AutoSize = true;
            salary_typeLabel.Location = new System.Drawing.Point(31, 124);
            salary_typeLabel.Name = "salary_typeLabel";
            salary_typeLabel.Size = new System.Drawing.Size(81, 17);
            salary_typeLabel.TabIndex = 11;
            salary_typeLabel.Text = "salary type:";
            // 
            // salary_typeTextBox
            // 
            this.salary_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "salary_type", true));
            this.salary_typeTextBox.Location = new System.Drawing.Point(118, 124);
            this.salary_typeTextBox.Name = "salary_typeTextBox";
            this.salary_typeTextBox.Size = new System.Drawing.Size(100, 22);
            this.salary_typeTextBox.TabIndex = 12;
            // 
            // hours_workedLabel
            // 
            hours_workedLabel.AutoSize = true;
            hours_workedLabel.Location = new System.Drawing.Point(31, 167);
            hours_workedLabel.Name = "hours_workedLabel";
            hours_workedLabel.Size = new System.Drawing.Size(97, 17);
            hours_workedLabel.TabIndex = 12;
            hours_workedLabel.Text = "hours worked:";
            // 
            // hours_workedTextBox
            // 
            this.hours_workedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "hours_worked", true));
            this.hours_workedTextBox.Location = new System.Drawing.Point(134, 167);
            this.hours_workedTextBox.Name = "hours_workedTextBox";
            this.hours_workedTextBox.Size = new System.Drawing.Size(100, 22);
            this.hours_workedTextBox.TabIndex = 13;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(31, 211);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(50, 17);
            salaryLabel.TabIndex = 13;
            salaryLabel.Text = "salary:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(87, 211);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.salaryTextBox.TabIndex = 14;
            // 
            // login_credentialsLabel
            // 
            login_credentialsLabel.AutoSize = true;
            login_credentialsLabel.Location = new System.Drawing.Point(31, 256);
            login_credentialsLabel.Name = "login_credentialsLabel";
            login_credentialsLabel.Size = new System.Drawing.Size(115, 17);
            login_credentialsLabel.TabIndex = 14;
            login_credentialsLabel.Text = "login credentials:";
            // 
            // login_credentialsTextBox
            // 
            this.login_credentialsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "login_credentials", true));
            this.login_credentialsTextBox.Location = new System.Drawing.Point(152, 253);
            this.login_credentialsTextBox.Name = "login_credentialsTextBox";
            this.login_credentialsTextBox.Size = new System.Drawing.Size(100, 22);
            this.login_credentialsTextBox.TabIndex = 15;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(34, 502);
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
            this.radioButton1.Location = new System.Drawing.Point(34, 465);
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
            this.butSortir.Location = new System.Drawing.Point(34, 549);
            this.butSortir.Margin = new System.Windows.Forms.Padding(4);
            this.butSortir.Name = "butSortir";
            this.butSortir.Size = new System.Drawing.Size(408, 34);
            this.butSortir.TabIndex = 32;
            this.butSortir.Text = "Сортировка";
            this.butSortir.UseVisualStyleBackColor = false;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(13, 116);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.RowHeadersWidth = 51;
            this.employeesDataGridView.RowTemplate.Height = 24;
            this.employeesDataGridView.Size = new System.Drawing.Size(817, 518);
            this.employeesDataGridView.TabIndex = 59;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "full_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "full_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn3.HeaderText = "position";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "salary_type";
            this.dataGridViewTextBoxColumn4.HeaderText = "salary_type";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "hours_worked";
            this.dataGridViewTextBoxColumn5.HeaderText = "hours_worked";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "salary";
            this.dataGridViewTextBoxColumn6.HeaderText = "salary";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "login_credentials";
            this.dataGridViewTextBoxColumn7.HeaderText = "login_credentials";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Поисковая строка 🡳";
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSearch.Location = new System.Drawing.Point(13, 58);
            this.txtProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(618, 34);
            this.txtProductSearch.TabIndex = 67;
            // 
            // btnOchist
            // 
            this.btnOchist.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOchist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOchist.Location = new System.Drawing.Point(525, 25);
            this.btnOchist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOchist.Name = "btnOchist";
            this.btnOchist.Size = new System.Drawing.Size(106, 27);
            this.btnOchist.TabIndex = 66;
            this.btnOchist.Text = "Отчистить";
            this.btnOchist.UseVisualStyleBackColor = false;
            // 
            // SotrydnikiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 709);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.btnOchist);
            this.Controls.Add(this.employeesDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SotrydnikiForm";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.SotrydnikiForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.praktik_PDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDobav;
        private System.Windows.Forms.Button btnYdal;
        private System.Windows.Forms.Button btnObnov;
        private Praktik_PDataSet praktik_PDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Praktik_PDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private Praktik_PDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox login_credentialsTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox hours_workedTextBox;
        private System.Windows.Forms.TextBox salary_typeTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox full_nameTextBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button butSortir;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Button btnOchist;
    }
}