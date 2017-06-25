namespace System {

	/// <summary>
	/// An extension to Random to generate UInt32s
	/// </summary>
	public static class RandomUInt32Extension {

		/// <summary>
		/// Get a random UInt32
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random UInt32</returns>
		public static UInt32 NextUInt32(this Random random) => random.NextUInt32(UInt32.MaxValue);

		/// <summary>
		/// Get a random UInt32
		/// </summary>
		/// <param name="random"></param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random UInt32</returns>
		public static UInt32 NextUInt32(this Random random, UInt32 maxValue) => random.NextUInt32(0, maxValue);

		/// <summary>
		/// Get a random UInt32
		/// </summary>
		/// <param name="random"></param>
		/// <param name="minValue">The minimum value</param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random UInt32</returns>
		public static UInt32 NextUInt32(this Random random, UInt32 minValue, UInt32 maxValue) => (UInt32)random.NextUInt64(minValue, maxValue);

	}

}
