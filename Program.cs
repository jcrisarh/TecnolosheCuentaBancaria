using System;
using System.Collections.Generic;

namespace SistemaCuentas
{
    class Program
    {
        static void Main(string[] args)
        {
            //se crea una cuenta para comprobar operaciones:
            Cuenta nuevaCuenta = new Cuenta();
            nuevaCuenta.numero = 12345;
            nuevaCuenta.titulares = new List<string> {"Cristina Arroyo", "Deborah Burbano", "Carolina Espinoza" };
            nuevaCuenta.saldo = 1450.8m;
            nuevaCuenta.depositar(1200.0m);
            Console.WriteLine(nuevaCuenta.saldo);
            nuevaCuenta.retirar(100m);
            Console.WriteLine(nuevaCuenta.saldo);

            //se crea una cuenta corriente para comprobar operaciones:
            CuentaCorriente cuentaCorriente = new CuentaCorriente();
            cuentaCorriente.numero = 23456;
            cuentaCorriente.saldo = 300m;
            cuentaCorriente.retirar(400.5m);
            Console.WriteLine(cuentaCorriente.saldo);

            //se crea una caja de ahorro para comprobar que no permite saldo negativo
            CajaAhorro cajaAhorro = new CajaAhorro();
            cajaAhorro.saldo = 250m;
            cajaAhorro.retirar(400m);
            Console.WriteLine(cajaAhorro.saldo);
        }
    }
}
