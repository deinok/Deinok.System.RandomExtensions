namespace System {

	/// <summary>
	/// An extension to Random to generate Int32s
	/// </summary>
	public static class RandomInt32Extension {

		/// <summary>
		/// Get a random Int16
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random Int32</returns>
		public static Int32 NextInt16(this Random random) => random.NextInt32(Int32.MaxValue);

		/// <summary>
		/// Get a random Int32
		/// </summary>
		/// <param name="random"></param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random Int32</returns>
		public static Int32 NextInt32(this Random random, Int32 maxValue) => random.NextInt32(0, maxValue);

		/// <summary>
		/// Get a random Int32
		/// </summary>
		/// <param name="random"></param>
		/// <param name="minValue">The minimum value</param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random Int32</returns>
		public static Int32 NextInt32(this Random random, Int32 minValue, Int32 maxValue) => (Int32)random.NextInt64(minValue, maxValue);

	}

}
