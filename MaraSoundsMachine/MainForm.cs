using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.Multimedia;
using SharpDX.XAudio2;

namespace MaraSoundsMachine
{

    public partial class MainForm : Form
    {

        #region Main Form Components
        public MainForm()
        {
            InitializeComponent();
            ResizeTabControl();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainFormResized(object sender, EventArgs e)
        {
            ResizeTabControl();
        }
        #endregion

        #region Tab Control Components
        private void ResizeTabControl()
        {
            soundPanel_tabControl.Size = new Size(this.Size.Width - 50, this.Size.Height - 70);
        }

        private void testButtonClick(object sender, EventArgs e)
        {
            AudioHandler.StartPlayWave(AudioHandler.WaveName.Loon0, 1, 0);
        }

        private void addSoundSource_buttonClick(object sender, EventArgs e)
        {
            soundPanel_tabControl.TabPages.Add("Water");
        }

        private void removeSoundSource_buttonClick(object sender, EventArgs e)
        {
            if (soundPanel_tabControl.TabPages.Count > 1)
            {
                soundPanel_tabControl.TabPages.RemoveAt(soundPanel_tabControl.TabPages.Count - 1);
            }
        }

        private void panning_mouseRelease(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                panControl_trackBar.Value = 0;
            }
        }
        #endregion

    }
}
