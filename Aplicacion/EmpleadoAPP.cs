using System;
using Negocio;

namespace Aplicacion
{
    public class EmpleadoAPP
    {
        private readonly EmpleadoBLL _empleadoBll = new EmpleadoBLL();

        public void MostrarEmpleados()
        {
            var empleados = _empleadoBll.ObtenerTodos();
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"{empleado.Id} - {empleado.Nombre} - {empleado.Departamento}");
            }
        }
    }
}
