using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.IO;
using System.Collections;
using System.Text;
using System.Web.UI.DataVisualization.Charting;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

namespace PieChart
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        static void InsertDataIntoSQLServerUsingSQLBulkCopy(DataTable csvFileData)
        {
            
           
        }

        protected void GetCSVValue()
        {
        }

        protected DataTable CreateTable()
        {
            // Create a new DataTable.
            DataTable table = new DataTable("TestTable");
            // Declare variables for DataColumn and DataRow objects.
            DataColumn column;
            DataRow row;

            // Create new DataColumn, set DataType, 
            // ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Id";
            column.ReadOnly = true;
            column.Unique = true;
            // Add the Column to the DataColumnCollection.
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Name";
            column.AutoIncrement = false;
            column.Caption = "Name";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            table.Columns.Add(column);

            // Make the ID column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table.Columns["Id"];
            table.PrimaryKey = PrimaryKeyColumns;

            return table;
        }
       private void PhoneNumber(String[]  source)
        {
            int[] array = { 12, 12, 12, 23, 45 };
            var dict = new Dictionary<int, int>();

            foreach (var value in array)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);




        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string inputContent;
                using (StreamReader inputStreamReader = new StreamReader(FileUpload1.PostedFile.InputStream))
                {
                    inputContent = inputStreamReader.ReadToEnd();
                }
               
                String[] line = inputContent.Split('\n');
                int[] PhoneNumber = new int[line.Length];
                // int count = 0;
                
                for (int i = 0; i < line.Length; i++)
                {


                    String[] str = line[i].Split(',');


                    
                    PhoneNumber[i]=Convert.ToInt32(str[0]) ;
                }

                //foreach (String str in line[0].Split(','))
                //{
                //    count++;
                //    Response.Write(str);
                //}
             
                int[] pointsArray = { 1, 2 ,1};

                // Set palette.
                this.ChartPhone.Palette = ChartColorPalette.SeaGreen;

                // Set title.
              //  this.Chart1.Titles.Add("Phone");



                //added
                int[] array = { 12, 12, 12, 23, 45,8,9,10 };
                var dict = new Dictionary<int, int>();

                foreach (var value in PhoneNumber)
                {
                    if (dict.ContainsKey(value))
                        dict[value]++;
                    else
                        dict[value] = 1;
                }
                List<string> Name = new List<string>();
                List<int> values = new List<int>();
                foreach (var pair in dict)
                {
                    // Add series.
                    Name.Add((pair.Key).ToString());
                    //   Series series = this.Chart1.Series.Add((pair.Key).ToString());
                    values.Add(pair.Value);
                    // Add point.
                  //  series.Points.Add(pair.Value);
                }

              DrawPieChart(values,Name,"Phone","Phone Record");

                //added





                // Add series.
                //for (int i = 0; i < PhoneNumber.Length; i++)
                //{
                //    // Add series.
                //    Series series = this.Chart1.Series.Add(PhoneNumber[i].ToString());

                //    // Add point.
                //    series.Points.Add(pointsArray[i]);
                //}

            }
            else
            {
                Response.Write("<p>Pleas insert file</p>");
            }
        }

        private void DrawPieChart(List<int> value,List<String> Name,String Title, String LegendTitle)
        {
            //reset your chart series and legends
            ChartPhone.Series.Clear();
            ChartPhone.Legends.Clear();

            //Add a new Legend(if needed) and do some formating
            this.ChartPhone.Titles.Add(Title);
            ChartPhone.Legends.Add(LegendTitle);
            ChartPhone.Legends[0].LegendStyle = LegendStyle.Table;
            ChartPhone.Legends[0].Docking = Docking.Bottom;
            ChartPhone.Legends[0].Alignment = StringAlignment.Center;
            ChartPhone.Legends[0].Title = Title;
            ChartPhone.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "MySeriesName";
            ChartPhone.Series.Add(seriesname);
            //set the chart-type to "Pie"
            ChartPhone.Series[seriesname].ChartType = SeriesChartType.Pie;

            //Add some datapoints so the series. in this case you can pass the values to this method
            foreach(var nw in value.Zip(Name, Tuple.Create))
            {
                ChartPhone.Series[seriesname].Points.AddXY(nw.Item2, nw.Item1);
                ChartPhone.Series[seriesname].IsValueShownAsLabel = true;
             //   Chart1.Series[seriesname].LabelFormat="#.##%";



            }
        
           
        }
    }
        }
