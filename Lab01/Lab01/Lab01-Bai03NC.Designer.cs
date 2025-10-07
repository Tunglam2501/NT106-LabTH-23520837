namespace Lab01
{
    partial class Lab01_Bai03NC
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
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnDocSo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbKetQuaDocSo = new System.Windows.Forms.RichTextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(249, 106);
            this.txtSo.MaxLength = 12;
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(100, 22);
            this.txtSo.TabIndex = 1;
            // 
            // btnDocSo
            // 
            this.btnDocSo.Location = new System.Drawing.Point(194, 188);
            this.btnDocSo.Name = "btnDocSo";
            this.btnDocSo.Size = new System.Drawing.Size(75, 23);
            this.btnDocSo.TabIndex = 2;
            this.btnDocSo.Text = "Đọc";
            this.btnDocSo.UseVisualStyleBackColor = true;
            this.btnDocSo.Click += new System.EventHandler(this.btnDocSo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cách đọc:";
            // 
            // rtbKetQuaDocSo
            // 
            this.rtbKetQuaDocSo.Location = new System.Drawing.Point(206, 287);
            this.rtbKetQuaDocSo.Name = "rtbKetQuaDocSo";
            this.rtbKetQuaDocSo.Size = new System.Drawing.Size(325, 96);
            this.rtbKetQuaDocSo.TabIndex = 4;
            this.rtbKetQuaDocSo.Text = "";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(360, 188);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(526, 187);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Lab01_Bai03NC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.rtbKetQuaDocSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDocSo);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.label1);
            this.Name = "Lab01_Bai03NC";
            this.Text = "Lab01_Bai03NC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnDocSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbKetQuaDocSo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}