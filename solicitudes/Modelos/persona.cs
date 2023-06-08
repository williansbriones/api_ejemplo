namespace solicitudes.Modelos
{
    public class persona
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }

        public string Genero { get; set; }



        public persona()
        {
            Id = new int();
            Nombre = string.Empty;
            Genero = string.Empty;
        }

    }
}
