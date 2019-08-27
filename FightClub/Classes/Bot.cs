using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fighting;

namespace FightClub
{
    internal static class Bot
    {
        public static CyberAttack GenerateCPUAction()
        {
            var random = new Random();

            return (CyberAttack)random.Next(0, 2);
        }
    }
}
