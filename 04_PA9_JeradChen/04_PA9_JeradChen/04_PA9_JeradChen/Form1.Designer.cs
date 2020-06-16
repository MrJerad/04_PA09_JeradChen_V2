namespace _04_PA9_JeradChen
{
    partial class Form1
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
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_selectcurrency = new System.Windows.Forms.Label();
            this.rdb_JapaneseYen = new System.Windows.Forms.RadioButton();
            this.rdb_USdollars = new System.Windows.Forms.RadioButton();
            this.lbl_value = new System.Windows.Forms.Label();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(50, 58);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(56, 17);
            this.lbl_amount.TabIndex = 0;
            this.lbl_amount.Text = "Amount";
            this.lbl_amount.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(143, 58);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(234, 22);
            this.txt_amount.TabIndex = 1;
            // 
            // lbl_selectcurrency
            // 
            this.lbl_selectcurrency.AutoSize = true;
            this.lbl_selectcurrency.Location = new System.Drawing.Point(50, 118);
            this.lbl_selectcurrency.Name = "lbl_selectcurrency";
            this.lbl_selectcurrency.Size = new System.Drawing.Size(108, 17);
            this.lbl_selectcurrency.TabIndex = 2;
            this.lbl_selectcurrency.Text = "Select Currency";
            // 
            // rdb_JapaneseYen
            // 
            this.rdb_JapaneseYen.AutoSize = true;
            this.rdb_JapaneseYen.Location = new System.Drawing.Point(263, 118);
            this.rdb_JapaneseYen.Name = "rdb_JapaneseYen";
            this.rdb_JapaneseYen.Size = new System.Drawing.Size(120, 21);
            this.rdb_JapaneseYen.TabIndex = 3;
            this.rdb_JapaneseYen.TabStop = true;
            this.rdb_JapaneseYen.Text = "Japanese Yen";
            this.rdb_JapaneseYen.UseVisualStyleBackColor = true;
            // 
            // rdb_USdollars
            // 
            this.rdb_USdollars.AutoSize = true;
            this.rdb_USdollars.Location = new System.Drawing.Point(263, 145);
            this.rdb_USdollars.Name = "rdb_USdollars";
            this.rdb_USdollars.Size = new System.Drawing.Size(96, 21);
            this.rdb_USdollars.TabIndex = 4;
            this.rdb_USdollars.TabStop = true;
            this.rdb_USdollars.Text = "US Dollars";
            this.rdb_USdollars.UseVisualStyleBackColor = true;
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Location = new System.Drawing.Point(50, 198);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(44, 17);
            this.lbl_value.TabIndex = 5;
            this.lbl_value.Text = "Value";
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(203, 198);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(234, 22);
            this.txt_value.TabIndex = 6;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(531, 118);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 23);
            this.btn_convert.TabIndex = 7;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(531, 157);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.rdb_USdollars);
            this.Controls.Add(this.rdb_JapaneseYen);
            this.Controls.Add(this.lbl_selectcurrency);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lbl_amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lbl_selectcurrency;
        private System.Windows.Forms.RadioButton rdb_JapaneseYen;
        private System.Windows.Forms.RadioButton rdb_USdollars;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_clear;
    }
}

