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
    public partial class CloseForm : Form
    {
        public CloseForm()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseForm_Load(object sender, EventArgs e)
        {

            if (MusicController.ChangeText == 1)
            {
                lblLogo.Text = "Музикален плейър";
                lblConfirm.Text = "Изход?";
                btnYes.Text = "Да";
                btnNo.Text = "Не";
                lblLogo.Left = (this.Width - lblLogo.Width) / 2;
                lblConfirm.Left = (this.Width - lblConfirm.Width) / 2;
            }

            if(MusicController.ChangeText == 2)
            {
                lblLogo.Text = "Music Player";
                lblConfirm.Text = "Exit?";
                btnYes.Text = "Yes";
                btnNo.Text = "No";
                lblLogo.Left = (this.Width - lblLogo.Width) / 2;
                lblConfirm.Left = (this.Width - lblConfirm.Width) / 2;
            }

            if (MusicController.ChangeText == 3)
            {
                lblLogo.Text = "Musikspieler";
                lblConfirm.Text = "Ausgang?";
                btnYes.Text = "Ja";
                btnNo.Text = "Nein";
                lblLogo.Left = (this.Width - lblLogo.Width) / 2;
                lblConfirm.Left = (this.Width - lblConfirm.Width) / 2;
            }
        }
    }
}
