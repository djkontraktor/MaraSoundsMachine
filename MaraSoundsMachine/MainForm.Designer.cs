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
            this.SuspendLayout();
            // 
            // soundPanel_tabControl
            // 
            this.soundPanel_tabControl.Location = new System.Drawing.Point(14, 13);
            this.soundPanel_tabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.soundPanel_tabControl.Multiline = true;
            this.soundPanel_tabControl.Name = "soundPanel_tabControl";
            this.soundPanel_tabControl.SelectedIndex = 0;
            this.soundPanel_tabControl.Size = new System.Drawing.Size(905, 459);
            this.soundPanel_tabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MaraSoundsMachine.Properties.Resources.m1_sounds;
            this.ClientSize = new System.Drawing.Size(933, 461);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl soundPanel_tabControl;
    }
}

