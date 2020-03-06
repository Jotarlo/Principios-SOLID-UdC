using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosAccesoDatos.DbModel
{
    public class PersonDbModel
    {
		public int Id { get; set; }


		public int TipoDocumento { get; set; }

		public string Documento { get; set; }

		public string Nombre { get; set; }

		public string Correo { get; set; }

		public string Telefono { get; set; }

		public string Mensaje { get; set; }

	}
}
