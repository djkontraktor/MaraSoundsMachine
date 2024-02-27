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
            Thread.CurrentThread.IsBackground = true;

            InitializeComponent();

            SoundSource defaultSoundSource = new SoundSource();
            AudioHandler.soundSourcesList.Add(defaultSoundSource);
        }
        #endregion

        #region Constructors/Destructors
        private TabPage ReturnDefaultTabPage()
        {
            TabPage newDefaultTabPage = new TabPage();

            #region Control Instantiation
            System.Windows.Forms.CheckBox soundSource_Enabled_checkBox = new System.Windows.Forms.CheckBox();

            System.Windows.Forms.Label sampleSelector_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.ComboBox sampleSelector_comboBox = new System.Windows.Forms.ComboBox();

            System.Windows.Forms.Label pan_Header = new System.Windows.Forms.Label();
            System.Windows.Forms.TrackBar pan_trackBar = new System.Windows.Forms.TrackBar();
            System.Windows.Forms.Label panL_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label panR_Label = new System.Windows.Forms.Label();

            System.Windows.Forms.Label volume_Header = new System.Windows.Forms.Label();
            System.Windows.Forms.TrackBar volume_trackBar = new System.Windows.Forms.TrackBar();
            System.Windows.Forms.Label volumeL_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label volumeR_Label = new System.Windows.Forms.Label();

            System.Windows.Forms.Label period_Header = new System.Windows.Forms.Label();
            System.Windows.Forms.TrackBar period_trackBar = new System.Windows.Forms.TrackBar();
            System.Windows.Forms.Label periodL_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label periodR_Label = new System.Windows.Forms.Label();

            System.Windows.Forms.Label pitch_Header = new System.Windows.Forms.Label();
            System.Windows.Forms.TrackBar pitch_trackBar = new System.Windows.Forms.TrackBar();
            System.Windows.Forms.Label pitchL_label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label pitchR_label = new System.Windows.Forms.Label();

            System.Windows.Forms.Label deltaPan_Header = new System.Windows.Forms.Label();
            System.Windows.Forms.TrackBar deltaPan_trackBar = new System.Windows.Forms.TrackBar();
            System.Windows.Forms.Label deltaPanL_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label deltaPanR_Label = new System.Windows.Forms.Label();
            
            System.Windows.Forms.Label deltaVolume_Header = new System.Windows.Forms.Label();
            System.Windows.Forms.TrackBar deltaVolume_trackBar = new System.Windows.Forms.TrackBar();
            System.Windows.Forms.Label deltaVolumeL_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label deltaVolumeR_Label = new System.Windows.Forms.Label();

            System.Windows.Forms.Label deltaPeriod_Header = new System.Windows.Forms.Label();
            System.Windows.Forms.TrackBar deltaPeriod_trackBar = new System.Windows.Forms.TrackBar();
            System.Windows.Forms.Label deltaPeriodL_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label deltaPeriodR_Label = new System.Windows.Forms.Label();

            System.Windows.Forms.Label deltaPitch_Header = new System.Windows.Forms.Label();
            System.Windows.Forms.TrackBar deltaPitch_trackBar = new System.Windows.Forms.TrackBar();
            System.Windows.Forms.Label deltaPitchL_Label = new System.Windows.Forms.Label();
            System.Windows.Forms.Label deltaPitchR_Label = new System.Windows.Forms.Label();
            #endregion

            #region Control Definition
            // 
            // deltaPitchR_Label
            // 
            deltaPitchR_Label.AutoSize = true;
            deltaPitchR_Label.Location = new System.Drawing.Point(557, 374);
            deltaPitchR_Label.Name = "deltaPitchR_Label";
            deltaPitchR_Label.Size = new System.Drawing.Size(14, 14);
            deltaPitchR_Label.TabIndex = 35;
            deltaPitchR_Label.Text = "5";
            // 
            // deltaPitchL_Label
            // 
            deltaPitchL_Label.AutoSize = true;
            deltaPitchL_Label.Location = new System.Drawing.Point(310, 374);
            deltaPitchL_Label.Name = "deltaPitchL_Label";
            deltaPitchL_Label.Size = new System.Drawing.Size(28, 14);
            deltaPitchL_Label.TabIndex = 34;
            deltaPitchL_Label.Text = "0.1";
            // 
            // pitchH_Label
            // 
            pitchR_label.AutoSize = true;
            pitchR_label.Location = new System.Drawing.Point(268, 374);
            pitchR_label.Name = "pitchR_label";
            pitchR_label.Size = new System.Drawing.Size(14, 14);
            pitchR_label.TabIndex = 33;
            pitchR_label.Text = "5";
            // 
            // pitchL_Label
            // 
            pitchL_label.AutoSize = true;
            pitchL_label.Location = new System.Drawing.Point(18, 374);
            pitchL_label.Name = "pitchL_label";
            pitchL_label.Size = new System.Drawing.Size(28, 14);
            pitchL_label.TabIndex = 32;
            pitchL_label.Text = "0.1";
            // 
            // deltaPitch_Header
            // 
            deltaPitch_Header.AutoSize = true;
            deltaPitch_Header.Location = new System.Drawing.Point(394, 326);
            deltaPitch_Header.Name = "deltaPitch_Header";
            deltaPitch_Header.Size = new System.Drawing.Size(84, 14);
            deltaPitch_Header.TabIndex = 31;
            deltaPitch_Header.Text = "Delta Pitch";
            // 
            // pitch_Header
            // 
            pitch_Header.AutoSize = true;
            pitch_Header.Location = new System.Drawing.Point(128, 326);
            pitch_Header.Name = "pitch_Header";
            pitch_Header.Size = new System.Drawing.Size(42, 14);
            pitch_Header.TabIndex = 30;
            pitch_Header.Text = "Pitch";
            // 
            // deltaPitch_trackBar
            // 
            deltaPitch_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            deltaPitch_trackBar.LargeChange = 10;
            deltaPitch_trackBar.Location = new System.Drawing.Point(313, 343);
            deltaPitch_trackBar.Maximum = 100;
            deltaPitch_trackBar.Name = "deltaPitch_trackBar";
            deltaPitch_trackBar.Size = new System.Drawing.Size(261, 45);
            deltaPitch_trackBar.TabIndex = 29;
            deltaPitch_trackBar.TickFrequency = 5;
            deltaPitch_trackBar.Value = 100;
            deltaPitch_trackBar.ValueChanged += new System.EventHandler(trackBarMoved);
            // 
            // pitch_trackBar
            // 
            pitch_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            pitch_trackBar.LargeChange = 10;
            pitch_trackBar.Location = new System.Drawing.Point(24, 343);
            pitch_trackBar.Maximum = 100;
            pitch_trackBar.Name = "pitch_trackBar";
            pitch_trackBar.Size = new System.Drawing.Size(261, 45);
            pitch_trackBar.TabIndex = 28;
            pitch_trackBar.TickFrequency = 5;
            pitch_trackBar.Value = 100;
            pitch_trackBar.ValueChanged += new System.EventHandler(trackBarMoved);
            // 
            // deltaPeriod_Header
            // 
            deltaPeriod_Header.AutoSize = true;
            deltaPeriod_Header.Location = new System.Drawing.Point(387, 255);
            deltaPeriod_Header.Name = "deltaPeriod_Header";
            deltaPeriod_Header.Size = new System.Drawing.Size(119, 14);
            deltaPeriod_Header.TabIndex = 27;
            deltaPeriod_Header.Text = "Delta Period (s)";
            // 
            // deltaPeriodR_Label
            // 
            deltaPeriodR_Label.AutoSize = true;
            deltaPeriodR_Label.Location = new System.Drawing.Point(553, 303);
            deltaPeriodR_Label.Name = "deltaPeriodR_Label";
            deltaPeriodR_Label.Size = new System.Drawing.Size(21, 14);
            deltaPeriodR_Label.TabIndex = 26;
            deltaPeriodR_Label.Text = "30";
            // 
            // deltaPeriodL_Label
            // 
            deltaPeriodL_Label.AutoSize = true;
            deltaPeriodL_Label.Location = new System.Drawing.Point(314, 303);
            deltaPeriodL_Label.Name = "deltaPeriodL_Label";
            deltaPeriodL_Label.Size = new System.Drawing.Size(14, 14);
            deltaPeriodL_Label.TabIndex = 25;
            deltaPeriodL_Label.Text = "0";
            // 
            // deltaPeriod_trackBar
            // 
            deltaPeriod_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            deltaPeriod_trackBar.LargeChange = 33;
            deltaPeriod_trackBar.Location = new System.Drawing.Point(310, 272);
            deltaPeriod_trackBar.Maximum = 999;
            deltaPeriod_trackBar.Name = "deltaPeriod_trackBar";
            deltaPeriod_trackBar.Size = new System.Drawing.Size(261, 45);
            deltaPeriod_trackBar.SmallChange = 11;
            deltaPeriod_trackBar.TabIndex = 24;
            deltaPeriod_trackBar.TickFrequency = 5;
            deltaPeriod_trackBar.ValueChanged += new System.EventHandler(trackBarMoved);
            // 
            // deltaVolumeR_Label
            // 
            deltaVolumeR_Label.AutoSize = true;
            deltaVolumeR_Label.Location = new System.Drawing.Point(550, 228);
            deltaVolumeR_Label.Name = "deltaVolumeR_Label";
            deltaVolumeR_Label.Size = new System.Drawing.Size(28, 14);
            deltaVolumeR_Label.TabIndex = 23;
            deltaVolumeR_Label.Text = "100";
            // 
            // deltaVolumeL_Label
            // 
            deltaVolumeL_Label.AutoSize = true;
            deltaVolumeL_Label.Location = new System.Drawing.Point(314, 228);
            deltaVolumeL_Label.Name = "deltaVolumeL_Label";
            deltaVolumeL_Label.Size = new System.Drawing.Size(14, 14);
            deltaVolumeL_Label.TabIndex = 22;
            deltaVolumeL_Label.Text = "0";
            // 
            // deltaVolume_Header
            // 
            deltaVolume_Header.AutoSize = true;
            deltaVolume_Header.Location = new System.Drawing.Point(394, 180);
            deltaVolume_Header.Name = "deltaVolume_Header";
            deltaVolume_Header.Size = new System.Drawing.Size(91, 14);
            deltaVolume_Header.TabIndex = 21;
            deltaVolume_Header.Text = "Delta Volume";
            // 
            // deltaVolume_trackBar
            // 
            deltaVolume_trackBar.LargeChange = 10;
            deltaVolume_trackBar.Location = new System.Drawing.Point(310, 197);
            deltaVolume_trackBar.Maximum = 100;
            deltaVolume_trackBar.Name = "deltaVolume_trackBar";
            deltaVolume_trackBar.Size = new System.Drawing.Size(261, 45);
            deltaVolume_trackBar.TabIndex = 20;
            deltaVolume_trackBar.TickFrequency = 5;
            deltaVolume_trackBar.ValueChanged += new System.EventHandler(trackBarMoved);
            // 
            // deltaPanR_Label
            // 
            deltaPanR_Label.AutoSize = true;
            deltaPanR_Label.Location = new System.Drawing.Point(555, 154);
            deltaPanR_Label.Name = "deltaPanR_Label";
            deltaPanR_Label.Size = new System.Drawing.Size(14, 14);
            deltaPanR_Label.TabIndex = 19;
            deltaPanR_Label.Text = "R";
            // 
            // deltaPanL_Label
            // 
            deltaPanL_Label.AutoSize = true;
            deltaPanL_Label.Location = new System.Drawing.Point(314, 154);
            deltaPanL_Label.Name = "deltaPanL_Label";
            deltaPanL_Label.Size = new System.Drawing.Size(14, 14);
            deltaPanL_Label.TabIndex = 18;
            deltaPanL_Label.Text = "L";
            // 
            // deltaPan_Header
            // 
            deltaPan_Header.AutoSize = true;
            deltaPan_Header.Location = new System.Drawing.Point(404, 106);
            deltaPan_Header.Name = "deltaPan_Header";
            deltaPan_Header.Size = new System.Drawing.Size(70, 14);
            deltaPan_Header.TabIndex = 17;
            deltaPan_Header.Text = "Delta Pan";
            // 
            // deltaPan_trackBar
            // 
            deltaPan_trackBar.LargeChange = 10;
            deltaPan_trackBar.Location = new System.Drawing.Point(310, 123);
            deltaPan_trackBar.Maximum = 100;
            deltaPan_trackBar.Minimum = -100;
            deltaPan_trackBar.Name = "deltaPan_trackBar";
            deltaPan_trackBar.Size = new System.Drawing.Size(261, 45);
            deltaPan_trackBar.TabIndex = 16;
            deltaPan_trackBar.TickFrequency = 5;
            deltaPan_trackBar.ValueChanged += new System.EventHandler(trackBarMoved);
            // 
            // periodR_Label
            // 
            periodR_Label.AutoSize = true;
            periodR_Label.Location = new System.Drawing.Point(264, 303);
            periodR_Label.Name = "periodR_Label";
            periodR_Label.Size = new System.Drawing.Size(21, 14);
            periodR_Label.TabIndex = 15;
            periodR_Label.Text = "30";
            // 
            // periodL_Label
            // 
            periodL_Label.AutoSize = true;
            periodL_Label.Location = new System.Drawing.Point(23, 303);
            periodL_Label.Name = "periodL_Label";
            periodL_Label.Size = new System.Drawing.Size(14, 14);
            periodL_Label.TabIndex = 14;
            periodL_Label.Text = "1";
            // 
            // period_Header
            // 
            period_Header.AutoSize = true;
            period_Header.Location = new System.Drawing.Point(116, 255);
            period_Header.Name = "period_Header";
            period_Header.Size = new System.Drawing.Size(77, 14);
            period_Header.TabIndex = 13;
            period_Header.Text = "Period (s)";
            // 
            // period_trackBar
            // 
            period_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            period_trackBar.LargeChange = 33;
            period_trackBar.Location = new System.Drawing.Point(21, 272);
            period_trackBar.Maximum = 999;
            period_trackBar.Minimum = 1;
            period_trackBar.Name = "period_trackBar";
            period_trackBar.Size = new System.Drawing.Size(261, 45);
            period_trackBar.SmallChange = 11;
            period_trackBar.TabIndex = 12;
            period_trackBar.TickFrequency = 5;
            period_trackBar.Value = 33;
            period_trackBar.ValueChanged += new System.EventHandler(trackBarMoved);
            // 
            // volumeR_Label
            // 
            volumeR_Label.AutoSize = true;
            volumeR_Label.Location = new System.Drawing.Point(261, 228);
            volumeR_Label.Name = "volumeR_Label";
            volumeR_Label.Size = new System.Drawing.Size(28, 14);
            volumeR_Label.TabIndex = 11;
            volumeR_Label.Text = "100";
            // 
            // volumeL_Label
            // 
            volumeL_Label.AutoSize = true;
            volumeL_Label.Location = new System.Drawing.Point(23, 228);
            volumeL_Label.Name = "volumeL_Label";
            volumeL_Label.Size = new System.Drawing.Size(14, 14);
            volumeL_Label.TabIndex = 10;
            volumeL_Label.Text = "0";
            // 
            // volume_Header
            // 
            volume_Header.AutoSize = true;
            volume_Header.Location = new System.Drawing.Point(128, 180);
            volume_Header.Name = "volume_Header";
            volume_Header.Size = new System.Drawing.Size(49, 14);
            volume_Header.TabIndex = 9;
            volume_Header.Text = "Volume";
            // 
            // volume_trackBar
            // 
            volume_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            volume_trackBar.LargeChange = 10;
            volume_trackBar.Location = new System.Drawing.Point(21, 197);
            volume_trackBar.Maximum = 100;
            volume_trackBar.Name = "volume_trackBar";
            volume_trackBar.Size = new System.Drawing.Size(261, 45);
            volume_trackBar.TabIndex = 8;
            volume_trackBar.TickFrequency = 5;
            volume_trackBar.Value = 100;
            volume_trackBar.ValueChanged += new System.EventHandler(trackBarMoved);
            // 
            // panR_Label
            // 
            panR_Label.AutoSize = true;
            panR_Label.Location = new System.Drawing.Point(268, 154);
            panR_Label.Name = "panR_Label";
            panR_Label.Size = new System.Drawing.Size(14, 14);
            panR_Label.TabIndex = 7;
            panR_Label.Text = "R";
            // 
            // panL_Label
            // 
            panL_Label.AutoSize = true;
            panL_Label.Location = new System.Drawing.Point(23, 154);
            panL_Label.Name = "panL_Label";
            panL_Label.Size = new System.Drawing.Size(14, 14);
            panL_Label.TabIndex = 6;
            panL_Label.Text = "L";
            // 
            // pan_Header
            // 
            pan_Header.AutoSize = true;
            pan_Header.Location = new System.Drawing.Point(138, 106);
            pan_Header.Name = "pan_Header";
            pan_Header.Size = new System.Drawing.Size(28, 14);
            pan_Header.TabIndex = 5;
            pan_Header.Text = "Pan";
            // 
            // pan_trackBar
            // 
            pan_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            pan_trackBar.LargeChange = 10;
            pan_trackBar.Location = new System.Drawing.Point(21, 123);
            pan_trackBar.Maximum = 100;
            pan_trackBar.Minimum = -100;
            pan_trackBar.Name = "pan_trackBar";
            pan_trackBar.Size = new System.Drawing.Size(261, 45);
            pan_trackBar.TabIndex = 4;
            pan_trackBar.TickFrequency = 5;
            pan_trackBar.ValueChanged += new System.EventHandler(trackBarMoved);
            pan_trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(pan_TrackBarMouseReleased);
            // 
            // sampleSelector_Label
            // 
            sampleSelector_Label.AutoSize = true;
            sampleSelector_Label.Location = new System.Drawing.Point(110, 54);
            sampleSelector_Label.Name = "sampleSelector_Label";
            sampleSelector_Label.Size = new System.Drawing.Size(77, 14);
            sampleSelector_Label.TabIndex = 3;
            sampleSelector_Label.Text = "Sound Type";
            // 
            // sampleSelector_comboBox
            // 
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
            sampleSelector_comboBox.SelectedIndexChanged += new System.EventHandler(sampleName_ComboBoxStateChanged);
            // 
            // soundSource_Enabled_checkBox
            // 
            soundSource_Enabled_checkBox.AutoSize = true;
            soundSource_Enabled_checkBox.Location = new System.Drawing.Point(105, 17);
            soundSource_Enabled_checkBox.Name = "soundSource_Enabled_checkBox";
            soundSource_Enabled_checkBox.Size = new System.Drawing.Size(82, 18);
            soundSource_Enabled_checkBox.TabIndex = 0;
            soundSource_Enabled_checkBox.Text = "Enabled?";
            soundSource_Enabled_checkBox.UseVisualStyleBackColor = true;
            soundSource_Enabled_checkBox.CheckStateChanged += new System.EventHandler(enable_CheckStateChanged);
            #endregion

            #region Tab Page Definition
            newDefaultTabPage.BackColor = System.Drawing.Color.Black;
            newDefaultTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            newDefaultTabPage.Controls.Add(soundSource_Enabled_checkBox);
            newDefaultTabPage.Controls.Add(sampleSelector_Label);
            newDefaultTabPage.Controls.Add(sampleSelector_comboBox);

            newDefaultTabPage.Controls.Add(pan_Header);
            newDefaultTabPage.Controls.Add(pan_trackBar);
            newDefaultTabPage.Controls.Add(panL_Label);
            newDefaultTabPage.Controls.Add(panR_Label);

            newDefaultTabPage.Controls.Add(volume_Header);
            newDefaultTabPage.Controls.Add(volume_trackBar);
            newDefaultTabPage.Controls.Add(volumeL_Label);
            newDefaultTabPage.Controls.Add(volumeR_Label);

            newDefaultTabPage.Controls.Add(period_Header);
            newDefaultTabPage.Controls.Add(period_trackBar);
            newDefaultTabPage.Controls.Add(periodL_Label);
            newDefaultTabPage.Controls.Add(periodR_Label);

            newDefaultTabPage.Controls.Add(pitch_Header);
            newDefaultTabPage.Controls.Add(pitch_trackBar);
            newDefaultTabPage.Controls.Add(pitchL_label);
            newDefaultTabPage.Controls.Add(pitchR_label);

            newDefaultTabPage.Controls.Add(deltaPan_Header);
            newDefaultTabPage.Controls.Add(deltaPan_trackBar);
            newDefaultTabPage.Controls.Add(deltaPanL_Label);
            newDefaultTabPage.Controls.Add(deltaPanR_Label);

            newDefaultTabPage.Controls.Add(deltaVolume_Header);
            newDefaultTabPage.Controls.Add(deltaVolume_trackBar);
            newDefaultTabPage.Controls.Add(deltaVolumeL_Label);
            newDefaultTabPage.Controls.Add(deltaVolumeR_Label);

            newDefaultTabPage.Controls.Add(deltaPeriod_Header);
            newDefaultTabPage.Controls.Add(deltaPeriod_trackBar);
            newDefaultTabPage.Controls.Add(deltaPeriodL_Label);
            newDefaultTabPage.Controls.Add(deltaPeriodR_Label);

            newDefaultTabPage.Controls.Add(deltaPitch_Header);
            newDefaultTabPage.Controls.Add(deltaPitch_trackBar);
            newDefaultTabPage.Controls.Add(deltaPitchL_Label);
            newDefaultTabPage.Controls.Add(deltaPitchR_Label);

            newDefaultTabPage.Location = new System.Drawing.Point(4, 23);
            newDefaultTabPage.Name = "newDefaultTabPage";
            newDefaultTabPage.Size = new System.Drawing.Size(600, 412);
            newDefaultTabPage.TabIndex = 0;
            newDefaultTabPage.Text = "Jjaro Ship Creak";
            #endregion

            return newDefaultTabPage;
        }
        
        private void AddSoundSource()
        {
            tabHolder_tabControl.TabPages.Add(ReturnDefaultTabPage());
            AudioHandler.soundSourcesList.Add(new SoundSource());
        }

        private void RemoveSoundSource()
        {
            if (tabHolder_tabControl.TabPages.Count > 1)
            {
                tabHolder_tabControl.TabPages.RemoveAt(tabHolder_tabControl.TabPages.Count - 1);
                AudioHandler.soundSourcesList.RemoveAt(AudioHandler.soundSourcesList.Count - 1);
            }
        }
        #endregion

        #region Main Form Button Callbacks
        private void addSoundSource_buttonClick(object sender, EventArgs e)
        {
            AddSoundSource();
        }

        private void removeSoundSource_buttonClick(object sender, EventArgs e)
        {
            RemoveSoundSource();
        }

        private void togglePlayback_ButtonClick(object sender, EventArgs e)
        {
            if (AudioHandler.uiPlaybackEnabled)
            {
                this.startPlayback_Button.Text = "Start Playback";
                AudioHandler.StopAudioPlayback();
            }
            else
            {
                this.startPlayback_Button.Text = "Stop Playback";
                AudioHandler.StartAudioPlayback();
            }
        }
        #endregion

        #region Sound Controls Callbacks
        private void enable_CheckStateChanged(object sender, EventArgs e)
        {
            int currentTab = this.tabHolder_tabControl.SelectedIndex;
            CheckBox thisCheckBox = (CheckBox)sender;

            AudioHandler.soundSourcesList[currentTab].Enabled = thisCheckBox.Checked;
        }

        private void sampleName_ComboBoxStateChanged(object sender, EventArgs e)
        {
            int currentTab = this.tabHolder_tabControl.SelectedIndex;
            ComboBox thisComboBox = (ComboBox)sender;

            string englishSampleName = thisComboBox.Text;

            AudioHandler.soundSourcesList[currentTab].ThisSample = PathMgt.ReturnSampleNameFromEnglishString(englishSampleName);

            this.tabHolder_tabControl.TabPages[currentTab].Text = englishSampleName;
        }

        private void pan_TrackBarMouseReleased(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TrackBar thisTrackBar = (TrackBar)tabHolder_tabControl.SelectedTab.Controls.Find("pan_trackBar", false)[0];
                thisTrackBar.Value = 0;
            }
        }

        private void trackBarMoved(object sender, EventArgs e)
        {
            int currentTab = this.tabHolder_tabControl.SelectedIndex;
            TrackBar thisTrackBar = (TrackBar)sender;

            float factor = 0;

            string thisTrackBarName = thisTrackBar.Name.ToLower();

            #region Which track bar?
            // pitch
            if (thisTrackBarName.StartsWith("pitch") && !thisTrackBarName.Contains("delta"))
            {
                factor = 0.1f;
                AudioHandler.soundSourcesList[currentTab].Base_pitch = (float)(thisTrackBar.Value) * factor;
            }

            // volume
            if (thisTrackBarName.StartsWith("volume") && !thisTrackBarName.Contains("delta"))
            {
                factor = 0.01f;
                AudioHandler.soundSourcesList[currentTab].Base_volume = (float)(thisTrackBar.Value) * factor;
            }

            // period
            if (thisTrackBarName.StartsWith("period") && !thisTrackBarName.Contains("delta"))
            {
                AudioHandler.soundSourcesList[currentTab].Base_period_ticks = thisTrackBar.Value;
            }

            // pan
            if (thisTrackBarName.StartsWith("pan") && !thisTrackBarName.Contains("delta"))
            {
                factor = 0.01f;
                AudioHandler.soundSourcesList[currentTab].Base_pan = (float)(thisTrackBar.Value) * factor;
            }

            // Dpitch
            if (thisTrackBarName.Contains("pitch") && thisTrackBarName.StartsWith("delta"))
            {
                factor = 0.1f;
                AudioHandler.soundSourcesList[currentTab].Delta_pitch = (float)(thisTrackBar.Value) * factor;
            }

            // Dvolume
            if (thisTrackBarName.Contains("volume") && thisTrackBarName.StartsWith("delta"))
            {
                factor = 0.01f;
                AudioHandler.soundSourcesList[currentTab].Delta_volume = (float)(thisTrackBar.Value) * factor;
            }

            // Dperiod
            if (thisTrackBarName.Contains("period") && thisTrackBarName.StartsWith("delta"))
            {
                AudioHandler.soundSourcesList[currentTab].Delta_period_ticks = thisTrackBar.Value;
            }

            // Dpan
            if (thisTrackBarName.Contains("pan") && thisTrackBarName.StartsWith("delta"))
            {
                factor = 0.01f;
                AudioHandler.soundSourcesList[currentTab].Delta_pan = (float)(thisTrackBar.Value) * factor;
            }
            #endregion

        }
        #endregion
    }
}
