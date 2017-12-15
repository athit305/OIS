using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.BaseViews;
using OIS.Common;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace OIS.Views.Dialogs
{
    public partial class ReportViewer : rBaseForm
    {
        private ReportDocument Report;
        public ReportViewer(ReportDocument rpt)
        {
            InitializeComponent();
            Report = rpt;
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = Report;

        }

        private void SetConnection(ReportDocument rpt)
        {
            try
            {
                ReportObjects crReportObjects;
                SubreportObject crSubreportObject;
                ReportDocument crSubreportDocument;
                Database crDatabase;
                Tables crTables;
                TableLogOnInfo crTableLogOnInfo;

                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                //pass the necessary parameters to the connectionInfo object
                crConnectionInfo.ServerName = OISDataInfo.DatabaseInfomation.DATASOURCE;
                crConnectionInfo.UserID = OISDataInfo.DatabaseInfomation.USERNAME;
                crConnectionInfo.Password = OISDataInfo.DatabaseInfomation.PASSWORD;
                crConnectionInfo.DatabaseName = OISDataInfo.DatabaseInfomation.DATABASENAME;

                //set up the database and tables objects to refer to the current report
                crDatabase = rpt.Database;
                crTables = crDatabase.Tables;

                //loop through all the tables and pass in the connection info
                foreach (Table crTable in crTables)
                {
                    crTableLogOnInfo = crTable.LogOnInfo;
                    crTableLogOnInfo.ConnectionInfo = crConnectionInfo;
                    crTable.ApplyLogOnInfo(crTableLogOnInfo);
                }

                //set the crSections object to the current report's sections
                Sections crSections = rpt.ReportDefinition.Sections;

                //loop through all the sections to find all the report objects
                foreach (Section crSection in crSections)
                {
                    crReportObjects = crSection.ReportObjects;
                    //loop through all the report objects to find all the subreports
                    foreach (ReportObject crReportObject in crReportObjects)
                    {
                        if (crReportObject.Kind == ReportObjectKind.SubreportObject)
                        {
                            //you will need to typecast the reportobject to a subreport 
                            //object once you find it
                            crSubreportObject = (SubreportObject)crReportObject;

                            //open the subreport object
                            crSubreportDocument = crSubreportObject.OpenSubreport(crSubreportObject.SubreportName);

                            //set the database and tables objects to work with the subreport
                            crDatabase = crSubreportDocument.Database;
                            crTables = crDatabase.Tables;

                            //loop through all the tables in the subreport and 
                            //set up the connection info and apply it to the tables
                            foreach (Table crTable in crTables)
                            {
                                crConnectionInfo.ServerName = OISDataInfo.DatabaseInfomation.DATASOURCE;
                                crConnectionInfo.UserID = OISDataInfo.DatabaseInfomation.USERNAME;
                                crConnectionInfo.Password = OISDataInfo.DatabaseInfomation.PASSWORD;
                                crConnectionInfo.DatabaseName = OISDataInfo.DatabaseInfomation.DATABASENAME;

                                crTableLogOnInfo = crTable.LogOnInfo;
                                crTableLogOnInfo.ConnectionInfo = crConnectionInfo;
                                crTable.ApplyLogOnInfo(crTableLogOnInfo);
                            }
                        }
                    }
                }

                TableLogOnInfos crTableLogonInfos = new TableLogOnInfos();
                TableLogOnInfo crTableLogonInfo = new TableLogOnInfo();
                foreach (Table table in rpt.Database.Tables)
                {
                    crTableLogonInfo.TableName = table.Name;
                    crTableLogonInfo.ConnectionInfo = crConnectionInfo;
                    crTableLogonInfos.Add(crTableLogonInfo);
                    table.ApplyLogOnInfo(crTableLogonInfo);
                }
                crystalReportViewer1.LogOnInfo = crTableLogonInfos;
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(null, ex);
            }
        }
    }
}
