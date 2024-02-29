namespace Inventory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnAddDCHR = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DCHR_INVID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCHR_PRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCHR_RCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCHR_DCHRNUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCHR_DATE_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnAddDCHR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(908, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 24);
            this.btnRefresh.Text = " بروزرسانی";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddDCHR
            // 
            this.btnAddDCHR.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDCHR.Image")));
            this.btnAddDCHR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDCHR.Name = "btnAddDCHR";
            this.btnAddDCHR.Size = new System.Drawing.Size(156, 24);
            this.btnAddDCHR.Text = "افزودن شخص جدید";
            this.btnAddDCHR.Click += new System.EventHandler(this.btnAddDCHR_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(896, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(896, 335);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DCHR_INVID,
            this.DCHR_PRID,
            this.DCHR_RCID,
            this.DCHR_DCHRNUM,
            this.DCHR_DATE_TIME});
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(872, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // DCHR_INVID
            // 
            this.DCHR_INVID.DataPropertyName = "DCHR_INVID";
            this.DCHR_INVID.HeaderText = "شناسه انبار تخلیه";
            this.DCHR_INVID.MinimumWidth = 6;
            this.DCHR_INVID.Name = "DCHR_INVID";
            this.DCHR_INVID.ReadOnly = true;
            // 
            // DCHR_PRID
            // 
            this.DCHR_PRID.DataPropertyName = "DCHR_PRID";
            this.DCHR_PRID.HeaderText = "شناسه کالا";
            this.DCHR_PRID.MinimumWidth = 6;
            this.DCHR_PRID.Name = "DCHR_PRID";
            this.DCHR_PRID.ReadOnly = true;
            // 
            // DCHR_RCID
            // 
            this.DCHR_RCID.DataPropertyName = "DCHR_RCID";
            this.DCHR_RCID.HeaderText = "شناسه تحویل گیرنده";
            this.DCHR_RCID.MinimumWidth = 6;
            this.DCHR_RCID.Name = "DCHR_RCID";
            this.DCHR_RCID.ReadOnly = true;
            // 
            // DCHR_DCHRNUM
            // 
            this.DCHR_DCHRNUM.DataPropertyName = "DCHR_DCHRNUM";
            this.DCHR_DCHRNUM.HeaderText = "تعداد کالا تخلیه";
            this.DCHR_DCHRNUM.MinimumWidth = 6;
            this.DCHR_DCHRNUM.Name = "DCHR_DCHRNUM";
            this.DCHR_DCHRNUM.ReadOnly = true;
            // 
            // DCHR_DATE_TIME
            // 
            this.DCHR_DATE_TIME.DataPropertyName = "DCHR_DATE_TIME";
            this.DCHR_DATE_TIME.HeaderText = "تاریخ تخلیه";
            this.DCHR_DATE_TIME.MinimumWidth = 6;
            this.DCHR_DATE_TIME.Name = "DCHR_DATE_TIME";
            this.DCHR_DATE_TIME.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 500);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(112, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(509, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(746, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "عبارت جستجو";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 553);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "انبارداری";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DCHR_INVID;
        private DataGridViewTextBoxColumn DCHR_PRID;
        private DataGridViewTextBoxColumn DCHR_RCID;
        private DataGridViewTextBoxColumn DCHR_DCHRNUM;
        private DataGridViewTextBoxColumn DCHR_DATE_TIME;
        private ToolStripButton btnRefresh;
        private ToolStripButton btnAddDCHR;
        private Button btnEdit;
        private Button btnDelete;
        private Label label1;
        private TextBox txtSearch;
    }
}