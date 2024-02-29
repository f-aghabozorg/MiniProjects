namespace Inventory
{
    partial class frmAddOrEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_PRID = new System.Windows.Forms.TextBox();
            this.txt_RCID = new System.Windows.Forms.TextBox();
            this.txt_DCHR_NUM = new System.Windows.Forms.TextBox();
            this.txt_DCHR_TIME = new System.Windows.Forms.TextBox();
            this.txt_INVID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_PRID);
            this.groupBox1.Controls.Add(this.txt_RCID);
            this.groupBox1.Controls.Add(this.txt_DCHR_NUM);
            this.groupBox1.Controls.Add(this.txt_DCHR_TIME);
            this.groupBox1.Controls.Add(this.txt_INVID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(307, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فرم تخلیه کالا";
            // 
            // txt_PRID
            // 
            this.txt_PRID.Location = new System.Drawing.Point(12, 79);
            this.txt_PRID.Name = "txt_PRID";
            this.txt_PRID.Size = new System.Drawing.Size(107, 27);
            this.txt_PRID.TabIndex = 9;
            // 
            // txt_RCID
            // 
            this.txt_RCID.Location = new System.Drawing.Point(12, 115);
            this.txt_RCID.Name = "txt_RCID";
            this.txt_RCID.Size = new System.Drawing.Size(107, 27);
            this.txt_RCID.TabIndex = 8;
            // 
            // txt_DCHR_NUM
            // 
            this.txt_DCHR_NUM.Location = new System.Drawing.Point(12, 150);
            this.txt_DCHR_NUM.Name = "txt_DCHR_NUM";
            this.txt_DCHR_NUM.Size = new System.Drawing.Size(107, 27);
            this.txt_DCHR_NUM.TabIndex = 7;
            // 
            // txt_DCHR_TIME
            // 
            this.txt_DCHR_TIME.Location = new System.Drawing.Point(12, 183);
            this.txt_DCHR_TIME.Name = "txt_DCHR_TIME";
            this.txt_DCHR_TIME.Size = new System.Drawing.Size(107, 27);
            this.txt_DCHR_TIME.TabIndex = 6;
            // 
            // txt_INVID
            // 
            this.txt_INVID.BackColor = System.Drawing.SystemColors.Window;
            this.txt_INVID.Location = new System.Drawing.Point(12, 41);
            this.txt_INVID.Name = "txt_INVID";
            this.txt_INVID.Size = new System.Drawing.Size(107, 27);
            this.txt_INVID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "تاریخ تخلیه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "تعداد تخلیه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "شناسه تحویل گیرنده";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "شناسه کالا";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "شناسه انبار تخلیه";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(107, 330);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 371);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddOrEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddOrEdit";
            this.Load += new System.EventHandler(this.frmAddOrEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txt_PRID;
        private TextBox txt_RCID;
        private TextBox txt_DCHR_NUM;
        private TextBox txt_DCHR_TIME;
        private TextBox txt_INVID;
        private Label label5;
        private Button btnSubmit;
    }
}