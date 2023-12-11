using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditMate.Core.Consts
{
    public static class CreditConsts
    {
        public const decimal EmprestimoMax = 1000000;
        public const decimal PfEmprestimoMin = 15000;
        public const int ParcelaMin = 5;
        public const int ParcelaMax = 72;

        public const int DiasPrimeiroVencimentoMin = 15;
        public const int DiasPrimeiroVencimentoMax = 40;
    }
}
