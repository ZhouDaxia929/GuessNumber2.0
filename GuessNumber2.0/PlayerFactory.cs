using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber2._0 {
    class PlayerFactory {
        public static Player makePlayer(int choice) {
            if (choice == 1)
                return new NaivePlayer();
            else if (choice == 2)
                return new HardPC();
            else if (choice == 3)
                return new HardPC2();
            else
                return new NaivePlayer();
            //return  new Clever1Player();
            //return new Clever2Player();
        }
    }
}
