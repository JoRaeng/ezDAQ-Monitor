using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.ComponentModel;

namespace YG
{
    internal class Graph
    {
        private Form1 form = null;
        public float mx_v = 1;
        public float mi_v = 0;
        public float mx_c = 1;
        public float mi_c = 0;
        //화면에 표시되는 y값 범위
        public float[] a_v = new float[2];
        private float[] a_c = new float[2];
        //화면에 표시되는 범위
        public List<int> display_v_index = new List<int>();
        public List<int> display_c_index = new List<int>();
        public List<float> display_v_y = new List<float>();
        public List<float> display_c_y = new List<float>();
        public List<double> distant_v = new List<double>();
        public List<double> distant_c = new List<double>();
        //화면에 표시되는 x값에 해당되는 y값의 최소최댓값
        private float[] b_v = new float[2];
        private float[] b_c = new float[2];
        //drag
        private bool is_vol_mouse_down = false;
        private bool is_cur_mouse_down = false;
        private float[] before_location = new float[2];
        private float[] current_location = new float[2];
        //marker
        public int selected_marker_num_v = 0;
        public int selected_marker_num_c = 0;

        public Graph(Form1 form)
        {
            this.form = form;
            a_v[0] = 0;
            a_v[1] = 1;
            a_c[0] = 0;
            a_c[1] = 1;
            b_v[0] = 0;
            b_v[1] = 1;
            b_c[0] = 0;
            b_c[1] = 1;
        }

        public void draw_v_graph()
        {
            if (form.get_vol_x_auto_range())
            {
                v_x_auto_range();
            }
            if (form.get_vol_y_auto_range())
            {
                v_y_auto_range();
            }
        }

        public void draw_c_graph()
        {
            if (form.get_cur_x_auto_range())
            {
                c_x_auto_range();
            }
            if (form.get_cur_y_auto_range())
            {
                c_y_auto_range();
            }
        }

        public void scroll_v (bool is_h)
        {
            if (is_h)
            {
                vh_scroll();
            }
            else
            {
                vv_scroll();
            }
        }

