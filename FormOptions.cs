using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGUI
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
           
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            UserOptions.Default.ExEdS = lbl_ExEd.Text;
            UserOptions.Default.TermS = lbl_Term.Text;
            UserOptions.Default.Usr2S = lbl_Usr2.Text;
            UserOptions.Default.Usr3S = lbl_Usr3.Text;
            UserOptions.Default.Save();
            
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            lbl_ExEd.Text = UserOptions.Default.ExEdS;
            lbl_Term.Text = UserOptions.Default.TermS;
            lbl_Usr2.Text = UserOptions.Default.Usr2S;
            lbl_Usr3.Text = UserOptions.Default.Usr3S;
        }

        private void btn_ExEd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "External Editor: .exe|*.exe|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lbl_ExEd.Text = ofd.FileName;
                UserOptions.Default.BtnExEdS = ofd.SafeFileName;
                UserOptions.Default.ExEdS = ofd.FileName;
                UserOptions.Default.Save();
                lbl_report.Text = "Editor set to "+ofd.FileName;
            }
        }

        private void btn_Term_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Term: .exe|*.exe|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lbl_Term.Text = ofd.FileName;
                UserOptions.Default.BtnTermS = ofd.SafeFileName;
                UserOptions.Default.TermS = ofd.FileName;
                UserOptions.Default.Save();
                lbl_report.Text = "Terminal set to " + ofd.FileName;
            }
        }

        private void btn_ReSet_Click(object sender, EventArgs e)
        {
            UserOptions.Default.ExEdS = "Not Set";
            UserOptions.Default.TermS = "Not Set";
            UserOptions.Default.Usr2S = "Not Set";
            UserOptions.Default.Usr3S = "Not Set";
            UserOptions.Default.BtnExEdS = "Tools";
            UserOptions.Default.BtnTermS = "Tools";
            UserOptions.Default.BtnUsr2S = "Tools";
            UserOptions.Default.BtnUsr3S = "Tools";
            UserOptions.Default.Save();
            lbl_ExEd.Text = UserOptions.Default.ExEdS;
            lbl_Term.Text = UserOptions.Default.TermS;
            lbl_Usr2.Text = UserOptions.Default.Usr2S;
            lbl_Usr3.Text = UserOptions.Default.Usr3S;
            
        }
    }
}
