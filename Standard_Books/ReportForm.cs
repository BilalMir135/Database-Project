using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Standard_Books.Classes;
using CrystalDecisions.Shared;

namespace Standard_Books
{
    public partial class ReportForm : Form
    {
        string path, type, procedure, parameter;
        object data;
        byte condition;
        short pubyear;

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            r.closerd();
        }

      
        Retreival r = new Retreival();
        public ReportForm(string title, string path, string type, string procedure=null, string parameter=null, object data = null, byte condition = 4, short pubyear = 1)
        {
            InitializeComponent();
            titleBar1.Title = title;
            this.path = path;
            this.type = type;
            this.data = data;
            this.procedure = procedure;
            this.parameter = parameter;
            this.condition = condition;
            this.pubyear = pubyear;
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            if (type == "Without Parameters")
            {
                showReport(this.path);
            }               
            else if (type == "With Parameters")
            { 
                r.getDataforReport(this.data, this.path, this.procedure, this.parameter, crystalReportViewer1, this.condition, this.pubyear);            
            }
               
        }

        private void showReport(string path)
        {
            try
            {
                ReportDocument rd = new ReportDocument();
                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;
                rd.Load(Application.StartupPath + path);
                crConnectionInfo.IntegratedSecurity = true;
                crConnectionInfo.ServerName = Properties.Settings.Default.ServerName;
                crConnectionInfo.DatabaseName = Properties.Settings.Default.Database;
                CrTables = rd.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.SelectionMode = CrystalDecisions.Windows.Forms.SelectionMode.None;
                crystalReportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            
        }       
    }
}