        public void scroll_c (bool is_h)
        {
            if (is_h)
            {
                ch_scroll();
            }
            else
            {
                cv_scroll();
            }
        }
        //wheel
        //그래프 내
        //v 축소
        public void scroll_down_v(int x, int y)
        {
            //%설정
            float x_change = (mx_v - mi_v) * 0.25f;
            float y_change = (a_v[1] - a_v[0]) * 0.25f;
            //휠 상하좌우 설정 
            if (mi_v - x_change < 0 && mx_v + x_change > form.get_tm() + 2500)
            {
                mi_v = 0;
                mx_v = form.get_tm() + 2500;
            }
            else if (mi_v - x_change < 0 && !(mx_v + x_change > form.get_tm() + 2500))
            {
                mx_v = mx_v - (mi_v - x_change) + x_change;
                mi_v = 0;
            }
            else if (mx_v + x_change > form.get_tm() + 2500 && !(mi_v - x_change < 0))
            {
                mi_v = mi_v - (mx_v + x_change - form.get_tm()+2500) - x_change;
                mx_v = form.get_tm() + 2500;
            }
            else if (!(mi_v - x_change < 0) && !(mx_v + x_change > form.get_tm() + 2500))
            {
                mi_v = mi_v - (x_change);
                mx_v = mx_v + (x_change);
            }

            if (a_v[0] - y_change < -85 && !(a_v[1] + y_change > 85))
            {
                a_v[1] = a_v[1] - (a_v[0] - y_change) + y_change;
                a_v[0] = -85;
            }
            else if (a_v[1] + y_change > 85 && !(a_v[0] - y_change < -85))
            {
                a_v[0] = a_v[0] - (a_v[1] + y_change - 85) - y_change;
                a_v[1] = 85;
            }
            else if (!(a_v[1] + y_change > 85) && !(a_v[0] - y_change < -85))
            {
                a_v[0] = a_v[0] - (y_change);
                a_v[1] = a_v[1] + (y_change);
            }
            


            form.get_vol_graph().ChartAreas[0].AxisX.Minimum = mi_v;
            form.get_vol_graph().ChartAreas[0].AxisX.Maximum = mx_v;
            form.get_vol_graph().ChartAreas[0].AxisY.Minimum = a_v[0];
            form.get_vol_graph().ChartAreas[0].AxisY.Maximum = a_v[1];
            set_y_label(true);
            set_x_label(true);
            set_track_bar_v();
            set_marker(form.get_marker_bar_v().Value, true);
        }
        //v 확대
        public void scroll_up_v(int x, int y)
        {
            //%설정
            float x_change = (mx_v - mi_v) * 0.25f;
            float y_change = (a_v[1] - a_v[0]) * 0.25f;
            //휠 상하좌우 설정
            if (mx_v - mi_v - (2 * x_change) >= 0.001 && a_v[1] - a_v[0] - (2 * y_change) >= 0.001)
            {
                mi_v = mi_v + (x_change);
                mx_v = mx_v - (x_change);
                a_v[0] = a_v[0] + (y_change);
                a_v[1] = a_v[1] - (y_change);
            }
            if (a_v[0] == a_v[1])
            {
                a_v[1] += 1;
            }
            

            form.get_vol_graph().ChartAreas[0].AxisX.Minimum = mi_v;
            form.get_vol_graph().ChartAreas[0].AxisX.Maximum = mx_v;
            form.get_vol_graph().ChartAreas[0].AxisY.Minimum = a_v[0];
            form.get_vol_graph().ChartAreas[0].AxisY.Maximum = a_v[1];
            set_y_label(true);
            set_x_label(true);
            set_track_bar_v();
            set_marker(form.get_marker_bar_v().Value, true);
        }
        //c 축소
        public void scroll_down_c(int x, int y)
        {
            //%설정
            float x_change = (mx_c- mi_c) * 0.25f;
            float y_change = (a_c[1] - a_c[0]) * 0.25f;
            //휠 상하좌우 설정
            if (mi_c - x_change < 0 && mx_c + x_change > form.get_tm() + 2500)
            {
                mi_c = 0;
                mx_c = form.get_tm() + 2500;
            }
            else if (mi_c - x_change < 0 && !(mx_c + x_change > form.get_tm() + 2500))
            {
                mx_c = mx_c - (mi_c - x_change) + x_change;
                mi_c = 0;
            }
            else if (mx_c + x_change > form.get_tm() + 2500 && !(mi_c - x_change < 0))
            {
                mi_c = mi_c - (mx_c + x_change - form.get_tm() + 2500) - x_change;
                mx_c = form.get_tm() + 2500;
            }
            else if (!(mi_c - x_change < 0) && !(mx_c + x_change > form.get_tm() + 2500))
            {
                mi_c = mi_c - (x_change);
                mx_c = mx_c + (x_change);
            }

            if (a_c[0] - y_change < -165 && !(a_c[1] + y_change > 165))
            {
                a_c[1] = a_c[1] - (a_c[0] - y_change) + y_change;
                a_c[0] = -1;
            }
            else if (a_c[1] + y_change > 165 && !(a_c[0] - y_change < -165))
            {
                a_c[0] = a_c[0] - (a_c[1] + y_change - 85) - y_change;
                a_v[1] = 85;
            }
            else if (!(a_c[1] + y_change > 165) && !(a_c[0] - y_change < -165))
            {
                a_c[0] = a_c[0] - (y_change);
                a_c[1] = a_c[1] + (y_change);
            }



            form.get_cur_graph().ChartAreas[0].AxisX.Minimum = mi_c;
            form.get_cur_graph().ChartAreas[0].AxisX.Maximum = mx_c;
            form.get_cur_graph().ChartAreas[0].AxisY.Minimum = a_c[0];
            form.get_cur_graph().ChartAreas[0].AxisY.Maximum = a_c[1];
            set_x_label(false);
            set_y_label(false);
            set_track_bar_c();
            set_marker(form.get_marker_bar_c().Value, false);
        }
        //c 확대
        public void scroll_up_c(int x, int y)
        {
            //%설정
            float x_change = (mx_c - mi_c) * 0.25f;
            float y_change = (a_c[1] - a_c[0]) * 0.25f;
            //휠 상하좌우 설정

            if (mx_c - mi_c - (2 * x_change) >= 0.001 && a_c[1] - a_c[0] - (2 * y_change) >= 0.001)
            {
                mx_c = mx_c - (x_change);
                mi_c = mi_c + (x_change);
                a_c[0] = a_c[0] + (y_change);
                a_c[1] = a_c[1] - (y_change);
            }
            if (a_c[0] == a_c[1])
            {
                a_c[1] += 1;
            }


            form.get_cur_graph().ChartAreas[0].AxisX.Minimum = mi_c;
            form.get_cur_graph().ChartAreas[0].AxisX.Maximum = mx_c;
            form.get_cur_graph().ChartAreas[0].AxisY.Minimum = a_c[0];
            form.get_cur_graph().ChartAreas[0].AxisY.Maximum = a_c[1];
            set_x_label(false);
            set_y_label(false);
            set_track_bar_c();
            set_marker(form.get_marker_bar_c().Value, false);
        }

