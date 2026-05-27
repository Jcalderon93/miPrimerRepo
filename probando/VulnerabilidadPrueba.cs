using System;
using Microsoft.Data.SqlClient;

namespace ProbandoSeguridad
{
    public class ControladorPrueba
    {
        public void ConsultarUsuarioInseguro(string idUsuario)
        {
            // Esta concatenación directa es una vulnerabilidad crítica que CodeQL detectará
            string consulta = "SELECT * FROM Usuarios WHERE Id = '" + idUsuario + "'";
            
            using (SqlConnection conexion = new SqlConnection("Server=localhost;Database=Test;"))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                comando.ExecuteReader();
            }
        }
    }
}