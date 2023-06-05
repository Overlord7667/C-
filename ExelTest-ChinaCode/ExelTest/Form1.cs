using System;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExelTest
{
    public partial class Form1 : Form
    {
        Excel.Application application;
        public Form1()
        {
            InitializeComponent();
            application = new Excel.Application();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Workbook workbook = application.Workbooks.Add();
            try
            {
                Excel.Series series;
                Excel.Worksheet sheet = application.Worksheets[1];
                Random random = new Random();

                for (int i = 1; i <= 7; i++)
                {
                    sheet.Cells[1, i] = random.Next(15);
                }

                ////////////////////////////////////////
                Excel.Range range = sheet.Cells[1, 1];
                Excel.Range range1 = sheet.Cells[2, 2];
                Excel.Range range2 = sheet.Cells[3, 3];
                Excel.Range range3 = sheet.Cells[4, 4];
                Excel.Range range4 = sheet.Cells[5, 3];
                Excel.Range range5 = sheet.Cells[6, 2];
                Excel.Range range6 = sheet.Cells[7, 1];
                Excel.Range range7 = sheet.Cells[3, 5];
                Excel.Range range8 = sheet.Cells[2, 6];
                Excel.Range range9 = sheet.Cells[1, 7];
                Excel.Range range10 = sheet.Cells[5, 5];
                Excel.Range range11 = sheet.Cells[6, 6];
                Excel.Range range12 = sheet.Cells[7, 7];
                ////////////////////////////////////////////////////////
                
                /////////////////////////////////////////////////////////
                range.Interior.Color = ColorTranslator.ToOle(Color.Red);
                range1.Interior.Color = ColorTranslator.ToOle(Color.Red);
                range2.Interior.Color = ColorTranslator.ToOle(Color.Red);
                range3.Interior.Color = ColorTranslator.ToOle(Color.Red);
                range4.Interior.Color = ColorTranslator.ToOle(Color.Red);
                range5.Interior.Color = ColorTranslator.ToOle(Color.Red);
                range6.Interior.Color = ColorTranslator.ToOle(Color.Red);
                range7.Interior.Color = ColorTranslator.ToOle(Color.Red);
                range8.Interior.Color = ColorTranslator.ToOle(Color.Red);
                range9.Interior.Color = ColorTranslator.ToOle(Color.Red);
                range10.Interior.Color = ColorTranslator.ToOle(Color.Red);
                range11.Interior.Color = ColorTranslator.ToOle(Color.Red);
                range12.Interior.Color = ColorTranslator.ToOle(Color.Red);
                //////////////////////////////////////////////////////////

                /////////////////////////////////////////////////////////
                Excel.Range begin = sheet.Cells[1, 2];
                Excel.Range end = sheet.Cells[1, 6];
                Excel.Range range13 = sheet.Range[begin, end];
                Excel.Range begin1 = sheet.Cells[2, 3];
                Excel.Range end1 = sheet.Cells[2, 5];
                Excel.Range range14 = sheet.Range[begin1, end1];
                Excel.Range range15 = sheet.Cells[3, 4];

                Excel.Range range16 = sheet.Cells[2, 1];
                Excel.Range begin2 = sheet.Cells[3, 1];
                Excel.Range end2 = sheet.Cells[3, 2];
                Excel.Range range17 = sheet.Range[begin2, end2];
                Excel.Range begin3 = sheet.Cells[4, 1];
                Excel.Range end3 = sheet.Cells[4, 3];
                Excel.Range range18 = sheet.Range[begin3, end3];
                Excel.Range begin4 = sheet.Cells[5, 1];
                Excel.Range end4 = sheet.Cells[5, 2];
                Excel.Range range19 = sheet.Range[begin4, end4];
                Excel.Range range20 = sheet.Cells[6, 1];
                ////////////////////////////////////////////////////////////
                
                /////////////////////////////////////////////////////////////
                range13.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range14.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range15.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range16.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range17.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range18.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range19.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range20.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                /////////////////////////////////////////////////////////////

                /////////////////////////////////////////////////////////////
                Excel.Range begin5 = sheet.Cells[3, 6];
                Excel.Range end5 = sheet.Cells[3, 7];
                Excel.Range range21 = sheet.Range[begin5, end5];
                Excel.Range begin6 = sheet.Cells[4, 5];
                Excel.Range end6 = sheet.Cells[4, 7];
                Excel.Range range22 = sheet.Range[begin6, end6];
                Excel.Range range23 = sheet.Cells[2, 7];
                Excel.Range begin7 = sheet.Cells[5, 6];
                Excel.Range end7 = sheet.Cells[5, 7];
                Excel.Range range24 = sheet.Range[begin7, end7];
                Excel.Range range25 = sheet.Cells[6, 7];

                Excel.Range range26 = sheet.Cells[5, 4];
                Excel.Range begin8 = sheet.Cells[6, 3];
                Excel.Range end8 = sheet.Cells[6, 5];
                Excel.Range range27 = sheet.Range[begin8, end8];
                Excel.Range begin9 = sheet.Cells[7, 2];
                Excel.Range end9 = sheet.Cells[7, 6];
                Excel.Range range28 = sheet.Range[begin9, end9];
                ////////////////////////////////////////////////////////////

                /////////////////////////////////////////////////////////////
                range21.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range22.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range23.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range24.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range25.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range26.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range27.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                range28.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                /////////////////////////////////////////////////////////////

                Excel.Chart chart = workbook.Charts.Add();
                chart.ChartType = Excel.XlChartType.xlLineMarkers;

                series = chart.SeriesCollection(1);
                series.Values = range; //(Excel.Range)sheet.Range["A1:A5"];

                chart.Activate();
                chart.Location(Excel.XlChartLocation.xlLocationAsObject, "Лист1");
                sheet.Shapes.Item(1).Left = 1;
                sheet.Shapes.Item(1).Top = 125;
                //MessageBox.Show(range.Address);
                //for (int i = 1; i <= 10; i++)
                //{
                //    sheet.Cells[i, 2].Formula = String.Format("=SUM({0})", range.Address);
                //    sheet.Cells[i, 2].FormulaHidden = true;
                //    sheet.Cells[i, 2].Calculate();
                //}
                workbook.SaveAs("D:\\ExcelTest.xlsx");
                workbook.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                workbook.Close();
            }
        }
    }
}
