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
            this.button1 = new System.Windows.Forms.Button();
            this.soundSource_tabPage = new System.Windows.Forms.TabPage();
            this.soundSource_Enabled_checkBox = new System.Windows.Forms.CheckBox();
            this.addSoundSource_Button = new System.Windows.Forms.Button();
            this.removeSoundSource_Button = new System.Windows.Forms.Button();
            this.soundPanel_tabControl.SuspendLayout();
            this.soundSource_tabPage.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.testButtonClick);
            // 
            // soundSource_tabPage
            // 
            this.soundSource_tabPage.BackColor = System.Drawing.Color.Black;
            this.soundSource_tabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.soundSource_tabPage.Controls.Add(this.soundSource_Enabled_checkBox);
            this.soundSource_tabPage.Location = new System.Drawing.Point(4, 23);
            this.soundSource_tabPage.Name = "soundSource_tabPage";
            this.soundSource_tabPage.Size = new System.Drawing.Size(897, 432);
            this.soundSource_tabPage.TabIndex = 0;
            this.soundSource_tabPage.Text = "Water";
            // 
            // soundSource_Enabled_checkBox
            // 
            this.soundSource_Enabled_checkBox.AutoSize = true;
            this.soundSource_Enabled_checkBox.Location = new System.Drawing.Point(38, 13);
            this.soundSource_Enabled_checkBox.Name = "soundSource_Enabled_checkBox";
            this.soundSource_Enabled_checkBox.Size = new System.Drawing.Size(82, 18);
            this.soundSource_Enabled_checkBox.TabIndex = 0;
            this.soundSource_Enabled_checkBox.Text = "Enabled?";
            this.soundSource_Enabled_checkBox.UseVisualStyleBackColor = true;
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
            this.DoubleBuffered = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl soundPanel_tabControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage soundSource_tabPage;
        private System.Windows.Forms.CheckBox soundSource_Enabled_checkBox;
        private System.Windows.Forms.Button addSoundSource_Button;
        private System.Windows.Forms.Button removeSoundSource_Button;
    }
}

