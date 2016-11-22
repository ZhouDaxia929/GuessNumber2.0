using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber2._0 {
    public partial class AllTest : Form {
        private Judgment jp2;
        private Player pp2;
        public AllTest (string choice) {
            InitializeComponent();
            jp2 = JudgmentFactory.makeJudgment();
            if (choice == "函数一")
                pp2 = PlayerFactory.makePlayer(1);
            else if (choice == "函数二")
                pp2 = PlayerFactory.makePlayer(2);
            else if (choice == "函数三")
                pp2 = PlayerFactory.makePlayer(3);
        }

        private void bt1_Click (object sender, EventArgs e) {
            tb1.Text = "";
            int M = 5040;

            int[] time_stat = new int[M];// 次数统计表
            // 初始化次数统计表
            for (int i = 0; i < M; i++)
                time_stat[i] = 0;
            
            // 每一种排列情况都玩一次模式
            for(int i = 0; i < M; i++){
                pp2.init();
                jp2.init();
                int[] temp = new int[4];
                for (int c = 0; c < 4; c++)
                    temp[c] = Run.get_arrange(i,c);
                ((HonestJudgment)jp2).setArrange(temp);
                int t = Run.play(pp2, jp2, 0);
                time_stat[t]++;
            }
            // 统计结果
            int total = 0;
            tb1.Text += "-------------\r\n";
            for (int i = 0; i < M; i++){
                if(time_stat[i] > 0){
                    tb1.Text += i + "\t" + time_stat[i] + "\r\n";
                    total += time_stat[i] * i;
                }
            }
            tb1.Text += "Average: " + total + "/" + M + "=" + (float)total / M + "\r\n";
            tb1.Text += "-------------\r\n";
        }
    }
}
