namespace System {

	/// <summary>
	/// An extension to Random to generate SBytes
	/// </summary>
	public static class RandomSByteExtension{

		/// <summary>
		/// Get a random SByte
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random SByte</returns>
		public static SByte NextSByte(this Random random) => random.NextSByte(SByte.MaxValue);

		/// <summary>
		/// Get a random SByte
		/// </summary>
		/// <param name="random"></param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random SByte</returns>
		public static SByte NextSByte(this Random random, SByte maxValue) => random.NextSByte(0, maxValue);

		/// <summary>
		/// Get a random SByte
		/// </summary>
		/// <param name="random"></param>
		/// <param name="minValue">The minimum value</param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random SByte</returns>
		public static SByte NextSByte(this Random random, SByte minValue, SByte maxValue) => (SByte)random.NextInt16(minValue, maxValue);

	}

}
