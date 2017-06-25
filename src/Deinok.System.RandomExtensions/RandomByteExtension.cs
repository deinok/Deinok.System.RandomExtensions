namespace System {

	/// <summary>
	/// An extension to random to generate bytes
	/// </summary>
	public static class RandomByteExtension {

		/// <summary>
		/// Get a random byte
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random byte</returns>
		public static byte NextByte(this Random random)=>random.NextBytes(1)[0];

		/// <summary>
		/// Get a random byte array
		/// </summary>
		/// <param name="random"></param>
		/// <param name="length">The length of the array</param>
		/// <returns>A random byte[]</returns>
		public static byte[] NextBytes(this Random random,int length){
			byte[] bytes = new byte[length];
			random.NextBytes(bytes);
			return bytes;
		}

	}

}
