using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace YG
{
    public partial class Form1 : Form
    {
        //그래프 그릴 배열
        private List<float> x = new List<float>();
        private List<float> y_v = new List<float>();
        private List<float> y_c = new List<float>();
        //그래프 라벨
        Label[] xl_v = new Label[11];
        Label[] xl_c = new Label[11];
        Label[] yl_v = new Label[6];
        Label[] yl_c = new Label[6];
        //arpt 시작 후 경과된 시간
        private int tm = 0;
        //autoRange
        private bool vol_x_auto_range = true;
        private bool cur_x_auto_range = true;
        private bool vol_y_auto_range = true;
        private bool cur_y_auto_range = true;
        //arpt 간격
        private int arpt = 0;
        //ShowLabel
        private bool show_label_v = false;
        private bool show_label_c = false;
        //그래프 객체
        Graph graph = null;

        public Form1()
        {
            InitializeComponent();
            graph = new Graph(this);
            vol_graph.ChartAreas[0].AxisX.IsMarginVisible = false;
            cur_graph.ChartAreas[0].AxisX.IsMarginVisible = false;
            marker_v.Parent = vol_graph;
            marker_v.Visible = false;
            marker_c.Parent = cur_graph;
            marker_c.Visible = false;
            round_marker_v.Parent = vol_graph;
            round_marker_v.Visible = false;
            round_marker_c.Parent = cur_graph;
            round_marker_c.Visible = false;
            //그래프 격자만 보이게 하기
            vol_graph.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            vol_graph.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            vol_graph.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.DimGray;
            vol_graph.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            vol_graph.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            vol_graph.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DimGray;
            cur_graph.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            cur_graph.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            cur_graph.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.DimGray;
            cur_graph.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            cur_graph.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            cur_graph.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DimGray;
            //x_v label
            xl_v1.Parent = vol_graph;
            xl_v1.Location = new Point(74, 125);
            xl_v2.Parent = vol_graph;
            xl_v2.Location = new Point(130, 125);
            xl_v3.Parent = vol_graph;
            xl_v3.Location = new Point(186, 125);
            xl_v4.Parent = vol_graph;
            xl_v4.Location = new Point(242, 125);
            xl_v5.Parent = vol_graph;
            xl_v5.Location = new Point(298, 125);
            xl_v6.Parent = vol_graph;
            xl_v6.Location = new Point(354, 125);
            xl_v7.Parent = vol_graph;
            xl_v7.Location = new Point(410, 125);
            xl_v8.Parent = vol_graph;
            xl_v8.Location = new Point(466, 125);
            xl_v9.Parent = vol_graph;
            xl_v9.Location = new Point(522, 125);
            xl_v10.Parent = vol_graph;
            xl_v10.Location = new Point(578, 125);
            xl_v11.Parent = vol_graph;
            xl_v11.Location = new Point(632, 125);
            xl_v[0] = xl_v1;
            xl_v[1] = xl_v2;
            xl_v[2] = xl_v3;
            xl_v[3] = xl_v4;
            xl_v[4] = xl_v5;
            xl_v[5] = xl_v6;
            xl_v[6] = xl_v7;
            xl_v[7] = xl_v8;
            xl_v[8] = xl_v9;
            xl_v[9] = xl_v10;
            xl_v[10] = xl_v11;
            //y_v label
            yl_v1.Parent = vol_graph;
            yl_v1.Location = new Point(40, 118);
            yl_v2.Parent = vol_graph;
            yl_v2.Location = new Point(40, 95);
            yl_v3.Parent = vol_graph;
            yl_v3.Location = new Point(40, 72);
            yl_v4.Parent = vol_graph;
            yl_v4.Location = new Point(40, 49);
            yl_v5.Parent = vol_graph;
            yl_v5.Location = new Point(40, 26);
            yl_v6.Parent = vol_graph;
            yl_v6.Location = new Point(40, 3);
            yl_v[0] = yl_v1;
            yl_v[1] = yl_v2;
            yl_v[2] = yl_v3;
            yl_v[3] = yl_v4;
            yl_v[4] = yl_v5;
            yl_v[5] = yl_v6;
            //x_c label
            xl_c1.Parent = cur_graph;
            xl_c1.Location = new Point(74, 125);
            xl_c2.Parent = cur_graph;
            xl_c2.Location = new Point(130, 125);
            xl_c3.Parent = cur_graph;
            xl_c3.Location = new Point(186, 125);
            xl_c4.Parent = cur_graph;
            xl_c4.Location = new Point(242, 125);
            xl_c5.Parent = cur_graph;
            xl_c5.Location = new Point(298, 125);
            xl_c6.Parent = cur_graph;
            xl_c6.Location = new Point(354, 125);
            xl_c7.Parent = cur_graph;
            xl_c7.Location = new Point(410, 125);
            xl_c8.Parent = cur_graph;
            xl_c8.Location = new Point(466, 125);
            xl_c9.Parent = cur_graph;
            xl_c9.Location = new Point(522, 125);
            xl_c10.Parent = cur_graph;
            xl_c10.Location = new Point(578, 125);
            xl_c11.Parent = cur_graph;
            xl_c11.Location = new Point(632, 125);
            xl_c[0] = xl_c1;
            xl_c[1] = xl_c2;
            xl_c[2] = xl_c3;
            xl_c[3] = xl_c4;
            xl_c[4] = xl_c5;
            xl_c[5] = xl_c6;
            xl_c[6] = xl_c7;
            xl_c[7] = xl_c8;
            xl_c[8] = xl_c9;
            xl_c[9] = xl_c10;
            xl_c[10] = xl_c11;
            //y_c label
            yl_c1.Parent = cur_graph;
            yl_c1.Location = new Point(40, 118);
            yl_c2.Parent = cur_graph;
            yl_c2.Location = new Point(40, 95);
            yl_c3.Parent = cur_graph;
            yl_c3.Location = new Point(40, 72);
            yl_c4.Parent = cur_graph;
            yl_c4.Location = new Point(40, 49);
            yl_c5.Parent = cur_graph;
            yl_c5.Location = new Point(40, 26);
            yl_c6.Parent = cur_graph;
            yl_c6.Location = new Point(40, 3);
            yl_c[0] = yl_c1;
            yl_c[1] = yl_c2;
            yl_c[2] = yl_c3;
            yl_c[3] = yl_c4;
            yl_c[4] = yl_c5;
            yl_c[5] = yl_c6;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSerialPorts();
        }

        private void rescan_c_Click(object sender, EventArgs e)
        {
            GetSerialPorts();
        }

        public void GetSerialPorts()
        {
            string[] port = SerialPort.GetPortNames();
            cbPort.Items.Clear();
            foreach (string portName in port)
            {
                cbPort.Items.Add(portName);
            }
        }

        private void connect_c_Click(object sender, EventArgs e)
        {
            if (cbPort.Text.Length != 0)
            {
                serialPort1.PortName = cbPort.Text;
                serialPort1.Open();
            }
            if (serialPort1.IsOpen)
            {
                connect_c.BackColor = Color.Lime;
                disconnect_c.BackColor = Color.Silver;
            }
        }

        private void disconnect_c_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (!serialPort1.IsOpen)
            {
                connect_c.BackColor = Color.Silver;
                disconnect_c.BackColor = Color.Lime;
            }
        }

        private void quit_c_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke(new EventHandler(recieve_data));
        }

        private void recieve_data(object s, EventArgs e)
        {
            string received_data = serialPort1.ReadExisting();
            if (received_data.Length != 0)
            {
                board_c.AppendText(received_data + "\n");
                if (received_data.Substring(0, 6) == ">MEAS:")
                {
                    //값 display
                    string tmp = received_data.Substring(5);
                    string[] temp = tmp.Split(',');
                    //VOL
                    temp[2] = temp[2].Replace(" ", string.Empty);
                    while (temp[2].Length < 4)
                    {
                        temp[2] = '0' + temp[2];
                    }
                    VOL.Text = temp[2].Substring(0, temp[2].Length - 3) + "." + temp[2].Substring(temp[2].Length - 3);

                    //CUR
                    temp[1] = temp[1].Replace(" ", string.Empty);
                    while (temp[1].Length < 4)
                    {
                        temp[1] = '0' + temp[1];
                    }
                    CUR.Text = temp[1].Substring(0, temp[1].Length - 3) + "." + temp[1].Substring(temp[1].Length - 3);
                }
                if (received_data.Substring(0, 6) == ">ARPT:")
                {
                    x.Add(tm);
                    CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                    ci.NumberFormat.CurrencyDecimalSeparator = ".";
                    string tmp = received_data.Substring(5);
                    string[] temp = tmp.Split(',');
                    //VOL
                    temp[3] = temp[3].Replace(" ", string.Empty);
                    while (temp[3].Length < 4)
                    {
                        temp[3] = '0' + temp[3];
                    }
                    VOL.Text = temp[3].Substring(0, temp[3].Length - 3) + "." + temp[3].Substring(temp[3].Length - 3);
                    //그래프 vol y값 입력
                    vol_graph.Series[0].Points.AddXY(tm, float.Parse(VOL.Text, NumberStyles.Any, ci));
                    y_v.Add(float.Parse(VOL.Text, NumberStyles.Any, ci));
                    
                    graph.draw_v_graph();

                    //CUR
                    temp[2] = temp[2].Replace(" ", string.Empty);
                    while (temp[2].Length < 4)
                    {
                        temp[2] = '0' + temp[2];
                    }
                    CUR.Text = temp[2].Substring(0, temp[2].Length - 3) + "." + temp[2].Substring(temp[2].Length - 3);
                    //그래프 cur y값 입력
                    cur_graph.Series[0].Points.AddXY(tm, float.Parse(CUR.Text, NumberStyles.Any, ci));
                    y_c.Add(float.Parse(CUR.Text, NumberStyles.Any, ci));
                    

                    graph.draw_c_graph();
                    //시간 설정
                    tm += arpt;
                }
            }
        }

        private void command_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (serialPort1.IsOpen)
                {
                    board_c.AppendText("<" + command.Text + "\r\n");
                    serialPort1.Write(command.Text + "\r");
                    command.Clear();
                }
            }
        }
        //arpt 숫자 외 입력 안받기
        private void arpt_valeu_keykress(object sender, KeyPressEventArgs e)
        {
            // 숫자와 백스페이스를 제외한 모든 키 입력 무시
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //arpt 버튼 클릭
        private void arpt_start_click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                arpt =  int.Parse(arpt_value.Text.ToString());
                board_c.AppendText("<" + "ARPT:" + arpt.ToString() + "\r\n");
                serialPort1.Write("ARPT:" + arpt.ToString() + "\r");
            }
        }
        

        private void arpt_0_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                arpt = 0;
                board_c.AppendText("<" + "ARPT:0\r\n");
                serialPort1.Write("ARPT:0\r");
            }
        }

        private void meas_q_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                board_c.AppendText("<" + "?MEAS:\r\n");
                serialPort1.Write("?MEAS:\r");
            }
        }

        private void irange_0_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                board_c.AppendText("<" + "IRANGE:0\r\n");
                serialPort1.Write("IRANGE:0\r");
            }
        }

        private void irange_1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                board_c.AppendText("<" + "IRANGE:1\r\n");
                serialPort1.Write("IRANGE:1\r");
            }
        }

        private void vhScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            vol_x_auto_range = false;
            is_vol_x_auto_range.BackColor = Color.Gray;
            graph.scroll_v(true);
        }

        private void vvScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            vol_x_auto_range = false;
            vol_y_auto_range = false;
            is_vol_x_auto_range.BackColor = Color.Gray;
            is_cur_y_auto_range.BackColor = Color.Gray;
            graph.scroll_v(false);
        }

        private void chScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            cur_x_auto_range = false;
            is_cur_x_auto_range.BackColor = Color.Gray;
            graph.scroll_c(true);
        }

        private void cvScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            cur_x_auto_range = false;
            cur_y_auto_range = false;
            is_cur_x_auto_range.BackColor = Color.Gray;
            is_cur_y_auto_range.BackColor = Color.Gray;
            graph.scroll_c(false);
        }
        //wheel
        public void vol_graph_wheel(object sender, MouseEventArgs e)
        {
            vol_x_auto_range = false;
            vol_y_auto_range = false;
            is_vol_x_auto_range.BackColor = Color.Gray;
            is_vol_y_auto_range.BackColor = Color.Gray;
            if (e.X >= 83 && e.Y <= 122)//그래프
            {
                if (e.Delta < 0) //Scroll Down
                {
                    graph.scroll_down_v(e.X, e.Y);
                }
                else if (e.Delta > 0) //Scroll up
                {
                    graph.scroll_up_v(e.X, e.Y);
                }
            }
            else if( e.X < 83 && e.Y <= 122)//y축 방향
            {
                
                if (e.Delta < 0) //Scroll Down
                {
                    graph.scroll_down_y(e.X, e.Y, true);
                }
                else if (e.Delta > 0) //Scroll up
                {
                    graph.scroll_up_y(e.X, e.Y, true);
                }
            }
            else if(e.X >= 83 && e.Y > 122)//x축 방향
            {
                if (e.Delta < 0) //Scroll Down
                {
                    graph.scroll_down_x(e.X, e.Y, true);
                }
                else if (e.Delta > 0) //Scroll up
                {
                    graph.scroll_up_x(e.X, e.Y, true);
                }
            }
        }

        public void cur_graph_wheel(object sender, MouseEventArgs e)
        {
            cur_x_auto_range = false;
            is_cur_x_auto_range.BackColor = Color.Gray;
            cur_y_auto_range = false;
            is_vol_y_auto_range.BackColor = Color.Gray;
            if (e.X >= 83 && e.Y <= 122)
            {
                if (e.Delta < 0) //Scroll Down
                {
                    graph.scroll_down_c(e.X, e.Y);
                }
                else if (e.Delta > 0) //Scroll up
                {
                    graph.scroll_up_c(e.X, e.Y);
                }
            }
            else if (e.X < 83 && e.Y <= 122)//y축 방향
            {

                if (e.Delta < 0) //Scroll Down
                {
                    graph.scroll_down_y(e.X, e.Y, false);
                }
                else if (e.Delta > 0) //Scroll up
                {
                    graph.scroll_up_y(e.X, e.Y, false);
                }
            }
            else if (e.X >= 83 && e.Y > 122)//x축 방향
            {
                if (e.Delta < 0) //Scroll Down
                {
                    graph.scroll_down_x(e.X, e.Y, false);
                }
                else if (e.Delta > 0) //Scroll up
                {
                    graph.scroll_up_x(e.X, e.Y, false);
                }
            }
        }

        
        //autoRange 조절
        private void is_vol_auto_range_Click(object sender, EventArgs e)
        {
            if (vol_x_auto_range)
            {
                vol_x_auto_range = false;
                is_vol_x_auto_range.BackColor = Color.Gray;
            }
            else
            {
                vol_x_auto_range= true;
                is_vol_x_auto_range.BackColor = Color.Lime;
            }
        }

        private void is_cur_auto_range_Click(object sender, EventArgs e)
        {
            if (cur_x_auto_range)
            {
                cur_x_auto_range = false;
                is_cur_x_auto_range.BackColor = Color.Gray;
            }
            else
            {
                cur_x_auto_range = true;
                is_cur_x_auto_range.BackColor = Color.Lime;
            }
        }

        private void is_vol_y_auto_range_Click(object sender, EventArgs e)
        {
            if (vol_y_auto_range)
            {
                vol_y_auto_range = false;
                is_vol_y_auto_range.BackColor = Color.Gray;
            }
            else
            {
                vol_y_auto_range = true;
                is_vol_y_auto_range.BackColor = Color.Lime;
            }
        }

        private void is_cur_y_auto_range_Click(object sender, EventArgs e)
        {
            if (cur_y_auto_range)
            {
                cur_y_auto_range = false;
                is_cur_y_auto_range.BackColor = Color.Gray;
            }
            else
            {
                cur_y_auto_range = true;
                is_cur_y_auto_range.BackColor = Color.Lime;
            }
        }

        //save log as excel
        private void save_log_Click(object sender, EventArgs e)
        {
            Excel_Class excel = new Excel_Class(this);
            excel.save_as_excel();
        }


        //drag graph controll
        private void vol_graph_mouse_down(object sender, MouseEventArgs e)
        {
            vol_x_auto_range = false;
            is_vol_x_auto_range.BackColor = Color.Gray;
            vol_y_auto_range = false;
            is_vol_y_auto_range.BackColor = Color.Gray;
            graph.mouse_down(sender, e, true);
        }
        private void vol_graph_mouse_move(object sender, MouseEventArgs e)
        {
            graph.mouse_move(sender, e, true);
        }
        private void vol_graph_mouse_up(object sender, MouseEventArgs e)
        {
            graph.mouse_up(sender, e, true);
        }
        private void cur_graph_mouse_down(object sender, MouseEventArgs e)
        {
            cur_x_auto_range = false;
            is_cur_x_auto_range.BackColor = Color.Gray;
            cur_y_auto_range = false;
            is_cur_y_auto_range.BackColor = Color.Gray;
            graph.mouse_down(sender, e, false);
        }
        private void cur_graph_mouse_move(object sender, MouseEventArgs e)
        {
            graph.mouse_move(sender.GetType(), e, false);
        }
        private void cur_graph_mouse_up(object sender, MouseEventArgs e)
        {
            graph.mouse_up(sender, e, false);
        }
        private void mouse_up(object sender, MouseEventArgs e)
        {
            graph.mouse_up(sender, e);
        }
        private void mouse_leave(object sender, EventArgs e)
        {
            graph.mouse_leave(sender, e);
        }

        //Marker
        private void show_v_label_Click(object sender, EventArgs e)
        {
            if (show_label_v)
            {
                vol_marker_hide();
            }
            else
            {
                show_label_v = true;
                show_v_label.BackColor = Color.Lime;
                marker_v.Visible = true;
                round_marker_v.Visible = true;
                graph.set_marker(marker_bar_v.Value, true);
            }
        }
        private void label_bar_v_value_changed(object sender, EventArgs e)
        {
            if (show_label_v)
            {
                marker_v.Visible = true;
                round_marker_v.Visible = true;
                graph.set_marker(marker_bar_v.Value, true);
            }
        }
        public void vol_marker_hide()
        {
            show_label_v = false;
            show_v_label.BackColor = Color.Gray;
            marker_v.Visible = false;
            round_marker_v.Visible = false;
        }
        public void vol_graph_click(object sender, MouseEventArgs e)
        {
            if (show_label_v)
            {
                show_v_label.BackColor = Color.Lime;
                marker_v.Visible = true;
                round_marker_v.Visible = true;
                graph.clilck_marker_v(e.X, e.Y);
            }
        }
        public void vol_marker_click(object sender, MouseEventArgs e)
        {
            if (show_label_v)
            {
                show_v_label.BackColor = Color.Lime;
                marker_v.Visible = true;
                round_marker_v.Visible = true;
                graph.clilck_marker_v(e.X + marker_v.Location.X, e.Y + marker_v.Location.Y);
            }
        }

        private void show_c_label_Click(object sender, EventArgs e)
        {
            if (show_label_c)
            {
                cur_marker_hide();
            }
            else
            {
                show_label_c = true;
                show_c_label.BackColor = Color.Lime;
                marker_c.Visible = true;
                round_marker_c.Visible = true;
                graph.set_marker(marker_bar_c.Value, false);
            }
        }
        private void label_bar_c_value_changed(object sender, EventArgs e)
        {
            if (show_label_c)
            {
                marker_c.Visible = true;
                round_marker_c.Visible = true;
                graph.set_marker(marker_bar_c.Value, false);
            }
        }
        public void cur_marker_hide()
        {
            show_label_c = false;
            show_c_label.BackColor = Color.Gray;
            marker_c.Visible = false;
            round_marker_c.Visible = false;
        }
        public void cur_graph_click(object sender, MouseEventArgs e)
        {
            if (show_label_c)
            {
                show_c_label.BackColor = Color.Lime;
                marker_c.Visible = true;
                round_marker_c.Visible = true;
                graph.clilck_marker_c(e.X, e.Y);
            }
        }
        public void cur_marker_click(object sender, MouseEventArgs e)
        {
            if (show_label_v)
            {
                show_c_label.BackColor = Color.Lime;
                marker_c.Visible = true;
                round_marker_c.Visible = true;
                graph.clilck_marker_c(e.X + marker_c.Location.X, e.Y + marker_c.Location.Y);
            }
        }


        //get
        public List<float> get_x()
        {
            return x;
        }

        public List<float> get_y_v()
        {
            return y_v;
        }

        public List<float> get_y_c()
        {
            return y_c;
        }
        public float get_tm()
        {
            return tm;
        }

        public int get_arpt()
        {
            return arpt;
        }

        public bool get_vol_x_auto_range()
        {
            return vol_x_auto_range;
        }

        public bool get_cur_x_auto_range()
        {
            return cur_x_auto_range;
        }

        public bool get_vol_y_auto_range()
        {
            return vol_y_auto_range;
        }

        public bool get_cur_y_auto_range()
        {
            return cur_y_auto_range;
        }

        public Chart get_vol_graph()
        {
            return vol_graph;
        }

        public Chart get_cur_graph()
        {
            return cur_graph;
        }

        public TextBox get_board_c()
        {
            return board_c;
        }

        public ScrollBar get_vhscrollbar()
        {
            return vhScrollBar;
        }
        public ScrollBar get_vvscrollbar()
        {
            return vvScrollBar;
        }
        public ScrollBar get_chscrollbar()
        {
            return chScrollBar;
        }
        public ScrollBar get_cvscrollbar()
        {
            return cvScrollBar;
        }
        public TrackBar get_marker_bar_v()
        {
            return marker_bar_v;
        }
        public TrackBar get_marker_bar_c()
        {
            return marker_bar_c;
        }
        public Label get_marker_v()
        {
            return marker_v;
        }
        public Label get_marker_c()
        {
            return marker_c;
        }
        public Label get_round_marker_v()
        {
            return round_marker_v;
        }
        public Label get_round_marker_c()
        {
            return round_marker_c;
        }
        public Label[] get_xl_v()
        {
            return xl_v;
        }
        public Label[] get_xl_c()
        {
            return xl_c;
        }
        public Label[] get_yl_v()
        {
            return yl_v;
        }
        public Label[] get_yl_c()
        {
            return yl_c;
        }
        //set
        public void set_marker_bar_v(int num)
        {
            if (num >= marker_bar_v.Minimum && num <= marker_bar_v.Maximum)
            {
                marker_bar_v.Value = num;
            }
        }
        public void set_marker_bar_c(int num)
        {
            if (num >= marker_bar_c.Minimum && num <= marker_bar_c.Maximum)
            {
                marker_bar_c.Value = num;
            }
        }

        //test
        private void test_Click(object sender, EventArgs e)
        {
            if (!test_timer.Enabled)
            {
                arpt = 250;
                test_timer.Start();
                test_c.BackColor = Color.Lime;
            }
            else
            {
                test_timer.Stop();
                test_c.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void test_timer_Tick(object sender, EventArgs e)
        {
            x.Add(tm);

            Random random = new Random();
            y_v.Add(random.Next(84));
            y_c.Add(random.Next(165));
            vol_graph.Series[0].Points.AddXY(tm, y_v[y_v.Count-1]);
            cur_graph.Series[0].Points.AddXY(tm, y_c[y_c.Count - 1]);
            graph.draw_v_graph();
            graph.draw_c_graph();
            tm += arpt;
        }

        
    }



}
