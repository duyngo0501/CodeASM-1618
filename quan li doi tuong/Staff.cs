using System;
using System.Collections.Generic;
using System.Text;

namespace quan_li_doi_tuong
{
    class Staff
    {
        //Properties
        private string staffName;
        private string staffPassWord;
        //Contructors
        public Staff()
        {

        }
        public Staff(string staffName, string staffPassWord)
        {
            this.staffName = staffName;
            this.staffPassWord = staffPassWord;
        }
        //Methods
        public string toString()
        {
            return staffName + "," + staffPassWord;
        }
        public string StaffName
        {
            get { return staffName; }
            set { staffName = value; }
        }
        public string StaffPassWord
        {
            get { return staffPassWord; }
            set { staffPassWord = value; }
        }

    }
}
