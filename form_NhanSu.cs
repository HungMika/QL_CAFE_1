using QL_CAFE.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QL_CAFE
{
    public partial class form_NhanSu : Form
    {

        public form_NhanSu()
        {
            InitializeComponent();
            loadNhanSuList();
        }
        void loadNhanSuList()
        {
            string query = "select * from NHANVIEN";
            DataProvider provider = new DataProvider();
            dataGridView_NhanSu.DataSource = provider.ExcuteQuery(query);
        }

        private void but_Qve_Click(object sender, EventArgs e)
        {
            form_main f = new form_main();
            f.Show();
            this.Hide();
        }

        private void form_NhanSu_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_main f = new form_main();
            f.Show();
            this.Hide();
        }
    }
}
