namespace System {

	/// <summary>
	/// An extension to random to generate chars
	/// </summary>
	public static class RandomCharExtension {

		/// <summary>
		/// Get a random char
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random char</returns>
		public static char NextChar(this Random random){
			string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
			return chars[random.Next(chars.Length - 1)];
		}

	}

}
