namespace ejercicio_clase.Program
{
	class Program
	{
		public static void Main(string[] args)
		{
			Empleados empleados = new Empleados("Despacho#40 ", 2012, "Arnaldo", "Mendoza", 1316718241, "Soltero");
			empleados.imprimir();
			Estudiantes estudiante = new Estudiantes("A345", "Anthony", "Martinez", 1304015541, "Casado");
			estudiante.imprimir();
			Personal personal = new Personal("secretara", "Juana", "Mendeez", 1315478954, "Soltera");
			personal.imprimir();
			Profesores profesores = new Profesores("Arquitectura", "Joel", "Perez", 1305879446, "divorciado");
			profesores.imprimir();
		}
	}
}