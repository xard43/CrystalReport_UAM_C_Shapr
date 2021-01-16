using System;
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

            ListOfReports();

            dtpCashReportDate.Value = new DateTime(2017, 08, 22);
            crystalReportViewer1.ToolPanelView = ToolPanelViewType.None;
            crystalReportViewer1.ReuseParameterValuesOnRefresh = true;
            ShowReport();
        }

        private void cmbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowReport();
        }

        private ParameterFields GetCashReportParameters()
        {
            ParameterFields crParams = new ParameterFields();
            ParameterField crParam = new ParameterField();
            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();

            crParam.Name = "DataRaportu";

            crParamDiscreteValue.Value = dtpCashReportDate.Value;
            crParam.CurrentValues.Add(crParamDiscreteValue);
            crParams.Add(crParam);

            return crParams;
        }

        private void ShowReport()
        {
            labCashReportDate.Visible = false;

            dtpCashReportDate.Visible = false;
            crystalReportViewer1.ReportSource = null;

            switch (cmbReports.SelectedIndex)
            {
                case 0:
                    crystalReportViewer1.ReportSource = null;
                    break;
                case 1:
                    crystalReportViewer1.ReportSource = crOpenItems1;
                    break;
                case 2:
                    labCashReportDate.Visible = true;
                    dtpCashReportDate.Visible = true;
                    crystalReportViewer1.ParameterFieldInfo = GetCashReportParameters();
                    crystalReportViewer1.ReportSource = crCashReport1;
                    break;

            }

        }
        
        private void ListOfReports()
        {
            cmbReports.Items.Clear();
            cmbReports.Items.Add("Wybierz raport");
            cmbReports.Items.Add("Otwarte pozycje");
            cmbReports.Items.Add("Raport kasowy");

            cmbReports.SelectedIndex = 0;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ShowReport();
        }
    }
}
