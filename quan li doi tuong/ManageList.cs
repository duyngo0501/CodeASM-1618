using System;
using System.Collections.Generic;
using System.Text;

namespace quan_li_doi_tuong
{
    class ManageList
    {
        List<Report> list = new List<Report>();

        public void Add()
        {
            Console.WriteLine("ID");
            int reporterID = int.Parse(Console.ReadLine());
            Console.WriteLine("Name");
            String reporterName = Console.ReadLine();
            Console.WriteLine("Day");
            int reportDate = int.Parse(Console.ReadLine());
            Console.WriteLine("Type of hacker");
            String reportType = Console.ReadLine();
            list.Add(new Report(reporterID, reporterName, reportDate, reportType));
        }
        public void View()
        {
            foreach (Report rp in list)
            {
                Console.WriteLine(rp.toString());
            }

        }
        public void Count()
        {
            int sum = 0;
            foreach (Report infor in list)
            {
                sum= sum + infor.getNumberofCase();
            }
            Console.WriteLine("Number of Case = {0}",sum);

        }
        public void test()
        {
            Report reporterID = new Report();
            reporterID.ReporterID = 123;
            Console.WriteLine(reporterID.ReporterID);
            Report reportDate = new  Report();
            reportDate.ReportDate = new DateTime();
            Console.WriteLine(reportDate.ReportDate);
            Report reportType = new Report();
            reportType.ReportType = "Cheat";
            Console.WriteLine(reportType.ReportType);
            Report playerID = new Report();
            playerID.PlayerID = 0501;
            Console.WriteLine(playerID.PlayerID);
        }

        public void test2()
        {
            Player pl = new Player();
            pl.Username = "duy";
            pl.Password = "123456";

            //doc tu console gia tri gan vao bien uname
            String uname = "";
            String pwd = "";
            if (uname.Equals(pl.Username) && pwd.Equals(pl.Password))
            {
                //print menu
            }
            else
            {
                //bao thong tin dang nhap sai
            }
        }
    }

}
