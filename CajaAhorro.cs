using System;
using System.Collections.Generic;

namespace SistemaCuentas
{
    public class CajaAhorro : Cuenta
    {
        public override void retirar(decimal monto)
        {
          if(saldo - monto <= 0m)
          {
              Console.WriteLine("No hay saldo suficiente para realizar esta operación ");
          }
          else
          {
              saldo = saldo - monto;
          }
          
        }

    }

    
}