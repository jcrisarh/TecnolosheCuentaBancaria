using System;
using System.Collections.Generic;

namespace SistemaCuentas
{
    public class Cuenta
    {
        public long numero { get; set; }
        //public string titular { get; set; }
        public decimal saldo { get; set; }
        public List<string> titulares { get; set; }


        public void depositar(decimal monto)
        {
           saldo = saldo + monto;
        }

        public virtual void retirar(decimal monto)
        {
          saldo = saldo - monto;
        }

    }

    
}