namespace COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.ValueObjects
{
    public class UsuarioVO
    {
        public string Value { get; set; }

        public UsuarioVO(string value)
        {
            ValidarVacios(value);
            MaximoCaracteres(value);
            Value = value;

        }
        public void ValidarVacios(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Usuario no puede estar vacío");
        }
        public void MaximoCaracteres(string value)
        {
            if (value.Length > 25)
                throw new ArgumentException("El usuario no puede tener mas de 25 caracteres.");
        }
    }
}

