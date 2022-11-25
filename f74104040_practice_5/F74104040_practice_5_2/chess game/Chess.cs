using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_game
{
    //Warrior
    class Chess
    {
        public string character;
        public int hp;
        public int mp;
        public int atk;
        public int atkRange;
        public int moveRange;

        public virtual int Skill(string name)
        {
            return 0;
        }


    }
    class Warrior1 : Chess
    {
        public int curr_hp = 100;
        public int curr_mp = 15;
        public int curr_mp_w2 = 15;
        public int curr_mp_m2 = 25;
        public int curr_mp_r2 = 10;

        public Warrior1()
        {

        }
        public Warrior1(string a_character, int a_hp, int a_mp, int a_atk, int a_atkRange, int a_moveRange)
        {
            character = a_character;
            curr_hp = a_hp; //changable
            curr_mp = a_mp; //changable
            atk = a_atk; //constant
            atkRange = a_atkRange; //constant
            moveRange = a_moveRange; //constant
        }

        public int Attack(string p2_name)
        {
            if (p2_name == "Warrior")
            {
                curr_hp -= 30;
                return curr_hp;
            }
            else if (p2_name == "Mage")
            {
                curr_hp -= 20;
                return curr_hp;
            }
            else if (p2_name == "Ranger")
            {
                curr_hp -= 30;
                return curr_hp;
            }
            return 0;
        }

        public override int Skill(string p2_name)
        {
            Warrior2 w2 = new Warrior2();
            if (p2_name == "Warrior")
            {
                curr_mp_w2 -= 10;
                curr_hp -= 30;
                w2.curr_hp += 15;
                return w2.curr_hp;
            }
            else if (p2_name == "Mage")
            {
                curr_mp_m2 -= 10;
                curr_hp -= 40;
                return curr_hp;
            }
            else if (p2_name == "Ranger")
            {
                curr_mp_r2 -= 10;
                curr_hp -= 30;
                return curr_hp;
            }
            return 0;
        }

    }
    // Mage
    class Mage1 : Chess
    {
        public int curr_hp = 70;
        public int curr_mp = 25;
        public int curr_mp_w2 = 15;
        public int curr_mp_m2 = 25;
        public int curr_mp_r2 = 10;
        public Mage1(string a_character, int a_hp, int a_mp, int a_atk, int a_atkRange, int a_moveRange)
        {
            character = a_character;
            hp = a_hp;
            mp = a_mp;
            atk = a_atk;
            atkRange = a_atkRange;
            moveRange = a_moveRange;
        }

        public int Attack(string p2_name)
        {
            if (p2_name == "Warrior")
            {
                curr_hp -= 30;
                return curr_hp;
            }
            else if (p2_name == "Mage")
            {
                curr_hp -= 20;
                return curr_hp;
            }
            else if (p2_name == "Ranger")
            {
                curr_hp -= 30;
                return curr_hp;
            }
            return 0;
        }

        public override int Skill(string p2_name)
        {
            Warrior2 w2 = new Warrior2();
            if (p2_name == "Warrior")
            {
                curr_mp_w2 -= 10;
                curr_hp -= 30;
                w2.curr_hp += 15;
                return w2.curr_hp;
            }
            else if (p2_name == "Mage")
            {
                curr_mp_m2 -= 10;
                curr_hp -= 40;
                return curr_hp;
            }
            else if (p2_name == "Ranger")
            {
                curr_mp_r2 -= 10;
                curr_hp -= 30;
                return curr_hp;
            }
            return 0;
        }
    }

    // Ranger
    class Ranger1 : Chess
    {
        public int curr_hp = 90;
        public int curr_mp = 10;
        public int curr_mp_w2 = 15;
        public int curr_mp_m2 = 25;
        public int curr_mp_r2 = 10;
        public Ranger1(string a_character, int a_hp, int a_mp, int a_atk, int a_atkRange, int a_moveRange)
        {
            character = a_character;
            hp = a_hp;
            mp = a_mp;
            atk = a_atk;
            atkRange = a_atkRange;
            moveRange = a_moveRange;
        }

        public int Attack(string p2_name)
        {
            if (p2_name == "Warrior")
            {
                curr_hp -= 30;
                return curr_hp;
            }
            else if (p2_name == "Mage")
            {
                curr_hp -= 20;
                return curr_hp;
            }
            else if (p2_name == "Ranger")
            {
                curr_hp -= 30;
                return curr_hp;
            }
            return 0;
        }

        public override int Skill(string p2_name)
        {
            Warrior2 w2 = new Warrior2();
            if (p2_name == "Warrior")
            {
                curr_mp_w2 -= 10;
                curr_hp -= 30;
                w2.curr_hp += 15;
                return w2.curr_hp;
            }
            else if (p2_name == "Mage")
            {
                curr_mp_m2 -= 10;
                curr_hp -= 40;
                return curr_hp;
            }
            else if (p2_name == "Ranger")
            {
                curr_mp_r2 -= 10;
                curr_hp -= 30;
                return curr_hp;
            }
            return 0;
        }
    }
    class Warrior2 : Chess
    {
        public int curr_hp = 100;
        public int curr_mp = 15;
        public int curr_mp_w1 = 15;
        public int curr_mp_m1 = 25;
        public int curr_mp_r1 = 10;
        public Warrior2()
        {

        }
        public Warrior2(string a_character, int a_hp, int a_mp, int a_atk, int a_atkRange, int a_moveRange)
        {
            character = a_character;
            hp = a_hp;
            mp = a_mp;
            atk = a_atk;
            atkRange = a_atkRange;
            moveRange = a_moveRange;
        }

        public int Attack(string p1_name)
        {
            if (p1_name == "Warrior")
            {
                curr_hp -= 30;
                return curr_hp;
            }
            else if (p1_name == "Mage")
            {
                curr_hp -= 20;
                return curr_hp;
            }
            else if (p1_name == "Ranger")
            {
                curr_hp -= 30;
                return curr_hp;
            }
            return 0;
        }

        public override int Skill(string p1_name)
        {
            Warrior1 w1 = new Warrior1();
            if (p1_name == "Warrior")
            {
                curr_mp_w1 -= 10;
                curr_hp -= 30;
                w1.curr_hp += 15;
                return w1.curr_hp;
            }
            else if (p1_name == "Mage")
            {
                curr_mp_m1 -= 10;
                curr_hp -= 40;
                return curr_hp;
            }
            else if (p1_name == "Ranger")
            {
                curr_mp_r1 -= 10;
                curr_hp -= 30;
                return curr_hp;
            }
            return 0;
        }
    }

    // Mage
    class Mage2 : Chess
    {
        public int curr_hp = 70;
        public int curr_mp = 25;
        public int curr_mp_w1 = 15;
        public int curr_mp_m1 = 25;
        public int curr_mp_r1 = 10;
        public Mage2()
        {

        }
        public Mage2(string a_character, int a_hp, int a_mp, int a_atk, int a_atkRange, int a_moveRange)
        {
            character = a_character;
            hp = a_hp;
            mp = a_mp;
            atk = a_atk;
            atkRange = a_atkRange;
            moveRange = a_moveRange;
        }

        public int Attack(string p1_name)
        {
            if (p1_name == "Warrior")
            {
                curr_hp -= 30;
                return curr_hp;
            }
            else if (p1_name == "Mage")
            {
                curr_hp -= 20;
                return curr_hp;
            }
            else if (p1_name == "Ranger")
            {
                curr_hp -= 30;
                return curr_hp;
            }
            return 0;
        }

        public override int Skill(string p1_name)
        {
            Warrior1 w1 = new Warrior1();
            if (p1_name == "Warrior")
            {
                curr_mp_w1 -= 10;
                curr_hp -= 30;
                w1.curr_hp += 15;
                return w1.curr_hp;
            }
            else if (p1_name == "Mage")
            {
                curr_mp_m1 -= 10;
                curr_hp -= 40;
                return curr_hp;
            }
            else if (p1_name == "Ranger")
            {
                curr_mp_r1 -= 10;
                curr_hp -= 30;
                return curr_hp;
            }
            return 0;
        }
    }

    // Ranger
    class Ranger2 : Chess
    {
        public int curr_hp = 90;
        public int curr_mp = 10;
        public int curr_mp_w1 = 15;
        public int curr_mp_m1 = 25;
        public int curr_mp_r1 = 10;
        public Ranger2()
        {

        }
        public Ranger2(string a_character, int a_hp, int a_mp, int a_atk, int a_atkRange, int a_moveRange)
        {
            character = a_character;
            hp = a_hp;
            mp = a_mp;
            atk = a_atk;
            atkRange = a_atkRange;
            moveRange = a_moveRange;
        }
        public int Attack(string p1_name)
        {
            if (p1_name == "Warrior")
            {
                curr_hp -= 30;
                return curr_hp;
            }
            else if (p1_name == "Mage")
            {
                curr_hp -= 20;
                return curr_hp;
            }
            else if (p1_name == "Ranger")
            {
                curr_hp -= 30;
                return curr_hp;
            }
            return 0;
        }

        public override int Skill(string p1_name)
        {
            Warrior1 w1 = new Warrior1();
            if (p1_name == "Warrior")
            {
                curr_mp_w1 -= 10;
                curr_hp -= 30;
                w1.curr_hp += 15;
                return w1.curr_hp;
            }
            else if (p1_name == "Mage")
            {
                curr_mp_m1 -= 10;
                curr_hp -= 40;
                return curr_hp;
            }
            else if (p1_name == "Ranger")
            {
                curr_mp_r1 -= 10;
                curr_hp -= 30;
                return curr_hp;
            }
            return 0;
        }
    }


}
