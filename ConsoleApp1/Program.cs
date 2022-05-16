using System;
using System.Collections;

namespace Gaming
{
    class Program
    {
        private static ArrayList playerList = new ArrayList();
        private static ArrayList reports = new ArrayList();

        static void Main(string[] args)
        {
            Player player1 = new Player("Duy", "duyngo", "123456", "player");
            Player player2 = new Player("Thuan", "thuan123", "0501", "player");
            Player player3 = new Player("Tien", "tien123", "0502", "player");
            Player staff = new Player("Staff", "staff", "2707", "staff");
            playerList.Add(player1);
            playerList.Add(player2);
            playerList.Add(player3);
            playerList.Add(staff);

            Player loggedInPlayer = null;
            String userName = "";
            string password = "";

            while (true)
            {
                if (loggedInPlayer == null)
                {
                    Console.WriteLine("Please login");
                    Console.WriteLine("Username");
                    userName = Console.ReadLine();
                    Console.WriteLine("Password");
                    password = Console.ReadLine();
                    loggedInPlayer = checkLogin(userName, password);
                }
                if (loggedInPlayer != null)
                {
                    showViolence(loggedInPlayer.UserName); //show violeance report if exist
                    showMenus();
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("input player's username to report");
                            string playerUserName = Console.ReadLine();
                            Console.WriteLine("input report type (A: for Abuse, C: for Cheat, Q: for Rage Quit, T: for Trolling game)");
                            string reportType = Console.ReadLine();

                            // check if user exist
                            Boolean userExist = checkUserName(playerUserName);

                            if (userExist == true)
                            {
                                Report rp = new Report(loggedInPlayer.UserName, reportType, playerUserName);
                                reports.Add(rp);
                            }
                            else
                            {
                                Console.WriteLine("Player's username you report does not exist");
                            }

                            break;
                        case "2":
                            //show reports of loggedIn user
                            if (reports.Count == 0)
                            {
                                Console.WriteLine("You didn't report anyone, yet");
                            } 
                            else
                            {
                                for (int i = 0; i < reports.Count; i++)
                                {
                                    Report rp2 = (Report)reports[i];
                                    if (rp2.ReporterUserName.Equals(loggedInPlayer.UserName))
                                    {
                                        Console.WriteLine((i + 1) + "." + " Reported user: " + rp2.PlayerUserName + " , report type: " + rp2.ReportType);
                                    }
                                }
                            }
                            break;
                        case "3":
                            loggedInPlayer = null;
                            Console.WriteLine("Loggout sucessfully, please login");
                            Console.WriteLine("Please login");
                            Console.WriteLine("Username");
                            userName = Console.ReadLine();
                            Console.WriteLine("Password");
                            password = Console.ReadLine();
                            loggedInPlayer = checkLogin(userName, password);

                            break;
                        case "4":
                            //show all reports for staff
                            if (loggedInPlayer.Role.Equals("staff"))
                            {
                                for (int i = 0; i < reports.Count; i++)
                                {
                                    Report rp2 = (Report)reports[i];
                                    Console.WriteLine((i + 1) + "." + " Reported user: " + rp2.PlayerUserName + " , report type: " + rp2.ReportType);
                                }
                            }
                            else
                            {
                                Console.WriteLine("This option for staff only, you are not staff");
                            }

                            break;
                        case "5":
                            if (loggedInPlayer.Role.Equals("staff"))
                            {
                                Console.WriteLine("reset report for player");
                                Console.WriteLine("input player's username ");

                                string playerUserName2 = Console.ReadLine();
                                 
                                for (int i = 0; i < reports.Count; i++)
                                {
                                    Report rp2 = (Report)reports[i];
                                    if (rp2.PlayerUserName.Equals(playerUserName2))
                                    {
                                        reports.RemoveAt(i); //remove report form list
                                        break;
                                    }
                                }
                                Console.WriteLine("reset successfully");
                            }
                            else
                            {
                                Console.WriteLine("This option for staff only, you are not staff");
                            }

                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
               else
               {
                    Console.WriteLine("incorrect username or password, please try again ");
               }
            }
           
        }
        //show Menu for user to access in report
        private static void showMenus()
        {
            Console.WriteLine("--- menu ----");
            Console.WriteLine("Press 1: to report a player");
            Console.WriteLine("Press 2: to show your reports");
            Console.WriteLine("Press 3: to logout");
            Console.WriteLine("Press 4: show all reports (for staff only)");
            Console.WriteLine("Press 5: reset report (for staff only)");
            Console.WriteLine("Press 6: to exit");
            Console.WriteLine("---  ----");
        }
        //to show user got report see type of report
        private static void showViolence(string uname)
        {
            for (int i = 0; i < reports.Count; i++)
            {
                Report rp2 = (Report)reports[i];
                if (rp2.PlayerUserName.Equals(uname))
                {
                    Console.WriteLine(" You got report type: " + rp2.ReportType);
                }
            }
        }
        //let user login into the report
        private static Player checkLogin(String uname, String password)
        {
            for (int i = 0; i < playerList.Count; i++)
            {
                Player pl = (Player)playerList[i];
                if (pl.UserName.Equals(uname.ToLower()) && pl.PlayerPassword.Equals(password))
                {
                    return pl;
                }
            }
            return null;
        }
        //Let user report someone
        private static Boolean checkUserName(string uname)
        {
            for (int i = 0; i < playerList.Count; i++)
            {
                Player pl = (Player)playerList[i];
                if (pl.UserName.Equals(uname))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
