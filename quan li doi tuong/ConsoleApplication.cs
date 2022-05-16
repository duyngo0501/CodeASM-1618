using System;
using System.Collections.Generic;
using System.Text;

namespace quan_li_doi_tuong
{
    class Console
    {
        //Properties
        private string player1;
        private string player2;
        private string player3;
        private string passWord;
        //Contructors
        public Console()
        {

        }   
        public Console(string player1,string player2,string player3,string passWord)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.player3 = player3;
            this.passWord = passWord;
        }
        //Methods
        public string toString()
        {
            return player1 + "," + player2 + "," + player3 + "," + passWord;
        }
        public string Player1
        {
            get { return player1; }
            set { player1 = value; }
        }
        public string Player2
        {
            get { return player2; }
            set { player2 = value; }
        }
        public string Player3
        {
            get { return player3; }
            set { player3 = value; }
        }
    }
}
