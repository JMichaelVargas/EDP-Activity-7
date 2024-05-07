using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace VargasForm
{
    public partial class product_form : UserControl
    {
        private DatabaseManager dbManager;
        private DataTable originalDataTable;

        public product_form()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (dbManager.OpenConnection())
                {
                    string selectQuery = "SELECT product_name, product_type, quantity, unit_price FROM mcdo_inventory";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, dbManager.connection))
                    {
                        originalDataTable = new DataTable();
                        adapter.Fill(originalDataTable);

                        dataGridView1.DataSource = originalDataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Visible = false;
                    Excel.Workbook workbook = excelApp.Workbooks.Open(textBox1.Text);
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                    Excel.Range range = worksheet.Range["C9", "F18"];

                    for (int i = 0; i < Math.Min(dataGridView1.Rows.Count, 10); i++)
                    {
                        for (int j = 0; j < Math.Min(dataGridView1.Columns.Count, 4); j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                            {
                                range.Cells[i + 1, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                range.Cells[i + 1, j + 1].Value = "";
                            }
                        }
                    }

                    Excel.Range productRange = worksheet.Range["C9", "C18"];

                    // Create a new worksheet for the chart
                    Excel.Worksheet chartSheet = workbook.Sheets.Add();
                    chartSheet.Name = "Chart";

                    // Add chart to the new worksheet
                    Excel.ChartObjects chartObjects = (Excel.ChartObjects)chartSheet.ChartObjects(Type.Missing);
                    Excel.ChartObject chartObject = chartObjects.Add(50, 50, 600, 300);
                    Excel.Chart chart = chartObject.Chart;

                    // Set data source for the chart
                    Excel.Range chartRange = worksheet.Range["E9", "F18"]; // Assuming Quantity is in column E and Price is in column F
                    chart.SetSourceData(chartRange);

                    // Set category labels (product names) for the chart
                    chart.Axes(Excel.XlAxisType.xlCategory).CategoryNames = productRange;

                    // Set chart type
                    chart.ChartType = Excel.XlChartType.xlColumnClustered;

                    // Set axis labels for Quantity and Price
                    chart.Axes(Excel.XlAxisType.xlCategory).HasTitle = true;
                    chart.Axes(Excel.XlAxisType.xlCategory).AxisTitle.Text = "Product";
                    chart.Axes(Excel.XlAxisType.xlValue).HasTitle = true;
                    chart.Axes(Excel.XlAxisType.xlValue).AxisTitle.Text = "Quantity and Price";

                    // Set series names
                    foreach (Excel.Series series in chart.SeriesCollection())
                    {
                        if (series.Name == "Series1")
                        {
                            series.Name = "Price";
                        }
                        else if (series.Name == "Series2")
                        {
                            series.Name = "Quantity";
                        }
                    }

                    worksheet.Range["C23"].Value = DateTime.Now;

                    // Save the changes and close the workbook
                    workbook.Save();
                    workbook.Close();
                    excelApp.Quit();

                    MessageBox.Show("Data and chart inserted into Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No data to export!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                // Load the selected file into pictureBox1
                pictureBox1.ImageLocation = ((OpenFileDialog)sender).FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private void product_form_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
