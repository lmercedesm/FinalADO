using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalADO.Models
{
    public class ClientesModel
    {
        public int IdProveedores { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Categoria { get; set; }
    }
}