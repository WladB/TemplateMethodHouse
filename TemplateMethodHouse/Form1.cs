using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateMethodHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AbstractHouse.g = this.CreateGraphics();
        }
       void CreateHouse(AbstractHouse abstractClass)
        { 
            abstractClass.TemplateMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateHouse(new SimpleHouse());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateHouse(new TwoDoorHouse());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateHouse(new HouseWithAnnex());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateHouse(new HouseModified());
        }
    }
}