        //x축 줌아웃
        public void scroll_down_x(int x, int y, bool is_v)
        {
            if (is_v)
            {
                //%설정
                float x_change = (mx_v - mi_v) * 0.25f;
                //휠 상하좌우 설정

                if (mi_v - x_change < 0 && !(mx_v + x_change > form.get_tm() + 2500))
                {
                    mx_v = mx_v - (mi_v - x_change) + x_change;
                    mi_v = 0;
                }
                else if (mx_v + x_change > form.get_tm() + 2500 && !(mi_v - x_change < 0))
                {
                    mi_v = mi_v - (mx_v + x_change - form.get_tm() + 2500) - x_change;
                    mx_v = form.get_tm() + 2500;
                }
                else if (!(mi_v - x_change < 0) && !(mx_v + x_change > form.get_tm() + 2500))
                {
                    mi_v = mi_v - (x_change);
                    mx_v = mx_v + (x_change);
                }

                form.get_vol_graph().ChartAreas[0].AxisX.Minimum = mi_v;
                form.get_vol_graph().ChartAreas[0].AxisX.Maximum = mx_v;
                set_x_label(true);
                set_y_label(true);
                set_track_bar_v();
                set_marker(form.get_marker_bar_v().Value, is_v);
            }
            else
            {
                //%설정
                float x_change = (mx_c - mi_c) * 0.25f;
                //휠 상하좌우 설정

                if (mi_c - x_change < 0 && !(mx_c + x_change > form.get_tm() + 2500))
                {
                    mx_c = mx_c - (mi_c - x_change) + x_change;
                    mi_c = 0;
                }
                else if (mx_c + x_change > form.get_tm() + 2500 && !(mi_c - x_change < 0))
                {
                    mi_c = mi_c - (mx_c + x_change - form.get_tm() + 2500) - x_change;
                    mx_c = form.get_tm() + 2500;
                }
                else if (!(mi_c - x_change < 0) && !(mx_c + x_change > form.get_tm() + 2500))
                {
                    mi_c = mi_c - (x_change);
                    mx_c = mx_c + (x_change);
                }

                form.get_cur_graph().ChartAreas[0].AxisX.Minimum = mi_c;
                form.get_cur_graph().ChartAreas[0].AxisX.Maximum = mx_c;
                set_x_label(false);
                set_y_label(false);
                set_track_bar_c();
                set_marker(form.get_marker_bar_c().Value, is_v);
            }
        }
        //x축 줌인
        public void scroll_up_x(int x, int y, bool is_v)
        {
            if (is_v)
            {
                //%설정
                float x_change = (mx_v - mi_v) * 0.25f;
                //휠 상하좌우 설정
                if (mx_v - mi_v - (2 * x_change) >= 0.001)
                {
                    mi_v = mi_v + (x_change);
                    mx_v = mx_v - (x_change);
                }


                form.get_vol_graph().ChartAreas[0].AxisX.Minimum = mi_v;
                form.get_vol_graph().ChartAreas[0].AxisX.Maximum = mx_v;
                set_x_label(true);
                set_track_bar_v();
                set_marker(form.get_marker_bar_v().Value, is_v);
            }
            else
            {
                //%설정
                float x_change = (mx_c - mi_c) * 0.25f;
                //휠 상하좌우 설정
                if (mx_c - mi_c - (2 * x_change) >= 0.001)
                {
                    mi_c = mi_c + (x_change);
                    mx_c = mx_c - (x_change);
                }


                form.get_cur_graph().ChartAreas[0].AxisX.Minimum = mi_c;
                form.get_cur_graph().ChartAreas[0].AxisX.Maximum = mx_c;
                set_x_label(false);
                set_track_bar_c();
                set_marker(form.get_marker_bar_c().Value, is_v);
            }
        }
        //y축 줌아웃
        public void scroll_down_y(int x, int y, bool is_v)
        {
            if (is_v)
            {
                //%설정
                float y_change = (a_v[1] - a_v[0]) * 0.25f;
                //휠 상하좌우 설정 
                if (a_v[0] - y_change < -85 && !(a_v[1] + y_change > 85))
                {
                    a_v[1] = a_v[1] - (a_v[0] - y_change) + y_change;
                    a_v[0] = -85;
                }
                else if (a_v[1] + y_change > 85 && !(a_v[0] - y_change < -85))
                {
                    a_v[0] = a_v[0] - (a_v[1] + y_change - 85) - y_change;
                    a_v[1] = 85;
                }
                else if (!(a_v[1] + y_change > 85) && !(a_v[0] - y_change < -85))
                {
                    a_v[0] = a_v[0] - (y_change);
                    a_v[1] = a_v[1] + (y_change);
                }

                form.get_vol_graph().ChartAreas[0].AxisY.Minimum = a_v[0];
                form.get_vol_graph().ChartAreas[0].AxisY.Maximum = a_v[1];
                set_y_label(is_v);
                set_marker(form.get_marker_bar_v().Value, is_v);
            }
            else
            {
                //%설정
                float y_change = (a_c[1] - a_c[0]) * 0.25f;
                //휠 상하좌우 설정 
                if (a_c[0] - y_change < -165 && !(a_c[1] + y_change > 165))
                {
                    a_c[1] = a_c[1] - (a_c[0] - y_change) + y_change;
                    a_c[0] = -165;
                }
                else if (a_c[1] + y_change > 165 && !(a_c[0] - y_change < -165))
                {
                    a_c[0] = a_c[0] - (a_c[1] + y_change - 165) - y_change;
                    a_c[1] = 165;
                }
                else if (!(a_c[1] + y_change > 165) && !(a_c[0] - y_change < -165))
                {
                    a_c[0] = a_c[0] - (y_change);
                    a_c[1] = a_c[1] + (y_change);
                }

                form.get_cur_graph().ChartAreas[0].AxisY.Minimum = a_c[0];
                form.get_cur_graph().ChartAreas[0].AxisY.Maximum = a_c[1];
                set_y_label(is_v);
                set_marker(form.get_marker_bar_c().Value, is_v);
            }
        }
        //y축 줌인
        public void scroll_up_y(int x, int y, bool is_v)
        {
            if (is_v)
            {
                //%설정
                float y_change = (a_v[1] - a_v[0]) * 0.25f;
                //휠 상하좌우 설정

                if (a_v[1] - a_v[0] - (2 * y_change) >= 0.001)
                {
                    a_v[0] = a_v[0] + (y_change);
                    a_v[1] = a_v[1] - (y_change);
                }

                form.get_vol_graph().ChartAreas[0].AxisY.Minimum = a_v[0];
                form.get_vol_graph().ChartAreas[0].AxisY.Maximum = a_v[1];
                set_y_label(is_v);
                set_marker(form.get_marker_bar_v().Value, is_v);
            }
            else
            {
                //%설정
                float y_change = (a_c[1] - a_c[0]) * 0.25f;
                //휠 상하좌우 설정

                if (a_c[1] - a_c[0] - (2 * y_change) >= 0.001)
                {
                    a_c[0] = a_c[0] + (y_change);
                    a_c[1] = a_c[1] - (y_change);
                }

                form.get_cur_graph().ChartAreas[0].AxisY.Minimum = a_c[0];
                form.get_cur_graph().ChartAreas[0].AxisY.Maximum = a_c[1];
                set_y_label(is_v);
                set_marker(form.get_marker_bar_c().Value, is_v);
            }
        }

