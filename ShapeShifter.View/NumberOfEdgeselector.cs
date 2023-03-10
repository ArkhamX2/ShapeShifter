using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeShifter.View
{
    public partial class NumberOfEdgeselector : Form
    {
        public NumberOfEdgeselector()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.textBoxNumberOfEdges.Text = this.textBoxNumberOfEdges.Text;
            this.Close();
        }
    }
}
