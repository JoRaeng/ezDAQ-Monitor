using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace YG
{
    public class Excel_Class
    {
        private Form1 form = null;
        static Excel.Application excel = null;
        static Workbook wb = null;
        static Worksheet ws = null;
        public string file_name = "";
        string folder_location = System.Windows.Forms.Application.StartupPath;
        private List<float> x = new List<float>();
        private List<float> y_v = new List<float>();
        private List<float> y_c = new List<float>();

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
            var chartObject2 = charts2.Add(240, 310, 100 + form.get_x().Count * 10, 300);
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
            if (file_name == "")
            {
                file_name = "ezDAQ-Monitor" + DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            }
            FolderBrowserDialog folder_dialog = new FolderBrowserDialog();

            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                file_name = folder_dialog.SelectedPath + file_name;
                wb.SaveAs(file_name, XlFileFormat.xlWorkbookDefault);
            }
        }

        public void read_excel()
        {
            OpenFileDialog folder_dialog = new OpenFileDialog();
            folder_dialog.InitialDirectory = ".";
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                //선택한 파일 경로
                file_name = folder_dialog.FileName;
                //이름이 null이 아니고 파일 타입이 .xlsx인 경우에만 실행
                if (file_name != null && file_name.EndsWith(".xlsx"))
                {
                    excel = new Excel.Application();                             // 엑셀 어플리케이션 생성
                    wb = excel.Workbooks.Open(file_name);                       // 워크북 열기
                    ws = wb.Worksheets.get_Item(1) as Excel.Worksheet; // 엑셀 첫번째 워크시트 가져오기
                    form.get_vol_graph().Series[0].Points.Clear();//그래프 초기화하기
                    form.get_cur_graph().Series[0].Points.Clear();


                    Range range = ws.UsedRange;    // 사용중인 셀 범위를 가져오기

                    //row == 1(ms)
                    for (int row = 2; row <= range.Rows.Count; row++)  // 가져온 열 만큼 반복
                    {
                        x.Add((float)(range.Cells[row, 1] as Range).Value2);//x값을 가져온다
                    }
                    //row == 2(V)
                    for (int row = 2; row <= range.Rows.Count; row++)  // 가져온 열 만큼 반복
                    {
                        y_v.Add((float)(range.Cells[row, 2] as Range).Value2);//vol y값을 가져온다.
                        form.get_vol_graph().Series[0].Points.AddXY(x[row-2], y_v[row-2]);//x값과 함께 그래프로 그린다.
                        if (x[row-2] > 10000)
                            form.get_vhscrollbar().Maximum = (int)x[row - 2];//스크롤바 범위를 넘어가면 늘려준다.
                    }
                    //row == 3(mA)
                    for (int row = 2; row <= range.Rows.Count; row++)  // 가져온 열 만큼 반복
                    {
                        y_c.Add((float)(range.Cells[row, 3] as Range).Value2);//cur y값을 가져온다.
                        form.get_cur_graph().Series[0].Points.AddXY(x[row - 2], y_c[row - 2]);//x값과 함께 그래프로 그린다.
                        if (x[row - 2] > 10000)
                            form.get_chscrollbar().Maximum = (int)x[row - 2];//스크롤바 범위를 넘어가면 늘려준다.
                    }
                    form.set_x(x);
                    form.set_y_v(y_v);
                    form.set_y_c(y_c);
                }
            }
        }
    }
}