        //축 간격 계산
        private void set_x_label(bool is_v)
        {
            if (is_v)
            {
                float[] label_values = new float[11];
                float a = (mx_v - mi_v) / 10;
                Label[] xl_v = form.get_xl_v();
                for (int i = 0; i < 11; i++)
                {
                    label_values[i] = (float)Math.Round(mi_v + (a * i));
                }
                for (int i = 0; i < 11; i++)
                {
                    xl_v[i].Text = label_values[i].ToString();
                }
            }
            else
            {
                float[] label_values = new float[11];
                float a = (mx_c - mi_c) / 10;
                Label[] xl_c = form.get_xl_c();
                for (int i = 0; i < 11; i++)
                {
                    label_values[i] = (float)Math.Round(mi_c + (a * i));
                }
                
                for (int i = 0; i < 11; i++)
                {
                    xl_c[i].Text = label_values[i].ToString();
                }
            }
        }
        private void set_y_label(bool is_v)
        {
            if (is_v)
            {
                float[] label_values = new float[6];
                float a = (a_v[1] - a_v[0]) / 5;
                Label[] yl_v = form.get_yl_v();
                for (int i = 0; i < 6; i++)
                {
                    label_values[i] = (float)Math.Round(a_v[0] + (a * i), 3);
                }
                for (int i = 0; i < 6; i++)
                {
                    yl_v[i].Text = label_values[i].ToString();
                }
            }
            else
            {
                float[] label_values = new float[6];
                float a = (a_c[1] - a_c[0]) / 5;
                Label[] yl_c = form.get_yl_c();
                for (int i = 0; i < 6; i++)
                {
                    label_values[i] = (float)Math.Round(a_c[0] + (a * i), 3);
                }

                for (int i = 0; i < 6; i++)
                {
                    yl_c[i].Text = label_values[i].ToString();
                }
            }
        }

        //vol그래프 화면에 보이는 범위 x값에 해당하는 y값 최대최소
        public void vol_min_n_max()
        {
            float a, b;
            
            if (display_v_y.Count != 0)
            {
                a = display_v_y.Min();
                b = display_v_y.Max();
                float c = (float)Math.Round((((b - a) * 1.25) / 3 / 2), 3);
                
                if (a == b)
                {
                    if (a > 1.333)
                    {
                        a_v[0] = a - 1;
                        a_v[1] = b + 1;
                    }
                    else
                    {
                        a_v[0] = -1;
                        a_v[1] = 1;
                    }
                }
                else
                {
                    a_v[0] = a - c;
                    a_v[1] = b + c;
                }
            }
            else
            {
                a_v[0] = -1;
                a_v[1] = 1;
            }
        }

