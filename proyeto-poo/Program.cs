/* Program by: Jesus Coronado and Elvis Gastelum
 * 
 * User: admin
 * Password: 1385
 * 
 * 
 * 
 */
using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using System.Collections;

namespace proyeto_poo
{
	class Program
	{
		[DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);
		int ReservedRooms = 0, UnreservedRooms = 10, SimpleReserved = 0, SimpleUnreserved = 5, DoubleReserved = 0, DoubleUnreserved = 3, LuxorReserved = 0, LuxorUnreserved = 2;
			
		
		
		
		
		public static void Main(string[] args)
		{
			Console.Title = "Login";
			string username = null,password = null, userIn = null, passIn = null;
			const string pathLogin = @"C:\Users\Admin\Documents\Programacion\C#\ConsoleEx\proyeto-poo\docs\username-pass.txt";
			bool Login = false, exit = false;
			int ThisDay = DateTime.Now.Hour;
			int SimpleRoom = 500, DoubleRoom = 700, LuxorRoom = 1000;
			
			long phone = 0;
			string name = null;
			bool paymethodwithcard = false;
			string email = null, input = null, todayHour = TimeHour(ThisDay);
			ArrayList PayData = new ArrayList();
			Simple Room101 = new Simple(ThisDay);
			Simple Room102 = new Simple(ThisDay);
			Simple Room103 = new Simple(ThisDay);
			Simple Room104 = new Simple(ThisDay);
			Simple Room105 = new Simple(ThisDay);
			Double Room106 = new Double(ThisDay);
			Double Room107 = new Double(ThisDay);
			Double Room108 = new Double(ThisDay);
			Luxor Room109 = new Luxor(ThisDay);
			Luxor Room110 = new Luxor(ThisDay);
			Program p = new Program();
			p.ReservedRoomsCount( ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
			
			
			if (ThisDay >= 12 && ThisDay <13) {
				SimpleRoom = 400;
				DoubleRoom = 600;
				LuxorRoom = 850;
			}else{
				SimpleRoom = 500;
				DoubleRoom = 700;
				LuxorRoom = 1000;
			}
			
			
			while(Login != true){
				WindowLog(); // creacion de la ventana de login
				Write("HOTEL HOLIDAY INN * LOGIN USUARIO", 22, 11); // mensaje en coordenada
				
				using (StreamReader ReadLogin = new StreamReader(File.Open(pathLogin, FileMode.Open))) {
				       	username = ReadLogin.ReadLine();
				       	password = ReadLogin.ReadLine();
				       	ReadLogin.Close();
				} // se lee un txt
				
				Write("Nombre: ", 24, 13);
				Write("Contraseña: ", 24, 14);
				userIn = MoveRead(32, 13); // un readline pero con coordenadas 
				
				if (userIn != username){
					PopUp("Nombre de usuario incorrecto", "LOGIN");
				} // messagebox con texto y titulo
				
				passIn = MoveRead(36,14);
				if (passIn != password){
					PopUp("Contraseña incorrecta", "LOGIN");
				}
				
				ConsoleEx.CursorVisible = false;
				if (username == userIn && password == passIn) {
					WindowLog();
					Write("LOGIN EXITOSO", 30, 11); 
					Login = true;
					Pause();
				}
				else{
					WindowLog();
					Write("LOGIN FALLIDO", 30, 11); 
					Pause();
				}
			}
			
			do{
				do{
					// titulo de la ventana
					WindowLogged("HOTEL HOLIDAY INN - INICIO", 25);
					// fin de titulo
					
					Write("Hora: " + todayHour, 65, 7);
					Write("Presiona 'r' para reservar.", 5, 7);
					Write("Presiona 's' para salir.", 5, 8);
					
					Write("INFO", 15, 12);
					
					Write("Habitaciones reservadas: " + p.ReservedRooms, 5, 13);
					Write("Habitaciones sin reservar: " + p.UnreservedRooms, 5, 14);
					
					Write("PRECIOS", 55, 12);
					Write("Habitaciones simples: " + SimpleRoom, 45, 13);
					Write("Habitaciones dobles: " + DoubleRoom, 45, 14);
					Write("Habitaciones luxor: " + LuxorRoom, 45, 15);
					
					Write("Horario de oferta de 12 PM a 1 PM", 25, 18);
					
					
					
					Write("Entrada: ",17,10);
					
					
					input = MoveRead(26,10);
					
					if (input != "r" && input != "s") {
						PopUp("Error: entrada incorrecta\nIngrese de nuevo","ERROR");
					}
					
					
				}while (input != "r" && input  != "s");

				
				
		    	
				
				if (input == "r") {
					Write("Cargando reservaciones.", 10, 20);
					Thread.Sleep(100);
					Write(".", 33, 20);
					Thread.Sleep(300);
					Write(".", 34, 20);
					Thread.Sleep(50);
					Write(".", 35, 20);
					Thread.Sleep(100);
					Write(".", 36, 20);
					Thread.Sleep(300);
					Write(".", 37, 20);
					Thread.Sleep(50);
					Write(".", 38, 20);
					Thread.Sleep(500);
					Write("presione enter para continuar.", 40, 20);
					
					Pause();
					
					WindowLogged("HOTEL HOLIDAY INN - RESERVACION", 23);
					Write("REGISTRO DE LA PERSONA", 5, 7);
					Write("Nombre: ", 5, 9);
					name = MoveRead(13,9);
					Write("Numero: ", 5, 10);
					
					bool phoneBool = false;
					while(phoneBool != true){
						try {
							do{
								WindowLogged("HOTEL HOLIDAY INN - RESERVACION", 23);
								Write("REGISTRO DE LA PERSONA", 5, 7);
								Write("Nombre: ", 5, 9);
								Write(name,13,9);
								Write("Numero: ", 5, 10);
								phone = Convert.ToInt64(MoveRead(13,10));
								phoneBool = true;
								if (phone.ToString().Length != 10) {
									PopUp("Ingrese un numero valido", "ERROR");
								}
							}while(phone.ToString().Length != 10);
							
							
						} catch (Exception e) {
							PopUp("Error: " + e.Message + "\nIngrese de nuevo","ERROR");
							phoneBool = false;
						}
					}
						
					
					
					Write("Email: ", 5, 11);
					email = MoveRead(12,11);
					Write("Pago con tarjeta? (false / true): ", 5, 12);
					
					bool payBool = false;
					while(payBool != true){
						try {
							WindowLogged("HOTEL HOLIDAY INN - RESERVACION", 23);
							Write("REGISTRO DE LA PERSONA", 5, 7);
							Write("Nombre: ", 5, 9);
							Write(name,13,9);
							Write("Numero: ", 5, 10);
							Write(phone.ToString(),13,10);
							Write("Email: ", 5, 11);
							Write(email,12,11);
							Write("Pago con tarjeta? (false / true): ", 5, 12);
							paymethodwithcard = Convert.ToBoolean(MoveRead(39,12));
							payBool = true;
							
						} catch (Exception e) {
							PopUp("Error: " + e.Message + "\nIngrese solamente false o true","ERROR");
							payBool = false;
						}
					}
					
					
					
					
					
					
					
					Person person1 = new Person(name,phone, email, paymethodwithcard,  ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
					
					PayData = person1.PayData(paymethodwithcard);
					person1.Pay(ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110);
					
					
				}
				
				if (input == "s") {
					Write("Cerrando sesion, presione enter.", 10, 20);
					exit = true;
				}
				
				p.ReservedRoomsCount( ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
				
				
				Pause();
			}while (exit != true);
			Write("Saliendo, enter para salir.", 43, 20);
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			Pause();
		} // fin del main
		
		static public void WindowLog(){
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
			ConsoleEx.TextColor(ConsoleForeground.White, ConsoleBackground.Blue);
			ConsoleEx.DrawRectangle(BorderStyle.LineDouble, 1, 1, 77, 22, true);
		}
		
		static public void WindowLogged(string title, int textX = 3){
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
			ConsoleEx.TextColor(ConsoleForeground.White, ConsoleBackground.Aquamarine);
			ConsoleEx.DrawRectangle(BorderStyle.LineSingle, 1, 1, 77, 3, true);
			Write(title, textX, 3); 
			ConsoleEx.TextColor(ConsoleForeground.White, ConsoleBackground.Blue);
			ConsoleEx.DrawRectangle(BorderStyle.LineDouble, 1, 5, 77, 18, true);
			Console.Title = title;
		}
		
		
		static public void Write(string text = "",int x = 0, int y = 0 ){
			ConsoleEx.WriteAt(x, y, text);
		}
		
		static public void Move(int x = 0, int y = 0){
			ConsoleEx.CursorVisible = true;
			ConsoleEx.Move(x,y);
		}
		
		static public string MoveRead(int x = 0, int y = 0){
			string value = null;
			ConsoleEx.CursorVisible = true;
			ConsoleEx.Move(x,y);
			value = Console.ReadLine();
			return value;
		}
		
		static public void PopUp(string message = null, string title = null){
			MessageBox((IntPtr)0, message, title, 0);
		}
		
		static public void Pause(){
			ConsoleEx.CursorVisible = false;
			Console.ReadKey();
		}
		
		static public string TimeHour(int time){
			string timeHour = null;
			
			if (time == 1){
				timeHour = time + " AM";
			}else if (time == 2){
				timeHour = time + " AM";
			}else if (time == 3){
				timeHour = time + " AM";
			}else if (time == 4){
				timeHour = time + " AM";
			}else if (time == 5){
				timeHour = time + " AM";
			}else if (time == 6){
				timeHour = time + " AM";
			}else if (time == 7){
				timeHour = time + " AM";
			}else if (time == 8){
				timeHour = time + " AM";
			}else if (time == 9){
				timeHour = time + " AM";
			}else if (time == 10){
				timeHour = time + " AM";
			}else if (time == 11){
				timeHour = time + " AM";
			}else if (time == 12){
				timeHour = time + " PM";
			}else if (time == 13){
				timeHour = (time - 12) + " PM";
			}else if (time == 14){
				timeHour = (time - 12) + " PM";
			}else if (time == 15){
				timeHour = (time - 12) + " PM";
			}else if (time == 16){
				timeHour = (time - 12) + " PM";
			}else if (time == 17){
				timeHour = (time - 12) + " PM";
			}else if (time == 18){
				timeHour = (time - 12) + " PM";
			}else if (time == 19){
				timeHour = (time - 12) + " PM";
			}else if (time == 20){
				timeHour = (time - 12) + " PM";
			}else if (time == 21){
				timeHour = (time - 12) + " PM";
			}else if (time == 22){
				timeHour = (time - 12) + " PM";
			}else if (time == 23){
				timeHour = (time - 12) + " PM";
			}else if (time == 24){
				timeHour = (time - 12) + " PM";
			}
			
			
			return timeHour;
		}
		
		
		public void ReservedRoomsCount( ref Simple Room101, ref Simple Room102, ref Simple Room103, ref Simple Room104, ref Simple Room105, ref Double Room106, ref Double Room107, ref Double Room108, ref Luxor Room109, ref Luxor Room110 ){
			
			
			
			if (Room101.ReservationStatus) {
				ReservedRooms++;
				UnreservedRooms--;
				SimpleReserved++;
				SimpleUnreserved--;
				
			}
			if (Room102.ReservationStatus) {
				ReservedRooms++;
				UnreservedRooms--;
				SimpleReserved++;
				SimpleUnreserved--;
				
			}
			if (Room103.ReservationStatus) {
				ReservedRooms++;
				UnreservedRooms--;
				SimpleReserved++;
				SimpleUnreserved--;
				
			}
			if (Room104.ReservationStatus) {
				ReservedRooms++;
				UnreservedRooms--;
				SimpleReserved++;
				SimpleUnreserved--;
				
			}
			if (Room105.ReservationStatus) {
				ReservedRooms++;
				UnreservedRooms--;
				SimpleReserved++;
				SimpleUnreserved--;
				
			}
			if (Room106.ReservationStatus) {
				ReservedRooms++;
				UnreservedRooms--;
				DoubleReserved++;
				DoubleUnreserved--;
				
			}
			if (Room107.ReservationStatus) {
				ReservedRooms++;
				UnreservedRooms--;
				DoubleReserved++;
				DoubleUnreserved--;
				
			}
			if (Room108.ReservationStatus) {
				ReservedRooms++;
				UnreservedRooms--;
				DoubleReserved++;
				DoubleUnreserved--;
				
			}
			if (Room109.ReservationStatus) {
				ReservedRooms++;
				UnreservedRooms--;
				LuxorReserved++;
				LuxorUnreserved--;
				
			}
			if (Room110.ReservationStatus) {
				ReservedRooms++;
				UnreservedRooms--;
				LuxorReserved++;
				LuxorUnreserved--;
			}
		}
		
		
		
		
	}
}