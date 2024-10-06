using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        public int IdImagen {  get; set; }

        public int IdArti { get; set; }    
        public string URlImagen { get; set; }

        public override string ToString()
        {
            return URlImagen;
        }
        public List<Imagen> Imagenes { get; set; } = new List<Imagen>();

    }
}