        //cur그래프 화면에 보이는 범위 x값에 해당하는 y값 최대최소
        public void cur_min_n_max()
        {
            float a, b;
            
            set_track_bar_c();
            if (display_c_y.Count != 0)
            {
                a = display_c_y.Min();
                b = display_c_y.Max();
                float c = (float)Math.Round((((b - a) * 1.25) / 3 / 2), 3);
                if (a == b)
                {
                    if (a > 1.333)
                    {
                        a_c[0] = a - 1;
                        a_c[1] = b + 1;
                    }
                    else
                    {
                        a_c[0] = -1;
                        a_c[1] = 1;
                    }
                }
                else
                {
                    a_c[0] = a - c;
                    a_c[1] = b + c;
                }
            }
            else
            {
                a_c[0] = -1;
                a_c[1] = 1;
            }
        }

        //그래프 x 최대 최소 계산
        private void graph_min_n_max(bool is_v)
        {
            if (is_v)
            {
                mx_v = form.get_tm() + 2500;
                if (mx_v < 10000)
                {
                    mx_v = 10000;
                }
                mi_v = mx_v - 10000;
            }
            else
            {
                mx_c = form.get_tm() + 2500;
                if (mx_c < 10000)
                {
                    mx_c = 10000;
                }
                mi_c = mx_c - 10000;
            }
        }


        //autoRange 범위 구하기
        private void v_x_auto_range()
        {
            graph_min_n_max(true);
            
            form.get_vol_graph().ChartAreas[0].AxisX.Minimum = mi_v;
            form.get_vol_graph().ChartAreas[0].AxisX.Maximum = mx_v;

            set_x_label(true);

            //스크롤 설정
            form.get_vhscrollbar().Maximum = (int)mx_v;
            form.get_vhscrollbar().Value = (int)mi_v;

            vol_min_n_max();
            set_track_bar_v();
            set_marker(form.get_marker_bar_v().Value, true);
        }
        
        private void v_y_auto_range()
        {
            if (form.get_y_v().Count != 0)
            {
                vol_min_n_max();
                b_v = a_v;
            }
            else
            {
                float[] d = new float[2];
                d[0] = -1;
                d[1] = 1;
                a_v = d;
                b_v = d;
            }
            //만약 현재 설정된 y scrollbar value가 b_v[0]보다 작다면 b_v[0]으로 설정
            if (form.get_vvscrollbar().Value/1000 < b_v[0])
            {
                form.get_vvscrollbar().Value = (int)(b_v[0]*1000);
            }
            form.get_vol_graph().ChartAreas[0].AxisY.Minimum = b_v[0];
            form.get_vol_graph().ChartAreas[0].AxisY.Maximum = b_v[1];
            set_y_label(true);
            form.get_vvscrollbar().Value = (int)(b_v[0]*1000);
            set_marker(form.get_marker_bar_v().Value, true);
        }

        private void c_x_auto_range()
        {
            graph_min_n_max(false);
            
            form.get_cur_graph().ChartAreas[0].AxisX.Minimum = mi_c;
            form.get_cur_graph().ChartAreas[0].AxisX.Maximum = mx_c;

            set_x_label(false);

            //스크롤 설정
            form.get_chscrollbar().Maximum = (int)mx_c;
            form.get_chscrollbar().Value = (int)mi_c;

            cur_min_n_max();
            set_track_bar_c();
            set_marker(form.get_marker_bar_c().Value, false);
        }

        private void c_y_auto_range()
        {
            if (form.get_y_c().Count != 0)
            {
                cur_min_n_max();
                b_c = a_c;
            }
            else
            {
                float[] d = new float[2];
                d[0] = -1;
                d[1] = 1;
                a_c = d;
                b_c = d;
            }
            form.get_cur_graph().ChartAreas[0].AxisY.Minimum = b_c[0];
            form.get_cur_graph().ChartAreas[0].AxisY.Maximum = b_c[1];
            set_y_label(false);
            form.get_cvscrollbar().Value = (int)(b_c[0]*1000);
            set_marker(form.get_marker_bar_c().Value, false);
        }

        public void set_track_bar_v()
        {
            display_v_y.Clear();
            display_v_index.Clear();
            List<float> x = form.get_x();
            List<float> y = form.get_y_v();
            for (int i = 0; i < x.Count; i++)
            {
                if (x[i] < mi_v)
                {
                    continue;
                }
                else if (x[i] >= mi_v && x[i] <= mx_v)
                {
                    display_v_y.Add(y[i]);
                    display_v_index.Add(i);
                }
                else if (x[i] > mx_v)
                {
                    break;
                }
            }
            if (display_v_index.Count != 0)
            {
                form.get_marker_bar_v().Enabled = true;
                if (form.get_marker_bar_v().Value < display_v_index[0])
                {
                    form.get_marker_bar_v().Value = display_v_index[0];
                }
                else if (form.get_marker_bar_v().Value > display_v_index[display_v_index.Count - 1])
                {
                    form.get_marker_bar_v().Value = display_v_index[display_v_index.Count - 1];
                }
                form.get_marker_bar_v().Minimum = display_v_index[0];
                form.get_marker_bar_v().Maximum = display_v_index[display_v_index.Count-1];
            }
            else
            {
                form.vol_marker_hide();
            }
        }

