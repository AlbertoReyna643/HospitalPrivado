﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HospitalPrivado.Models{
	public class ApplicationDbContext:DbContext{
		public DbSet<Administradores> Administradores { get; set; }
		public DbSet<Pacientes> Pacientes { get; set; }
		public DbSet<Doctores> Doctores { get; set; }
	}
}