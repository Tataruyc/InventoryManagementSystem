using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.Axes;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class graph_form : Form
    {
        static DB db = new DB();
        static List<int> data_X = new List<int>();
        static List<int> data_Y = new List<int>();
        static List<string> colunmName = new List<string>();

        static string tableName;
        static int personID;

        public graph_form(int personid)
        {
            InitializeComponent();
            personID = personid;
        }


        public static void dataFilling(int valueColumn1, int valueColumn2)
        {
            SqlCommand command = new SqlCommand($"select * from {tableName} where ID = {personID}", db.genConnectionDB());
            db.openConnectionDB();
            SqlDataReader reader = command.ExecuteReader();

            colunmName.Clear();
            data_Y.Clear();

            while (reader.Read())
            {
                colunmName.Add(reader.GetString(valueColumn1));
                data_Y.Add(reader.GetInt32(valueColumn2));
            }

            reader.Close();
            db.closeConnectionDB();

        }

        public void printGraph(string grapgname) 
        {
            foreach (Control control in this.Controls.OfType<PlotView>().ToList())
            {
                this.Controls.Remove(control);
                control.Dispose();
            }

            PlotModel plotModel = new PlotModel { Title = grapgname };
            var pieSeries = new PieSeries();
            for (int i = 0; i < data_Y.Count; i++)
            {
                pieSeries.Slices.Add(new PieSlice(colunmName[i], data_Y[i]));
            }
            plotModel.Series.Add(pieSeries);

            var plotView = new PlotView();
            plotView.Model = plotModel;
            plotView.Dock = DockStyle.Fill;
            this.Controls.Add(plotView);
        }

        private void showProductsTable_Click(object sender, EventArgs e)
        {
            tableName = "ProductInfo";

            dataFilling(2, 4);

            printGraph("Продукты");
        }

        private void showSalesTable_Click(object sender, EventArgs e)
        {
            tableName = "TradingInfo";

            dataFilling(4,5);

            printGraph("Покупки");
        }

        private void showShopTable_Click(object sender, EventArgs e)
        {
            tableName = "ManagingPurchase";

            dataFilling(3, 4);

            printGraph("Продажи");
        }
    }
}
