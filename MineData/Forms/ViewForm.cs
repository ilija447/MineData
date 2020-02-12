using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineData
{
    public partial class dataView : Form
    {
        String data;
        public dataView(string data)
        {
            InitializeComponent();

            this.data = data;

            richTextBox1.Text = data;

            this.Text = "Data";
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
