using System;

namespace SistemaCuentas
{
    public class Cliente
    {
        public long DNI { get; set; }
        public string nombreCompleto { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public long Telefono { get; set; }
        public string email { get; set; }
    }
}