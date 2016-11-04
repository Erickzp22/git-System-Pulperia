namespace DataAcesss.Objetos
{
    class Usuario
    {
        public int Cedula { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contraseña { get; set; }

        Perfil Perfil = new Perfil();
        public int Estado { get; set; }

    }
}
