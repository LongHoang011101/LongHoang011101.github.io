using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNH
{
    public partial class btnDelete2 : Form
    {
        SqlConnection connection;
        SqlCommand command,command1,command2,command3;
        string str = @"Data Source=DESKTOP-GPFJC6H\SQLSERVER;Initial Catalog=QLNH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        SqlDataAdapter adapter3 = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        DataTable table3 = new DataTable();
        void dataKH()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Customer ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvKH.DataSource = table;
        }
        void dataTable()
        {
            command1 = connection.CreateCommand();
            command1.CommandText = "select * from TableFood";
            adapter1.SelectCommand = command1;
            table1.Clear();
            adapter1.Fill(table1);
            dtgvTable.DataSource = table1;
        }
        void dataFC()
        {
            command2 = connection.CreateCommand();
            command2.CommandText = "select * from FoodCategory";
            adapter2.SelectCommand = command2;
            table2.Clear();
            adapter2.Fill(table2);
            dtgvFC.DataSource = table2;
        }
        void dataFood()
        {
            command3 = connection.CreateCommand();
            command3.CommandText = "select * from Food";
            adapter3.SelectCommand = command3;
            table3.Clear();
            adapter3.Fill(table3);
            dtgvFood.DataSource = table3;
        }
        public btnDelete2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            dataKH();
            dataTable();
            dataFC();
            dataFood();
        }

        private void dtgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvKH.CurrentRow.Index;
            txbIdCus.Text = dtgvKH.Rows[i].Cells[0].Value.ToString();
            txbNameCus.Text = dtgvKH.Rows[i].Cells[1].Value.ToString();
            cbGender.Text = dtgvKH.Rows[i].Cells[2].Value.ToString();
            txbPhoneNumber.Text = dtgvKH.Rows[i].Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Customer values('" + txbIdCus.Text + "',N'" + txbNameCus.Text + "', N'" + cbGender.Text + "','" + txbPhoneNumber.Text + "')";
            command.ExecuteNonQuery();
            dataKH();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Customer set TenKH = N'" + txbNameCus.Text + "', GioiTinh = N'" + cbGender.Text + "', SDT = '"+txbPhoneNumber.Text+ "' where MaKH = '"+txbIdCus.Text+"' ";
            command.ExecuteNonQuery();
            dataKH();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Customer where MaKH = '"+txbIdCus.Text+"'";
            command.ExecuteNonQuery();
            dataKH();
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchData(txtSearchBox.Text);
        }
        public void SearchData(string search)
        {
            string query = "select * from Customer where TenKH like '%" + search + "%'";
            adapter = new SqlDataAdapter(query, connection);
            table = new DataTable();
            adapter.Fill(table);
            dtgvKH.DataSource = table;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvTable.CurrentRow.Index;
            txbIdTable.Text = dtgvTable.Rows[i].Cells[0].Value.ToString();
            cbStatus.Text = dtgvTable.Rows[i].Cells[1].Value.ToString();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            command1 = connection.CreateCommand();
            command1.CommandText = "insert into TableFood values('" + txbIdTable.Text + "',N'" + cbStatus.Text + "')";
            command1.ExecuteNonQuery();
            dataTable();
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            command1 = connection.CreateCommand();
            command1.CommandText = "update TableFood set TinhTrang = N'" + cbStatus.Text + "' where MaBan = '" + txbIdTable.Text + "' ";
            command1.ExecuteNonQuery();
            dataTable();
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            command1 = connection.CreateCommand();
            command1.CommandText = "delete from TableFood where MaBan = '" + txbIdTable.Text + "'";
            command1.ExecuteNonQuery();
            dataTable();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            command2 = connection.CreateCommand();
            command2.CommandText = "insert into FoodCategory values('" + txbIdFC.Text + "',N'" + txbNameFC.Text + "')";
            command2.ExecuteNonQuery();
            dataFC();
        }

        private void dtgvFC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvFC.CurrentRow.Index;
            txbIdFC.Text = dtgvFC.Rows[i].Cells[0].Value.ToString();
            txbNameFC.Text = dtgvFC.Rows[i].Cells[1].Value.ToString();
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            command2 = connection.CreateCommand();
            command2.CommandText = "update FoodCategory set TenNhom = N'" + txbNameFC.Text + "' where MaNhom = '" + txbIdFC.Text + "' ";
            command2.ExecuteNonQuery();
            dataFC();
        }

        private void btDelete2_Click(object sender, EventArgs e)
        {
            command2 = connection.CreateCommand();
            command2.CommandText = "delete from FoodCategory where MaNhom = '" + txbIdFC.Text + "'";
            command2.ExecuteNonQuery();
            dataFC();
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            command3 = connection.CreateCommand();
            command3.CommandText = "insert into Food values('" + txbIdFood.Text + "',N'" + txbNameFood.Text + "', N'" + txbFood.Text + "','" + txbPrice.Text + "')";
            command3.ExecuteNonQuery();
            dataFood();
        }

        private void btnUpdate3_Click(object sender, EventArgs e)
        {
            command3 = connection.CreateCommand();
            command3.CommandText = "update Food set TenMon = N'" + txbNameFood.Text + "', MaNhom = N'" + txbFood.Text + "', GiaTien = '" + txbPrice.Text + "' where MaMon = '" + txbIdFood.Text + "' ";
            command3.ExecuteNonQuery();
            dataFood();
        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {
            command3 = connection.CreateCommand();
            command3.CommandText = "delete from Food where MaMon = '" + txbIdFood.Text + "'";
            command3.ExecuteNonQuery();
            dataFood();
        }

        private void dtgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvFood.CurrentRow.Index;
            txbIdFood.Text = dtgvFood.Rows[i].Cells[0].Value.ToString();
            txbNameFood.Text = dtgvFood.Rows[i].Cells[1].Value.ToString();
            txbFood.Text = dtgvFood.Rows[i].Cells[2].Value.ToString();
            txbPrice.Text = dtgvFood.Rows[i].Cells[3].Value.ToString();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txbSearchBox1_TextChanged(object sender, EventArgs e)
        {
            SearchData1(txbSearchBox1.Text);
        }
        public void SearchData1(string search)
        {
            string query1 = "select * from Food where MaNhom like '%" + search + "%'";
            adapter3 = new SqlDataAdapter(query1, connection);
            table3 = new DataTable();
            adapter3.Fill(table3);
            dtgvFood.DataSource = table3;
        }
    }
}
