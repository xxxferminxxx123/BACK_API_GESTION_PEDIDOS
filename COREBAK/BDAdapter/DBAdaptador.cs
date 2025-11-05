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
        public async Task<List<T>> SpConsultaDatos<T>(string nombreSP, Dictionary<string, dynamic>? parametros, Func<SqlDataReader, T> mapeo)
        {
            var resultado = new List<T>();

            using (SqlConnection conexion = new SqlConnection(_connectionString))
            {
                await conexion.OpenAsync();
                using (SqlCommand comando = new SqlCommand(nombreSP, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    if (parametros != null)
                    {
                        foreach (var param in parametros)
                        {
                            comando.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    using (SqlDataReader reader = await comando.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            resultado.Add(mapeo(reader));
                        }
                    }
                }
            }

            return resultado;
        }


        public async Task<string> SpConsultaJson(string nombreSP, Dictionary<string, dynamic>? parametros = null)
        {
            using (SqlConnection conexion = new SqlConnection(_connectionString))
            {
                await conexion.OpenAsync();
                using (SqlCommand comando = new SqlCommand(nombreSP, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    if (parametros != null)
                    {
                        foreach (var param in parametros)
                        {
                            comando.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    // Opción 1: Si tu SP devuelve un solo valor JSON
                    var resultado = await comando.ExecuteScalarAsync();
                    return resultado?.ToString() ?? "[]";

                    // Opción 2: Si tu SP devuelve el JSON en una columna de un resultado
                    /*
                    using (SqlDataReader reader = await comando.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return reader.GetString(0); // Primera columna
                        }
                        return "[]";
                    }
                    */
                }
            }
        }
    }
}