﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace CrystalReports_UAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbReports.Items.Clear();
            cmbReports.Items.Add("Wybierz raport");
            cmbReports.Items.Add("Otwarte pozycje");

            cmbReports.SelectedIndex = 0;
        }

        private void cmbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbReports.SelectedIndex)
            {
                case 0:
                    crystalReportViewer1.ReportSource = null;
                    break;
                case 1:
                    crystalReportViewer1.ReportSource = crOpenItems1;
                    break;
               
            }
              
        }
    }
}
