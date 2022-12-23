using OTUS.SOLID.UseCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OTUS.SOLID.UseCase.Implementations
{
    public class RandomEvenNumberGenerate : INumberGenerator
    {
        public int GetNumber(int min, int max)
        {
            return new Random().Next(min / 2, max / 2) * 2;
        }
    }
}
