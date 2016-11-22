using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber2._0 {
    public partial class PlayerToPC : Form {
        private int num2 = 0;
        private Judgment jp2;
        private Player pp2;
        private int[] test4 = new int[4];
        private int times = 0;
        public PlayerToPC (string choice) {
            InitializeComponent();
            //互相比赛模式
            Hashtable hashtable = new Hashtable();
            Random rm = new Random();
            int RmNum = 4;
            int j = 0;
            for (int i = 0; hashtable.Count < RmNum; i++) {
                int nValue = rm.Next(10);
                if (!hashtable.ContainsValue(nValue) && nValue != 0) {
                    hashtable.Add(nValue, nValue);
                    test4[j] = nValue;
                    j++;
                }
            }
            num2 = test4[0] * 1000 + test4[1] * 100 + test4[2] * 10 + test4[3];
            jp2 = JudgmentFactory.makeJudgment();
            if (choice == "函数一")
                pp2 = PlayerFactory.makePlayer(1);
            else if (choice == "函数二")
                pp2 = PlayerFactory.makePlayer(2);
            else if (choice == "函数三")
                pp2 = PlayerFactory.makePlayer(3);
            pp2.init();
            jp2.init();
        }

        private void bt1_Click (object sender, EventArgs e) {
            if(tb1.Text != "" && tb1.Text.Length == 4) {
                //处理玩家部分
                string strPlayer = tb1.Text.Trim();
                //处理PC部分
                int guess = pp2.getNextGuess();
                tb2.Text = Run.get_info(guess);
                string strPC = tb2.Text;
                //tb22.Text = Run.get_guess_info(guess, )
                ((HonestJudgment)jp2).setArrange(test4);


                string str = Run.contest(pp2, jp2, 1, strPlayer, guess);
                times++;
                string[] sArray = str.Split(',');

                if (sArray[0] == "T") {
                    if (sArray[1] == "PC") {
                        MessageBox.Show("PC Win!!!");
                        MessageBox.Show("第" + times.ToString() + "次：" + Run.get_info(guess));
                        tb11.Text += "第" + times.ToString() + "次：" + Run.get_guess_info_player(strPlayer, char.Parse(sArray[3])) + "\r\n";
                        tb22.Text += "第" + times.ToString() + "次：" + Run.get_guess_info(guess, char.Parse(sArray[4])) + "\r\n";
                    }
                    else if (sArray[1] == "User") {
                        MessageBox.Show("Player Win!!!");
                        MessageBox.Show("第" + times.ToString() + "次：" + strPlayer);
                        tb11.Text += "第" + times.ToString() + "次：" + Run.get_guess_info_player(strPlayer, char.Parse(sArray[3])) + "\r\n";
                        tb22.Text += "第" + times.ToString() + "次：" + Run.get_guess_info(guess, char.Parse(sArray[4])) + "\r\n";
                    }
                    else
                        MessageBox.Show("Both Win!!!");
                        MessageBox.Show("第" + times.ToString() + "次：" + strPlayer);
                        tb11.Text += "第" + times.ToString() + "次：" + Run.get_guess_info_player(strPlayer, char.Parse(sArray[3])) + "\r\n";
                        tb22.Text += "第" + times.ToString() + "次：" + Run.get_guess_info(guess, char.Parse(sArray[4])) + "\r\n";
                }
                else {
                    MessageBox.Show("都错了");
                    tb11.Text += "第" + times.ToString() + "次：" + Run.get_guess_info_player(strPlayer, char.Parse(sArray[3])) + "\r\n";
                    tb22.Text += "第" + times.ToString() + "次：" + Run.get_guess_info(guess, char.Parse(sArray[4])) + "\r\n";
                }
                tb1.Text = "";
            }
            else if(tb1.Text == "" && tb1.Text.Length == 4) {
                MessageBox.Show("输入不可为空！！！");
            }
            else {
                MessageBox.Show("输入的数字必须是4个不相同的数字！");
            }
        }
        private void bt2_Click (object sender, EventArgs e) {
            lb3.Text = num2.ToString();
        }
    }
}
