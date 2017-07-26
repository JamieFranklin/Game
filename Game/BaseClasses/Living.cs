using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum LivingStates
{
    ALIVE,
    DEAD,
    UNDEAD,
    UNKILLABLE
}

namespace Game.Classes
{
    class Living
    {
        int health;
        String ID;
        int stamina;
        LivingStates state = LivingStates.ALIVE;

        static List<Living> allLiving = new List<Living>();

        public Living(String id, int hp, int stam){
            ID = id;
            health = hp;
            stamina = stam;
            Living.allLiving.Add(this);
        }

        public void destroy(){
            Living.allLiving.Remove(this);
        }

        public static Living findLivingByID(String objID){
            foreach (var obj in allLiving){
                if(obj.ID == objID){
                    return obj;
                }
            }
            return null;
        }

        public void damage(int dmg){
            health = health - dmg;
            if(health < 0){
                state = LivingStates.DEAD;
            }
        }

        public void changeTotalStam(int newStam){
            stamina = newStam;
        }

        public void changeStam(int val){
            if(stamina + val >= 0){
                stamina = stamina + val;
            }else{
                stamina = 0;
            }

        }
    }
}
