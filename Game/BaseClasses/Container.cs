using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes{

    class Container{

        static List<Container> allContainers = new List<Container>();
        String ID;
        int size;

        public Container(String id, int size){
            ID = id;
            this.size = size;
        }
    }
}
