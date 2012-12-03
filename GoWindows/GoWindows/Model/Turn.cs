using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoWindows.Model
{
    class Turn
    {
        string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        DateTime _date = DateTime.Now;
        public string date
        {
            get { return _date.ToShortTimeString(); }            
        }

        public Position position;
    }
}
