/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 5/6/2019
 * Time: 6:45 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyeto_poo
{
	/// <summary>
	/// Description of Double.
	/// </summary>
	public class Double: Room
	{
		public Double(int Hour)
		{
			if (Convert.ToInt32(Hour) >= 12 && Convert.ToInt32(Hour) < 13) {
				PriceRoom = 600;
			} else{
				PriceRoom = 700;
			}
		}
		
		
		
		
		
		
	}
}
