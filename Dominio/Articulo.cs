using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string CodArticulo { get; set; }
        public string   NombreArticulo { get; set; }
        public string   DescripcionArticulo { get; set; }
        public decimal  PrecioArticulo { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public int IdMarca { get; set; } 
        public int IdCategoria { get; set; } 
        public Imagen Imagen { get; set; }
        public List<Imagen> Imagenes { get; set; } = new List<Imagen>();
        public string DescripcionMarca { get; set; }  
        public string DescripcionCategoria { get; set; }
    }
}
