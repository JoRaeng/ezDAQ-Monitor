using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace YG
{
    internal class Excel_Class
    {
        private Form1 form = null;
        static Excel.Application excel = null;
        static Workbook wb = null;
        static Worksheet ws = null;

        public Excel_Class(Form1 form)
        {
            this.form = form;
        }

        public void save_as_excel()
        {
            excel = new Excel.Application(); //엑셀 생성
            wb = excel.Workbooks.Add(); //워크북 추가
            ws = wb.Worksheets.get_Item(1) as Worksheet; //첫번째 워크시트 가져오기

            draw_chart();
            ws.Columns.AutoFit();
            save_excel();
            wb.Close(true);
            excel.Quit();
        }

        private void draw_chart()
        {
            //엑셀 그래프 그릴 임시 시트 입력하기

            ws.Cells[1, 1] = "ms";
            ws.Cells[1, 2] = "V";
            ws.Cells[1, 3] = "mA";

            //저장할 ms 데이터 가져오기
            List<float> ms = form.get_x();
            //셀에 데이터 입력
            for (int i = 0; i < ms.Count; i++)
            {
                ws.Cells[i + 2, 1] = ms[i];
            }
            List<float> v = form.get_y_v();
            for (int i = 0; i < v.Count; i++)
            {
                ws.Cells[i + 2, 2] = v[i];
            }
            List<float> c = form.get_y_c();
            for (int i = 0; i < c.Count; i++)
            {
                ws.Cells[i + 2, 3] = c[i];
            }

            //v그래프 그리기
            var workbook = excel.Workbooks[1];
            var worksheet = workbook.Worksheets[1] as Worksheet;

            // Add chart.
            var charts = worksheet.ChartObjects() as ChartObjects;
            var chartObject = charts.Add(240, 10, 100 + form.get_x().Count * 10, 300);
            var chart = chartObject.Chart;
            // Set chart range 
            string lu_v = "B2";
            string rb_v = "B" + form.get_x().Count.ToString();
            var range = worksheet.get_Range(lu_v, rb_v);
            string top = "A2";
            string bottom = "A" + form.get_x().Count.ToString();
            var xrange = worksheet.get_Range(top, bottom);
            chart.SetSourceData(range);

            // Set chart properties.
            chart.ChartType = XlChartType.xlLine;
            chart.ChartWizard(Source: range,
                CategoryTitle: "ms",
                ValueTitle: "V");
            Excel.Series series = (Excel.Series)chart.SeriesCollection(1);
            series.XValues = xrange;
            //c그래프 그리기
            var workbook2 = excel.Workbooks[1];
            var worksheet2 = workbook2.Worksheets[1] as Worksheet;

            // Add chart.
            var charts2 = worksheet2.ChartObjects() as ChartObjects;
            var chartObject2 = charts2.Add(240, 310,100 +form.get_x().Count * 10, 300);
            var chart2 = chartObject2.Chart;
            // Set chart range.
            string lu_c = "C2";
            string rb_c = "C" + form.get_x().Count.ToString();
            var range2 = worksheet2.get_Range(lu_c, rb_c);
            chart2.SetSourceData(range2);

            // Set chart properties.
            chart2.ChartType = XlChartType.xlLine;
            chart2.ChartWizard(Source: range2,
                CategoryTitle: "ms",
                ValueTitle: "mA");

            Excel.Series series2 = (Excel.Series)chart2.SeriesCollection(1);
            series2.XValues = xrange;
        }
        private void save_excel()
        {
            string file_name;
            SaveFileDialog file_dialog = new SaveFileDialog();
            file_dialog.OverwritePrompt = true;

            if(file_dialog.ShowDialog() == DialogResult.OK)
            {
                file_name = file_dialog.FileName;
                wb.SaveAs(file_name, XlFileFormat.xlWorkbookDefault);
            }
        }
    }

    
}
