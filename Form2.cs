using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Stat { get; set; }
        public int Num{ get; set; }

        private void Enter_Click(object sender, EventArgs e)
        {
           
            Num =Convert.ToUInt16(value.Value);
            Close();
        }

        private void stats_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stat = stats.SelectedItem.ToString();

        }
    }
}