        public void set_track_bar_c()
        {
            display_c_y.Clear();
            display_c_index.Clear();
            List<float> x = form.get_x();
            List<float> y = form.get_y_c();

            for (int i = 0; i < x.Count; i++)
            {
                if (x[i] < mi_c)
                {
                    continue;
                }
                else if (x[i] >= mi_c && x[i] <= mx_c)
                {
                    display_c_y.Add(y[i]);
                    display_c_index.Add(i);
                }
                else if (x[i] > mx_c)
                {
                    break;
                }
            }
            if (display_c_index.Count != 0)
            {
                form.get_marker_bar_c().Enabled = true;
                if (form.get_marker_bar_c().Value < display_c_index[0])
                {
                    form.get_marker_bar_c().Value = display_c_index[0];
                }
                else if (form.get_marker_bar_c().Value > display_c_index[display_c_index.Count - 1])
                {
                    form.get_marker_bar_c().Value = display_c_index[display_c_index.Count - 1];
                }
                form.get_marker_bar_c().Minimum = display_c_index[0];
                form.get_marker_bar_c().Maximum = display_c_index[display_c_index.Count-1];
            }
            else
            {
                form.cur_marker_hide();
            }
        }
        //스크롤 따라 그래프 움직임
        private void vh_scroll()
        {
            float range = Math.Abs(mx_v - mi_v);
            mi_v = form.get_vhscrollbar().Value;
            mx_v = form.get_vhscrollbar().Value + range;
            form.get_vol_graph().ChartAreas[0].AxisX.Minimum = mi_v;
            form.get_vol_graph().ChartAreas[0].AxisX.Maximum = mx_v;
            set_x_label(true);
            set_track_bar_v();
            set_marker(form.get_marker_bar_v().Value, true);
        }

        private void vv_scroll()
        {
            float range = Math.Abs(a_v[1] - a_v[0]);
            
            form.get_vol_graph().ChartAreas[0].AxisY.Minimum = -form.get_vvscrollbar().Value/1000;
            form.get_vol_graph().ChartAreas[0].AxisY.Maximum = -form.get_vvscrollbar().Value/1000 + range;

            a_v[0] = -form.get_vvscrollbar().Value/1000;
            a_v[1] = -form.get_vvscrollbar().Value/1000 + range;
            set_y_label(true);
            set_marker(form.get_marker_bar_v().Value, true);
        }

        private void ch_scroll()
        {
            float range = Math.Abs(mx_c - mi_c);
            mi_c = form.get_chscrollbar().Value;
            mx_c = form.get_chscrollbar().Value + range;
            form.get_cur_graph().ChartAreas[0].AxisX.Minimum = mi_c;
            form.get_cur_graph().ChartAreas[0].AxisX.Maximum = mx_c;
            set_x_label(false);
            set_track_bar_c();
            set_marker(form.get_marker_bar_c().Value, false);
        }

        private void cv_scroll()
        {
            float range = Math.Abs(a_c[1] - a_c[0]);
            
            form.get_cur_graph().ChartAreas[0].AxisY.Minimum = -form.get_cvscrollbar().Value/1000;
            form.get_cur_graph().ChartAreas[0].AxisY.Maximum = -form.get_cvscrollbar().Value/1000 + range;

            a_c[0] = -form.get_cvscrollbar().Value / 1000;
            a_c[1] = -form.get_cvscrollbar().Value/1000 + range;
            set_y_label(false);
            set_marker(form.get_marker_bar_c().Value, false);
        }


        //mouse drag
        public void mouse_down(object sender, MouseEventArgs e, bool is_vol)
        {
            if (is_vol)
            {
                is_vol_mouse_down = true;
                current_location = get_cursor_x_y(e.X, e.Y, is_vol);
            }
            else
            {
                is_cur_mouse_down = true;
                current_location = get_cursor_x_y(e.X, e.Y, is_vol);
            }
        }
        
