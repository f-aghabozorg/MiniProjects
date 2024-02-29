using System.Data;

namespace Inventory
{
    public partial class Form1 : Form
    {
        IWareHouseDB repository;
        public Form1()
        {
            InitializeComponent();
            repository = new WareHouseDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = repository.SelectAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnAddDCHR_Click(object sender, EventArgs e)
        {
            frmAddOrEdit FormAdd = new frmAddOrEdit();
            FormAdd.FormText = " افزودن اطلاعات تخلیه کالا";
            FormAdd.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string DCHR_INVID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string DCHR_PRID = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string DCHR_RCID = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string DCHR_DATE_TIME = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                if (MessageBox.Show("آیا از حذف مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    repository.Delete(DCHR_INVID, DCHR_PRID, DCHR_RCID, DCHR_DATE_TIME);
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا یک شخص را از لیست انتخاب کنید");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                frmAddOrEdit FormEdit = new frmAddOrEdit();
                FormEdit.FormText = " ویرایش اطلاعات تخلیه کالا";
                string DCHR_INVID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string DCHR_PRID = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string DCHR_RCID = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string DCHR_DATE_TIME = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                DataTable data_table_edit = repository.SelectRow(DCHR_INVID, DCHR_PRID, DCHR_RCID, DCHR_DATE_TIME);
                FormEdit.dt = data_table_edit;
                if (FormEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repository.Search(txtSearch.Text);
        }
    }
}