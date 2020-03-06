using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Mapeadores
{
    public abstract class MapeadorBaseRepositorio<T1, T2>
    {
        public abstract T2 MapearT1T2(T1 entrada);
        public abstract T1 MapearT2T1(T2 entrada);
        public abstract IEnumerable<T2> MapearT1T2(IEnumerable<T1> entrada);
        public abstract IEnumerable<T1> MapearT2T1(IEnumerable<T2> entrada);
    }
}
