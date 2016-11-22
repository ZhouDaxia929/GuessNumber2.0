using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber2._0 {
    class JudgmentFactory {
        public static Judgment makeJudgment() {
            return new HonestJudgment();
        }
    }
}
