using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaraSoundsMachine
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainFormResized(object sender, EventArgs e)
        {

            // Adjust the size of the tab box now proportionally so
            soundPanel_tabControl.Size = MainForm.Size;
        }
    }
}
