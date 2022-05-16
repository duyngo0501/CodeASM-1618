using System;
using System.Collections.Generic;
using System.Text;

namespace Gaming
{
    class Player
    {
        //Properties
        private string playerName;
        private string userName;
        private string playerPassword;
        private string role; //player or staff

        //Contructors
        public Player()
        {

        }
        public Player(string playerName, string userName, string playerPassword, string role)
        {
            this.playerName = playerName;
            this.userName = userName;
            this.playerPassword = playerPassword;
            this.role = role;
        }
        //Methods
        public string toString()
        {
            return  playerName + ","+ userName + "," + playerPassword ;
        }
 
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string PlayerPassword
        {
            get { return playerPassword; }
            set { playerPassword = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

    }
}
