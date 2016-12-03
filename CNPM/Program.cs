using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMonsterBallFactory mon = new SimpleMonsterBallFactory();
            MonsterBall m = mon.createMonsterBall("MonsterBall3 ");
            Console.WriteLine(m.Speed);
        }
    }
}
