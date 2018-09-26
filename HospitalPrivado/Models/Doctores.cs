using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HospitalPrivado.Models
{
	public class Doctores{
		[Key]
		public int id { get; set; }
		[Required]
		public string nombre { get; set; }
		[Required]
		public string apellido_paterno { get; set; }
		[Required]
		public string apellido_materno { get; set; }
		[Required]
		public int edad { get; set; }
		[Required]
		public string fecha_de_nacimiento { get; set; }
		[Required]
		public string correo_electronico { get; set; }
		[Required]
		public string curp { get; set; }
		[Required]
		public string estado_ciudad { get; set; }
		[Required]
		public string municipio { get; set; }
		[Required]
		public string domicilio { get; set; }
		[Required]
		public string cedula_profesional { get; set; }
		[Required]
		public string especialidad { get; set; }
		[Required]
		public string contrasena { get; set; }
	}
}