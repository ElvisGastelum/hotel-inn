/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 05/05/2019
 * Time: 05:50 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections;

namespace proyeto_poo
{
	/// <summary>
	/// Description of Person.
	/// </summary>
	public class Person : Functions
	{
		string _name = null;
		long _phone = 0000000000;
		string _email = null;
		bool _paymethodwithcard = false;
		int ReservedRooms = 0, UnreservedRooms = 10, SimpleReserved = 0, SimpleUnreserved = 5, DoubleReserved = 0, DoubleUnreserved = 3, LuxorReserved = 0, LuxorUnreserved = 2;
		ArrayList PayDataVar = new ArrayList();
		
		public Person( string name, long phone, string email, bool paymethodwithcard,  ref Simple Room101, ref Simple Room102, ref Simple Room103, ref Simple Room104, ref Simple Room105, ref Double Room106, ref Double Room107, ref Double Room108, ref Luxor Room109, ref Luxor Room110 )
		{
			this.name = name;
			this.phone = phone;
			this.email = email;
			this.paymethodwithcard = paymethodwithcard;
			
			ReservedRoomsCount( ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
			
		}
		
		public string name{ get{return _name;} set{_name = value;}}
		public long phone{ get{return _phone;} set{_phone = value;}}
		public string email{ get{return _email;} set{_email = value;}}
		public bool paymethodwithcard{ get{return _paymethodwithcard;} set{_paymethodwithcard = value;}}
		
		
		double _FinalTotalFinalized = 0.0;
        public double FinalTotalFinalized{get { return _FinalTotalFinalized; }set { _FinalTotalFinalized = value; }}
		
		public long PaymentCardNumber {get;set;}
		string _MM_YY_Of_Card = "nothing";
		public string MM_YY_Of_Card {get{return _MM_YY_Of_Card;}set{_MM_YY_Of_Card = value;}}

		public int CVC_Of_Card {get;set;}
		
		string[] _CardType = {
			"credito",
			"debito"
		};
		public string[] CardType {get{return _CardType;}}
        
        
		public string print(){
			string str = null;
			string temp = null;
			
			str = "Nombre: " + name + "\n";
			str += "Telefono: " + phone + "\n";
			str += "Email: " + email + "\n";
			
			if (_paymethodwithcard){
				temp = "Si";
			}else{
				temp = "No";
			}
			
			str += "Pago con tarjeta: " + temp + "\n";
			
			
			
			
			return str;
		}
		
		public ArrayList PayData(bool paymenthodwithcard){
			
			if(paymenthodwithcard){
				
				do{
					WindowLogged("HOTEL HOLIDAY INN - RESERVACION: PAGO", 23);
					Write("REGISTRO DEL METODO DE PAGO", 5, 7);
					Write("Tipo de tarjeta (credito / debito): ", 5, 9);
					PayDataVar.Insert(0, MoveRead(41,9));
					
					if (PayDataVar[0].ToString() != "credito" && PayDataVar[0].ToString() != "debito") {
						PopUp("Error: entrada incorrecta\nIngrese de nuevo","ERROR");
					}
					
					
				}while (PayDataVar[0].ToString() != "credito" && PayDataVar[0].ToString() != "debito");
				
				while (PaymentCardNumber.ToString().Length != 16) {
					try {
						WindowLogged("HOTEL HOLIDAY INN - RESERVACION: PAGO", 23);
						Write("REGISTRO DEL METODO DE PAGO", 5, 7);
						Write("Tipo de tarjeta (credito / debito): ", 5, 9);
						Write(PayDataVar[0].ToString(), 41,9);
						Write("Numero de tarjeta: ", 5, 10);
						PaymentCardNumber = Convert.ToInt64(MoveRead(24,10));
						
						if (PaymentCardNumber.ToString().Length != 16) {
							PopUp("Error: ingrese un numero valido\nIngrese de nuevo","ERROR");
						}
						
						
					} catch (Exception e) {
						PopUp("Error: " + e.Message + "\nIngrese de nuevo","ERROR");
					}
				}
				
				while (MM_YY_Of_Card.Length != 5) {
					
					WindowLogged("HOTEL HOLIDAY INN - RESERVACION: PAGO", 23);
					Write("REGISTRO DEL METODO DE PAGO", 5, 7);
					Write("Tipo de tarjeta (credito / debito): ", 5, 9);
					Write(PayDataVar[0].ToString(), 41,9);
					Write("Numero de tarjeta: ", 5, 10);
					Write(PaymentCardNumber.ToString(),24, 10);
					Write("MM - YY de la tarjeta (MM/YY): ", 5, 11);
					MM_YY_Of_Card = MoveRead(36,11);
					
					if (MM_YY_Of_Card.Length != 5) {
						PopUp("Error: ingrese un numero valido\nIngrese de nuevo","ERROR");
					}
					
				}
				
				while (CVC_Of_Card.ToString().Length != 3) {
					try {
						WindowLogged("HOTEL HOLIDAY INN - RESERVACION: PAGO", 23);
						Write("REGISTRO DEL METODO DE PAGO", 5, 7);
						Write("Tipo de tarjeta (credito / debito): ", 5, 9);
						Write(PayDataVar[0].ToString(), 41,9);
						Write("Numero de tarjeta: ", 5, 10);
						Write(PaymentCardNumber.ToString(),24, 10);
						Write("MM - YY de la tarjeta (MM/YY): ", 5, 11);
						Write(MM_YY_Of_Card, 36, 11);
						
						Write("CVC: ", 5, 12);
						CVC_Of_Card = Convert.ToInt32(MoveRead(11,12));
						
						if (CVC_Of_Card.ToString().Length != 3) {
							PopUp("Error: ingrese un numero valido\nIngrese de nuevo","ERROR");
						}
						
						
					} catch (Exception e) {
						PopUp("Error: " + e.Message + "\nIngrese de nuevo","ERROR");
					}
				}
				
			}
			
			
			
			return PayDataVar;
		}
		
		public void Pay(ref Simple Room101, ref Simple Room102, ref Simple Room103, ref Simple Room104, ref Simple Room105, ref Double Room106, ref Double Room107, ref Double Room108, ref Luxor Room109, ref Luxor Room110){
			string input = null;
			string input2 = null;
			do{
				WindowLogged("HOTEL HOLIDAY INN - RESERVACION: HABITACION", 23);
				Write("Elija tipo de  habitacion disponible", 5, 7);
				Write("Opcion elegida: ", 5, 9);
				Write("1. Habitaciones simples ocupadas: " + SimpleReserved, 5, 10);
				Write("2. Habitaciones dobles ocupadas: " + DoubleReserved, 5, 11);
				Write("3. Habitaciones luxor ocupadas: " + LuxorReserved, 5, 12);
				Write("*. Cancelar reservacion en curso: " + LuxorReserved, 5, 13);
				input = MoveRead(22, 9);
				
				switch (input) {
					case "1":
						WindowLogged("HOTEL HOLIDAY INN - RESERVACION: HABITACION", 23);
						Write("Elija habitacion disponible", 5, 7);
						Write("Opcion elegida: ", 5, 9);
						Write("1. 101 Ocupada: " + Room101.ReservationStatus, 5, 10);
						Write("2. 102 Ocupada: " + Room102.ReservationStatus, 5, 11);
						Write("3. 103 Ocupada: " + Room103.ReservationStatus, 5, 12);
						Write("5. 104 Ocupada: " + Room104.ReservationStatus, 5, 13);
						Write("5. 105 Ocupada: " + Room105.ReservationStatus, 5, 14);
						input2 = MoveRead(22, 9);
						switch (input2) {
							case "1":
								Room101.ReservationStatus = false;
								Room102.ReservationStatus = false;
								Room103.ReservationStatus = false;
								Room104.ReservationStatus = false;
								Room105.ReservationStatus = false;
								Room106.ReservationStatus = false;
								Room107.ReservationStatus = false;
								Room108.ReservationStatus = false;
								Room109.ReservationStatus = false;
								Room110.ReservationStatus = false;
								
								Write("Habitacion reservada", 30, 16);
								Room101.ReservationStatus = true;
								ReservedRoomsCount( ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
								
								break;
							case "2":
								Room101.ReservationStatus = false;
								Room102.ReservationStatus = false;
								Room103.ReservationStatus = false;
								Room104.ReservationStatus = false;
								Room105.ReservationStatus = false;
								Room106.ReservationStatus = false;
								Room107.ReservationStatus = false;
								Room108.ReservationStatus = false;
								Room109.ReservationStatus = false;
								Room110.ReservationStatus = false;
								
								Write("Habitacion reservada", 30, 16);
								Room102.ReservationStatus = true;
								ReservedRoomsCount( ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
								
								break;
							case "3":
								Room101.ReservationStatus = false;
								Room102.ReservationStatus = false;
								Room103.ReservationStatus = false;
								Room104.ReservationStatus = false;
								Room105.ReservationStatus = false;
								Room106.ReservationStatus = false;
								Room107.ReservationStatus = false;
								Room108.ReservationStatus = false;
								Room109.ReservationStatus = false;
								Room110.ReservationStatus = false;
								
								Write("Habitacion reservada", 30, 16);
								Room103.ReservationStatus = true;
								ReservedRoomsCount( ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
								
								break;
							case "4":
								Room101.ReservationStatus = false;
								Room102.ReservationStatus = false;
								Room103.ReservationStatus = false;
								Room104.ReservationStatus = false;
								Room105.ReservationStatus = false;
								Room106.ReservationStatus = false;
								Room107.ReservationStatus = false;
								Room108.ReservationStatus = false;
								Room109.ReservationStatus = false;
								Room110.ReservationStatus = false;
								
								Write("Habitacion reservada", 30, 16);
								Room104.ReservationStatus = true;
								ReservedRoomsCount( ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
								
								break;
							case "5":
								Room101.ReservationStatus = false;
								Room102.ReservationStatus = false;
								Room103.ReservationStatus = false;
								Room104.ReservationStatus = false;
								Room105.ReservationStatus = false;
								Room106.ReservationStatus = false;
								Room107.ReservationStatus = false;
								Room108.ReservationStatus = false;
								Room109.ReservationStatus = false;
								Room110.ReservationStatus = false;
								
								Write("Habitacion reservada", 30, 16);
								Room105.ReservationStatus = true;
								ReservedRoomsCount( ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
								
								break;
							default:
								PopUp("Elija una opcion valida","ERROR");
								break;
						}
						break;
					case "2":
						WindowLogged("HOTEL HOLIDAY INN - RESERVACION: HABITACION", 23);
						Write("Elija habitacion disponible", 5, 7);
						Write("Opcion elegida: ", 5, 9);
						Write("1. 106 Ocupada: " + Room106.ReservationStatus, 5, 10);
						Write("2. 107 Ocupada: " + Room107.ReservationStatus, 5, 11);
						Write("3. 108 Ocupada: " + Room108.ReservationStatus, 5, 12);
						input2 = MoveRead(22, 9);
						switch (input2) {
							case "1":
								Write("Habitacion reservada", 30, 16);
								Room106.ReservationStatus = true;
								ReservedRoomsCount( ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
								
								break;
							case "2":
								Write("Habitacion reservada", 30, 16);
								Room107.ReservationStatus = true;
								ReservedRoomsCount( ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
								
								break;
							case "3":
								Write("Habitacion reservada", 30, 16);
								Room108.ReservationStatus = true;
								ReservedRoomsCount( ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
								
								break;
							default:
								PopUp("Elija una opcion valida","ERROR");
								break;
						}
						break;
					case "3":
						WindowLogged("HOTEL HOLIDAY INN - RESERVACION: HABITACION", 23);
						Write("Elija habitacion disponible", 5, 7);
						Write("Opcion elegida: ", 5, 9);
						Write("1. 109 Ocupada: " + Room106.ReservationStatus, 5, 10);
						Write("2. 110 Ocupada: " + Room107.ReservationStatus, 5, 11);
						input2 = MoveRead(22, 9);
						switch (input2) {
							case "1":
								Write("Habitacion reservada", 30, 16);
								Room109.ReservationStatus = true;
								ReservedRoomsCount( ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
								
								break;
							case "2":
								Write("Habitacion reservada", 30, 16);
								Room110.ReservationStatus = true;
								ReservedRoomsCount( ref Room101, ref Room102, ref Room103, ref Room104, ref Room105, ref Room106, ref Room107, ref Room108, ref Room109, ref Room110 );
								
								break;
							default:
								PopUp("Elija una opcion valida","ERROR");
								break;
						}
						break;
					case "*":
						
						break;
					default:
						PopUp("Elija una opcion valida","ERROR");
						break;
					
				}
				
				
				
				
			}while(input != "*" && input != "1" && input != "2" && input != "3");
			
			
			
			
			
			
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
