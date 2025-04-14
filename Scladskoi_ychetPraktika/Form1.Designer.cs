
namespace Scladskoi_ychetPraktika
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param "name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProdykziaForm = new System.Windows.Forms.Button();
            this.RasMat_but = new System.Windows.Forms.Button();
            this.Sotrydniki_but = new System.Windows.Forms.Button();
            this.Otch = new System.Windows.Forms.Button();
            this.Klients_but = new System.Windows.Forms.Button();
            this.Zakazi_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProdykziaForm
            // 
            this.ProdykziaForm.BackColor = System.Drawing.SystemColors.ControlText;
            this.ProdykziaForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdykziaForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdykziaForm.Location = new System.Drawing.Point(127, 166);
            this.ProdykziaForm.Margin = new System.Windows.Forms.Padding(2);
            this.ProdykziaForm.Name = "ProdykziaForm";
            this.ProdykziaForm.Size = new System.Drawing.Size(130, 30);
            this.ProdykziaForm.TabIndex = 37;
            this.ProdykziaForm.Text = "Продукция";
            this.ProdykziaForm.UseVisualStyleBackColor = false;
            this.ProdykziaForm.Click += new System.EventHandler(this.ProdykziaForm_Click);
            // 
            // RasMat_but
            // 
            this.RasMat_but.BackColor = System.Drawing.SystemColors.ControlText;
            this.RasMat_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RasMat_but.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RasMat_but.Location = new System.Drawing.Point(127, 257);
            this.RasMat_but.Margin = new System.Windows.Forms.Padding(2);
            this.RasMat_but.Name = "RasMat_but";
            this.RasMat_but.Size = new System.Drawing.Size(280, 30);
            this.RasMat_but.TabIndex = 36;
            this.RasMat_but.Text = "Расходные материалы";
            this.RasMat_but.UseVisualStyleBackColor = false;
            this.RasMat_but.Click += new System.EventHandler(this.RasMat_but_Click);
            // 
            // Sotrydniki_but
            // 
            this.Sotrydniki_but.BackColor = System.Drawing.SystemColors.ControlText;
            this.Sotrydniki_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sotrydniki_but.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sotrydniki_but.Location = new System.Drawing.Point(277, 214);
            this.Sotrydniki_but.Margin = new System.Windows.Forms.Padding(2);
            this.Sotrydniki_but.Name = "Sotrydniki_but";
            this.Sotrydniki_but.Size = new System.Drawing.Size(130, 30);
            this.Sotrydniki_but.TabIndex = 35;
            this.Sotrydniki_but.Text = "Сотрудники";
            this.Sotrydniki_but.UseVisualStyleBackColor = false;
            this.Sotrydniki_but.Click += new System.EventHandler(this.Sotrydniki_but_Click);
            // 
            // Otch
            // 
            this.Otch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Otch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Otch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Otch.Location = new System.Drawing.Point(127, 301);
            this.Otch.Margin = new System.Windows.Forms.Padding(2);
            this.Otch.Name = "Otch";
            this.Otch.Size = new System.Drawing.Size(280, 30);
            this.Otch.TabIndex = 34;
            this.Otch.Text = "Отчёт";
            this.Otch.UseVisualStyleBackColor = false;
            this.Otch.Click += new System.EventHandler(this.Otch_Click);
            // 
            // Klients_but
            // 
            this.Klients_but.BackColor = System.Drawing.SystemColors.ControlText;
            this.Klients_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Klients_but.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Klients_but.Location = new System.Drawing.Point(127, 214);
            this.Klients_but.Margin = new System.Windows.Forms.Padding(2);
            this.Klients_but.Name = "Klients_but";
            this.Klients_but.Size = new System.Drawing.Size(130, 30);
            this.Klients_but.TabIndex = 33;
            this.Klients_but.Text = "Клиенты";
            this.Klients_but.UseVisualStyleBackColor = false;
            this.Klients_but.Click += new System.EventHandler(this.Klients_but_Click);
            // 
            // Zakazi_but
            // 
            this.Zakazi_but.BackColor = System.Drawing.SystemColors.ControlText;
            this.Zakazi_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zakazi_but.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Zakazi_but.Location = new System.Drawing.Point(277, 166);
            this.Zakazi_but.Margin = new System.Windows.Forms.Padding(2);
            this.Zakazi_but.Name = "Zakazi_but";
            this.Zakazi_but.Size = new System.Drawing.Size(130, 30);
            this.Zakazi_but.TabIndex = 32;
            this.Zakazi_but.Text = "Заказы";
            this.Zakazi_but.UseVisualStyleBackColor = false;
            this.Zakazi_but.Click += new System.EventHandler(this.Zakazi_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 50);
            this.label1.TabIndex = 31;
            this.label1.Text = "Информационная система для скаладского учёта \r\n                     ООО\"ФУДАГРОТР" +
    "ЕЙД\"\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(647, 447);
            this.Controls.Add(this.ProdykziaForm);
            this.Controls.Add(this.RasMat_but);
            this.Controls.Add(this.Sotrydniki_but);
            this.Controls.Add(this.Otch);
            this.Controls.Add(this.Klients_but);
            this.Controls.Add(this.Zakazi_but);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.LightSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProdykziaForm;
        private System.Windows.Forms.Button RasMat_but;
        private System.Windows.Forms.Button Sotrydniki_but;
        private System.Windows.Forms.Button Otch;
        private System.Windows.Forms.Button Klients_but;
        private System.Windows.Forms.Button Zakazi_but;
        private System.Windows.Forms.Label label1;
    }
}

