using System.Data;
using System;
using Microsoft.Data.SqlClient;

namespace COREBAK.BDAdapter
{
    public interface IDBAdaptador
    {
        Task<int> SpManipulacionDatos(string nombreSP, Dictionary<string, dynamic> parametros);
    }

    public class DBAdaptador : IDBAdaptador
    {
        public readonly string _connectionString;

        public DBAdaptador(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> SpManipulacionDatos(string nombreSP, Dictionary<string, dynamic> parametros)
        {
            using (SqlConnection conexion = new SqlConnection(_connectionString))
            {
                await conexion.OpenAsync();

                using (SqlCommand comando = new SqlCommand(nombreSP, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    foreach (var param in parametros)
                    {
                        comando.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }

                    int filasAfectadas = await comando.ExecuteNonQueryAsync();
                    return filasAfectadas;
                }
            }
        }
    }
}