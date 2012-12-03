using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoWindows.Model
{
    class Player
    {
        string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _nick;
        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        int _nmbWin;
        public int numberOfWins
        {
            get { return _nmbWin; }
            set { _nmbWin = value; }
        }

        int _nmbLoose;
        public int numberOfLoose
        {
            get { return _nmbLoose; }
            set { _nmbLoose = value; }
        }

        int _nmbDraw;
        public int numberOfDraws
        {
            get { return _nmbDraw; }
            set { _nmbDraw = value; }
        }

        public int Score
        {
         get { return (_nmbWin + _nmbDraw - _nmbLoose); }
        }
    }
}
