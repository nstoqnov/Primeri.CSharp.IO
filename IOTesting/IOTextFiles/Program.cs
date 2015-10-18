using System;

namespace IOTextFiles
{
	class MainClass
	{
		

		public static void Main (string[] args)
		{
			STable _STable = new STable ();
			IOSettings _io = new IOSettings (_STable);




			if (_io.open ())								//_io.save ())
			{
				Console.WriteLine ("Tablicata e prochetena uspeshno.");

			} else {
				Console.WriteLine ("Tablicata NE e prochetena uspeshno.");
			}

			Console.WriteLine (_STable.stable[2]);
		}
	}
}
