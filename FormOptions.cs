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
        public int button = 0;
        public FormOptions()
        {
            InitializeComponent();
           
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btn_Save_Click(object sender, EventArgs e)
        //{
        //    UserOptions.Default.ExEdS = lbl_ExEd.Text;
        //    UserOptions.Default.TermS = lbl_Term.Text;
        //    UserOptions.Default.Usr2S = lbl_Usr2.Text;
        //    UserOptions.Default.Usr3S = lbl_Usr3.Text;
        //    UserOptions.Default.Save();

        //}

        private void FormOptions_Load(object sender, EventArgs e)
        {

            lbl_ExEd.Text = UserOptions.Default.BtnExEdS;
            lbl_Term.Text = UserOptions.Default.BtnTermS;
            lbl_Usr2.Text = UserOptions.Default.Usr2S;
            lbl_Usr3.Text = UserOptions.Default.Usr3S;
            lbl_NameBBS.Text = UserOptions.Default.BBSnameS;
            lbl_NameSysOp.Text = UserOptions.Default.SysOpnameS;
        }

        private void btn_ExEd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "External Editor: .exe|*.exe|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lbl_ExEd.Text = ofd.SafeFileName;
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
                lbl_Term.Text = ofd.SafeFileName;
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
            UserOptions.Default.Usr3S = "On";
            UserOptions.Default.BtnExEdS = "Tools";
            UserOptions.Default.BtnTermS = "Tools";
            UserOptions.Default.BtnUsr2S = "Tools";
            UserOptions.Default.BtnUsr3S = "Options";
            UserOptions.Default.BBSnameS = "No Name";
            UserOptions.Default.SysOpnameS = "No Name";
            UserOptions.Default.Save();
            lbl_ExEd.Text = UserOptions.Default.ExEdS;
            lbl_Term.Text = UserOptions.Default.TermS;
            lbl_Usr2.Text = UserOptions.Default.Usr2S;
            lbl_Usr3.Text = UserOptions.Default.Usr3S;
            lbl_NameBBS.Text = UserOptions.Default.BBSnameS;
            lbl_NameSysOp.Text = UserOptions.Default.SysOpnameS;
            tb_input.Visible = false;
            btn_Set.Visible = false;
        }

        private void btn_Usr3_Click(object sender, EventArgs e)
        {
            string notify = UserOptions.Default.Usr3S;
            if (notify == "Off")
            {
                UserOptions.Default.Usr3S = "On";
            }
            else
            {
                UserOptions.Default.Usr3S = "Off";

            }
            UserOptions.Default.Save();
            lbl_Usr3.Text = UserOptions.Default.Usr3S;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button = 5;
            lbl_report.Text = "Enter the name of your BBS";
            tb_input.Visible = true;
            btn_Set.Visible = true;
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            if(button == 5)
            {
                UserOptions.Default.BBSnameS = tb_input.Text;
                UserOptions.Default.Save();
                lbl_NameBBS.Text = tb_input.Text;
                lbl_report.Text = "BBS Name set to " + tb_input.Text;
                tb_input.Text = "";
                tb_input.Visible = false;
                btn_Set.Visible = false;
                button = 0;
            }
            if (button == 6)
            {
                UserOptions.Default.SysOpnameS = tb_input.Text;
                UserOptions.Default.Save();
                lbl_NameSysOp.Text = tb_input.Text;
                lbl_report.Text = "SysOp Name set to " + tb_input.Text;
                tb_input.Text = "";
                tb_input.Visible = false;
                btn_Set.Visible = false;
                button = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button = 6;
            lbl_report.Text = "Enter the SysOp Name you use";
            tb_input.Visible = true;
            btn_Set.Visible = true;
        }
    }
}
