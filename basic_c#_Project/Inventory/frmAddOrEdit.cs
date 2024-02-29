using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory
{
    public partial class frmAddOrEdit : Form
    {
        IWareHouseDB repository;
        public string FormText = "";
        public DataTable dt;
        public frmAddOrEdit()
        {
            InitializeComponent();
            repository = new WareHouseDB();
        }
        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            this.Text = FormText;
            if (FormText == " ویرایش اطلاعات تخلیه کالا") {
                txt_INVID.Text = dt.Rows[0][0].ToString();
                txt_PRID.Text = dt.Rows[0][1].ToString();
                txt_RCID.Text = dt.Rows[0][2].ToString();
                txt_DCHR_NUM.Text = dt.Rows[0][3].ToString();
                txt_DCHR_TIME.Text = dt.Rows[0][4].ToString();
                btnSubmit.Text = "ویرایش";
            }
        }
        bool ValidateInputs()
{
            if (txt_INVID.Text == "")
            {

                MessageBox.Show("لطفا شناسه انبار را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_PRID.Text == "")
            {
                MessageBox.Show("لطفا شناسه کالا را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_RCID.Text == "")
            {
                MessageBox.Show("لطفا شناسه تحویل گیرنده را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_DCHR_NUM.Text == "")
            {
                MessageBox.Show("لطفا تعداد را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_DCHR_TIME.Text == "")
            {
                MessageBox.Show("لطفا تاریخ را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool isSuccess =
                    (FormText == " ویرایش اطلاعات تخلیه کالا") ?
                    repository.Update(txt_INVID.Text, txt_PRID.Text, txt_RCID.Text, txt_DCHR_NUM.Text, txt_DCHR_TIME.Text)
                    : repository.Insert(txt_INVID.Text, txt_PRID.Text, txt_RCID.Text, txt_DCHR_NUM.Text, txt_DCHR_TIME.Text);
                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
