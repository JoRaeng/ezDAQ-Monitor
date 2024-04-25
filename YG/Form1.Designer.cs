using System.Drawing;

namespace YG
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.connect_c = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.rescan_c = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.command = new System.Windows.Forms.TextBox();
            this.board_c = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.yl_c6 = new System.Windows.Forms.Label();
            this.yl_c5 = new System.Windows.Forms.Label();
            this.yl_c4 = new System.Windows.Forms.Label();
            this.yl_c3 = new System.Windows.Forms.Label();
            this.yl_c2 = new System.Windows.Forms.Label();
            this.yl_c1 = new System.Windows.Forms.Label();
            this.yl_v6 = new System.Windows.Forms.Label();
            this.yl_v5 = new System.Windows.Forms.Label();
            this.yl_v4 = new System.Windows.Forms.Label();
            this.yl_v3 = new System.Windows.Forms.Label();
            this.yl_v2 = new System.Windows.Forms.Label();
            this.yl_v1 = new System.Windows.Forms.Label();
            this.is_cur_x_auto_range = new System.Windows.Forms.Button();
            this.xl_c11 = new System.Windows.Forms.Label();
            this.xl_c10 = new System.Windows.Forms.Label();
            this.xl_c9 = new System.Windows.Forms.Label();
            this.xl_c8 = new System.Windows.Forms.Label();
            this.xl_c7 = new System.Windows.Forms.Label();
            this.xl_c6 = new System.Windows.Forms.Label();
            this.xl_c5 = new System.Windows.Forms.Label();
            this.xl_c4 = new System.Windows.Forms.Label();
            this.xl_c3 = new System.Windows.Forms.Label();
            this.xl_c2 = new System.Windows.Forms.Label();
            this.xl_c1 = new System.Windows.Forms.Label();
            this.xl_v11 = new System.Windows.Forms.Label();
            this.xl_v9 = new System.Windows.Forms.Label();
            this.xl_v8 = new System.Windows.Forms.Label();
            this.xl_v7 = new System.Windows.Forms.Label();
            this.xl_v6 = new System.Windows.Forms.Label();
            this.xl_v5 = new System.Windows.Forms.Label();
            this.xl_v4 = new System.Windows.Forms.Label();
            this.xl_v3 = new System.Windows.Forms.Label();
            this.xl_v2 = new System.Windows.Forms.Label();
            this.xl_v10 = new System.Windows.Forms.Label();
            this.xl_v1 = new System.Windows.Forms.Label();
            this.round_marker_c = new System.Windows.Forms.Label();
            this.round_marker_v = new System.Windows.Forms.Label();
            this.marker_c = new System.Windows.Forms.Label();
            this.show_c_label = new System.Windows.Forms.Button();
            this.marker_bar_c = new System.Windows.Forms.TrackBar();
            this.marker_v = new System.Windows.Forms.Label();
            this.is_cur_y_auto_range = new System.Windows.Forms.Button();
            this.is_vol_y_auto_range = new System.Windows.Forms.Button();
            this.show_v_label = new System.Windows.Forms.Button();
            this.marker_bar_v = new System.Windows.Forms.TrackBar();
            this.is_vol_x_auto_range = new System.Windows.Forms.Button();
            this.cvScrollBar = new System.Windows.Forms.VScrollBar();
            this.chScrollBar = new System.Windows.Forms.HScrollBar();
            this.vhScrollBar = new System.Windows.Forms.HScrollBar();
            this.vvScrollBar = new System.Windows.Forms.VScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.CUR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VOL = new System.Windows.Forms.Label();
            this.cur_graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.vol_graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.quit_c = new System.Windows.Forms.Button();
            this.disconnect_c = new System.Windows.Forms.Button();
            this.arpt_0 = new System.Windows.Forms.Button();
            this.meas_q = new System.Windows.Forms.Button();
            this.irange_0 = new System.Windows.Forms.Button();
            this.irange_1 = new System.Windows.Forms.Button();
            this.test_c = new System.Windows.Forms.Button();
            this.test_timer = new System.Windows.Forms.Timer(this.components);
            this.save_log = new System.Windows.Forms.Button();
            this.arpt_value = new System.Windows.Forms.TextBox();
            this.arpt_start = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marker_bar_c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marker_bar_v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cur_graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vol_graph)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 112500;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // connect_c
            // 
            this.connect_c.BackColor = System.Drawing.Color.Silver;
            this.connect_c.Location = new System.Drawing.Point(190, 61);
            this.connect_c.Name = "connect_c";
            this.connect_c.Size = new System.Drawing.Size(67, 19);
            this.connect_c.TabIndex = 0;
            this.connect_c.Text = "Connect";
            this.connect_c.UseVisualStyleBackColor = false;
            this.connect_c.Click += new System.EventHandler(this.connect_c_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPort);
            this.groupBox1.Location = new System.Drawing.Point(11, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(25, 29);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 20);
            this.cbPort.Sorted = true;
            this.cbPort.TabIndex = 0;
            // 
            // rescan_c
            // 
            this.rescan_c.Location = new System.Drawing.Point(190, 31);
            this.rescan_c.Margin = new System.Windows.Forms.Padding(2);
            this.rescan_c.Name = "rescan_c";
            this.rescan_c.Size = new System.Drawing.Size(67, 19);
            this.rescan_c.TabIndex = 2;
            this.rescan_c.Text = "ReScan";
            this.rescan_c.UseVisualStyleBackColor = true;
            this.rescan_c.Click += new System.EventHandler(this.rescan_c_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.command);
            this.tabPage2.Controls.Add(this.board_c);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Terminal";
            // 
            // command
            // 
            this.command.Location = new System.Drawing.Point(17, 376);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(640, 21);
            this.command.TabIndex = 1;
            this.command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.command_KeyDown);
            // 
            // board_c
            // 
            this.board_c.Location = new System.Drawing.Point(17, 20);
            this.board_c.Multiline = true;
            this.board_c.Name = "board_c";
            this.board_c.ReadOnly = true;
            this.board_c.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.board_c.Size = new System.Drawing.Size(640, 340);
            this.board_c.TabIndex = 0;
            this.board_c.WordWrap = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 508);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.yl_c6);
            this.tabPage1.Controls.Add(this.yl_c5);
            this.tabPage1.Controls.Add(this.yl_c4);
            this.tabPage1.Controls.Add(this.yl_c3);
            this.tabPage1.Controls.Add(this.yl_c2);
            this.tabPage1.Controls.Add(this.yl_c1);
            this.tabPage1.Controls.Add(this.yl_v6);
            this.tabPage1.Controls.Add(this.yl_v5);
            this.tabPage1.Controls.Add(this.yl_v4);
            this.tabPage1.Controls.Add(this.yl_v3);
            this.tabPage1.Controls.Add(this.yl_v2);
            this.tabPage1.Controls.Add(this.yl_v1);
            this.tabPage1.Controls.Add(this.is_cur_x_auto_range);
            this.tabPage1.Controls.Add(this.xl_c11);
            this.tabPage1.Controls.Add(this.xl_c10);
            this.tabPage1.Controls.Add(this.xl_c9);
            this.tabPage1.Controls.Add(this.xl_c8);
            this.tabPage1.Controls.Add(this.xl_c7);
            this.tabPage1.Controls.Add(this.xl_c6);
            this.tabPage1.Controls.Add(this.xl_c5);
            this.tabPage1.Controls.Add(this.xl_c4);
            this.tabPage1.Controls.Add(this.xl_c3);
            this.tabPage1.Controls.Add(this.xl_c2);
            this.tabPage1.Controls.Add(this.xl_c1);
            this.tabPage1.Controls.Add(this.xl_v11);
            this.tabPage1.Controls.Add(this.xl_v9);
            this.tabPage1.Controls.Add(this.xl_v8);
            this.tabPage1.Controls.Add(this.xl_v7);
            this.tabPage1.Controls.Add(this.xl_v6);
            this.tabPage1.Controls.Add(this.xl_v5);
            this.tabPage1.Controls.Add(this.xl_v4);
            this.tabPage1.Controls.Add(this.xl_v3);
            this.tabPage1.Controls.Add(this.xl_v2);
            this.tabPage1.Controls.Add(this.xl_v10);
            this.tabPage1.Controls.Add(this.xl_v1);
            this.tabPage1.Controls.Add(this.round_marker_c);
            this.tabPage1.Controls.Add(this.round_marker_v);
            this.tabPage1.Controls.Add(this.marker_c);
            this.tabPage1.Controls.Add(this.show_c_label);
            this.tabPage1.Controls.Add(this.marker_bar_c);
            this.tabPage1.Controls.Add(this.marker_v);
            this.tabPage1.Controls.Add(this.is_cur_y_auto_range);
            this.tabPage1.Controls.Add(this.is_vol_y_auto_range);
            this.tabPage1.Controls.Add(this.show_v_label);
            this.tabPage1.Controls.Add(this.marker_bar_v);
            this.tabPage1.Controls.Add(this.is_vol_x_auto_range);
            this.tabPage1.Controls.Add(this.cvScrollBar);
            this.tabPage1.Controls.Add(this.chScrollBar);
            this.tabPage1.Controls.Add(this.vhScrollBar);
            this.tabPage1.Controls.Add(this.vvScrollBar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.CUR);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.VOL);
            this.tabPage1.Controls.Add(this.cur_graph);
            this.tabPage1.Controls.Add(this.vol_graph);
            this.tabPage1.Font = new System.Drawing.Font("굴림", 11F);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Graph";
            // 
            // yl_c6
            // 
            this.yl_c6.AutoSize = true;
            this.yl_c6.BackColor = System.Drawing.Color.Transparent;
            this.yl_c6.Font = new System.Drawing.Font("굴림", 9F);
            this.yl_c6.Location = new System.Drawing.Point(37, 379);
            this.yl_c6.Name = "yl_c6";
            this.yl_c6.Size = new System.Drawing.Size(23, 12);
            this.yl_c6.TabIndex = 10048;
            this.yl_c6.Text = "165";
            this.yl_c6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yl_c5
            // 
            this.yl_c5.AutoSize = true;
            this.yl_c5.BackColor = System.Drawing.Color.Transparent;
            this.yl_c5.Font = new System.Drawing.Font("굴림", 9F);
            this.yl_c5.Location = new System.Drawing.Point(22, 379);
            this.yl_c5.Name = "yl_c5";
            this.yl_c5.Size = new System.Drawing.Size(23, 12);
            this.yl_c5.TabIndex = 10047;
            this.yl_c5.Text = "132";
            this.yl_c5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yl_c4
            // 
            this.yl_c4.AutoSize = true;
            this.yl_c4.BackColor = System.Drawing.Color.Transparent;
            this.yl_c4.Font = new System.Drawing.Font("굴림", 9F);
            this.yl_c4.Location = new System.Drawing.Point(8, 379);
            this.yl_c4.Name = "yl_c4";
            this.yl_c4.Size = new System.Drawing.Size(17, 12);
            this.yl_c4.TabIndex = 10046;
            this.yl_c4.Text = "99";
            this.yl_c4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yl_c3
            // 
            this.yl_c3.AutoSize = true;
            this.yl_c3.BackColor = System.Drawing.Color.Transparent;
            this.yl_c3.Font = new System.Drawing.Font("굴림", 9F);
            this.yl_c3.Location = new System.Drawing.Point(37, 363);
            this.yl_c3.Name = "yl_c3";
            this.yl_c3.Size = new System.Drawing.Size(17, 12);
            this.yl_c3.TabIndex = 10045;
            this.yl_c3.Text = "66";
            this.yl_c3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yl_c2
            // 
            this.yl_c2.AutoSize = true;
            this.yl_c2.BackColor = System.Drawing.Color.Transparent;
            this.yl_c2.Font = new System.Drawing.Font("굴림", 9F);
            this.yl_c2.Location = new System.Drawing.Point(22, 363);
            this.yl_c2.Name = "yl_c2";
            this.yl_c2.Size = new System.Drawing.Size(17, 12);
            this.yl_c2.TabIndex = 10044;
            this.yl_c2.Text = "33";
            this.yl_c2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yl_c1
            // 
            this.yl_c1.AutoSize = true;
            this.yl_c1.BackColor = System.Drawing.Color.Transparent;
            this.yl_c1.Font = new System.Drawing.Font("굴림", 9F);
            this.yl_c1.Location = new System.Drawing.Point(8, 363);
            this.yl_c1.Name = "yl_c1";
            this.yl_c1.Size = new System.Drawing.Size(11, 12);
            this.yl_c1.TabIndex = 10043;
            this.yl_c1.Text = "0";
            this.yl_c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yl_v6
            // 
            this.yl_v6.AutoSize = true;
            this.yl_v6.BackColor = System.Drawing.Color.Transparent;
            this.yl_v6.Font = new System.Drawing.Font("굴림", 9F);
            this.yl_v6.Location = new System.Drawing.Point(37, 147);
            this.yl_v6.Name = "yl_v6";
            this.yl_v6.Size = new System.Drawing.Size(17, 12);
            this.yl_v6.TabIndex = 10042;
            this.yl_v6.Text = "85";
            this.yl_v6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yl_v5
            // 
            this.yl_v5.AutoSize = true;
            this.yl_v5.BackColor = System.Drawing.Color.Transparent;
            this.yl_v5.Font = new System.Drawing.Font("굴림", 9F);
            this.yl_v5.Location = new System.Drawing.Point(25, 147);
            this.yl_v5.Name = "yl_v5";
            this.yl_v5.Size = new System.Drawing.Size(17, 12);
            this.yl_v5.TabIndex = 10041;
            this.yl_v5.Text = "68";
            this.yl_v5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yl_v4
            // 
            this.yl_v4.AutoSize = true;
            this.yl_v4.BackColor = System.Drawing.Color.Transparent;
            this.yl_v4.Font = new System.Drawing.Font("굴림", 9F);
            this.yl_v4.Location = new System.Drawing.Point(11, 147);
            this.yl_v4.Name = "yl_v4";
            this.yl_v4.Size = new System.Drawing.Size(17, 12);
            this.yl_v4.TabIndex = 10040;
            this.yl_v4.Text = "51";
            this.yl_v4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yl_v3
            // 
            this.yl_v3.AutoSize = true;
            this.yl_v3.BackColor = System.Drawing.Color.Transparent;
            this.yl_v3.Font = new System.Drawing.Font("굴림", 9F);
            this.yl_v3.Location = new System.Drawing.Point(37, 125);
            this.yl_v3.Name = "yl_v3";
            this.yl_v3.Size = new System.Drawing.Size(17, 12);
            this.yl_v3.TabIndex = 10039;
            this.yl_v3.Text = "34";
            this.yl_v3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yl_v2
            // 
            this.yl_v2.AutoSize = true;
            this.yl_v2.BackColor = System.Drawing.Color.Transparent;
            this.yl_v2.Font = new System.Drawing.Font("굴림", 9F);
            this.yl_v2.Location = new System.Drawing.Point(23, 125);
            this.yl_v2.Name = "yl_v2";
            this.yl_v2.Size = new System.Drawing.Size(17, 12);
            this.yl_v2.TabIndex = 10038;
            this.yl_v2.Text = "17";
            this.yl_v2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yl_v1
            // 
            this.yl_v1.AutoSize = true;
            this.yl_v1.BackColor = System.Drawing.Color.Transparent;
            this.yl_v1.Font = new System.Drawing.Font("굴림", 9F);
            this.yl_v1.Location = new System.Drawing.Point(11, 125);
            this.yl_v1.Name = "yl_v1";
            this.yl_v1.Size = new System.Drawing.Size(11, 12);
            this.yl_v1.TabIndex = 10037;
            this.yl_v1.Text = "0";
            this.yl_v1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // is_cur_x_auto_range
            // 
            this.is_cur_x_auto_range.BackColor = System.Drawing.Color.Lime;
            this.is_cur_x_auto_range.Font = new System.Drawing.Font("굴림", 9F);
            this.is_cur_x_auto_range.Location = new System.Drawing.Point(582, 246);
            this.is_cur_x_auto_range.Margin = new System.Windows.Forms.Padding(2);
            this.is_cur_x_auto_range.Name = "is_cur_x_auto_range";
            this.is_cur_x_auto_range.Size = new System.Drawing.Size(85, 23);
            this.is_cur_x_auto_range.TabIndex = 10004;
            this.is_cur_x_auto_range.Text = "XAutoRange";
            this.is_cur_x_auto_range.UseVisualStyleBackColor = false;
            this.is_cur_x_auto_range.Click += new System.EventHandler(this.is_cur_auto_range_Click);
            // 
            // xl_c11
            // 
            this.xl_c11.AutoSize = true;
            this.xl_c11.BackColor = System.Drawing.Color.Transparent;
            this.xl_c11.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_c11.Location = new System.Drawing.Point(23, 322);
            this.xl_c11.Name = "xl_c11";
            this.xl_c11.Size = new System.Drawing.Size(35, 12);
            this.xl_c11.TabIndex = 10036;
            this.xl_c11.Text = "10000";
            this.xl_c11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_c10
            // 
            this.xl_c10.AutoSize = true;
            this.xl_c10.BackColor = System.Drawing.Color.Transparent;
            this.xl_c10.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_c10.Location = new System.Drawing.Point(9, 322);
            this.xl_c10.Name = "xl_c10";
            this.xl_c10.Size = new System.Drawing.Size(29, 12);
            this.xl_c10.TabIndex = 10035;
            this.xl_c10.Text = "9000";
            this.xl_c10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_c9
            // 
            this.xl_c9.AutoSize = true;
            this.xl_c9.BackColor = System.Drawing.Color.Transparent;
            this.xl_c9.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_c9.Location = new System.Drawing.Point(40, 310);
            this.xl_c9.Name = "xl_c9";
            this.xl_c9.Size = new System.Drawing.Size(29, 12);
            this.xl_c9.TabIndex = 10034;
            this.xl_c9.Text = "8000";
            this.xl_c9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_c8
            // 
            this.xl_c8.AutoSize = true;
            this.xl_c8.BackColor = System.Drawing.Color.Transparent;
            this.xl_c8.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_c8.Location = new System.Drawing.Point(23, 310);
            this.xl_c8.Name = "xl_c8";
            this.xl_c8.Size = new System.Drawing.Size(29, 12);
            this.xl_c8.TabIndex = 10033;
            this.xl_c8.Text = "7000";
            this.xl_c8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_c7
            // 
            this.xl_c7.AutoSize = true;
            this.xl_c7.BackColor = System.Drawing.Color.Transparent;
            this.xl_c7.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_c7.Location = new System.Drawing.Point(9, 310);
            this.xl_c7.Name = "xl_c7";
            this.xl_c7.Size = new System.Drawing.Size(29, 12);
            this.xl_c7.TabIndex = 10032;
            this.xl_c7.Text = "6000";
            this.xl_c7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_c6
            // 
            this.xl_c6.AutoSize = true;
            this.xl_c6.BackColor = System.Drawing.Color.Transparent;
            this.xl_c6.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_c6.Location = new System.Drawing.Point(40, 298);
            this.xl_c6.Name = "xl_c6";
            this.xl_c6.Size = new System.Drawing.Size(29, 12);
            this.xl_c6.TabIndex = 10031;
            this.xl_c6.Text = "5000";
            this.xl_c6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_c5
            // 
            this.xl_c5.AutoSize = true;
            this.xl_c5.BackColor = System.Drawing.Color.Transparent;
            this.xl_c5.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_c5.Location = new System.Drawing.Point(23, 298);
            this.xl_c5.Name = "xl_c5";
            this.xl_c5.Size = new System.Drawing.Size(29, 12);
            this.xl_c5.TabIndex = 10030;
            this.xl_c5.Text = "4000";
            this.xl_c5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_c4
            // 
            this.xl_c4.AutoSize = true;
            this.xl_c4.BackColor = System.Drawing.Color.Transparent;
            this.xl_c4.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_c4.Location = new System.Drawing.Point(9, 298);
            this.xl_c4.Name = "xl_c4";
            this.xl_c4.Size = new System.Drawing.Size(29, 12);
            this.xl_c4.TabIndex = 10029;
            this.xl_c4.Text = "3000";
            this.xl_c4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_c3
            // 
            this.xl_c3.AutoSize = true;
            this.xl_c3.BackColor = System.Drawing.Color.Transparent;
            this.xl_c3.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_c3.Location = new System.Drawing.Point(43, 286);
            this.xl_c3.Name = "xl_c3";
            this.xl_c3.Size = new System.Drawing.Size(29, 12);
            this.xl_c3.TabIndex = 10028;
            this.xl_c3.Text = "2000";
            this.xl_c3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_c2
            // 
            this.xl_c2.AutoSize = true;
            this.xl_c2.BackColor = System.Drawing.Color.Transparent;
            this.xl_c2.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_c2.Location = new System.Drawing.Point(26, 286);
            this.xl_c2.Name = "xl_c2";
            this.xl_c2.Size = new System.Drawing.Size(29, 12);
            this.xl_c2.TabIndex = 10027;
            this.xl_c2.Text = "1000";
            this.xl_c2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_c1
            // 
            this.xl_c1.AutoSize = true;
            this.xl_c1.BackColor = System.Drawing.Color.Transparent;
            this.xl_c1.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_c1.Location = new System.Drawing.Point(9, 286);
            this.xl_c1.Name = "xl_c1";
            this.xl_c1.Size = new System.Drawing.Size(11, 12);
            this.xl_c1.TabIndex = 10026;
            this.xl_c1.Text = "0";
            this.xl_c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_v11
            // 
            this.xl_v11.AutoSize = true;
            this.xl_v11.BackColor = System.Drawing.Color.Transparent;
            this.xl_v11.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_v11.Location = new System.Drawing.Point(606, 166);
            this.xl_v11.Name = "xl_v11";
            this.xl_v11.Size = new System.Drawing.Size(35, 12);
            this.xl_v11.TabIndex = 10025;
            this.xl_v11.Text = "10000";
            this.xl_v11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_v9
            // 
            this.xl_v9.AutoSize = true;
            this.xl_v9.BackColor = System.Drawing.Color.Transparent;
            this.xl_v9.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_v9.Location = new System.Drawing.Point(580, 160);
            this.xl_v9.Name = "xl_v9";
            this.xl_v9.Size = new System.Drawing.Size(29, 12);
            this.xl_v9.TabIndex = 10024;
            this.xl_v9.Text = "8000";
            this.xl_v9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_v8
            // 
            this.xl_v8.AutoSize = true;
            this.xl_v8.BackColor = System.Drawing.Color.Transparent;
            this.xl_v8.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_v8.Location = new System.Drawing.Point(518, 160);
            this.xl_v8.Name = "xl_v8";
            this.xl_v8.Size = new System.Drawing.Size(29, 12);
            this.xl_v8.TabIndex = 10023;
            this.xl_v8.Text = "7000";
            this.xl_v8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_v7
            // 
            this.xl_v7.AutoSize = true;
            this.xl_v7.BackColor = System.Drawing.Color.Transparent;
            this.xl_v7.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_v7.Location = new System.Drawing.Point(456, 160);
            this.xl_v7.Name = "xl_v7";
            this.xl_v7.Size = new System.Drawing.Size(29, 12);
            this.xl_v7.TabIndex = 10022;
            this.xl_v7.Text = "6000";
            this.xl_v7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_v6
            // 
            this.xl_v6.AutoSize = true;
            this.xl_v6.BackColor = System.Drawing.Color.Transparent;
            this.xl_v6.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_v6.Location = new System.Drawing.Point(394, 160);
            this.xl_v6.Name = "xl_v6";
            this.xl_v6.Size = new System.Drawing.Size(29, 12);
            this.xl_v6.TabIndex = 10021;
            this.xl_v6.Text = "5000";
            this.xl_v6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_v5
            // 
            this.xl_v5.AutoSize = true;
            this.xl_v5.BackColor = System.Drawing.Color.Transparent;
            this.xl_v5.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_v5.Location = new System.Drawing.Point(332, 160);
            this.xl_v5.Name = "xl_v5";
            this.xl_v5.Size = new System.Drawing.Size(29, 12);
            this.xl_v5.TabIndex = 10020;
            this.xl_v5.Text = "4000";
            this.xl_v5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_v4
            // 
            this.xl_v4.AutoSize = true;
            this.xl_v4.BackColor = System.Drawing.Color.Transparent;
            this.xl_v4.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_v4.Location = new System.Drawing.Point(270, 160);
            this.xl_v4.Name = "xl_v4";
            this.xl_v4.Size = new System.Drawing.Size(29, 12);
            this.xl_v4.TabIndex = 10019;
            this.xl_v4.Text = "3000";
            this.xl_v4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_v3
            // 
            this.xl_v3.AutoSize = true;
            this.xl_v3.BackColor = System.Drawing.Color.Transparent;
            this.xl_v3.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_v3.Location = new System.Drawing.Point(208, 160);
            this.xl_v3.Name = "xl_v3";
            this.xl_v3.Size = new System.Drawing.Size(29, 12);
            this.xl_v3.TabIndex = 10018;
            this.xl_v3.Text = "2000";
            this.xl_v3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_v2
            // 
            this.xl_v2.AutoSize = true;
            this.xl_v2.BackColor = System.Drawing.Color.Transparent;
            this.xl_v2.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_v2.Location = new System.Drawing.Point(146, 160);
            this.xl_v2.Name = "xl_v2";
            this.xl_v2.Size = new System.Drawing.Size(29, 12);
            this.xl_v2.TabIndex = 10017;
            this.xl_v2.Text = "1000";
            this.xl_v2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_v10
            // 
            this.xl_v10.AutoSize = true;
            this.xl_v10.BackColor = System.Drawing.Color.Transparent;
            this.xl_v10.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_v10.Location = new System.Drawing.Point(642, 160);
            this.xl_v10.Name = "xl_v10";
            this.xl_v10.Size = new System.Drawing.Size(29, 12);
            this.xl_v10.TabIndex = 10016;
            this.xl_v10.Text = "9000";
            this.xl_v10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xl_v1
            // 
            this.xl_v1.AutoSize = true;
            this.xl_v1.BackColor = System.Drawing.Color.Transparent;
            this.xl_v1.Font = new System.Drawing.Font("굴림", 9F);
            this.xl_v1.Location = new System.Drawing.Point(84, 160);
            this.xl_v1.Name = "xl_v1";
            this.xl_v1.Size = new System.Drawing.Size(11, 12);
            this.xl_v1.TabIndex = 10015;
            this.xl_v1.Text = "0";
            this.xl_v1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // round_marker_c
            // 
            this.round_marker_c.AutoSize = true;
            this.round_marker_c.BackColor = System.Drawing.Color.Transparent;
            this.round_marker_c.Font = new System.Drawing.Font("굴림", 8F);
            this.round_marker_c.ForeColor = System.Drawing.Color.Lime;
            this.round_marker_c.Location = new System.Drawing.Point(362, 336);
            this.round_marker_c.Name = "round_marker_c";
            this.round_marker_c.Size = new System.Drawing.Size(16, 11);
            this.round_marker_c.TabIndex = 10014;
            this.round_marker_c.Text = "●";
            // 
            // round_marker_v
            // 
            this.round_marker_v.AutoSize = true;
            this.round_marker_v.BackColor = System.Drawing.Color.Transparent;
            this.round_marker_v.Font = new System.Drawing.Font("굴림", 8F);
            this.round_marker_v.ForeColor = System.Drawing.Color.Lime;
            this.round_marker_v.Location = new System.Drawing.Point(362, 52);
            this.round_marker_v.Name = "round_marker_v";
            this.round_marker_v.Size = new System.Drawing.Size(16, 11);
            this.round_marker_v.TabIndex = 10013;
            this.round_marker_v.Text = "●";
            // 
            // marker_c
            // 
            this.marker_c.AutoSize = true;
            this.marker_c.BackColor = System.Drawing.Color.White;
            this.marker_c.Location = new System.Drawing.Point(-34, -15);
            this.marker_c.Name = "marker_c";
            this.marker_c.Size = new System.Drawing.Size(34, 15);
            this.marker_c.TabIndex = 10012;
            this.marker_c.Text = "x, y";
            this.marker_c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.marker_c.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cur_marker_click);
            // 
            // show_c_label
            // 
            this.show_c_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.show_c_label.Font = new System.Drawing.Font("굴림", 11F);
            this.show_c_label.Location = new System.Drawing.Point(25, 433);
            this.show_c_label.Name = "show_c_label";
            this.show_c_label.Size = new System.Drawing.Size(60, 23);
            this.show_c_label.TabIndex = 10011;
            this.show_c_label.Text = "Marker";
            this.show_c_label.UseVisualStyleBackColor = false;
            this.show_c_label.Click += new System.EventHandler(this.show_c_label_Click);
            // 
            // marker_bar_c
            // 
            this.marker_bar_c.Enabled = false;
            this.marker_bar_c.LargeChange = 1;
            this.marker_bar_c.Location = new System.Drawing.Point(78, 434);
            this.marker_bar_c.Maximum = 0;
            this.marker_bar_c.Name = "marker_bar_c";
            this.marker_bar_c.Size = new System.Drawing.Size(581, 45);
            this.marker_bar_c.TabIndex = 10010;
            this.marker_bar_c.ValueChanged += new System.EventHandler(this.label_bar_c_value_changed);
            // 
            // marker_v
            // 
            this.marker_v.AutoSize = true;
            this.marker_v.BackColor = System.Drawing.Color.White;
            this.marker_v.Location = new System.Drawing.Point(-34, -15);
            this.marker_v.Name = "marker_v";
            this.marker_v.Size = new System.Drawing.Size(34, 15);
            this.marker_v.TabIndex = 10009;
            this.marker_v.Text = "x, y";
            this.marker_v.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.marker_v.MouseClick += new System.Windows.Forms.MouseEventHandler(this.vol_marker_click);
            // 
            // is_cur_y_auto_range
            // 
            this.is_cur_y_auto_range.BackColor = System.Drawing.Color.Lime;
            this.is_cur_y_auto_range.Font = new System.Drawing.Font("굴림", 9F);
            this.is_cur_y_auto_range.Location = new System.Drawing.Point(495, 246);
            this.is_cur_y_auto_range.Margin = new System.Windows.Forms.Padding(2);
            this.is_cur_y_auto_range.Name = "is_cur_y_auto_range";
            this.is_cur_y_auto_range.Size = new System.Drawing.Size(85, 23);
            this.is_cur_y_auto_range.TabIndex = 10008;
            this.is_cur_y_auto_range.Text = "YAutoRange";
            this.is_cur_y_auto_range.UseVisualStyleBackColor = false;
            this.is_cur_y_auto_range.Click += new System.EventHandler(this.is_cur_y_auto_range_Click);
            // 
            // is_vol_y_auto_range
            // 
            this.is_vol_y_auto_range.BackColor = System.Drawing.Color.Lime;
            this.is_vol_y_auto_range.Font = new System.Drawing.Font("굴림", 9F);
            this.is_vol_y_auto_range.Location = new System.Drawing.Point(495, 11);
            this.is_vol_y_auto_range.Margin = new System.Windows.Forms.Padding(2);
            this.is_vol_y_auto_range.Name = "is_vol_y_auto_range";
            this.is_vol_y_auto_range.Size = new System.Drawing.Size(85, 23);
            this.is_vol_y_auto_range.TabIndex = 10007;
            this.is_vol_y_auto_range.Text = "YAutoRange";
            this.is_vol_y_auto_range.UseVisualStyleBackColor = false;
            this.is_vol_y_auto_range.Click += new System.EventHandler(this.is_vol_y_auto_range_Click);
            // 
            // show_v_label
            // 
            this.show_v_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.show_v_label.Font = new System.Drawing.Font("굴림", 11F);
            this.show_v_label.Location = new System.Drawing.Point(25, 205);
            this.show_v_label.Name = "show_v_label";
            this.show_v_label.Size = new System.Drawing.Size(60, 23);
            this.show_v_label.TabIndex = 10006;
            this.show_v_label.Text = "Marker";
            this.show_v_label.UseVisualStyleBackColor = false;
            this.show_v_label.Click += new System.EventHandler(this.show_v_label_Click);
            // 
            // marker_bar_v
            // 
            this.marker_bar_v.Enabled = false;
            this.marker_bar_v.LargeChange = 1;
            this.marker_bar_v.Location = new System.Drawing.Point(78, 205);
            this.marker_bar_v.Maximum = 0;
            this.marker_bar_v.Name = "marker_bar_v";
            this.marker_bar_v.Size = new System.Drawing.Size(581, 45);
            this.marker_bar_v.TabIndex = 10005;
            this.marker_bar_v.ValueChanged += new System.EventHandler(this.label_bar_v_value_changed);
            // 
            // is_vol_x_auto_range
            // 
            this.is_vol_x_auto_range.BackColor = System.Drawing.Color.Lime;
            this.is_vol_x_auto_range.Font = new System.Drawing.Font("굴림", 9F);
            this.is_vol_x_auto_range.Location = new System.Drawing.Point(582, 11);
            this.is_vol_x_auto_range.Margin = new System.Windows.Forms.Padding(2);
            this.is_vol_x_auto_range.Name = "is_vol_x_auto_range";
            this.is_vol_x_auto_range.Size = new System.Drawing.Size(85, 23);
            this.is_vol_x_auto_range.TabIndex = 20;
            this.is_vol_x_auto_range.Text = "XAutoRange";
            this.is_vol_x_auto_range.UseVisualStyleBackColor = false;
            this.is_vol_x_auto_range.Click += new System.EventHandler(this.is_vol_auto_range_Click);
            // 
            // cvScrollBar
            // 
            this.cvScrollBar.LargeChange = 1000;
            this.cvScrollBar.Location = new System.Drawing.Point(650, 272);
            this.cvScrollBar.Maximum = 165000;
            this.cvScrollBar.Minimum = -165000;
            this.cvScrollBar.Name = "cvScrollBar";
            this.cvScrollBar.Size = new System.Drawing.Size(17, 122);
            this.cvScrollBar.SmallChange = 1000;
            this.cvScrollBar.TabIndex = 10;
            this.cvScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cvScrollBar_Scroll);
            // 
            // chScrollBar
            // 
            this.chScrollBar.Location = new System.Drawing.Point(91, 415);
            this.chScrollBar.Maximum = 10000;
            this.chScrollBar.Minimum = -10000;
            this.chScrollBar.Name = "chScrollBar";
            this.chScrollBar.Size = new System.Drawing.Size(558, 17);
            this.chScrollBar.SmallChange = 10;
            this.chScrollBar.TabIndex = 10000;
            this.chScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.chScrollBar_Scroll);
            // 
            // vhScrollBar
            // 
            this.vhScrollBar.Location = new System.Drawing.Point(91, 178);
            this.vhScrollBar.Maximum = 10000;
            this.vhScrollBar.Minimum = -10000;
            this.vhScrollBar.Name = "vhScrollBar";
            this.vhScrollBar.Size = new System.Drawing.Size(558, 17);
            this.vhScrollBar.SmallChange = 10;
            this.vhScrollBar.TabIndex = 10000;
            this.vhScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vhScrollBar_Scroll);
            // 
            // vvScrollBar
            // 
            this.vvScrollBar.LargeChange = 1000;
            this.vvScrollBar.Location = new System.Drawing.Point(651, 40);
            this.vvScrollBar.Maximum = 85000;
            this.vvScrollBar.Minimum = -85000;
            this.vvScrollBar.Name = "vvScrollBar";
            this.vvScrollBar.Size = new System.Drawing.Size(17, 122);
            this.vvScrollBar.SmallChange = 1000;
            this.vvScrollBar.TabIndex = 10;
            this.vvScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vvScrollBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15F);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(99, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "mA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CUR
            // 
            this.CUR.AutoSize = true;
            this.CUR.Font = new System.Drawing.Font("굴림", 15F);
            this.CUR.ForeColor = System.Drawing.Color.Lime;
            this.CUR.Location = new System.Drawing.Point(7, 246);
            this.CUR.Name = "CUR";
            this.CUR.Size = new System.Drawing.Size(82, 20);
            this.CUR.TabIndex = 3;
            this.CUR.Text = "---.---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(99, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "mV";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VOL
            // 
            this.VOL.AutoSize = true;
            this.VOL.Font = new System.Drawing.Font("굴림", 15F);
            this.VOL.ForeColor = System.Drawing.Color.Lime;
            this.VOL.Location = new System.Drawing.Point(7, 12);
            this.VOL.Name = "VOL";
            this.VOL.Size = new System.Drawing.Size(82, 20);
            this.VOL.TabIndex = 0;
            this.VOL.Text = "---.---";
            // 
            // cur_graph
            // 
            this.cur_graph.BackColor = System.Drawing.Color.DimGray;
            this.cur_graph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cur_graph.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.cur_graph.BackSecondaryColor = System.Drawing.Color.White;
            this.cur_graph.BorderlineColor = System.Drawing.Color.DimGray;
            this.cur_graph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea11.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea11.AxisX.LabelAutoFitMinFontSize = 10;
            chartArea11.AxisX.MajorGrid.Interval = 250D;
            chartArea11.AxisX.Minimum = 0D;
            chartArea11.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea11.AxisY.LabelAutoFitMinFontSize = 10;
            chartArea11.AxisY.MajorGrid.Interval = 10D;
            chartArea11.AxisY.Maximum = 165D;
            chartArea11.AxisY.Minimum = 0D;
            chartArea11.BackColor = System.Drawing.Color.Black;
            chartArea11.InnerPlotPosition.Auto = false;
            chartArea11.InnerPlotPosition.Height = 80F;
            chartArea11.InnerPlotPosition.Width = 90F;
            chartArea11.InnerPlotPosition.X = 10F;
            chartArea11.Name = "ChartArea1";
            chartArea11.ShadowColor = System.Drawing.Color.White;
            this.cur_graph.ChartAreas.Add(chartArea11);
            this.cur_graph.Location = new System.Drawing.Point(9, 272);
            this.cur_graph.Name = "cur_graph";
            this.cur_graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.cur_graph.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Chartreuse};
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Name = "Series1";
            this.cur_graph.Series.Add(series11);
            this.cur_graph.Size = new System.Drawing.Size(661, 157);
            this.cur_graph.TabIndex = 10002;
            this.cur_graph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cur_graph_click);
            this.cur_graph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cur_graph_mouse_down);
            this.cur_graph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cur_graph_mouse_move);
            this.cur_graph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cur_graph_mouse_up);
            this.cur_graph.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.cur_graph_wheel);
            // 
            // vol_graph
            // 
            this.vol_graph.BackColor = System.Drawing.Color.DimGray;
            this.vol_graph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vol_graph.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.vol_graph.BackSecondaryColor = System.Drawing.Color.White;
            this.vol_graph.BorderlineColor = System.Drawing.Color.DimGray;
            this.vol_graph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea12.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea12.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea12.AxisX.IsLabelAutoFit = false;
            chartArea12.AxisX.LabelAutoFitMinFontSize = 10;
            chartArea12.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea12.AxisX.MajorGrid.Interval = 250D;
            chartArea12.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea12.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea12.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea12.AxisX.Minimum = 0D;
            chartArea12.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea12.AxisX.ScaleView.Zoomable = false;
            chartArea12.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea12.AxisY.LabelAutoFitMinFontSize = 10;
            chartArea12.AxisY.MajorGrid.Interval = 10D;
            chartArea12.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea12.AxisY.Maximum = 85D;
            chartArea12.AxisY.Minimum = 0D;
            chartArea12.BackColor = System.Drawing.Color.Black;
            chartArea12.InnerPlotPosition.Auto = false;
            chartArea12.InnerPlotPosition.Height = 80F;
            chartArea12.InnerPlotPosition.Width = 90F;
            chartArea12.InnerPlotPosition.X = 10F;
            chartArea12.IsSameFontSizeForAllAxes = true;
            chartArea12.Name = "ChartArea1";
            chartArea12.ShadowColor = System.Drawing.Color.White;
            this.vol_graph.ChartAreas.Add(chartArea12);
            this.vol_graph.Location = new System.Drawing.Point(9, 35);
            this.vol_graph.Name = "vol_graph";
            this.vol_graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.vol_graph.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Chartreuse};
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Name = "Series1";
            this.vol_graph.Series.Add(series12);
            this.vol_graph.Size = new System.Drawing.Size(661, 157);
            this.vol_graph.TabIndex = 10003;
            this.vol_graph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.vol_graph_click);
            this.vol_graph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vol_graph_mouse_down);
            this.vol_graph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vol_graph_mouse_move);
            this.vol_graph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.vol_graph_mouse_up);
            this.vol_graph.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.vol_graph_wheel);
            // 
            // quit_c
            // 
            this.quit_c.Location = new System.Drawing.Point(648, 29);
            this.quit_c.Margin = new System.Windows.Forms.Padding(2);
            this.quit_c.Name = "quit_c";
            this.quit_c.Size = new System.Drawing.Size(74, 19);
            this.quit_c.TabIndex = 4;
            this.quit_c.Text = "Quit";
            this.quit_c.UseVisualStyleBackColor = true;
            this.quit_c.Click += new System.EventHandler(this.quit_c_Click);
            // 
            // disconnect_c
            // 
            this.disconnect_c.BackColor = System.Drawing.Color.Lime;
            this.disconnect_c.Font = new System.Drawing.Font("굴림", 7F);
            this.disconnect_c.Location = new System.Drawing.Point(190, 85);
            this.disconnect_c.Name = "disconnect_c";
            this.disconnect_c.Size = new System.Drawing.Size(67, 19);
            this.disconnect_c.TabIndex = 5;
            this.disconnect_c.Text = "Disconnect";
            this.disconnect_c.UseVisualStyleBackColor = false;
            this.disconnect_c.Click += new System.EventHandler(this.disconnect_c_Click);
            // 
            // arpt_0
            // 
            this.arpt_0.BackColor = System.Drawing.Color.Lime;
            this.arpt_0.Location = new System.Drawing.Point(446, 84);
            this.arpt_0.Margin = new System.Windows.Forms.Padding(2);
            this.arpt_0.Name = "arpt_0";
            this.arpt_0.Size = new System.Drawing.Size(74, 19);
            this.arpt_0.TabIndex = 11;
            this.arpt_0.Text = "Stop";
            this.arpt_0.UseVisualStyleBackColor = false;
            this.arpt_0.Click += new System.EventHandler(this.arpt_0_Click);
            // 
            // meas_q
            // 
            this.meas_q.Font = new System.Drawing.Font("굴림", 9F);
            this.meas_q.Location = new System.Drawing.Point(368, 31);
            this.meas_q.Margin = new System.Windows.Forms.Padding(2);
            this.meas_q.Name = "meas_q";
            this.meas_q.Size = new System.Drawing.Size(74, 19);
            this.meas_q.TabIndex = 14;
            this.meas_q.Text = "?MEAS:";
            this.meas_q.UseVisualStyleBackColor = true;
            this.meas_q.Click += new System.EventHandler(this.meas_q_Click);
            // 
            // irange_0
            // 
            this.irange_0.BackColor = System.Drawing.Color.Lime;
            this.irange_0.Font = new System.Drawing.Font("굴림", 8F);
            this.irange_0.Location = new System.Drawing.Point(368, 56);
            this.irange_0.Margin = new System.Windows.Forms.Padding(2);
            this.irange_0.Name = "irange_0";
            this.irange_0.Size = new System.Drawing.Size(74, 19);
            this.irange_0.TabIndex = 13;
            this.irange_0.Text = "IRANGE:0";
            this.irange_0.UseVisualStyleBackColor = false;
            this.irange_0.Click += new System.EventHandler(this.irange_0_Click);
            // 
            // irange_1
            // 
            this.irange_1.BackColor = System.Drawing.Color.Silver;
            this.irange_1.Font = new System.Drawing.Font("굴림", 8F);
            this.irange_1.Location = new System.Drawing.Point(446, 56);
            this.irange_1.Margin = new System.Windows.Forms.Padding(2);
            this.irange_1.Name = "irange_1";
            this.irange_1.Size = new System.Drawing.Size(74, 19);
            this.irange_1.TabIndex = 16;
            this.irange_1.Text = "IRANGE:1";
            this.irange_1.UseVisualStyleBackColor = false;
            this.irange_1.Click += new System.EventHandler(this.irange_1_Click);
            // 
            // test_c
            // 
            this.test_c.Location = new System.Drawing.Point(570, 29);
            this.test_c.Margin = new System.Windows.Forms.Padding(2);
            this.test_c.Name = "test_c";
            this.test_c.Size = new System.Drawing.Size(74, 19);
            this.test_c.TabIndex = 19;
            this.test_c.Text = "test";
            this.test_c.UseVisualStyleBackColor = true;
            this.test_c.Click += new System.EventHandler(this.test_Click);
            // 
            // test_timer
            // 
            this.test_timer.Interval = 250;
            this.test_timer.Tick += new System.EventHandler(this.test_timer_Tick);
            // 
            // save_log
            // 
            this.save_log.BackColor = System.Drawing.Color.Silver;
            this.save_log.Location = new System.Drawing.Point(632, 84);
            this.save_log.Margin = new System.Windows.Forms.Padding(2);
            this.save_log.Name = "save_log";
            this.save_log.Size = new System.Drawing.Size(100, 19);
            this.save_log.TabIndex = 20;
            this.save_log.Text = "Save Log Start";
            this.save_log.UseVisualStyleBackColor = false;
            this.save_log.Click += new System.EventHandler(this.save_log_Click);
            // 
            // arpt_value
            // 
            this.arpt_value.Location = new System.Drawing.Point(263, 85);
            this.arpt_value.Name = "arpt_value";
            this.arpt_value.Size = new System.Drawing.Size(100, 21);
            this.arpt_value.TabIndex = 21;
            this.arpt_value.Text = "100";
            this.arpt_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arpt_valeu_keykress);
            // 
            // arpt_start
            // 
            this.arpt_start.BackColor = System.Drawing.Color.Silver;
            this.arpt_start.Location = new System.Drawing.Point(368, 85);
            this.arpt_start.Margin = new System.Windows.Forms.Padding(2);
            this.arpt_start.Name = "arpt_start";
            this.arpt_start.Size = new System.Drawing.Size(74, 19);
            this.arpt_start.TabIndex = 22;
            this.arpt_start.Text = "AutoReport";
            this.arpt_start.UseVisualStyleBackColor = false;
            this.arpt_start.Click += new System.EventHandler(this.arpt_start_click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(734, 24);
            this.menuStrip.TabIndex = 25;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.settings});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu.Text = "Menu";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem,
            this.toolStripSeparator1});
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadFileToolStripMenuItem.Text = "Load File";
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.browseToolStripMenuItem.Text = "Browse...";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // settings
            // 
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(180, 22);
            this.settings.Text = "Settings";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(734, 621);
            this.Controls.Add(this.arpt_start);
            this.Controls.Add(this.arpt_value);
            this.Controls.Add(this.save_log);
            this.Controls.Add(this.test_c);
            this.Controls.Add(this.meas_q);
            this.Controls.Add(this.irange_0);
            this.Controls.Add(this.irange_1);
            this.Controls.Add(this.arpt_0);
            this.Controls.Add(this.disconnect_c);
            this.Controls.Add(this.quit_c);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rescan_c);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connect_c);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.mouse_leave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_up);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marker_bar_c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marker_bar_v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cur_graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vol_graph)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button connect_c;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Button rescan_c;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CUR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VOL;
        private System.Windows.Forms.TextBox command;
        private System.Windows.Forms.TextBox board_c;
        private System.Windows.Forms.Button quit_c;
        private System.Windows.Forms.Button disconnect_c;
        private System.Windows.Forms.Button arpt_0;
        private System.Windows.Forms.Button meas_q;
        private System.Windows.Forms.Button irange_0;
        private System.Windows.Forms.Button irange_1;
        private System.Windows.Forms.HScrollBar vhScrollBar;
        private System.Windows.Forms.VScrollBar vvScrollBar;
        private System.Windows.Forms.VScrollBar cvScrollBar;
        private System.Windows.Forms.HScrollBar chScrollBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart cur_graph;
        private System.Windows.Forms.DataVisualization.Charting.Chart vol_graph;
        private System.Windows.Forms.Button test_c;
        private System.Windows.Forms.Timer test_timer;
        private System.Windows.Forms.Button is_cur_x_auto_range;
        private System.Windows.Forms.Button is_vol_x_auto_range;
        private System.Windows.Forms.Button save_log;
        private System.Windows.Forms.TrackBar marker_bar_v;
        private System.Windows.Forms.Button show_v_label;
        private System.Windows.Forms.Button is_vol_y_auto_range;
        private System.Windows.Forms.Button is_cur_y_auto_range;
        private System.Windows.Forms.Label marker_v;
        private System.Windows.Forms.Button show_c_label;
        private System.Windows.Forms.TrackBar marker_bar_c;
        private System.Windows.Forms.Label marker_c;
        private System.Windows.Forms.Label round_marker_v;
        private System.Windows.Forms.Label round_marker_c;
        private System.Windows.Forms.Label xl_v1;
        private System.Windows.Forms.Label xl_v10;
        private System.Windows.Forms.Label xl_v2;
        private System.Windows.Forms.Label xl_v9;
        private System.Windows.Forms.Label xl_v8;
        private System.Windows.Forms.Label xl_v7;
        private System.Windows.Forms.Label xl_v6;
        private System.Windows.Forms.Label xl_v5;
        private System.Windows.Forms.Label xl_v4;
        private System.Windows.Forms.Label xl_v3;
        private System.Windows.Forms.Label xl_v11;
        private System.Windows.Forms.Label xl_c11;
        private System.Windows.Forms.Label xl_c10;
        private System.Windows.Forms.Label xl_c9;
        private System.Windows.Forms.Label xl_c8;
        private System.Windows.Forms.Label xl_c7;
        private System.Windows.Forms.Label xl_c6;
        private System.Windows.Forms.Label xl_c5;
        private System.Windows.Forms.Label xl_c4;
        private System.Windows.Forms.Label xl_c3;
        private System.Windows.Forms.Label xl_c2;
        private System.Windows.Forms.Label xl_c1;
        private System.Windows.Forms.Label yl_v1;
        private System.Windows.Forms.Label yl_c6;
        private System.Windows.Forms.Label yl_c5;
        private System.Windows.Forms.Label yl_c4;
        private System.Windows.Forms.Label yl_c3;
        private System.Windows.Forms.Label yl_c2;
        private System.Windows.Forms.Label yl_c1;
        private System.Windows.Forms.Label yl_v5;
        private System.Windows.Forms.Label yl_v4;
        private System.Windows.Forms.Label yl_v3;
        private System.Windows.Forms.Label yl_v2;
        private System.Windows.Forms.Label yl_v6;
        private System.Windows.Forms.TextBox arpt_value;
        private System.Windows.Forms.Button arpt_start;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settings;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

