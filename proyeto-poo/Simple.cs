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
	/// Description of Simple.
	/// </summary>
	public class Simple : Room
	{
		public Simple(int Hour)
		{
			if (Convert.ToInt32(Hour) >= 12 && Convert.ToInt32(Hour) < 13) {
				PriceRoom = 400;
			} else{
				PriceRoom = 500;
			}
		}
		
		
		
		
	}
}
