/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 5/6/2019
 * Time: 6:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyeto_poo
{
	/// <summary>
	/// Description of Luxor.
	/// </summary>
	public class Luxor: Room
	{
		public Luxor(int Hour)
		{
			if (Convert.ToInt32(Hour) >= 12 && Convert.ToInt32(Hour) < 13) {
				PriceRoom = 850;
			} else{
				PriceRoom = 1000;
			}
		}
		
		
		
		
		
	}
}
