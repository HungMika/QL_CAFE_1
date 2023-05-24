
namespace QL_CAFE
{
    partial class form_NhanSu
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
            this.but_Them = new System.Windows.Forms.Button();
            this.but_Xoa = new System.Windows.Forms.Button();
            this.but_Sua = new System.Windows.Forms.Button();
            this.dataGridView_NhanSu = new System.Windows.Forms.DataGridView();
            this.but_Qve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanSu)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Them
            // 
            this.but_Them.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Them.Location = new System.Drawing.Point(8, 105);
            this.but_Them.Name = "but_Them";
            this.but_Them.Size = new System.Drawing.Size(71, 31);
            this.but_Them.TabIndex = 1;
            this.but_Them.Text = "Thêm";
            this.but_Them.UseVisualStyleBackColor = true;
            // 
            // but_Xoa
            // 
            this.but_Xoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Xoa.Location = new System.Drawing.Point(85, 105);
            this.but_Xoa.Name = "but_Xoa";
            this.but_Xoa.Size = new System.Drawing.Size(71, 31);
            this.but_Xoa.TabIndex = 2;
            this.but_Xoa.Text = "Xoá";
            this.but_Xoa.UseVisualStyleBackColor = true;
            // 
            // but_Sua
            // 
            this.but_Sua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Sua.Location = new System.Drawing.Point(162, 105);
            this.but_Sua.Name = "but_Sua";
            this.but_Sua.Size = new System.Drawing.Size(71, 31);
            this.but_Sua.TabIndex = 3;
            this.but_Sua.Text = "Sửa";
            this.but_Sua.UseVisualStyleBackColor = true;
            // 
            // dataGridView_NhanSu
            // 
            this.dataGridView_NhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhanSu.Location = new System.Drawing.Point(8, 151);
            this.dataGridView_NhanSu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_NhanSu.Name = "dataGridView_NhanSu";
            this.dataGridView_NhanSu.RowHeadersWidth = 62;
            this.dataGridView_NhanSu.RowTemplate.Height = 28;
            this.dataGridView_NhanSu.Size = new System.Drawing.Size(508, 272);
            this.dataGridView_NhanSu.TabIndex = 4;
            // 
            // but_Qve
            // 
            this.but_Qve.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Qve.Location = new System.Drawing.Point(441, 105);
            this.but_Qve.Name = "but_Qve";
            this.but_Qve.Size = new System.Drawing.Size(71, 31);
            this.but_Qve.TabIndex = 5;
            this.but_Qve.Text = "Trở về";
            this.but_Qve.UseVisualStyleBackColor = true;
            this.but_Qve.Click += new System.EventHandler(this.but_Qve_Click);
            // 
            // form_NhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 441);
            this.Controls.Add(this.but_Qve);
            this.Controls.Add(this.dataGridView_NhanSu);
            this.Controls.Add(this.but_Sua);
            this.Controls.Add(this.but_Xoa);
            this.Controls.Add(this.but_Them);
            this.Name = "form_NhanSu";
            this.Text = "Nhân sự";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_NhanSu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanSu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button but_Them;
        private System.Windows.Forms.Button but_Xoa;
        private System.Windows.Forms.Button but_Sua;
        private System.Windows.Forms.DataGridView dataGridView_NhanSu;
        private System.Windows.Forms.Button but_Qve;
    }
}