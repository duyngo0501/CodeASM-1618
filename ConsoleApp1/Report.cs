using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace Gaming
{
    class Report
    {
        //Properties
        private String reporterUserName;
        private string reportType;
        private string playerUserName;
        //Contructors
        public Report() 
        { 
        
        }
        public Report(string reporterUserName, string reportType, string playerUserName)
        {
            this.reporterUserName = reporterUserName;
            this.reportType = reportType;
            this.playerUserName = playerUserName;
        }
        //Methods
        public string toString()
        {
            return reporterUserName + "," + "," + reportType + "," + playerUserName;
        }
        public string ReporterUserName
        {
            get { return reporterUserName; }
            set { reporterUserName = value; }
        }
        public string ReportType
        {
            get { return reportType; }
            set { reportType = value; }
        }
        public string PlayerUserName
        {
            get { return playerUserName; }
            set { playerUserName = value; }
        }
    }
}
