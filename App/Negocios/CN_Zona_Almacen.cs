﻿using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class CN_Zona_Almacen
    {
        private CD_Zona_Almacen ObjetoZonaAlmacen = new CD_Zona_Almacen();

        public List<Zona_Almacen> ListarZonaAlmacen()
        {
            return ObjetoZonaAlmacen.MostrarZonasAlmacen();
        }
    }
}