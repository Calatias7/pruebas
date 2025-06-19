using Dominio;
using Datos;
using System.Collections.Generic;

namespace Negocio
{
    public class EmpleadoBLL
    {
        private readonly EmpleadoDAL _empleadoDal = new EmpleadoDAL();

        public List<Empleado> ObtenerTodos()
        {
            return _empleadoDal.ObtenerTodos();
        }
    }
}
