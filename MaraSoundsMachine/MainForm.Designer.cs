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
            this.freqRand_Label = new System.Windows.Forms.Label();
            this.freqRand1_Label = new System.Windows.Forms.Label();
            this.freqRand0_Label = new System.Windows.Forms.Label();
            this.freqRandomness_trackBar = new System.Windows.Forms.TrackBar();
            this.volumeRand1_Label = new System.Windows.Forms.Label();
            this.volumeRand0_label = new System.Windows.Forms.Label();
            this.volumeRandomness_Label = new System.Windows.Forms.Label();
            this.volumeRandomness_trackBar = new System.Windows.Forms.TrackBar();
            this.panRandom1_Label = new System.Windows.Forms.Label();
            this.panRandom0_Label = new System.Windows.Forms.Label();
            this.panRandomness_Label = new System.Windows.Forms.Label();
            this.panRandomness_trackBar = new System.Windows.Forms.TrackBar();
            this.randomSoundFreqH_Label = new System.Windows.Forms.Label();
            this.randomSoundFreqL_Label = new System.Windows.Forms.Label();
            this.randomFrequency_Label = new System.Windows.Forms.Label();
            this.randomFrequency_trackBar = new System.Windows.Forms.TrackBar();
            this.volume1_Label = new System.Windows.Forms.Label();
            this.volume0_Label = new System.Windows.Forms.Label();
            this.volumeControl_Label = new System.Windows.Forms.Label();
            this.volumeControl_trackBar = new System.Windows.Forms.TrackBar();
            this.rEar_Label = new System.Windows.Forms.Label();
            this.lEar_Label = new System.Windows.Forms.Label();
            this.panControl_Label = new System.Windows.Forms.Label();
            this.panControl_trackBar = new System.Windows.Forms.TrackBar();
            this.sampleSelector_Label = new System.Windows.Forms.Label();
            this.sampleSelector_comboBox = new System.Windows.Forms.ComboBox();
            this.soundSource_Enabled_checkBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addSoundSource_Button = new System.Windows.Forms.Button();
            this.removeSoundSource_Button = new System.Windows.Forms.Button();
            this.soundPanel_tabControl.SuspendLayout();
            this.soundSource_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freqRandomness_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeRandomness_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panRandomness_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomFrequency_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panControl_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // soundPanel_tabControl
            // 
            this.soundPanel_tabControl.Controls.Add(this.soundSource_tabPage);
            this.soundPanel_tabControl.Location = new System.Drawing.Point(14, 13);
            this.soundPanel_tabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.soundPanel_tabControl.Multiline = true;
            this.soundPanel_tabControl.Name = "soundPanel_tabControl";
            this.soundPanel_tabControl.SelectedIndex = 0;
            this.soundPanel_tabControl.Size = new System.Drawing.Size(905, 459);
            this.soundPanel_tabControl.TabIndex = 0;
            // 
            // soundSource_tabPage
            // 
            this.soundSource_tabPage.BackColor = System.Drawing.Color.Black;
            this.soundSource_tabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.soundSource_tabPage.Controls.Add(this.freqRand_Label);
            this.soundSource_tabPage.Controls.Add(this.freqRand1_Label);
            this.soundSource_tabPage.Controls.Add(this.freqRand0_Label);
            this.soundSource_tabPage.Controls.Add(this.freqRandomness_trackBar);
            this.soundSource_tabPage.Controls.Add(this.volumeRand1_Label);
            this.soundSource_tabPage.Controls.Add(this.volumeRand0_label);
            this.soundSource_tabPage.Controls.Add(this.volumeRandomness_Label);
            this.soundSource_tabPage.Controls.Add(this.volumeRandomness_trackBar);
            this.soundSource_tabPage.Controls.Add(this.panRandom1_Label);
            this.soundSource_tabPage.Controls.Add(this.panRandom0_Label);
            this.soundSource_tabPage.Controls.Add(this.panRandomness_Label);
            this.soundSource_tabPage.Controls.Add(this.panRandomness_trackBar);
            this.soundSource_tabPage.Controls.Add(this.randomSoundFreqH_Label);
            this.soundSource_tabPage.Controls.Add(this.randomSoundFreqL_Label);
            this.soundSource_tabPage.Controls.Add(this.randomFrequency_Label);
            this.soundSource_tabPage.Controls.Add(this.randomFrequency_trackBar);
            this.soundSource_tabPage.Controls.Add(this.volume1_Label);
            this.soundSource_tabPage.Controls.Add(this.volume0_Label);
            this.soundSource_tabPage.Controls.Add(this.volumeControl_Label);
            this.soundSource_tabPage.Controls.Add(this.volumeControl_trackBar);
            this.soundSource_tabPage.Controls.Add(this.rEar_Label);
            this.soundSource_tabPage.Controls.Add(this.lEar_Label);
            this.soundSource_tabPage.Controls.Add(this.panControl_Label);
            this.soundSource_tabPage.Controls.Add(this.panControl_trackBar);
            this.soundSource_tabPage.Controls.Add(this.sampleSelector_Label);
            this.soundSource_tabPage.Controls.Add(this.sampleSelector_comboBox);
            this.soundSource_tabPage.Controls.Add(this.soundSource_Enabled_checkBox);
            this.soundSource_tabPage.Location = new System.Drawing.Point(4, 23);
            this.soundSource_tabPage.Name = "soundSource_tabPage";
            this.soundSource_tabPage.Size = new System.Drawing.Size(897, 432);
            this.soundSource_tabPage.TabIndex = 0;
            this.soundSource_tabPage.Text = "Jjaro Ship Creak";
            // 
            // freqRand_Label
            // 
            this.freqRand_Label.AutoSize = true;
            this.freqRand_Label.Location = new System.Drawing.Point(376, 255);
            this.freqRand_Label.Name = "freqRand_Label";
            this.freqRand_Label.Size = new System.Drawing.Size(147, 14);
            this.freqRand_Label.TabIndex = 27;
            this.freqRand_Label.Text = "Frequency Randomness";
            // 
            // freqRand1_Label
            // 
            this.freqRand1_Label.AutoSize = true;
            this.freqRand1_Label.Location = new System.Drawing.Point(550, 303);
            this.freqRand1_Label.Name = "freqRand1_Label";
            this.freqRand1_Label.Size = new System.Drawing.Size(28, 14);
            this.freqRand1_Label.TabIndex = 26;
            this.freqRand1_Label.Text = "100";
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
            // freqRandomness_trackBar
            // 
            this.freqRandomness_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freqRandomness_trackBar.LargeChange = 10;
            this.freqRandomness_trackBar.Location = new System.Drawing.Point(310, 272);
            this.freqRandomness_trackBar.Maximum = 100;
            this.freqRandomness_trackBar.Name = "freqRandomness_trackBar";
            this.freqRandomness_trackBar.Size = new System.Drawing.Size(261, 45);
            this.freqRandomness_trackBar.SmallChange = 5;
            this.freqRandomness_trackBar.TabIndex = 24;
            this.freqRandomness_trackBar.TickFrequency = 5;
            this.freqRandomness_trackBar.ValueChanged += new System.EventHandler(this.soundControl_freqRandomnessValueChanged);
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
            this.volumeRandomness_Label.Location = new System.Drawing.Point(387, 180);
            this.volumeRandomness_Label.Name = "volumeRandomness_Label";
            this.volumeRandomness_Label.Size = new System.Drawing.Size(126, 14);
            this.volumeRandomness_Label.TabIndex = 21;
            this.volumeRandomness_Label.Text = "Volume Randomness";
            // 
            // volumeRandomness_trackBar
            // 
            this.volumeRandomness_trackBar.LargeChange = 10;
            this.volumeRandomness_trackBar.Location = new System.Drawing.Point(310, 197);
            this.volumeRandomness_trackBar.Maximum = 100;
            this.volumeRandomness_trackBar.Name = "volumeRandomness_trackBar";
            this.volumeRandomness_trackBar.Size = new System.Drawing.Size(261, 45);
            this.volumeRandomness_trackBar.SmallChange = 5;
            this.volumeRandomness_trackBar.TabIndex = 20;
            this.volumeRandomness_trackBar.TickFrequency = 5;
            this.volumeRandomness_trackBar.ValueChanged += new System.EventHandler(this.soundControl_volumeRandomnessValueChanged);
            // 
            // panRandom1_Label
            // 
            this.panRandom1_Label.AutoSize = true;
            this.panRandom1_Label.Location = new System.Drawing.Point(550, 154);
            this.panRandom1_Label.Name = "panRandom1_Label";
            this.panRandom1_Label.Size = new System.Drawing.Size(28, 14);
            this.panRandom1_Label.TabIndex = 19;
            this.panRandom1_Label.Text = "100";
            // 
            // panRandom0_Label
            // 
            this.panRandom0_Label.AutoSize = true;
            this.panRandom0_Label.Location = new System.Drawing.Point(314, 154);
            this.panRandom0_Label.Name = "panRandom0_Label";
            this.panRandom0_Label.Size = new System.Drawing.Size(14, 14);
            this.panRandom0_Label.TabIndex = 18;
            this.panRandom0_Label.Text = "0";
            // 
            // panRandomness_Label
            // 
            this.panRandomness_Label.AutoSize = true;
            this.panRandomness_Label.Location = new System.Drawing.Point(396, 106);
            this.panRandomness_Label.Name = "panRandomness_Label";
            this.panRandomness_Label.Size = new System.Drawing.Size(105, 14);
            this.panRandomness_Label.TabIndex = 17;
            this.panRandomness_Label.Text = "Pan Randomness";
            // 
            // panRandomness_trackBar
            // 
            this.panRandomness_trackBar.LargeChange = 10;
            this.panRandomness_trackBar.Location = new System.Drawing.Point(310, 123);
            this.panRandomness_trackBar.Maximum = 100;
            this.panRandomness_trackBar.Name = "panRandomness_trackBar";
            this.panRandomness_trackBar.Size = new System.Drawing.Size(261, 45);
            this.panRandomness_trackBar.SmallChange = 5;
            this.panRandomness_trackBar.TabIndex = 16;
            this.panRandomness_trackBar.TickFrequency = 5;
            this.panRandomness_trackBar.ValueChanged += new System.EventHandler(this.soundControl_panRandomnessValueChanged);
            // 
            // randomSoundFreqH_Label
            // 
            this.randomSoundFreqH_Label.AutoSize = true;
            this.randomSoundFreqH_Label.Location = new System.Drawing.Point(261, 303);
            this.randomSoundFreqH_Label.Name = "randomSoundFreqH_Label";
            this.randomSoundFreqH_Label.Size = new System.Drawing.Size(28, 14);
            this.randomSoundFreqH_Label.TabIndex = 15;
            this.randomSoundFreqH_Label.Text = "100";
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
            // randomFrequency_Label
            // 
            this.randomFrequency_Label.AutoSize = true;
            this.randomFrequency_Label.Location = new System.Drawing.Point(76, 255);
            this.randomFrequency_Label.Name = "randomFrequency_Label";
            this.randomFrequency_Label.Size = new System.Drawing.Size(161, 14);
            this.randomFrequency_Label.TabIndex = 13;
            this.randomFrequency_Label.Text = "Random Sound Frequency";
            // 
            // randomFrequency_trackBar
            // 
            this.randomFrequency_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomFrequency_trackBar.LargeChange = 10;
            this.randomFrequency_trackBar.Location = new System.Drawing.Point(21, 272);
            this.randomFrequency_trackBar.Maximum = 100;
            this.randomFrequency_trackBar.Minimum = 1;
            this.randomFrequency_trackBar.Name = "randomFrequency_trackBar";
            this.randomFrequency_trackBar.Size = new System.Drawing.Size(261, 45);
            this.randomFrequency_trackBar.SmallChange = 5;
            this.randomFrequency_trackBar.TabIndex = 12;
            this.randomFrequency_trackBar.TickFrequency = 5;
            this.randomFrequency_trackBar.Value = 50;
            this.randomFrequency_trackBar.ValueChanged += new System.EventHandler(this.soundControl_baseFrequencyValueChanged);
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
            // volumeControl_trackBar
            // 
            this.volumeControl_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeControl_trackBar.LargeChange = 10;
            this.volumeControl_trackBar.Location = new System.Drawing.Point(21, 197);
            this.volumeControl_trackBar.Maximum = 100;
            this.volumeControl_trackBar.Name = "volumeControl_trackBar";
            this.volumeControl_trackBar.Size = new System.Drawing.Size(261, 45);
            this.volumeControl_trackBar.SmallChange = 5;
            this.volumeControl_trackBar.TabIndex = 8;
            this.volumeControl_trackBar.TickFrequency = 5;
            this.volumeControl_trackBar.Value = 100;
            this.volumeControl_trackBar.ValueChanged += new System.EventHandler(this.soundControl_volumeStateChanged);
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
            this.panControl_Label.Location = new System.Drawing.Point(123, 106);
            this.panControl_Label.Name = "panControl_Label";
            this.panControl_Label.Size = new System.Drawing.Size(56, 14);
            this.panControl_Label.TabIndex = 5;
            this.panControl_Label.Text = "Panning";
            // 
            // panControl_trackBar
            // 
            this.panControl_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panControl_trackBar.LargeChange = 10;
            this.panControl_trackBar.Location = new System.Drawing.Point(21, 123);
            this.panControl_trackBar.Maximum = 100;
            this.panControl_trackBar.Minimum = -100;
            this.panControl_trackBar.Name = "panControl_trackBar";
            this.panControl_trackBar.Size = new System.Drawing.Size(261, 45);
            this.panControl_trackBar.SmallChange = 5;
            this.panControl_trackBar.TabIndex = 4;
            this.panControl_trackBar.TickFrequency = 5;
            this.panControl_trackBar.ValueChanged += new System.EventHandler(this.soundControl_panStateChanged);
            this.panControl_trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panning_mouseRelease);
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
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(583, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.testButtonClick);
            // 
            // addSoundSource_Button
            // 
            this.addSoundSource_Button.ForeColor = System.Drawing.Color.Black;
            this.addSoundSource_Button.Location = new System.Drawing.Point(227, 7);
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
            this.removeSoundSource_Button.Location = new System.Drawing.Point(390, 6);
            this.removeSoundSource_Button.Name = "removeSoundSource_Button";
            this.removeSoundSource_Button.Size = new System.Drawing.Size(158, 23);
            this.removeSoundSource_Button.TabIndex = 3;
            this.removeSoundSource_Button.Text = "Remove Sound Source";
            this.removeSoundSource_Button.UseVisualStyleBackColor = true;
            this.removeSoundSource_Button.Click += new System.EventHandler(this.removeSoundSource_buttonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MaraSoundsMachine.Properties.Resources.m1_sounds;
            this.ClientSize = new System.Drawing.Size(933, 461);
            this.Controls.Add(this.removeSoundSource_Button);
            this.Controls.Add(this.addSoundSource_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.soundPanel_tabControl);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm";
            this.Text = "Marathon Sounds Machine v0.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainFormResized);
            this.soundPanel_tabControl.ResumeLayout(false);
            this.soundSource_tabPage.ResumeLayout(false);
            this.soundSource_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freqRandomness_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeRandomness_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panRandomness_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomFrequency_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panControl_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl soundPanel_tabControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage soundSource_tabPage;
        private System.Windows.Forms.CheckBox soundSource_Enabled_checkBox;
        private System.Windows.Forms.Button addSoundSource_Button;
        private System.Windows.Forms.Button removeSoundSource_Button;
        private System.Windows.Forms.ComboBox sampleSelector_comboBox;
        private System.Windows.Forms.Label sampleSelector_Label;
        private System.Windows.Forms.TrackBar panControl_trackBar;
        private System.Windows.Forms.Label panControl_Label;
        private System.Windows.Forms.Label lEar_Label;
        private System.Windows.Forms.Label rEar_Label;
        private System.Windows.Forms.TrackBar volumeControl_trackBar;
        private System.Windows.Forms.Label volumeControl_Label;
        private System.Windows.Forms.Label volume0_Label;
        private System.Windows.Forms.Label volume1_Label;
        private System.Windows.Forms.TrackBar randomFrequency_trackBar;
        private System.Windows.Forms.Label randomFrequency_Label;
        private System.Windows.Forms.Label randomSoundFreqL_Label;
        private System.Windows.Forms.Label randomSoundFreqH_Label;
        private System.Windows.Forms.TrackBar panRandomness_trackBar;
        private System.Windows.Forms.Label panRandomness_Label;
        private System.Windows.Forms.Label panRandom0_Label;
        private System.Windows.Forms.Label panRandom1_Label;
        private System.Windows.Forms.TrackBar volumeRandomness_trackBar;
        private System.Windows.Forms.Label volumeRandomness_Label;
        private System.Windows.Forms.Label volumeRand0_label;
        private System.Windows.Forms.Label volumeRand1_Label;
        private System.Windows.Forms.TrackBar freqRandomness_trackBar;
        private System.Windows.Forms.Label freqRand0_Label;
        private System.Windows.Forms.Label freqRand1_Label;
        private System.Windows.Forms.Label freqRand_Label;
    }
}

