using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseHunter
{
    public partial class HouseDB : Form
    {
        private string connectionString;
        private List<HouseData> Houses = new List<HouseData>();

        public HouseDB()
        {
            InitializeComponent();
        }

        private void HouseDB_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["HouseHunter.Properties.Settings.HouseDataConnectionString"].ConnectionString;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            populateClientDataListBox();
        }

        private void populateClientDataListBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlDataAdapter clientAdapter = new SqlDataAdapter("SELECT * FROM Houses", connection))
            {
                DataTable clientData = new DataTable();
                connection.Open();
                clientAdapter.Fill(clientData);
                connection.Close();

                clientData.DefaultView.Sort = "postalCode";
                clientData = clientData.DefaultView.ToTable();
                for (int row = 0; row < clientData.Rows.Count; row++)
                {
                    int id = (int)clientData.Rows[row]["houseID"];
                    String address = clientData.Rows[row]["address"].ToString();
                    string postalCode = clientData.Rows[row]["postalCode"].ToString();
                    
                    DateTime lDate = (DateTime)clientData.Rows[row]["listDate"];
                    string listDate = lDate.ToString("dd/MM/yyyy");

                    string listPrice = Math.Round((decimal)clientData.Rows[row]["listPrice"], 2).ToString();
                    string numberOfBed = clientData.Rows[row]["numberOfBed"].ToString();
                    string numberOfBath = clientData.Rows[row]["numberOfBath"].ToString();
                    String description = clientData.Rows[row]["description"].ToString();

                    string sellPrice = "NULL";
                    if (decimal.TryParse(clientData.Rows[row]["sellPrice"].ToString(), out decimal sPrice))
                    {
                        sellPrice = Math.Round(sPrice, 2).ToString();
                    }

                    string sellDate = "NULL";
                    if (clientData.Rows[row]["sellDate"].ToString() != "")
                    {
                        DateTime sDate = (DateTime)clientData.Rows[row]["sellDate"];
                        sellDate = sDate.ToString("dd/MM/yyyy");
                    }

                    string sqFeet = clientData.Rows[row]["sqFeet"].ToString();

                    HouseData houseData = new HouseData()
                    {
                        id = id,
                        address = address,
                        postalCode = postalCode,
                        listDate = listDate,
                        listPrice = listPrice,
                        numberOfBed = numberOfBed,
                        numberOfBath = numberOfBath,
                        description = description,
                        sellPrice = sellPrice,
                        sellDate = sellDate,
                        sqFeet = sqFeet
                    };

                    Houses.Add(houseData);
                    ListViewItem item = new ListViewItem(id.ToString());
                    item.SubItems.Add(address);
                    item.SubItems.Add(postalCode);
                    if (Convert.ToDouble(listPrice)/Convert.ToDouble(sqFeet) <= 200)
                    {
                        item.ForeColor = Color.Red;
                    }

                    listViewSmall.Items.Add(item);
                }
            }
        }

        private void listViewSmall_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listViewSmall.Items.Count; i++)
            {
                if (listViewSmall.Items[i].Selected == true)
                {
                    string id = listViewSmall.Items[i].Text;
                    FillTheFullData(Int32.Parse(id));
                    break;
                }
            }
        }

        private void FillTheFullData(int id)
        {
            foreach (var house in Houses)
            {
                if (house.id == id)
                {
                    ListViewItem item = new ListViewItem(house.id.ToString());
                    item.SubItems.Add(house.address);
                    item.SubItems.Add(house.postalCode);
                    item.SubItems.Add(house.listDate);
                    item.SubItems.Add(house.listPrice);
                    item.SubItems.Add(house.numberOfBed);
                    item.SubItems.Add(house.numberOfBath);
                    item.SubItems.Add(house.description);
                    item.SubItems.Add(house.sqFeet);
                    item.SubItems.Add(house.sellPrice);
                    item.SubItems.Add(house.sellDate);

                    if (Convert.ToDouble(house.listPrice) / Convert.ToDouble(house.sqFeet) <= 200)
                    {
                        item.ForeColor = Color.Red;
                    }

                    listViewDatabase.Items.Add(item);
                }
            }
        }
    }
}
