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

        private void panning_mouseRelease(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                panControl_trackBar.Value = 0;
            }
        }

        private TabPage ReturnDefaultTabPage()
        {
            TabPage thisTabPage = new TabPage();

            #region Control Instantiation
            System.Windows.Forms.Label freqRand_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label freqRand0_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label freqRand1_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.TrackBar freqRandomness_trackBar = new System.Windows.Forms.TrackBar();

            System.Windows.Forms.TrackBar volumeRandomness_trackBar = new System.Windows.Forms.TrackBar();
            System.Windows.Forms.Label volumeRandomness_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label volumeRand0_label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label volumeRand1_Label = new System.Windows.Forms.Label();

            System.Windows.Forms.TrackBar panRandomness_trackBar = new System.Windows.Forms.TrackBar();
            System.Windows.Forms.Label panRandomness_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label panRandom0_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label panRandom1_Label = new System.Windows.Forms.Label();

            System.Windows.Forms.TrackBar randomFrequency_trackBar = new System.Windows.Forms.TrackBar();
            System.Windows.Forms.Label randomFrequency_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label randomSoundFreqL_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label randomSoundFreqH_Label = new System.Windows.Forms.Label();

            System.Windows.Forms.TrackBar volumeControl_trackBar = new System.Windows.Forms.TrackBar();
            System.Windows.Forms.Label volumeControl_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label volume0_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label volume1_Label = new System.Windows.Forms.Label();

            System.Windows.Forms.TrackBar panControl_trackBar = new System.Windows.Forms.TrackBar();
            System.Windows.Forms.Label panControl_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lEar_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label rEar_Label = new System.Windows.Forms.Label();

            System.Windows.Forms.ComboBox sampleSelector_comboBox = new System.Windows.Forms.ComboBox();
            System.Windows.Forms.Label sampleSelector_Label = new System.Windows.Forms.Label();

            System.Windows.Forms.CheckBox soundSource_Enabled_checkBox = new System.Windows.Forms.CheckBox();
            #endregion

            #region Control Definition
            freqRand_Label.AutoSize = true;
            freqRand_Label.Location = new System.Drawing.Point(376, 255);
            freqRand_Label.Name = "freqRand_Label";
            freqRand_Label.Size = new System.Drawing.Size(147, 14);
            freqRand_Label.TabIndex = 27;
            freqRand_Label.Text = "Frequency Randomness";

            freqRand0_Label.AutoSize = true;
            freqRand0_Label.Location = new System.Drawing.Point(314, 303);
            freqRand0_Label.Name = "freqRand0_Label";
            freqRand0_Label.Size = new System.Drawing.Size(14, 14);
            freqRand0_Label.TabIndex = 25;
            freqRand0_Label.Text = "0";

            freqRand1_Label.AutoSize = true;
            freqRand1_Label.Location = new System.Drawing.Point(550, 303);
            freqRand1_Label.Name = "freqRand1_Label";
            freqRand1_Label.Size = new System.Drawing.Size(28, 14);
            freqRand1_Label.TabIndex = 26;
            freqRand1_Label.Text = "100";

            freqRandomness_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            freqRandomness_trackBar.LargeChange = 10;
            freqRandomness_trackBar.Location = new System.Drawing.Point(310, 272);
            freqRandomness_trackBar.Maximum = 100;
            freqRandomness_trackBar.Name = "freqRandomness_trackBar";
            freqRandomness_trackBar.Size = new System.Drawing.Size(261, 45);
            freqRandomness_trackBar.SmallChange = 5;
            freqRandomness_trackBar.TabIndex = 24;
            freqRandomness_trackBar.TickFrequency = 5;

            volumeRand1_Label.AutoSize = true;
            volumeRand1_Label.Location = new System.Drawing.Point(550, 228);
            volumeRand1_Label.Name = "volumeRand1_Label";
            volumeRand1_Label.Size = new System.Drawing.Size(28, 14);
            volumeRand1_Label.TabIndex = 23;
            volumeRand1_Label.Text = "100";

            volumeRand0_label.AutoSize = true;
            volumeRand0_label.Location = new System.Drawing.Point(314, 228);
            volumeRand0_label.Name = "volumeRand0_label";
            volumeRand0_label.Size = new System.Drawing.Size(14, 14);
            volumeRand0_label.TabIndex = 22;
            volumeRand0_label.Text = "0";

            volumeRandomness_Label.AutoSize = true;
            volumeRandomness_Label.Location = new System.Drawing.Point(387, 180);
            volumeRandomness_Label.Name = "volumeRandomness_Label";
            volumeRandomness_Label.Size = new System.Drawing.Size(126, 14);
            volumeRandomness_Label.TabIndex = 21;
            volumeRandomness_Label.Text = "Volume Randomness";

            volumeRandomness_trackBar.LargeChange = 10;
            volumeRandomness_trackBar.Location = new System.Drawing.Point(310, 197);
            volumeRandomness_trackBar.Maximum = 100;
            volumeRandomness_trackBar.Name = "volumeRandomness_trackBar";
            volumeRandomness_trackBar.Size = new System.Drawing.Size(261, 45);
            volumeRandomness_trackBar.SmallChange = 5;
            volumeRandomness_trackBar.TabIndex = 20;
            volumeRandomness_trackBar.TickFrequency = 5;

            panRandom1_Label.AutoSize = true;
            panRandom1_Label.Location = new System.Drawing.Point(550, 154);
            panRandom1_Label.Name = "panRandom1_Label";
            panRandom1_Label.Size = new System.Drawing.Size(28, 14);
            panRandom1_Label.TabIndex = 19;
            panRandom1_Label.Text = "100";

            panRandom0_Label.AutoSize = true;
            panRandom0_Label.Location = new System.Drawing.Point(314, 154);
            panRandom0_Label.Name = "panRandom0_Label";
            panRandom0_Label.Size = new System.Drawing.Size(14, 14);
            panRandom0_Label.TabIndex = 18;
            panRandom0_Label.Text = "0";

            panRandomness_Label.AutoSize = true;
            panRandomness_Label.Location = new System.Drawing.Point(396, 106);
            panRandomness_Label.Name = "panRandomness_Label";
            panRandomness_Label.Size = new System.Drawing.Size(105, 14);
            panRandomness_Label.TabIndex = 17;
            panRandomness_Label.Text = "Pan Randomness";

            panRandomness_trackBar.LargeChange = 10;
            panRandomness_trackBar.Location = new System.Drawing.Point(310, 123);
            panRandomness_trackBar.Maximum = 100;
            panRandomness_trackBar.Name = "panRandomness_trackBar";
            panRandomness_trackBar.Size = new System.Drawing.Size(261, 45);
            panRandomness_trackBar.SmallChange = 5;
            panRandomness_trackBar.TabIndex = 16;
            panRandomness_trackBar.TickFrequency = 5;

            randomSoundFreqH_Label.AutoSize = true;
            randomSoundFreqH_Label.Location = new System.Drawing.Point(261, 303);
            randomSoundFreqH_Label.Name = "randomSoundFreqH_Label";
            randomSoundFreqH_Label.Size = new System.Drawing.Size(28, 14);
            randomSoundFreqH_Label.TabIndex = 15;
            randomSoundFreqH_Label.Text = "100";

            randomSoundFreqL_Label.AutoSize = true;
            randomSoundFreqL_Label.Location = new System.Drawing.Point(23, 303);
            randomSoundFreqL_Label.Name = "randomSoundFreqL_Label";
            randomSoundFreqL_Label.Size = new System.Drawing.Size(14, 14);
            randomSoundFreqL_Label.TabIndex = 14;
            randomSoundFreqL_Label.Text = "1";

            randomFrequency_Label.AutoSize = true;
            randomFrequency_Label.Location = new System.Drawing.Point(76, 255);
            randomFrequency_Label.Name = "randomFrequency_Label";
            randomFrequency_Label.Size = new System.Drawing.Size(161, 14);
            randomFrequency_Label.TabIndex = 13;
            randomFrequency_Label.Text = "Random Sound Frequency";

            randomFrequency_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            randomFrequency_trackBar.LargeChange = 10;
            randomFrequency_trackBar.Location = new System.Drawing.Point(21, 272);
            randomFrequency_trackBar.Maximum = 100;
            randomFrequency_trackBar.Minimum = 1;
            randomFrequency_trackBar.Name = "randomFrequency_trackBar";
            randomFrequency_trackBar.Size = new System.Drawing.Size(261, 45);
            randomFrequency_trackBar.SmallChange = 5;
            randomFrequency_trackBar.TabIndex = 12;
            randomFrequency_trackBar.TickFrequency = 5;
            randomFrequency_trackBar.Value = 50;

            volume1_Label.AutoSize = true;
            volume1_Label.Location = new System.Drawing.Point(261, 228);
            volume1_Label.Name = "volume1_Label";
            volume1_Label.Size = new System.Drawing.Size(28, 14);
            volume1_Label.TabIndex = 11;
            volume1_Label.Text = "100";

            volume0_Label.AutoSize = true;
            volume0_Label.Location = new System.Drawing.Point(23, 228);
            volume0_Label.Name = "volume0_Label";
            volume0_Label.Size = new System.Drawing.Size(14, 14);
            volume0_Label.TabIndex = 10;
            volume0_Label.Text = "0";

            volumeControl_Label.AutoSize = true;
            volumeControl_Label.Location = new System.Drawing.Point(128, 180);
            volumeControl_Label.Name = "volumeControl_Label";
            volumeControl_Label.Size = new System.Drawing.Size(49, 14);
            volumeControl_Label.TabIndex = 9;
            volumeControl_Label.Text = "Volume";

            volumeControl_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            volumeControl_trackBar.LargeChange = 10;
            volumeControl_trackBar.Location = new System.Drawing.Point(21, 197);
            volumeControl_trackBar.Maximum = 100;
            volumeControl_trackBar.Name = "volumeControl_trackBar";
            volumeControl_trackBar.Size = new System.Drawing.Size(261, 45);
            volumeControl_trackBar.SmallChange = 5;
            volumeControl_trackBar.TabIndex = 8;
            volumeControl_trackBar.TickFrequency = 5;
            volumeControl_trackBar.Value = 100;

            rEar_Label.AutoSize = true;
            rEar_Label.Location = new System.Drawing.Point(268, 154);
            rEar_Label.Name = "rEar_Label";
            rEar_Label.Size = new System.Drawing.Size(14, 14);
            rEar_Label.TabIndex = 7;
            rEar_Label.Text = "R";

            lEar_Label.AutoSize = true;
            lEar_Label.Location = new System.Drawing.Point(23, 154);
            lEar_Label.Name = "lEar_Label";
            lEar_Label.Size = new System.Drawing.Size(14, 14);
            lEar_Label.TabIndex = 6;
            lEar_Label.Text = "L";

            panControl_Label.AutoSize = true;
            panControl_Label.Location = new System.Drawing.Point(123, 106);
            panControl_Label.Name = "panControl_Label";
            panControl_Label.Size = new System.Drawing.Size(56, 14);
            panControl_Label.TabIndex = 5;
            panControl_Label.Text = "Panning";

            panControl_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            panControl_trackBar.LargeChange = 10;
            panControl_trackBar.Location = new System.Drawing.Point(21, 123);
            panControl_trackBar.Maximum = 100;
            panControl_trackBar.Minimum = -100;
            panControl_trackBar.Name = "panControl_trackBar";
            panControl_trackBar.Size = new System.Drawing.Size(261, 45);
            panControl_trackBar.SmallChange = 5;
            panControl_trackBar.TabIndex = 4;
            panControl_trackBar.TickFrequency = 5;
            panControl_trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panning_mouseRelease);

            sampleSelector_Label.AutoSize = true;
            sampleSelector_Label.Location = new System.Drawing.Point(110, 54);
            sampleSelector_Label.Name = "sampleSelector_Label";
            sampleSelector_Label.Size = new System.Drawing.Size(77, 14);
            sampleSelector_Label.TabIndex = 3;
            sampleSelector_Label.Text = "Sound Type";

            sampleSelector_comboBox.BackColor = System.Drawing.Color.Black;
            sampleSelector_comboBox.ForeColor = System.Drawing.Color.Lime;
            sampleSelector_comboBox.FormattingEnabled = true;
            sampleSelector_comboBox.Items.AddRange(new object[] {
            "Jjaro Ship Creak",
            "Loon",
            "Water",
            "Sewage",
            "Lava",
            "Goo",
            "Under Media",
            "Wind",
            "Waterfall",
            "Siren",
            "Fan",
            "S\'pht Platform",
            "Alien Harmonics",
            "Heavy S\'pht Platform",
            "Light Machinery",
            "Heavy Machinery",
            "Transformer",
            "Sparking Transformer",
            "Water Drip",
            "Machine Binder",
            "Machine Bookpress",
            "Machine Puncher",
            "Electric",
            "Alarm",
            "Night Wind",
            "Surface Explosion",
            "Underground Explosion",
            "Pfhor Platform",
            "Pfhor Door",
            "Alien Ship 1",
            "Alien Ship 2"});
            sampleSelector_comboBox.Location = new System.Drawing.Point(26, 71);
            sampleSelector_comboBox.Name = "sampleSelector_comboBox";
            sampleSelector_comboBox.Size = new System.Drawing.Size(271, 22);
            sampleSelector_comboBox.TabIndex = 2;
            sampleSelector_comboBox.Text = "Jjaro Ship Creak";

            soundSource_Enabled_checkBox.AutoSize = true;
            soundSource_Enabled_checkBox.Location = new System.Drawing.Point(105, 17);
            soundSource_Enabled_checkBox.Name = "soundSource_Enabled_checkBox";
            soundSource_Enabled_checkBox.Size = new System.Drawing.Size(82, 18);
            soundSource_Enabled_checkBox.TabIndex = 0;
            soundSource_Enabled_checkBox.Text = "Enabled?";
            soundSource_Enabled_checkBox.UseVisualStyleBackColor = true;
            #endregion

            #region Tab Page Definition
            thisTabPage.BackColor = System.Drawing.Color.Black;
            thisTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            thisTabPage.Location = new System.Drawing.Point(4, 23);
            thisTabPage.Name = "soundSource_tabPage";
            thisTabPage.Size = new System.Drawing.Size(897, 432);
            //thisTabPage.TabIndex = 0;
            thisTabPage.Text = "Jjaro Ship Creak";
            thisTabPage.Controls.Add(freqRand_Label);
            thisTabPage.Controls.Add(freqRand0_Label);
            thisTabPage.Controls.Add(freqRand1_Label);
            thisTabPage.Controls.Add(freqRandomness_trackBar);
            thisTabPage.Controls.Add(volumeRand0_label);
            thisTabPage.Controls.Add(volumeRand1_Label);
            thisTabPage.Controls.Add(volumeRandomness_Label);
            thisTabPage.Controls.Add(volumeRandomness_trackBar);
            thisTabPage.Controls.Add(panRandomness_Label);
            thisTabPage.Controls.Add(panRandom0_Label);
            thisTabPage.Controls.Add(panRandom1_Label);
            thisTabPage.Controls.Add(panRandomness_trackBar);
            thisTabPage.Controls.Add(randomSoundFreqH_Label);
            thisTabPage.Controls.Add(randomSoundFreqL_Label);
            thisTabPage.Controls.Add(randomFrequency_Label);
            thisTabPage.Controls.Add(randomFrequency_trackBar);
            thisTabPage.Controls.Add(volume1_Label);
            thisTabPage.Controls.Add(volume0_Label);
            thisTabPage.Controls.Add(volumeControl_Label);
            thisTabPage.Controls.Add(volumeControl_trackBar);
            thisTabPage.Controls.Add(rEar_Label);
            thisTabPage.Controls.Add(lEar_Label);
            thisTabPage.Controls.Add(panControl_Label);
            thisTabPage.Controls.Add(panControl_trackBar);
            thisTabPage.Controls.Add(sampleSelector_Label);
            thisTabPage.Controls.Add(sampleSelector_comboBox);
            thisTabPage.Controls.Add(soundSource_Enabled_checkBox);
            #endregion

            return thisTabPage;
        }
        #endregion

        #region Button Callbacks
        private void testButtonClick(object sender, EventArgs e)
        {
            AudioHandler.StartPlayWave(AudioHandler.WaveName.Loon0, 1, 0);
        }

        private void addSoundSource_buttonClick(object sender, EventArgs e)
        {
            TabPage defaultTabPage = ReturnDefaultTabPage();

            soundPanel_tabControl.TabPages.Add(defaultTabPage);
        }

        private void removeSoundSource_buttonClick(object sender, EventArgs e)
        {
            if (soundPanel_tabControl.TabPages.Count > 1)
            {
                soundPanel_tabControl.TabPages.RemoveAt(soundPanel_tabControl.TabPages.Count - 1);
            }
        }
        #endregion

    }
}