        public void mouse_move(object sender, MouseEventArgs e, bool is_vol)
        {
            if (is_vol)
            {
                if (is_vol_mouse_down)
                {
                    before_location = current_location;
                    current_location = get_cursor_x_y(e.X, e.Y, is_vol);
                    float[] dif = new float[2];
                    dif[0] = (before_location[0] - current_location[0]);
                    dif[1] = (before_location[1] - current_location[1]);
                    mi_v = (float)form.get_vol_graph().ChartAreas[0].AxisX.Minimum + dif[0];
                    mx_v = (float)form.get_vol_graph().ChartAreas[0].AxisX.Maximum + dif[0];
                    a_v[0] = (float)form.get_vol_graph().ChartAreas[0].AxisY.Minimum + dif[1];
                    a_v[1] = (float)form.get_vol_graph().ChartAreas[0].AxisY.Maximum + dif[1];
                    form.get_vol_graph().ChartAreas[0].AxisX.Minimum = mi_v;
                    form.get_vol_graph().ChartAreas[0].AxisX.Maximum = mx_v;
                    form.get_vol_graph().ChartAreas[0].AxisY.Minimum = a_v[0];
                    form.get_vol_graph().ChartAreas[0].AxisY.Maximum = a_v[1];
                    set_x_label(true);
                    set_y_label(true);
                    set_track_bar_v();
                    set_marker(form.get_marker_bar_v().Value, true);
                }
            }
            else
            {
                if (is_cur_mouse_down)
                {
                    before_location = current_location;
                    current_location = get_cursor_x_y(e.X, e.Y, is_vol);
                    float[] dif = new float[2];
                    dif[0] = (before_location[0] - current_location[0]);
                    dif[1] = (before_location[1] - current_location[1]);
                    mi_c = (float)form.get_cur_graph().ChartAreas[0].AxisX.Minimum + dif[0];
                    mx_c = (float)form.get_cur_graph().ChartAreas[0].AxisX.Maximum + dif[0];
                    a_c[0] = (float)form.get_cur_graph().ChartAreas[0].AxisY.Minimum + dif[1];
                    a_c[1] = (float)form.get_cur_graph().ChartAreas[0].AxisY.Maximum + dif[1];
                    form.get_cur_graph().ChartAreas[0].AxisX.Minimum = mi_c;
                    form.get_cur_graph().ChartAreas[0].AxisX.Maximum = mx_c;
                    form.get_cur_graph().ChartAreas[0].AxisY.Minimum = a_c[0];
                    form.get_cur_graph().ChartAreas[0].AxisY.Maximum = a_c[1];
                    set_x_label(false);
                    set_y_label(false);
                    set_track_bar_c();
                    set_marker(form.get_marker_bar_c().Value, false);
                }
            }

        }
        public void mouse_up(object sender, MouseEventArgs e, bool is_vol)
        {
            if (is_vol)
            {
                is_vol_mouse_down = false;
                before_location = current_location;
                current_location = get_cursor_x_y(e.X, e.Y, is_vol);
                float[] dif = new float[2];
                dif[0] = (before_location[0] - current_location[0]);
                dif[1] = (before_location[1] - current_location[1]);
                mi_v = (float)form.get_vol_graph().ChartAreas[0].AxisX.Minimum + dif[0];
                mx_v = (float)form.get_vol_graph().ChartAreas[0].AxisX.Maximum + dif[0];
                a_v[0] = (float)form.get_vol_graph().ChartAreas[0].AxisY.Minimum + dif[1];
                a_v[1] = (float)form.get_vol_graph().ChartAreas[0].AxisY.Maximum + dif[1];
                form.get_vol_graph().ChartAreas[0].AxisX.Minimum = mi_v;
                form.get_vol_graph().ChartAreas[0].AxisX.Maximum = mx_v;
                form.get_vol_graph().ChartAreas[0].AxisY.Minimum = a_v[0];
                form.get_vol_graph().ChartAreas[0].AxisY.Maximum = a_v[1];
                set_x_label(true);
                set_y_label(true);
                set_track_bar_v();
                set_marker(form.get_marker_bar_v().Value, true);
            }
            else
            {
                is_cur_mouse_down = false;
                before_location = current_location;
                current_location = get_cursor_x_y(e.X, e.Y, is_vol);
                float[] dif = new float[2];
                dif[0] = (before_location[0] - current_location[0]);
                dif[1] = (before_location[1] - current_location[1]);
                mi_c = (float)form.get_cur_graph().ChartAreas[0].AxisX.Minimum + dif[0];
                mx_c = (float)form.get_cur_graph().ChartAreas[0].AxisX.Maximum + dif[0];
                a_c[0] = (float)form.get_cur_graph().ChartAreas[0].AxisY.Minimum + dif[1];
                a_c[1] = (float)form.get_cur_graph().ChartAreas[0].AxisY.Maximum + dif[1];
                form.get_cur_graph().ChartAreas[0].AxisX.Minimum = mi_c;
                form.get_cur_graph().ChartAreas[0].AxisX.Maximum = mx_c;
                form.get_cur_graph().ChartAreas[0].AxisY.Minimum = a_c[0];
                form.get_cur_graph().ChartAreas[0].AxisY.Maximum = a_c[1];
                set_x_label(false);
                set_y_label(false);
                set_track_bar_c();
                set_marker(form.get_marker_bar_c().Value, false);
            }
        }
        public void mouse_up(object sender, MouseEventArgs e)
        {
            is_vol_mouse_down = false;
            is_cur_mouse_down = false;
        }
        public void mouse_leave(object sender, EventArgs e)
        {
            is_vol_mouse_down = false;
            is_cur_mouse_down = false;
        }

