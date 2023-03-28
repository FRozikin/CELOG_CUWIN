using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CELOGDLL;

namespace CSCallDLL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnWriteLog_Click(object sender, EventArgs e)
        {
            String T1 = TxtCH.Text;
            String T2 = TxtLV.Text;

            if ((T1.Length > 0) && (T2.Length > 0))
            {
                try
                {
                    CELog.WriteLog(T1, T2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            } 

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}