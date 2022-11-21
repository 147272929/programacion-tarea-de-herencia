utilizando  el sistema ;
utilizando  el sistema . Colecciones . genérico ;
utilizando  el sistema . Linq ;
utilizando  el sistema . texto ;
utilizando  el sistema . Enhebrar _ tareas ;

espacio de nombres  ejercicio_clase
{
	clase  Empleados : Persona
	{

		public  string  numero_despacho { set ; obtener ; }
		public  int  anio { conjunto ; obtener ; }

		public  Empleados ( String  despacho , int  Anio , String  Nombre , String  apellidos , int  numero , String  estado ) : base ( Nombre , apellidos , numero , estado )
		{
			esto _ numero_despacho  =  despacho ;
			esto _ anio  =  anio ;
		}

		public  void  imprimir ()
		{
			consola _ WriteLine ( " -------------------------------------------- " );
			consola _ WriteLine ( "     Empleados del trabajo " );
			consola _ WriteLine ( " " );
			consola _ WriteLine ( " Numero de Despacho: "  +  numero_despacho );
			consola _ WriteLine ( " " );
			consola _ WriteLine ( " Año de incorporación: "  +  año );
			consola _ WriteLine ( " Nombre: "  +  nombre  +  " - Apellido: "  +  apellido );
			consola _ WriteLine ( " Numero de Identificacion: "  +  numero_identificacion );
			consola _ WriteLine ( " Estado Civil: "  +  estado_civil );
			consola _ WriteLine ( " " );
			opciones ();
			consola _ WriteLine ( " " );
			consola _ WriteLine ( " -------------------------------------------- " );
		}

		public  void  opcioness ()
		{
			 Opciones de cadena ;
			consola _ WriteLine ( " Opciones alternativas: " );
			consola _ WriteLine ( " Si desea cambiar el despacho utilice Ingrese: 1 " );
			consola _ WriteLine ( " Si desea cambiar el Estado Civil Ingrese: 2 " );
			consola _ WriteLine ( " Si desea salir utilice: salir " );
			opciones  =  Consola . Línea de lectura ();
			cambio ( opciones );
		}
		public  void  cambio ( String  cambios )
		{

			cambiar ( cambios . ToString ())
			{
				caso  " 1 " :
					cambio_espacho ();
					romper ;
				caso  " 2 " :
					cambio civil ();
					romper ;
				caso  " salir " :
					consola _ WriteLine ( " .... " );
					romper ;

			}

		}
		public  void  cambio_espacho ()
		{
			String  espacio_nuevo ;
			consola _ WriteLine ( " Ingrese el nuevo espacho " );
			espacio_new  =  Consola . Línea de lectura ();
			consola _ WriteLine ( " Despacho cambiado exitosamente " );
			numero_despacho  =  espacio_nuevo ;
		}
	}

}