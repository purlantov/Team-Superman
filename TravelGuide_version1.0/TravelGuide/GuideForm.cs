using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelGuide
{
    public partial class GuideForm : Form
    {
        public GuideForm()
        {
            InitializeComponent();
        }

        private void button_OnExit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
