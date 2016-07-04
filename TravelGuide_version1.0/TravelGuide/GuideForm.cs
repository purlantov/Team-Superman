namespace TravelGuide
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class GuideForm : Form
    {
        public GuideForm()
        {
            InitializeComponent();
            listBox_Continent.Scale(new SizeF(1, 1));
            listBox_Continent.Resize += listBox_Continent_Resize; //delegate
        }

        private void button_OnExit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void listBox_Continent_Resize(object sender, EventArgs e)
        {
            PrintContinent("asia");
        }

        public void PrintContinent(string list)
        {
            listBox_Continent.Items.Add(list);
        }
    }
}
