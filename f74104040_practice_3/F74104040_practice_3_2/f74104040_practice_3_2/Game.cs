using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackgame
{
    class Game
    {
        // game instance
        public bool cantake = false, canplace = false, check;

        public Game()
        {

        }

        public Game(int state, int heap)
        {
            if (state == 0 && heap != -1)
                cantake = true;
            else if (state == 1 && heap != 3)
                canplace = true;
        }


        public bool win(string s0, string s1, string s2)
        {
            if (s0.Length != 3 || s1.Length != 3 || s2.Length != 3) return false; 
            for(int i=0; i<2; i++)
            {
                if (s0[i] != s0[i + 1])
                {
                    check = false;
                    break;
                }
                else check = true;
                if (s1[i] != s1[i + 1])
                {
                    check = false;
                    break;
                }
                else check = true;
                if (s2[i] != s2[i + 1])
                {
                    check = false;
                    break;
                }
                else check = true;
            }
            if (check)
                return true;
            else
                return false;
        }
        

    }
}
