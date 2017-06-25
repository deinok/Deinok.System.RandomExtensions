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
			return (char)random.NextUInt32(char.MaxValue);
		}

		/// <summary>
		/// Get a random ASCII char
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random ASCII char</returns>
		public static char NextCharAscii(this Random random){
			return (char)random.NextUInt16(127);
		}

	}

}
