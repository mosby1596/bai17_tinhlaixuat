namespace bai17_tinh_lai_xuat
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtvon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtls = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.lstkq = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "số tiền";
            // 
            // txtvon
            // 
            this.txtvon.Location = new System.Drawing.Point(95, 36);
            this.txtvon.Name = "txtvon";
            this.txtvon.Size = new System.Drawing.Size(121, 20);
            this.txtvon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // txtls
            // 
            this.txtls.Location = new System.Drawing.Point(95, 62);
            this.txtls.Name = "txtls";
            this.txtls.Size = new System.Drawing.Size(121, 20);
            this.txtls.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(95, 88);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(121, 20);
            this.txtnam.TabIndex = 1;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(236, 50);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(91, 42);
            this.btntinh.TabIndex = 2;
            this.btntinh.Text = "tinh";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // lstkq
            // 
            this.lstkq.FormattingEnabled = true;
            this.lstkq.Location = new System.Drawing.Point(57, 142);
            this.lstkq.Name = "lstkq";
            this.lstkq.Size = new System.Drawing.Size(253, 186);
            this.lstkq.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstkq);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvon);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.ListBox lstkq;
    }
}

