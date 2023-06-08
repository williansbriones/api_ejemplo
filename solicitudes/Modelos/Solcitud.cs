namespace solicitudes.Modelos
{
    public class Solcitud
    {

        public int Id_solicitud {  get; set; }
        public bool Estado { get; set; }
        public persona Solicitante { get; set; }
        public persona Asistente { get; set; }




        public Solcitud()
        {
            Id_solicitud = new int();
            Estado = false;
            Solicitante = new persona();
            Asistente = new persona();
        }
    }
}
