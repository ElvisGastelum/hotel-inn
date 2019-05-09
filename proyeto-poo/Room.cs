/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 5/6/2019
 * Time: 6:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyeto_poo
{
	/// <summary>
	/// Description of Room.
	/// </summary>
	public class Room : Functions
	{
		public Room()
		{
		}
		
		public int NumberRoom{get;set;}
		public int PriceRoom{get;set;}
		
		
		bool _ReservationStatus = false;
		public bool ReservationStatus{
			get{
				return _ReservationStatus;
			}
			set{
				_ReservationStatus = value;
			}
		}
		
		
		
		
	}
}
