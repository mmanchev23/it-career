
namespace Music_Controller
{
    partial class MusicController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicController));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDE = new System.Windows.Forms.Button();
            this.btnEN = new System.Windows.Forms.Button();
            this.btnBG = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.ListBoxSelectedSongs = new System.Windows.Forms.ListBox();
            this.btnSelectSongs = new System.Windows.Forms.Button();
            this.WindowsMediaPlayerSongs = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayerSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.btnDE);
            this.panel1.Controls.Add(this.btnEN);
            this.panel1.Controls.Add(this.btnBG);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblLogo);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnDE
            // 
            this.btnDE.BackgroundImage = global::Music_Controller.Properties.Resources.изтеглен_файл;
            resources.ApplyResources(this.btnDE, "btnDE");
            this.btnDE.Name = "btnDE";
            this.btnDE.UseVisualStyleBackColor = true;
            this.btnDE.Click += new System.EventHandler(this.btnDE_Click);
            // 
            // btnEN
            // 
            this.btnEN.BackgroundImage = global::Music_Controller.Properties.Resources._1200px_Flag_of_the_United_Kingdom_svg;
            resources.ApplyResources(this.btnEN, "btnEN");
            this.btnEN.Name = "btnEN";
            this.btnEN.UseVisualStyleBackColor = true;
            this.btnEN.Click += new System.EventHandler(this.btnEN_Click);
            // 
            // btnBG
            // 
            this.btnBG.BackgroundImage = global::Music_Controller.Properties.Resources._1200px_Flag_of_Bulgaria_svg;
            resources.ApplyResources(this.btnBG, "btnBG");
            this.btnBG.Name = "btnBG";
            this.btnBG.UseVisualStyleBackColor = true;
            this.btnBG.Click += new System.EventHandler(this.btnBG_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLogo
            // 
            resources.ApplyResources(this.lblLogo, "lblLogo");
            this.lblLogo.Name = "lblLogo";
            // 
            // ListBoxSelectedSongs
            // 
            this.ListBoxSelectedSongs.FormattingEnabled = true;
            resources.ApplyResources(this.ListBoxSelectedSongs, "ListBoxSelectedSongs");
            this.ListBoxSelectedSongs.Name = "ListBoxSelectedSongs";
            this.ListBoxSelectedSongs.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedSongs_SelectedIndexChanged);
            // 
            // btnSelectSongs
            // 
            resources.ApplyResources(this.btnSelectSongs, "btnSelectSongs");
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.UseVisualStyleBackColor = true;
            this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // WindowsMediaPlayerSongs
            // 
            resources.ApplyResources(this.WindowsMediaPlayerSongs, "WindowsMediaPlayerSongs");
            this.WindowsMediaPlayerSongs.Name = "WindowsMediaPlayerSongs";
            this.WindowsMediaPlayerSongs.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayerSongs.OcxState")));
            this.WindowsMediaPlayerSongs.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.WindowsMediaPlayerSongs_KeyDownEvent);
            this.WindowsMediaPlayerSongs.KeyPressEvent += new AxWMPLib._WMPOCXEvents_KeyPressEventHandler(this.WindowsMediaPlayerSongs_KeyPressEvent);
            this.WindowsMediaPlayerSongs.KeyUpEvent += new AxWMPLib._WMPOCXEvents_KeyUpEventHandler(this.WindowsMediaPlayerSongs_KeyUpEvent);
            this.WindowsMediaPlayerSongs.Enter += new System.EventHandler(this.WindowsMediaPlayerSongs_Enter);
            // 
            // MusicController
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.WindowsMediaPlayerSongs);
            this.Controls.Add(this.btnSelectSongs);
            this.Controls.Add(this.ListBoxSelectedSongs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicController";
            this.Load += new System.EventHandler(this.MusicController_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MusicController_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MusicController_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MusicController_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MusicController_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayerSongs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.ListBox ListBoxSelectedSongs;
        private System.Windows.Forms.Button btnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayerSongs;
        private System.Windows.Forms.Button btnDE;
        private System.Windows.Forms.Button btnEN;
        private System.Windows.Forms.Button btnBG;
    }
}

