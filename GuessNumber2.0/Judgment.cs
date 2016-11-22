using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber2._0 {
    interface Judgment {
        void init();
        char doJudge(int arr_index);
        char doJudge2(int[] temp);
    }
}
