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
    public partial class SingleTest : Form {
        private Judgment jp2;
        private Player pp2;
        public SingleTest (string choice) {
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
            pp2.init();
            jp2.init();
            tb2.Text = "";
            int num = int.Parse(tb1.Text.Trim());
            int[] test = new int[4];
            test[0] = num / 1000;
            test[1] = num / 100 % 10;
            test[2] = num / 10 % 10;
            test[3] = num % 10;
            ((HonestJudgment)jp2).setArrange(test);
            //int result = Run.play(pp2, jp2, 1);

            int time = 0;
            while (true) {
                int guess = pp2.getNextGuess();
                char re = jp2.doJudge(guess);
                tb2.Text += "第" + time.ToString() + "次：" + Run.get_guess_info(guess, re) + "\r\n";
                //Run.get_guess_info(guess, re);
                time++;
                if (re == (char)40)
                    break;
                pp2.setGuessResult(guess, re);
            }


            //Console.Write("[" + num + "]");
            //Console.WriteLine(" : {0}", result);
        }
    }
}
