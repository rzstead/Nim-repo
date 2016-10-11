using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim.CpuVsCpu
{
    public interface ComPlayer
    {
        int[] ChooseMove();
        int[] CreateRandomMove();
    }
}
