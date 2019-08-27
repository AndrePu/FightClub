using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    public interface IAction
    {
        void GetHit(CyberAttack bodyPart, int damage);
        void SetBlock(CyberAttack bodyPart);
    }
}
