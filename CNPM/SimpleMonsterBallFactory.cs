using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM
{
    class SimpleMonsterBallFactory
    {
        public MonsterBall createMonsterBall(string type)
        {
            MonsterBall mb = null;
            if (type.Equals("MonsterBall1"))
                mb = new MonsterBall1();
            else if (type.Equals("MonsterBall2"))
                mb = new MonsterBall2();
            else
                mb = new MonsterBall3();
            return mb;
        }
    }
}
