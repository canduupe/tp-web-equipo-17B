﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vouchers
    {
        public string CodigoVaucher { get; set; }
        public int IdCliente { get; set; }
        public int IdArticulo { get; set; }
        public DateTime FechaCanje { get; set; }


    }
}