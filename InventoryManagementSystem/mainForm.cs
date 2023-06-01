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

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {

        static string UserLogin = login_form.userLog;
        static DB db = new DB();
        private DataSet dataSet = null;

        SqlDataAdapter adapter = null;
        SqlCommandBuilder builder = null;


        string tableName = null;

        private static int getIDPerson()
        {
            int PersonId = default(int);
            SqlCommand getPersonId = new SqlCommand($"select ID from UsersInformation where Login = @login", db.genConnectionDB());
            getPersonId.Parameters.AddWithValue("@login", UserLogin);
            db.openConnectionDB();
            SqlDataReader reader = getPersonId.ExecuteReader();
            if (reader.Read())
            {
                PersonId = reader.GetInt32(0);
            }
            db.closeConnectionDB();
            return PersonId;
        }

        int personID = getIDPerson();

        

        public MainForm()
        {
            InitializeComponent();

            SqlCommand command = new SqlCommand($"select * from UsersInformation where ID = {personID}", db.genConnectionDB());
            db.openConnectionDB();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                usersName.Text = reader.GetString(1);
                userSurname.Text = reader.GetString(2);
                usersCompany.Text = reader.GetString(3);
            }

            db.closeConnectionDB();

        }

        private void loadData(string TableName)
        {
            db.openConnectionDB();
            SqlCommand command = new SqlCommand($"select * from {TableName} where ID = {personID}", db.genConnectionDB());
            adapter = new SqlDataAdapter(command);
            dataSet = new DataSet();
            builder = new SqlCommandBuilder(adapter);


            builder.GetDeleteCommand();
            builder.GetInsertCommand();
            builder.GetUpdateCommand();

            adapter.Fill(dataSet, TableName);
          
            db.closeConnectionDB();

            information.DataSource = dataSet.Tables[TableName];
        }

        private void reloadData(string tableName)
        {
            try
            {
                dataSet.Tables[tableName].Clear();
                SqlCommand command = new SqlCommand($"select * from {tableName} where ID = {personID}", db.genConnectionDB());
                adapter = new SqlDataAdapter(command);

                adapter.Fill(dataSet, tableName);
                information.DataSource = dataSet.Tables[tableName];
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void productManagmentBtn_Click(object sender, EventArgs e)
        {
            tableName = "ProductInfo";
            loadData(tableName);   
        }

       
        private void tradingInfoBtn_Click(object sender, EventArgs e)
        {
            tableName = "TradingInfo";
            loadData(tableName);

        }

        private void purchaseManagmentBtn_Click(object sender, EventArgs e)
        {
            tableName = "ManagingPurchase";
            loadData(tableName);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = information.Rows.Count - 2;

            SqlCommand saveCommand = null;

            information.DefaultValuesNeeded += information_DefaultValuesNeeded;

            switch (tableName)
            {
                case "ProductInfo":
                    saveCommand = new SqlCommand($"insert into {tableName} values(@ID, @PN, @PT, @PC)", db.genConnectionDB());
                    saveCommand.Parameters.Add("@PN", SqlDbType.NVarChar).Value = information.Rows[rowIndex].Cells["ProductName"].Value;
                    saveCommand.Parameters.Add("@PT", SqlDbType.NVarChar).Value = information.Rows[rowIndex].Cells["ProductType"].Value;
                    saveCommand.Parameters.Add("@PC", SqlDbType.Int).Value = information.Rows[rowIndex].Cells["ProductCount"].Value;
                    break;
                case "TradingInfo":
                    saveCommand = new SqlCommand($"insert into {tableName} values(@ID, @BN, @PI, (select ProductName FROM ProductInfo where ProductID = @PI), @PG)", db.genConnectionDB());
                    saveCommand.Parameters.AddWithValue("@ID", personID);
                    saveCommand.Parameters.Add("@BN", SqlDbType.NVarChar).Value = information.Rows[rowIndex].Cells["BuyerName"].Value;
                    saveCommand.Parameters.Add("@PI", SqlDbType.Int).Value = information.Rows[rowIndex].Cells["ProductID"].Value;
                    saveCommand.Parameters.Add("@PG", SqlDbType.Int).Value = information.Rows[rowIndex].Cells["PurchasedGoods"].Value;
                    break;
                case "ManagingPurchase":
                    saveCommand = new SqlCommand($"insert into {tableName} values(@ID, @SN, @PN, @NP)", db.genConnectionDB());
                    saveCommand.Parameters.Add("@SN", SqlDbType.NVarChar).Value = information.Rows[rowIndex].Cells["SellerName"].Value;
                    saveCommand.Parameters.Add("@PN", SqlDbType.NVarChar).Value = information.Rows[rowIndex].Cells["ProductName"].Value;
                    saveCommand.Parameters.Add("@NP", SqlDbType.NVarChar).Value = information.Rows[rowIndex].Cells["NumProductsPurchases"].Value;
                    break;
                default:
                    break;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = saveCommand;

            adapter = new SqlDataAdapter($"select * from {tableName}", db.genConnectionDB());
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Update(dataSet, tableName);

            reloadData(tableName);
        }

        private void Information_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void updateTableBtn_Click(object sender, EventArgs e)
        {
            reloadData(tableName);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DataGridView c = this.information;

            if (MessageBox.Show("Удалить эти данные?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int rowIndex = c.CurrentCell.RowIndex;

                information.Rows.RemoveAt(rowIndex);

                dataSet.Tables[tableName].Rows[rowIndex].Delete();

                DataGridViewRow row = information.CurrentRow;
                DataGridViewCell cell = row.Cells[1];
                object value = cell.Value;

                SqlCommand deleteCommand = new SqlCommand($"delete from {tableName} where ID = {value}", db.genConnectionDB());
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = deleteCommand;

                adapter = new SqlDataAdapter($"select * from {tableName}", db.genConnectionDB());
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.Update(dataSet, tableName);

            }

            reloadData(tableName);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Изменить значение?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {        

                object value = information.CurrentCell;
                SqlCommand editCommand = new SqlCommand($"update {tableName} set {information.Columns[information.CurrentCell.ColumnIndex].Name} = {value}", db.genConnectionDB());

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = editCommand;

                adapter = new SqlDataAdapter($"select * from {tableName}", db.genConnectionDB());
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.Update(dataSet, tableName);

            }
        }

        private void information_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["ID"].Value = personID;
        }

        private void graphBuildBtn_Click(object sender, EventArgs e)
        {
            graph_form graph = new graph_form(personID);
            graph.Show();
        }


    }

}