        //커서 위치의 x, y값
        public float[] get_cursor_x_y(int x, int y, bool is_vol)
        {
            float[] point = new float[2];
            float[] scale = new float[2];
            
            if (is_vol)
            {   scale[0] = (mx_v - mi_v) / (630 - 75);
                scale[1] = (a_v[1] - a_v[0]) / (122 - 5);
                float y_offset_v = a_v[0];
                point[0] = (x - 83) * scale[0] + mi_v;
                point[1] = (122 - y) * scale[1] + y_offset_v;
            }
            else
            {
                scale[0] = (mx_c - mi_c) / (630 - 75);
                scale[1] = (a_c[1] - a_c[0]) / (122 - 5);
                float y_offset_c = a_c[0];
                point[0] = (x - 83) * scale[0] + mi_c;
                point[1] = (122 - y) * scale[1] + y_offset_c;
            }
            return point;
        }

        //x, y값 위치의 Location
        public Point get_location(double x, double y, bool is_vol)
        {
            int[] point = new int[2];
            float[] scale = new float[2];
            if (is_vol)
            {
                scale[0] = (mx_v - mi_v) / (630 - 75);
                scale[1] = (a_v[1] - a_v[0]) / (122 - 5);
                point[0] = (int)((x-mi_v) / scale[0]) + 83;
                point[1] = 122 - (int)((y - a_v[0]) / scale[1]);
                return new Point(point[0], point[1]);
            }
            else
            {
                scale[0] = (mx_c - mi_c) / (630 - 75);
                scale[1] = (a_c[1] - a_c[0]) / (122 - 5);
                point[0] = (int)((x-mi_c) / scale[0]) + 83;
                point[1] = 122 - (int)((y - a_c[0]) / scale[1]);
                return new Point(point[0], point[1]);
            }
            
        }

        //marker의 위치와 표시되는 정보 설정
        public void set_marker(int num, bool is_vol)
        {
            if (is_vol)
            {
                double x = form.get_x()[num];
                double y = form.get_y_v()[num];
                Point point = get_location(x, y, is_vol);
                Point p = new Point(0, 0);
                form.get_marker_v().Location = point;
                form.get_marker_v().Text = ("time: " + x.ToString() + "ms\n\rV: " + Math.Round(y, 3).ToString());
                p.X = point.X - 6;
                p.Y = point.Y - 5;
                form.get_round_marker_v().Location = p;
                form.set_marker_bar_v(num);
            }
            else
            {
                double x = form.get_x()[num];
                double y = form.get_y_c()[num];
                Point point = get_location(x, y, is_vol);
                Point p = new Point(0, 0);
                form.get_marker_c().Location = point;
                form.get_marker_c().Text = ("time: " + x.ToString() + "ms\n\rmA: " + Math.Round(y, 3).ToString());
                p.X = point.X - 6;
                p.Y = point.Y - 5;
                form.get_round_marker_c().Location = p;
                form.set_marker_bar_c(num);
            }
        }

        //가장 가까운 x, y를 찾아 너무 멀지 않다면 marker를 설정함. 
        public void click_marker_v(int x, int y)
        {
            //[x, y]
            float[] point = get_cursor_x_y(x, y, true);
            distant_v.Clear();
            for(int i = 0; i < display_v_index.Count; i++)
            {
                int index = display_v_index[i];
                distant_v.Add((Math.Pow(point[0] - form.get_x()[index], 2)) + Math.Pow(point[1] - form.get_y_v()[index], 2));
            }

            int num = display_v_index[distant_v.IndexOf(distant_v.Min())];
            Point p = get_location(form.get_x()[num], form.get_y_v()[num], true);
            double dis = Math.Sqrt(Math.Pow(x - p.X, 2) + Math.Pow(y - p.Y, 2));
            if (dis > 100)
            {
                form.vol_marker_hide();
            }
            else
            {
                form.get_marker_bar_v().Value = num;
            }
        }

        public void click_marker_c(int x, int y)
        {
            //[x, y]
            float[] point = get_cursor_x_y(x, y, false);
            distant_c.Clear();
            for (int i = 0; i < display_c_index.Count; i++)
            {
                int index = display_c_index[i];
                distant_c.Add((Math.Pow(point[0] - form.get_x()[index], 2)) + Math.Pow(point[1] - form.get_y_c()[index], 2));
            }

            int num = display_c_index[distant_c.IndexOf(distant_c.Min())];
            Point p = get_location(form.get_x()[num], form.get_y_c()[num], false);
            double dis = Math.Sqrt(Math.Pow(x - p.X, 2) + Math.Pow(y - p.Y, 2));
            if (dis > 50)
            {
                form.cur_marker_hide();
            }
            else
            {
                form.get_marker_bar_c().Value = num;
            }
        }

    }
}
