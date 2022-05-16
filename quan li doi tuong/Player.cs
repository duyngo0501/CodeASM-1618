using System;
using System.Collections.Generic;
using System.Text;

namespace quan_li_doi_tuong
{
    class Player
    {
        //Properties
        private int playerId;
        private string playerName;
        private string userName;
        private string playerPassword;
        private DateTime registerDate;
        //Contructors
        public Player()
        {

        }
        public Player(int playerId, string playerName, string userName, string playerPassword, DateTime registerDate)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.userName = userName;
            this.playerPassword = playerPassword;
            this.registerDate = registerDate;
        }
        //Methods
        public string toString()
        {
            return playerId + "," + playerName + ","+ userName + "," + playerPassword + "," + registerDate;
        }
        public int PlayerId
        {
            get { return playerId; }
            set { playerId = value;  }
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
        public DateTime RegisterDate
        {
            get { return registerDate; }
            set { registerDate = value; }
        }
    }
}
