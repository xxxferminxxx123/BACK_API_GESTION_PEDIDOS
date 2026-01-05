namespace COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.ValueObjects
{
    public class Nombre
    {
        public string Value { get; set; }

        public Nombre(string value)
        {
            ValidarVacios(value);
            MaximoCaracteres(value);
            Value = value;
        }

        public void ValidarVacios(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Nombre no puede estar vacío");
        }
        public void MaximoCaracteres(string value)
        {
            if (value.Length > 25)
                throw new ArgumentException("El nombre no puede tener mas de 25 caracteres.");
        }

    }
}
