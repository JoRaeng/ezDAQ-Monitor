using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YG
{
    public partial class Form2 : Form
    {
        Form1 form1 = null;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void save_Click(object sender, EventArgs e)
        {
            form1.get_excel().file_name = file_name.Text;
            Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
