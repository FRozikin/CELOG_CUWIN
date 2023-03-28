using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CSCallConsule
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnWriteLog_Click(object sender, EventArgs e)
        {
        String T1  = TxtCH.Text;
        String T2  = TxtLV.Text;

        if((T1.Length > 0) && (T2.Length >0))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(Directory.GetCurrentDirectory() + @"\CELOG.exe", "");
                startInfo.Arguments = T1 + " " + T2;
                    try
                    {
                        Process.Start(startInfo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message); 
                    }

            } 

        }

    }
}