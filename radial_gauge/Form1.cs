using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Gauge;

namespace radial_gauge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //RadialGauge radialGauge1 = new RadialGauge();

            this.radialGauge1.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;

            this.radialGauge1.MinorDifference = 50;

            this.radialGauge1.Value = 50;

            this.Controls.Add(radialGauge1);

        }
    }
}
