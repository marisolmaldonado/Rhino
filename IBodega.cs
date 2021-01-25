using System;
using System.Collections.Generic;
using System.Text;

namespace Rhino.Test
{
    interface IBodega
    {
        int Existencia(string producto);
        void actualizarExistencia(string producto, int cantidad);
    }
}
