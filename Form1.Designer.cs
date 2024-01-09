namespace WindowsFormsApp2
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
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BMX = new System.Windows.Forms.Button();
            this.BMN = new System.Windows.Forms.Button();
            this.BA = new System.Windows.Forms.Button();
            this.Bvegetale = new System.Windows.Forms.Button();
            this.Bfruit = new System.Windows.Forms.Button();
            this.Color_CH = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Button();
            this.kkal_ch = new System.Windows.Forms.Button();
            this.color_fin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // BMX
            // 
            this.BMX.Location = new System.Drawing.Point(415, 200);
            this.BMX.Name = "BMX";
            this.BMX.Size = new System.Drawing.Size(75, 23);
            this.BMX.TabIndex = 4;
            this.BMX.Text = "MAX";
            this.BMX.UseVisualStyleBackColor = true;
            this.BMX.Click += new System.EventHandler(this.BMX_Click);
            // 
            // BMN
            // 
            this.BMN.Location = new System.Drawing.Point(415, 239);
            this.BMN.Name = "BMN";
            this.BMN.Size = new System.Drawing.Size(75, 23);
            this.BMN.TabIndex = 5;
            this.BMN.Text = "MIN";
            this.BMN.UseVisualStyleBackColor = true;
            this.BMN.Click += new System.EventHandler(this.BMN_Click);
            // 
            // BA
            // 
            this.BA.Location = new System.Drawing.Point(415, 281);
            this.BA.Name = "BA";
            this.BA.Size = new System.Drawing.Size(75, 23);
            this.BA.TabIndex = 6;
            this.BA.Text = "AVERAGE";
            this.BA.UseVisualStyleBackColor = true;
            this.BA.Click += new System.EventHandler(this.BA_Click);
            // 
            // Bvegetale
            // 
            this.Bvegetale.Location = new System.Drawing.Point(149, 200);
            this.Bvegetale.Name = "Bvegetale";
            this.Bvegetale.Size = new System.Drawing.Size(75, 23);
            this.Bvegetale.TabIndex = 7;
            this.Bvegetale.Text = "Vegetable";
            this.Bvegetale.UseVisualStyleBackColor = true;
            this.Bvegetale.Click += new System.EventHandler(this.Bvegetale_Click);
            // 
            // Bfruit
            // 
            this.Bfruit.Location = new System.Drawing.Point(149, 239);
            this.Bfruit.Name = "Bfruit";
            this.Bfruit.Size = new System.Drawing.Size(75, 23);
            this.Bfruit.TabIndex = 8;
            this.Bfruit.Text = "Fruit";
            this.Bfruit.UseVisualStyleBackColor = true;
            this.Bfruit.Click += new System.EventHandler(this.Bfruit_Click);
            // 
            // Color_CH
            // 
            this.Color_CH.Location = new System.Drawing.Point(149, 281);
            this.Color_CH.Name = "Color_CH";
            this.Color_CH.Size = new System.Drawing.Size(75, 23);
            this.Color_CH.TabIndex = 9;
            this.Color_CH.Text = "Color_CH";
            this.Color_CH.UseVisualStyleBackColor = true;
            this.Color_CH.Click += new System.EventHandler(this.Color_CH_Click);
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(68, 201);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(75, 23);
            this.Color.TabIndex = 10;
            this.Color.Text = "Color";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // kkal_ch
            // 
            this.kkal_ch.Location = new System.Drawing.Point(68, 239);
            this.kkal_ch.Name = "kkal_ch";
            this.kkal_ch.Size = new System.Drawing.Size(75, 23);
            this.kkal_ch.TabIndex = 11;
            this.kkal_ch.Text = "Kkal_CH";
            this.kkal_ch.UseVisualStyleBackColor = true;
            this.kkal_ch.Click += new System.EventHandler(this.kkal_ch_Click);
            // 
            // color_fin
            // 
            this.color_fin.Location = new System.Drawing.Point(68, 281);
            this.color_fin.Name = "color_fin";
            this.color_fin.Size = new System.Drawing.Size(75, 23);
            this.color_fin.TabIndex = 12;
            this.color_fin.Text = "Color_fin";
            this.color_fin.UseVisualStyleBackColor = true;
            this.color_fin.Click += new System.EventHandler(this.color_fin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 335);
            this.Controls.Add(this.color_fin);
            this.Controls.Add(this.kkal_ch);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Color_CH);
            this.Controls.Add(this.Bfruit);
            this.Controls.Add(this.Bvegetale);
            this.Controls.Add(this.BA);
            this.Controls.Add(this.BMN);
            this.Controls.Add(this.BMX);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BMX;
        private System.Windows.Forms.Button BMN;
        private System.Windows.Forms.Button BA;
        private System.Windows.Forms.Button Bvegetale;
        private System.Windows.Forms.Button Bfruit;
        private System.Windows.Forms.Button Color_CH;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.Button kkal_ch;
        private System.Windows.Forms.Button color_fin;
    }
}

