using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS.SOLID.UseCase.Interfaces
{
    public interface INumberGenerator
    {
        int GetNumber(int min, int max);
    }
}
