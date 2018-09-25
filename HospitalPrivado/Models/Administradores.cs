using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HospitalPrivado.Models{

	public class Administradores{
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
		public DateTime fecha_de_nacimiento { get; set; }
		[Required]
		public string correo_electronico { get; set; }
		[Required]
		public string contrasena { get; set; }
	}
}