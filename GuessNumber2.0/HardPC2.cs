using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessNumber2._0 {
    class HardPC2 : Data, Player {
        private bool[] _cand = new bool[M];
        private int _cand_count;
        public void init () {
            for (int i = 0; i < M; i++)
                _cand[i] = true;
            _cand_count = M;
        }
        public int getNextGuess () {
            // 第一次猜测总是使用第一个排列
            if (_cand_count == M)//排列次数用完结束
                return 0;
            if (_cand_count == 1) {
                for (int i = 0; i < M; i++)
                    if (_cand[i])
                        return i;
            }
            /*
            与Clever1Player的区别：下一次猜测的排列不局限于可行排列
           */
            int[] res_count = new int[MATCH + 1];
            int min_max = M + 1;
            int min_max_index = 0;
            for (int i = 0; i < M; i++) {
                //对于每一个可行排列Ri
                int cur_max = 0;
                for (int j = 0; j <= MATCH; j++)
                    res_count[j] = 0;
                for (int j = 0; j < M; j++) {
                    if (_cand[j]) {
                        res_count[(int)table[i, j]]++;
                    }

                }
                for (int j = 0; j <= MATCH; j++)
                    if (res_count[j] > cur_max)
                        cur_max = res_count[j];
                //如果cur_max小于全局min_max，则更新min_max，并记录下当前排列的序号，这样能找到最好最坏情况
                if (cur_max < min_max) {
                    min_max = cur_max;
                    min_max_index = i;
                }
            }
            return min_max_index;
        }
        public void setGuessResult (int arr_index, char result) {
            // 依据返回结果进一步排除已有的可行排列
            for (int j = 0; j < M; j++) {
                if (_cand[j] && table[arr_index, j] != result) {
                    _cand[j] = false;
                    _cand_count--;
                }
            }
        }
    }
}
