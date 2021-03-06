﻿using System.Collections.Generic;

namespace Rhino.Test
{
    internal class Bodega
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
      

        internal void Add(string producto, int cantidad)
        {
            dic.Add(producto, cantidad);
        }

        internal int Existencia(string producto)
        {
            if (dic.ContainsKey(producto))
            {
                return dic[producto];
            }
            return 0;
        }

        internal void ActualizarExistencia(string producto, int cantidad)
        {
            if (dic.ContainsKey(producto))
            {
                dic[producto] = cantidad;
            }
            else
            {
                Add(producto, cantidad);
            }    
        }
    }
}