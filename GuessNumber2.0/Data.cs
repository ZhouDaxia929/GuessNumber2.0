using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber2._0 {
    class Data
    {
        protected static int N = 4;// 排列长度
        protected static int M = (10 * 9 * 8 * 7);// 总的可能排列数,5040
        protected static int MATCH = (N * 10);// 猜测正确时的judge()返回值，如果是完全正确结果，judge函数会返回40
        protected static int[,] arrange = new int[M, N];// 所有可能排列的列表，一行一个排列
        protected static char[,] table = new char[M, M];// 各排列之间的关系矩阵
        protected static int arr_count;// 用于生成所有排列时使用的全局变量
    }
}
