using System.Collections.Generic;

namespace ControladorApp.Mapeadores
{
    public abstract class MapeadorBaseControlador<T1, T2>
    {

        public abstract T2 MapearT1T2(T1 entrada);
        public abstract T1 MapearT2T1(T2 entrada);
        public abstract IEnumerable<T2> MapearT1T2(IEnumerable<T1> entrada);
        public abstract IEnumerable<T1> MapearT2T1(IEnumerable<T2> entrada);
    }
}
