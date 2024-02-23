namespace MaraSoundsMachine
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.soundPanel_tabControl = new System.Windows.Forms.TabControl();
            this.soundSource_tabPage = new System.Windows.Forms.TabPage();
            this.periodRand_Label = new System.Windows.Forms.Label();
            this.freqRand1_Label = new System.Windows.Forms.Label();
            this.freqRand0_Label = new System.Windows.Forms.Label();
            this.deltaPeriod_trackBar = new System.Windows.Forms.TrackBar();
            this.volumeRand1_Label = new System.Windows.Forms.Label();
            this.volumeRand0_label = new System.Windows.Forms.Label();
            this.volumeRandomness_Label = new System.Windows.Forms.Label();
            this.deltaVolume_trackBar = new System.Windows.Forms.TrackBar();
            this.panRandom1_Label = new System.Windows.Forms.Label();
            this.panRandom0_Label = new System.Windows.Forms.Label();
            this.panRandomness_Label = new System.Windows.Forms.Label();
            this.deltaPan_trackBar = new System.Windows.Forms.TrackBar();
            this.randomSoundFreqH_Label = new System.Windows.Forms.Label();
            this.randomSoundFreqL_Label = new System.Windows.Forms.Label();
            this.period_Label = new System.Windows.Forms.Label();
            this.period_trackBar = new System.Windows.Forms.TrackBar();
            this.volume1_Label = new System.Windows.Forms.Label();
            this.volume0_Label = new System.Windows.Forms.Label();
            this.volumeControl_Label = new System.Windows.Forms.Label();
            this.volume_trackBar = new System.Windows.Forms.TrackBar();
            this.rEar_Label = new System.Windows.Forms.Label();
            this.lEar_Label = new System.Windows.Forms.Label();
            this.panControl_Label = new System.Windows.Forms.Label();
            this.pan_trackBar = new System.Windows.Forms.TrackBar();
            this.sampleSelector_Label = new System.Windows.Forms.Label();
            this.sampleSelector_comboBox = new System.Windows.Forms.ComboBox();
            this.soundSource_Enabled_checkBox = new System.Windows.Forms.CheckBox();
            this.startPlayback_Button = new System.Windows.Forms.Button();
            this.addSoundSource_Button = new System.Windows.Forms.Button();
            this.removeSoundSource_Button = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.pitch_Label = new System.Windows.Forms.Label();
            this.pitchRand_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.soundPanel_tabControl.SuspendLayout();
            this.soundSource_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltaPeriod_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaVolume_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaPan_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // soundPanel_tabControl
            // 
            this.soundPanel_tabControl.Controls.Add(this.soundSource_tabPage);
            this.soundPanel_tabControl.Location = new System.Drawing.Point(13, 36);
            this.soundPanel_tabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.soundPanel_tabControl.Multiline = true;
            this.soundPanel_tabControl.Name = "soundPanel_tabControl";
            this.soundPanel_tabControl.SelectedIndex = 0;
            this.soundPanel_tabControl.Size = new System.Drawing.Size(608, 439);
            this.soundPanel_tabControl.TabIndex = 0;
            // 
            // soundSource_tabPage
            // 
            this.soundSource_tabPage.BackColor = System.Drawing.Color.Black;
            this.soundSource_tabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.soundSource_tabPage.Controls.Add(this.label4);
            this.soundSource_tabPage.Controls.Add(this.label3);
            this.soundSource_tabPage.Controls.Add(this.label2);
            this.soundSource_tabPage.Controls.Add(this.label1);
            this.soundSource_tabPage.Controls.Add(this.pitchRand_Label);
            this.soundSource_tabPage.Controls.Add(this.pitch_Label);
            this.soundSource_tabPage.Controls.Add(this.trackBar2);
            this.soundSource_tabPage.Controls.Add(this.trackBar1);
            this.soundSource_tabPage.Controls.Add(this.periodRand_Label);
            this.soundSource_tabPage.Controls.Add(this.freqRand1_Label);
            this.soundSource_tabPage.Controls.Add(this.freqRand0_Label);
            this.soundSource_tabPage.Controls.Add(this.deltaPeriod_trackBar);
            this.soundSource_tabPage.Controls.Add(this.volumeRand1_Label);
            this.soundSource_tabPage.Controls.Add(this.volumeRand0_label);
            this.soundSource_tabPage.Controls.Add(this.volumeRandomness_Label);
            this.soundSource_tabPage.Controls.Add(this.deltaVolume_trackBar);
            this.soundSource_tabPage.Controls.Add(this.panRandom1_Label);
            this.soundSource_tabPage.Controls.Add(this.panRandom0_Label);
            this.soundSource_tabPage.Controls.Add(this.panRandomness_Label);
            this.soundSource_tabPage.Controls.Add(this.deltaPan_trackBar);
            this.soundSource_tabPage.Controls.Add(this.randomSoundFreqH_Label);
            this.soundSource_tabPage.Controls.Add(this.randomSoundFreqL_Label);
            this.soundSource_tabPage.Controls.Add(this.period_Label);
            this.soundSource_tabPage.Controls.Add(this.period_trackBar);
            this.soundSource_tabPage.Controls.Add(this.volume1_Label);
            this.soundSource_tabPage.Controls.Add(this.volume0_Label);
            this.soundSource_tabPage.Controls.Add(this.volumeControl_Label);
            this.soundSource_tabPage.Controls.Add(this.volume_trackBar);
            this.soundSource_tabPage.Controls.Add(this.rEar_Label);
            this.soundSource_tabPage.Controls.Add(this.lEar_Label);
            this.soundSource_tabPage.Controls.Add(this.panControl_Label);
            this.soundSource_tabPage.Controls.Add(this.pan_trackBar);
            this.soundSource_tabPage.Controls.Add(this.sampleSelector_Label);
            this.soundSource_tabPage.Controls.Add(this.sampleSelector_comboBox);
            this.soundSource_tabPage.Controls.Add(this.soundSource_Enabled_checkBox);
            this.soundSource_tabPage.Location = new System.Drawing.Point(4, 23);
            this.soundSource_tabPage.Name = "soundSource_tabPage";
            this.soundSource_tabPage.Size = new System.Drawing.Size(600, 412);
            this.soundSource_tabPage.TabIndex = 0;
            this.soundSource_tabPage.Text = "Jjaro Ship Creak";
            // 
            // periodRand_Label
            // 
            this.periodRand_Label.AutoSize = true;
            this.periodRand_Label.Location = new System.Drawing.Point(387, 255);
            this.periodRand_Label.Name = "periodRand_Label";
            this.periodRand_Label.Size = new System.Drawing.Size(119, 14);
            this.periodRand_Label.TabIndex = 27;
            this.periodRand_Label.Text = "Delta Period (s)";
            // 
            // freqRand1_Label
            // 
            this.freqRand1_Label.AutoSize = true;
            this.freqRand1_Label.Location = new System.Drawing.Point(553, 303);
            this.freqRand1_Label.Name = "freqRand1_Label";
            this.freqRand1_Label.Size = new System.Drawing.Size(21, 14);
            this.freqRand1_Label.TabIndex = 26;
            this.freqRand1_Label.Text = "30";
            // 
            // freqRand0_Label
            // 
            this.freqRand0_Label.AutoSize = true;
            this.freqRand0_Label.Location = new System.Drawing.Point(314, 303);
            this.freqRand0_Label.Name = "freqRand0_Label";
            this.freqRand0_Label.Size = new System.Drawing.Size(14, 14);
            this.freqRand0_Label.TabIndex = 25;
            this.freqRand0_Label.Text = "0";
            // 
            // deltaPeriod_trackBar
            // 
            this.deltaPeriod_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deltaPeriod_trackBar.LargeChange = 33;
            this.deltaPeriod_trackBar.Location = new System.Drawing.Point(310, 272);
            this.deltaPeriod_trackBar.Maximum = 999;
            this.deltaPeriod_trackBar.Name = "deltaPeriod_trackBar";
            this.deltaPeriod_trackBar.Size = new System.Drawing.Size(261, 45);
            this.deltaPeriod_trackBar.SmallChange = 11;
            this.deltaPeriod_trackBar.TabIndex = 24;
            this.deltaPeriod_trackBar.TickFrequency = 5;
            this.deltaPeriod_trackBar.ValueChanged += new System.EventHandler(this.soundControl_deltaPeriodValueChanged);
            // 
            // volumeRand1_Label
            // 
            this.volumeRand1_Label.AutoSize = true;
            this.volumeRand1_Label.Location = new System.Drawing.Point(550, 228);
            this.volumeRand1_Label.Name = "volumeRand1_Label";
            this.volumeRand1_Label.Size = new System.Drawing.Size(28, 14);
            this.volumeRand1_Label.TabIndex = 23;
            this.volumeRand1_Label.Text = "100";
            // 
            // volumeRand0_label
            // 
            this.volumeRand0_label.AutoSize = true;
            this.volumeRand0_label.Location = new System.Drawing.Point(314, 228);
            this.volumeRand0_label.Name = "volumeRand0_label";
            this.volumeRand0_label.Size = new System.Drawing.Size(14, 14);
            this.volumeRand0_label.TabIndex = 22;
            this.volumeRand0_label.Text = "0";
            // 
            // volumeRandomness_Label
            // 
            this.volumeRandomness_Label.AutoSize = true;
            this.volumeRandomness_Label.Location = new System.Drawing.Point(394, 180);
            this.volumeRandomness_Label.Name = "volumeRandomness_Label";
            this.volumeRandomness_Label.Size = new System.Drawing.Size(91, 14);
            this.volumeRandomness_Label.TabIndex = 21;
            this.volumeRandomness_Label.Text = "Delta Volume";
            // 
            // deltaVolume_trackBar
            // 
            this.deltaVolume_trackBar.LargeChange = 10;
            this.deltaVolume_trackBar.Location = new System.Drawing.Point(310, 197);
            this.deltaVolume_trackBar.Maximum = 100;
            this.deltaVolume_trackBar.Name = "deltaVolume_trackBar";
            this.deltaVolume_trackBar.Size = new System.Drawing.Size(261, 45);
            this.deltaVolume_trackBar.TabIndex = 20;
            this.deltaVolume_trackBar.TickFrequency = 5;
            this.deltaVolume_trackBar.ValueChanged += new System.EventHandler(this.soundControl_volumeRandomnessValueChanged);
            // 
            // panRandom1_Label
            // 
            this.panRandom1_Label.AutoSize = true;
            this.panRandom1_Label.Location = new System.Drawing.Point(555, 154);
            this.panRandom1_Label.Name = "panRandom1_Label";
            this.panRandom1_Label.Size = new System.Drawing.Size(14, 14);
            this.panRandom1_Label.TabIndex = 19;
            this.panRandom1_Label.Text = "R";
            // 
            // panRandom0_Label
            // 
            this.panRandom0_Label.AutoSize = true;
            this.panRandom0_Label.Location = new System.Drawing.Point(314, 154);
            this.panRandom0_Label.Name = "panRandom0_Label";
            this.panRandom0_Label.Size = new System.Drawing.Size(14, 14);
            this.panRandom0_Label.TabIndex = 18;
            this.panRandom0_Label.Text = "L";
            // 
            // panRandomness_Label
            // 
            this.panRandomness_Label.AutoSize = true;
            this.panRandomness_Label.Location = new System.Drawing.Point(404, 106);
            this.panRandomness_Label.Name = "panRandomness_Label";
            this.panRandomness_Label.Size = new System.Drawing.Size(70, 14);
            this.panRandomness_Label.TabIndex = 17;
            this.panRandomness_Label.Text = "Delta Pan";
            // 
            // deltaPan_trackBar
            // 
            this.deltaPan_trackBar.LargeChange = 10;
            this.deltaPan_trackBar.Location = new System.Drawing.Point(310, 123);
            this.deltaPan_trackBar.Maximum = 100;
            this.deltaPan_trackBar.Minimum = -100;
            this.deltaPan_trackBar.Name = "deltaPan_trackBar";
            this.deltaPan_trackBar.Size = new System.Drawing.Size(261, 45);
            this.deltaPan_trackBar.TabIndex = 16;
            this.deltaPan_trackBar.TickFrequency = 5;
            this.deltaPan_trackBar.ValueChanged += new System.EventHandler(this.soundControl_panRandomnessValueChanged);
            // 
            // randomSoundFreqH_Label
            // 
            this.randomSoundFreqH_Label.AutoSize = true;
            this.randomSoundFreqH_Label.Location = new System.Drawing.Point(264, 303);
            this.randomSoundFreqH_Label.Name = "randomSoundFreqH_Label";
            this.randomSoundFreqH_Label.Size = new System.Drawing.Size(21, 14);
            this.randomSoundFreqH_Label.TabIndex = 15;
            this.randomSoundFreqH_Label.Text = "30";
            // 
            // randomSoundFreqL_Label
            // 
            this.randomSoundFreqL_Label.AutoSize = true;
            this.randomSoundFreqL_Label.Location = new System.Drawing.Point(23, 303);
            this.randomSoundFreqL_Label.Name = "randomSoundFreqL_Label";
            this.randomSoundFreqL_Label.Size = new System.Drawing.Size(14, 14);
            this.randomSoundFreqL_Label.TabIndex = 14;
            this.randomSoundFreqL_Label.Text = "1";
            // 
            // period_Label
            // 
            this.period_Label.AutoSize = true;
            this.period_Label.Location = new System.Drawing.Point(116, 255);
            this.period_Label.Name = "period_Label";
            this.period_Label.Size = new System.Drawing.Size(77, 14);
            this.period_Label.TabIndex = 13;
            this.period_Label.Text = "Period (s)";
            // 
            // period_trackBar
            // 
            this.period_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.period_trackBar.LargeChange = 33;
            this.period_trackBar.Location = new System.Drawing.Point(21, 272);
            this.period_trackBar.Maximum = 999;
            this.period_trackBar.Minimum = 1;
            this.period_trackBar.Name = "period_trackBar";
            this.period_trackBar.Size = new System.Drawing.Size(261, 45);
            this.period_trackBar.SmallChange = 11;
            this.period_trackBar.TabIndex = 12;
            this.period_trackBar.TickFrequency = 5;
            this.period_trackBar.Value = 33;
            this.period_trackBar.ValueChanged += new System.EventHandler(this.soundControl_periodValueChanged);
            // 
            // volume1_Label
            // 
            this.volume1_Label.AutoSize = true;
            this.volume1_Label.Location = new System.Drawing.Point(261, 228);
            this.volume1_Label.Name = "volume1_Label";
            this.volume1_Label.Size = new System.Drawing.Size(28, 14);
            this.volume1_Label.TabIndex = 11;
            this.volume1_Label.Text = "100";
            // 
            // volume0_Label
            // 
            this.volume0_Label.AutoSize = true;
            this.volume0_Label.Location = new System.Drawing.Point(23, 228);
            this.volume0_Label.Name = "volume0_Label";
            this.volume0_Label.Size = new System.Drawing.Size(14, 14);
            this.volume0_Label.TabIndex = 10;
            this.volume0_Label.Text = "0";
            // 
            // volumeControl_Label
            // 
            this.volumeControl_Label.AutoSize = true;
            this.volumeControl_Label.Location = new System.Drawing.Point(128, 180);
            this.volumeControl_Label.Name = "volumeControl_Label";
            this.volumeControl_Label.Size = new System.Drawing.Size(49, 14);
            this.volumeControl_Label.TabIndex = 9;
            this.volumeControl_Label.Text = "Volume";
            // 
            // volume_trackBar
            // 
            this.volume_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume_trackBar.LargeChange = 10;
            this.volume_trackBar.Location = new System.Drawing.Point(21, 197);
            this.volume_trackBar.Maximum = 100;
            this.volume_trackBar.Name = "volume_trackBar";
            this.volume_trackBar.Size = new System.Drawing.Size(261, 45);
            this.volume_trackBar.TabIndex = 8;
            this.volume_trackBar.TickFrequency = 5;
            this.volume_trackBar.Value = 100;
            this.volume_trackBar.ValueChanged += new System.EventHandler(this.soundControl_volumeStateChanged);
            // 
            // rEar_Label
            // 
            this.rEar_Label.AutoSize = true;
            this.rEar_Label.Location = new System.Drawing.Point(268, 154);
            this.rEar_Label.Name = "rEar_Label";
            this.rEar_Label.Size = new System.Drawing.Size(14, 14);
            this.rEar_Label.TabIndex = 7;
            this.rEar_Label.Text = "R";
            // 
            // lEar_Label
            // 
            this.lEar_Label.AutoSize = true;
            this.lEar_Label.Location = new System.Drawing.Point(23, 154);
            this.lEar_Label.Name = "lEar_Label";
            this.lEar_Label.Size = new System.Drawing.Size(14, 14);
            this.lEar_Label.TabIndex = 6;
            this.lEar_Label.Text = "L";
            // 
            // panControl_Label
            // 
            this.panControl_Label.AutoSize = true;
            this.panControl_Label.Location = new System.Drawing.Point(138, 106);
            this.panControl_Label.Name = "panControl_Label";
            this.panControl_Label.Size = new System.Drawing.Size(28, 14);
            this.panControl_Label.TabIndex = 5;
            this.panControl_Label.Text = "Pan";
            // 
            // pan_trackBar
            // 
            this.pan_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_trackBar.LargeChange = 10;
            this.pan_trackBar.Location = new System.Drawing.Point(21, 123);
            this.pan_trackBar.Maximum = 100;
            this.pan_trackBar.Minimum = -100;
            this.pan_trackBar.Name = "pan_trackBar";
            this.pan_trackBar.Size = new System.Drawing.Size(261, 45);
            this.pan_trackBar.TabIndex = 4;
            this.pan_trackBar.TickFrequency = 5;
            this.pan_trackBar.ValueChanged += new System.EventHandler(this.soundControl_panStateChanged);
            this.pan_trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panning_mouseRelease);
            // 
            // sampleSelector_Label
            // 
            this.sampleSelector_Label.AutoSize = true;
            this.sampleSelector_Label.Location = new System.Drawing.Point(110, 54);
            this.sampleSelector_Label.Name = "sampleSelector_Label";
            this.sampleSelector_Label.Size = new System.Drawing.Size(77, 14);
            this.sampleSelector_Label.TabIndex = 3;
            this.sampleSelector_Label.Text = "Sound Type";
            // 
            // sampleSelector_comboBox
            // 
            this.sampleSelector_comboBox.BackColor = System.Drawing.Color.Black;
            this.sampleSelector_comboBox.ForeColor = System.Drawing.Color.Lime;
            this.sampleSelector_comboBox.FormattingEnabled = true;
            this.sampleSelector_comboBox.Items.AddRange(new object[] {
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
            this.sampleSelector_comboBox.Location = new System.Drawing.Point(26, 71);
            this.sampleSelector_comboBox.Name = "sampleSelector_comboBox";
            this.sampleSelector_comboBox.Size = new System.Drawing.Size(271, 22);
            this.sampleSelector_comboBox.TabIndex = 2;
            this.sampleSelector_comboBox.Text = "Jjaro Ship Creak";
            this.sampleSelector_comboBox.SelectedIndexChanged += new System.EventHandler(this.soundSource_ComboBox_StateChange);
            // 
            // soundSource_Enabled_checkBox
            // 
            this.soundSource_Enabled_checkBox.AutoSize = true;
            this.soundSource_Enabled_checkBox.Location = new System.Drawing.Point(105, 17);
            this.soundSource_Enabled_checkBox.Name = "soundSource_Enabled_checkBox";
            this.soundSource_Enabled_checkBox.Size = new System.Drawing.Size(82, 18);
            this.soundSource_Enabled_checkBox.TabIndex = 0;
            this.soundSource_Enabled_checkBox.Text = "Enabled?";
            this.soundSource_Enabled_checkBox.UseVisualStyleBackColor = true;
            this.soundSource_Enabled_checkBox.CheckStateChanged += new System.EventHandler(this.soundSource_CheckBoxStateChange);
            // 
            // startPlayback_Button
            // 
            this.startPlayback_Button.ForeColor = System.Drawing.Color.Black;
            this.startPlayback_Button.Location = new System.Drawing.Point(328, 5);
            this.startPlayback_Button.Name = "startPlayback_Button";
            this.startPlayback_Button.Size = new System.Drawing.Size(118, 23);
            this.startPlayback_Button.TabIndex = 1;
            this.startPlayback_Button.Text = "Start Playback";
            this.startPlayback_Button.UseVisualStyleBackColor = true;
            this.startPlayback_Button.Click += new System.EventHandler(this.startPlayback_ButtonClick);
            // 
            // addSoundSource_Button
            // 
            this.addSoundSource_Button.ForeColor = System.Drawing.Color.Black;
            this.addSoundSource_Button.Location = new System.Drawing.Point(13, 5);
            this.addSoundSource_Button.Name = "addSoundSource_Button";
            this.addSoundSource_Button.Size = new System.Drawing.Size(145, 23);
            this.addSoundSource_Button.TabIndex = 2;
            this.addSoundSource_Button.Text = "Add Sound Source";
            this.addSoundSource_Button.UseVisualStyleBackColor = true;
            this.addSoundSource_Button.Click += new System.EventHandler(this.addSoundSource_buttonClick);
            // 
            // removeSoundSource_Button
            // 
            this.removeSoundSource_Button.ForeColor = System.Drawing.Color.Black;
            this.removeSoundSource_Button.Location = new System.Drawing.Point(164, 5);
            this.removeSoundSource_Button.Name = "removeSoundSource_Button";
            this.removeSoundSource_Button.Size = new System.Drawing.Size(158, 23);
            this.removeSoundSource_Button.TabIndex = 3;
            this.removeSoundSource_Button.Text = "Remove Sound Source";
            this.removeSoundSource_Button.UseVisualStyleBackColor = true;
            this.removeSoundSource_Button.Click += new System.EventHandler(this.removeSoundSource_buttonClick);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(24, 343);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(261, 45);
            this.trackBar1.TabIndex = 28;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 100;
            // 
            // trackBar2
            // 
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar2.LargeChange = 10;
            this.trackBar2.Location = new System.Drawing.Point(313, 343);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(261, 45);
            this.trackBar2.TabIndex = 29;
            this.trackBar2.TickFrequency = 5;
            this.trackBar2.Value = 100;
            // 
            // pitch_Label
            // 
            this.pitch_Label.AutoSize = true;
            this.pitch_Label.Location = new System.Drawing.Point(128, 326);
            this.pitch_Label.Name = "pitch_Label";
            this.pitch_Label.Size = new System.Drawing.Size(42, 14);
            this.pitch_Label.TabIndex = 30;
            this.pitch_Label.Text = "Pitch";
            // 
            // pitchRand_Label
            // 
            this.pitchRand_Label.AutoSize = true;
            this.pitchRand_Label.Location = new System.Drawing.Point(394, 326);
            this.pitchRand_Label.Name = "pitchRand_Label";
            this.pitchRand_Label.Size = new System.Drawing.Size(84, 14);
            this.pitchRand_Label.TabIndex = 31;
            this.pitchRand_Label.Text = "Delta Pitch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 14);
            this.label2.TabIndex = 33;
            this.label2.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 14);
            this.label3.TabIndex = 34;
            this.label3.Text = "0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 14);
            this.label4.TabIndex = 35;
            this.label4.Text = "5";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MaraSoundsMachine.Properties.Resources.m1_sounds;
            this.ClientSize = new System.Drawing.Size(634, 490);
            this.Controls.Add(this.removeSoundSource_Button);
            this.Controls.Add(this.addSoundSource_Button);
            this.Controls.Add(this.startPlayback_Button);
            this.Controls.Add(this.soundPanel_tabControl);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 529);
            this.MinimumSize = new System.Drawing.Size(650, 529);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Marathon Sounds Machine v0.1";
            this.soundPanel_tabControl.ResumeLayout(false);
            this.soundSource_tabPage.ResumeLayout(false);
            this.soundSource_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltaPeriod_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaVolume_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaPan_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl soundPanel_tabControl;
        private System.Windows.Forms.Button startPlayback_Button;
        private System.Windows.Forms.TabPage soundSource_tabPage;
        private System.Windows.Forms.CheckBox soundSource_Enabled_checkBox;
        private System.Windows.Forms.Button addSoundSource_Button;
        private System.Windows.Forms.Button removeSoundSource_Button;
        private System.Windows.Forms.ComboBox sampleSelector_comboBox;
        private System.Windows.Forms.Label sampleSelector_Label;
        private System.Windows.Forms.TrackBar pan_trackBar;
        private System.Windows.Forms.Label panControl_Label;
        private System.Windows.Forms.Label lEar_Label;
        private System.Windows.Forms.Label rEar_Label;
        private System.Windows.Forms.TrackBar volume_trackBar;
        private System.Windows.Forms.Label volumeControl_Label;
        private System.Windows.Forms.Label volume0_Label;
        private System.Windows.Forms.Label volume1_Label;
        private System.Windows.Forms.TrackBar period_trackBar;
        private System.Windows.Forms.Label period_Label;
        private System.Windows.Forms.Label randomSoundFreqL_Label;
        private System.Windows.Forms.Label randomSoundFreqH_Label;
        private System.Windows.Forms.TrackBar deltaPan_trackBar;
        private System.Windows.Forms.Label panRandomness_Label;
        private System.Windows.Forms.Label panRandom0_Label;
        private System.Windows.Forms.Label panRandom1_Label;
        private System.Windows.Forms.TrackBar deltaVolume_trackBar;
        private System.Windows.Forms.Label volumeRandomness_Label;
        private System.Windows.Forms.Label volumeRand0_label;
        private System.Windows.Forms.Label volumeRand1_Label;
        private System.Windows.Forms.TrackBar deltaPeriod_trackBar;
        private System.Windows.Forms.Label freqRand0_Label;
        private System.Windows.Forms.Label freqRand1_Label;
        private System.Windows.Forms.Label periodRand_Label;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label pitch_Label;
        private System.Windows.Forms.Label pitchRand_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

