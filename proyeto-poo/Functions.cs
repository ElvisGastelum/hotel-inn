/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 5/6/2019
 * Time: 4:07 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using System.Collections;


namespace proyeto_poo
{
	/// <summary>
	/// Description of Functions.
	/// </summary>
	public class Functions
	{
		[DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);
		
		
		public Functions()
		{
		}
		
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
		
		
	}
}
