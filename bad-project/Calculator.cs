using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bad_project;
public class Calculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}
