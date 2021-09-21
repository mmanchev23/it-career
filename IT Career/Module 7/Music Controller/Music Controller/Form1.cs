using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Controller
{
    public partial class MusicController : Form
    {
        public MusicController()
        {
            InitializeComponent();
        }
        
        CloseForm closeForm = new CloseForm();

        string[] paths, files;

        public static int ChangeText { get; set; }

        private void ListBoxSelectedSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Play indexed song
            WindowsMediaPlayerSongs.URL = paths[ListBoxSelectedSongs.SelectedIndex];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseForm closeForm = new CloseForm();
            DialogResult dlgr = closeForm.ShowDialog();
            if (dlgr == DialogResult.Yes)
                Close();

            closeForm.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void WindowsMediaPlayerSongs_Enter(object sender, EventArgs e)
        {

        }

        private void MusicController_Load(object sender, EventArgs e)
        {
            WindowsMediaPlayerSongs.settings.autoStart = false;
        }

        private void MusicController_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void MusicController_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void WindowsMediaPlayerSongs_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {

        }

        private void WindowsMediaPlayerSongs_KeyUpEvent(object sender, AxWMPLib._WMPOCXEvents_KeyUpEvent e)
        {

        }

        private void WindowsMediaPlayerSongs_KeyPressEvent(object sender, AxWMPLib._WMPOCXEvents_KeyPressEvent e)
        {

        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            //You can select multiple songs at once
            ofd.Multiselect = true;

            //Adds the selected songs to the ListBox
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    ListBoxSelectedSongs.Items.Add(files[i]);
                }
            }
        }

        private void btnBG_Click(object sender, EventArgs e)
        {
            btnSelectSongs.Text = "Изберете песни";
            lblLogo.Text = "Музикален плейър";
            ChangeText = 1;
        }

        private void btnEN_Click(object sender, EventArgs e)
        {
            btnSelectSongs.Text = "Select Songs";
            lblLogo.Text = "Music Player";
            ChangeText = 2;
        }

        private void MusicController_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void MusicController_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnDE_Click(object sender, EventArgs e)
        {
            btnSelectSongs.Text = "Lieder auswählen";
            lblLogo.Text = "Musikspieler";
            ChangeText = 3;
        }
    }
}
