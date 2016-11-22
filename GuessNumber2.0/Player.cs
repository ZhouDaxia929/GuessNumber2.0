using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber2._0 {
    interface Player {
        void init();
        int getNextGuess();
        void setGuessResult(int arr_index, char result);
    }
}
