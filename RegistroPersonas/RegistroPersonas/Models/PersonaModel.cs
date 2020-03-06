using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroPersonas.Models
{
    public class PersonaModel
    {

        public int Id { get; set; }

        [Required]
        [DisplayName("Tipo de Documento")]
        public int TipoDocumento { get; set; }

        [Required]
        [DisplayName("Documento")]
        public string Documento { get; set; }

        [Required]
        [DisplayName("Nombre Completo")]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("Correo Electrónico")]
        public string Correo { get; set; }

        [DisplayName("Teléfono")]
        public string Telefono { get; set; }

        [Required]
        [DisplayName("Mensaje")]
        public string Mensaje { get; set; }


        /// <summary>
        /// NUNCA HACER
        /// </summary>
        public IList<TipoDocumento> ListaDocumentos
        {
            get
            {
                return new List<TipoDocumento>() {
            new TipoDocumento() { Id = 1, Tipo = "CC" },
            new TipoDocumento() { Id = 2, Tipo = "NIT" },
            new TipoDocumento() { Id = 3, Tipo = "CE" },
            new TipoDocumento() { Id = 4, Tipo = "RC" }
            };
            }
        }

    }

    public class TipoDocumento
    {
        public int Id { get; set; }
        public String Tipo { get; set; }
    }

}