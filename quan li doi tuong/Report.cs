using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace quan_li_doi_tuong
{
    class Report
    {
        //Properties
        private int reporterID;
        private DateTime reportDate;
        private string reportType;
        private int playerID;
        //Contructors
        public Report() 
        { 
        
        }
        public Report(int reporterID, string reporterName, DateTime reportDate, string reportType, int playerID)
        {
            this.reporterID = reporterID;
            this.reportDate = reportDate;
            this.reportType = reportType;
            this.playerID = playerID;
        }
        //Methods
        public string toString()
        {
            return reporterID + "," + reportDate + "," + reportType + "," + playerID ;
        }
        public int ReporterID
        {
            get { return reporterID; }
            set { reporterID = value; }
        }
        public DateTime ReportDate
        {
            get { return reportDate; }
            set { reportDate = value; }
        }
        public string ReportType
        {
            get { return reportType; }
            set { reportType = value; }
        }
        public int PlayerID
        {
            get { return playerID; }
            set { playerID = value; }
        }
    }
}
