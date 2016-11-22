using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber2._0 {
    class Run : Data {
        public static void swap (ref int[] a, int i, int j) {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        // 使用递归方法计算排列，就是从0~9中挑选4个不同的数
        public static void arr (int[] a, int start) {
            if (start == N) {
                for (int i = 0; i < N; i++)
                    arrange[arr_count, i] = a[i];
                arr_count++;
                return;
            }
            for (int i = start; i <= 9; i++) {
                swap(ref a, start, i);
                arr(a, start + 1);
                swap(ref a, start, i);  //回到初始情况
            }
        }

        // 初始化所有可能排列情况的列表
        public static void init_arrange () {
            int[] a = new int[10];
            arr_count = 0;
            for (int i = 0; i <= 9; i++)
                a[i] = i;
            arr(a, 0);
        }

        // 判断两个排列之间的关系
        // 返回结果为“A*10+B”；譬如结果为“1A2B”，则返回值为 (char)12
        public static char judge (int[] v1, int[] v2) {
            int a = 0;
            int b = 0;
            for (int i = 0; i < N; i++) {
                if (v1[i] == v2[i])
                    a++;
                for (int j = 0; j < N; j++) {
                    if (v1[i] == v2[j])
                        b++;
                }
            }
            b -= a; //因为b中含有a中的部分情况
            return (char)(a * 10 + b);
        }

        // 打表，初始化各个排列间的关系矩阵，耗时较多(有待改进)，不过为了以后查询更快点，这个初始化函数放在了最初的页面
        public static void init_table () {
            for (int i = 0; i < M; i++)
                for (int j = 0; j <= i; j++) {
                    int[] temp1 = new int[4];
                    int[] temp2 = new int[4];
                    for (int c = 0; c < N; c++) {
                        temp1[c] = arrange[i, c];
                        temp2[c] = arrange[j, c];
                    }
                    table[i, j] = table[j, i] = judge(temp1, temp2);
                }
        }

        public static int get_arrange (int a, int b) {
            return arrange[a, b];
        }

        //返回猜测信息
        public static string get_info (int arr_index) {
            StringBuilder strB = new StringBuilder();
            for (int i = 0; i < N; i++) {
                strB.Append(arrange[arr_index, i]);
            }
            return strB.ToString();
        }

        //返回猜测与结果信息字符串,PC部分
        public static string get_guess_info (int arr_index, char result) {
            StringBuilder strB = new StringBuilder();
            strB.Append("[");
            for (int i = 0; i < N; i++) {
                strB.Append(arrange[arr_index, i]);
            }
            strB.Append("] --> ");
            strB.Append((int)result / 10);
            strB.Append("A");
            strB.Append((int)result % 10);
            strB.Append("B");
            return strB.ToString();
        }

        //返回猜测与结果信息字符串,PC部分
        public static string get_guess_info_player (string PlayerNumber, char result) {
            StringBuilder strB = new StringBuilder();
            strB.Append("[");
            strB.Append(PlayerNumber);
            strB.Append("] --> ");
            strB.Append((int)result / 10);
            strB.Append("A");
            strB.Append((int)result % 10);
            strB.Append("B");
            return strB.ToString();
        }

        // 一次连续猜测，返回猜测次数
        public static int play (Player p, Judgment j, int change) {
            int time = 0;
            while (true) {
                int guess = p.getNextGuess();
                char result = j.doJudge(guess);
                time++;
                if (result == (char)MATCH)
                    break;
                p.setGuessResult(guess, result);
            }
            return time;
        }

        //竞争猜测
        public static string contest (Player p, Judgment j, int change, string PlayerNumber, int PCguess) {
            int timePC = 0;
            int timeUser = 0;

            int num = int.Parse(PlayerNumber);
            int[] test = new int[4];
            test[0] = num / 1000;
            test[1] = num / 100 % 10;
            test[2] = num / 10 % 10;
            test[3] = num % 10;
            char re = j.doJudge2(test);
            timeUser++;
            
            int guess = PCguess;
            char result = j.doJudge(guess);
            timePC++;
            p.setGuessResult(guess, result);

            if (re == (char)MATCH && result != (char)MATCH)
                return "T,User," + timeUser + "," + re + "," + result;
            else if (re != (char)MATCH && result == (char)MATCH)
                return "T,PC," + timePC + "," + re + "," + result;
            else if(re == (char)MATCH && result == (char)MATCH)
                return "T,Both," + timeUser + "," + re + "," + result;      
            else
                return "F,," + timeUser + "," + re + "," + result;
        }
    }
}
