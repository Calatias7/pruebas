using Dominio;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using Transversal;

namespace Datos
{
    public class EmpleadoDAL
    {
        public List<Empleado> ObtenerTodos()
        {
            var empleados = new List<Empleado>();

            using var conexion = ConexionOracle.ObtenerConexion();
            using var comando = new OracleCommand("SELECT ID, NOMBRE, DEPARTAMENTO FROM EMPLEADO", conexion);
            using var lector = comando.ExecuteReader();
            while (lector.Read())
            {
                empleados.Add(new Empleado
                {
                    Id = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Departamento = lector.GetString(2)
                });
            }

            return empleados;
        }
    }
}
