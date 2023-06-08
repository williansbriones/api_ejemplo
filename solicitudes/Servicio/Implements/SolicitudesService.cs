using api_proyecto_web.DBConText;
using solicitudes.Modelos;
using System.Data;

namespace solicitudes.Servicio.Implements
{
    public class SolicitudesService : IcrudSolicitud
    {
        static Connection db = new Connection();

        public SolicitudesService()
        {
            db = new Connection("User Id=ADMIN;Password=ProgramacionWeb2023#;Data Source=r7dbt8zx2wqrpwgt_high; " + " Connection Timeout=30;");
        }
        public Solcitud ConsultarSolicitud(int id_solicitud)
        { 
            bool estado;
            Solcitud Solicitud = new Solcitud();
            string Query = string.Format("select id_solicitud as solicitud, estado as estado from solicitus where id_solicitud = " + id_solicitud);

           DataTable dt = db.Execute(Query);


            if (dt.Rows.Count >0 ) 
            { 
                if (dt.Rows[0]["estado"].ToString() == "F") 
                {
                    estado = false;
                }
                else
                {
                    estado = true;
                }


                Solicitud.Id_solicitud = Convert.ToInt32(dt.Rows[0]["solicitud"]);
                Solicitud.Estado = estado;
                Solicitud.Solicitante = new persona { Genero = "12312", Id = 1, Nombre = "pipe" };
                Solicitud.Asistente = new persona { Genero = "2321", Id = 2, Nombre = "pepe" };


            return Solicitud;
            }

            return new Solcitud();
        }
    }
}
