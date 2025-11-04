using System.Text.Json;

namespace COREBAK.JsonAdaptor
{
    public interface IJsonAdaptador
    {
        T Deserializar<T>(string json);
        string Serializar<T>(T objeto);
    }

    public class JsonAdaptador : IJsonAdaptador
    {
        public readonly JsonSerializerOptions _opciones;

        public JsonAdaptador()
        {
            _opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
        }

        /// <summary>
        /// Deserializa un JSON a cualquier tipo T
        /// </summary>
        public T Deserializar<T>(string json)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(json))
                {
                    throw new ArgumentException("El JSON no puede estar vacío");
                }

                var objeto = JsonSerializer.Deserialize<T>(json, _opciones);

                if (objeto == null)
                {
                    throw new ArgumentException($"El JSON no pudo ser deserializado a {typeof(T).Name}");
                }

                return objeto;
            }
            catch (JsonException ex)
            {
                throw new ArgumentException($"Error al deserializar JSON a {typeof(T).Name}: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Serializa cualquier objeto a JSON
        /// </summary>
        public string Serializar<T>(T objeto)
        {
            try
            {
                if (objeto == null)
                {
                    throw new ArgumentNullException(nameof(objeto));
                }

                return JsonSerializer.Serialize(objeto, _opciones);
            }
            catch (JsonException ex)
            {
                throw new ArgumentException($"Error al serializar objeto de tipo {typeof(T).Name}: {ex.Message}", ex);
            }
        }
    }
}