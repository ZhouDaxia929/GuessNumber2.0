using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber2._0 {
    class HardPC : Data, Player {
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
            if(_cand_count == 1) {
                for (int i = 0; i < M; i++)
                    if (_cand[i])
                        return i;
            }
         
         // 悲观假设：
         //     假设无论猜什么排列，电脑总是能正确地返回结果，
         //     使得依据返回结果能进一步排除掉的可行排列数目最少（即剩余的可行排列数目最多）
         // 贪婪算法：
         //     从可行排列中选择下一次猜测的排列；
         //     在悲观假设总是成立的条件下，使得每次排除掉的可行排列数目最多（即剩余的可行排列数目最少），即求最好的最坏情况；
         //就是想办法在下一回合排除掉更多的选择

            int[] res_count = new int[MATCH + 1];
            int min_max = M + 1;
            int min_max_index = 0;
            for(int i = 0; i < M; i++) {
                //对于每一个可行排列
                if (_cand[i]) {
                    /*
                    下一次猜测排列Ri的时候，裁判将会返回一个结果
                    根据悲观假设，裁判返回的结果总是使得依据返回结果能进一步排除掉的可行排列数目最少
                    即剩余的可行排列数目最多
                    cur_max记录该最坏情况下剩余的可行排列数目
                     */
                    int cur_max = 0;
                    for (int j = 0; j <= MATCH; j++)
                        res_count[j] = 0;
                    for (int j = 0; j < M; j++) {
                        if (_cand[j]) {  //如果该项和剩余的可行项进行比较
                            res_count[table[i, j]]++;  //测量分散程度或者叫分布程度
                        }    
                    }
                    for (int j = 0; j <= MATCH; j++)
                        if (res_count[j] > cur_max)
                            cur_max = res_count[j];
                    //如果cur_max小于全局min_max，则更新min_max，并记录下当前排列的序号，这样能找到最好最坏情况
                    if (cur_max < min_max) {  //找到一个分布程度最大的项
                        min_max = cur_max;
                        min_max_index = i;
                    }
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
