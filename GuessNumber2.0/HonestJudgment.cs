﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber2._0 {
    class HonestJudgment : Data, Judgment{
        //private static final int N = 4; // 排列长度
        private int[] _my_arr = new int[N];
        public void init(){}
        // 设置裁判的正确结果
        public void setArrange(int[] arr) {
            for(int i = 0; i < N; i++)
                _my_arr[i] = arr[i];
        }
 
        public char doJudge(int arr_index){
            int[] temp = new int[4];
            for (int c = 0; c < N; c++) {
                temp[c] = arrange[arr_index, c];
            }
            return Run.judge(_my_arr, temp);
        }

        public char doJudge2(int[] temp) {
            return Run.judge(_my_arr, temp);
        }
    }
}
