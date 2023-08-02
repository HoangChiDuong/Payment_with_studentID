using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scansText
{
    public partial class Form3 : Form
    {
        private string idStd;
        public Form3(string idStd)
        {
            InitializeComponent();
            this.idStd = idStd;
        }
        public SheetsService API()
        {
            string[] Scopes = { SheetsService.Scope.Spreadsheets };
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
                {
                    ClientId = "188776004155-u1ir7kf15fsbted8q4lq250qoitku7lk.apps.googleusercontent.com",
                    ClientSecret = "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"
                }
            , Scopes, "user", CancellationToken.None, new FileDataStore("MyAppsToken")).Result,
                ApplicationName = "Google Sheets API .NET Quickstart",
            });
            return service;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                var service = API();
                var values = service.Spreadsheets.Values.Get("1wjt4VJTrIUAc6wHFbZRZelq83J5PhHZr8T-od8C96JI", $"{"data-record"}!A:F").Execute().Values;
                var listvalues = values.Where(r => r.Count >= 0 && r[0].ToString().Equals(idStd)).ToList();
                if (listvalues != null)
                {
                   // label2.Visible = true;
                    dataGridView1.Visible = true;
                    //this.Width = 1303;
                    this.CenterToScreen();
                }
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("TransactionID");
                dataTable.Columns.Add("Student_ID");
                dataTable.Columns.Add("Student_Name");
                dataTable.Columns.Add("Pay");
                dataTable.Columns.Add("Available_Balances");
                dataTable.Columns.Add("Trading_Time");
                foreach (var row in listvalues)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["TransactionID"] = row[5].ToString();
                    dataRow["Student_ID"] = row[0].ToString();
                    dataRow["Student_Name"] = row[1].ToString();
                    dataRow["Pay"] = row[2].ToString();
                    dataRow["Available_Balances"] = row[3].ToString();
                    dataRow["Trading_Time"] = row[4].ToString();
                    dataTable.Rows.Add(dataRow);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // var form1 = new Form1();
            this.Close();
            //form1.ShowDialog();
            
        }
    }
}
