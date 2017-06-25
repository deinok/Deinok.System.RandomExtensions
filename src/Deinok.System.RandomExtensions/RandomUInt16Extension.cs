namespace System {

	/// <summary>
	/// An extension to Random to generate UInt16s
	/// </summary>
	public static class RandomUInt16Extension {

		/// <summary>
		/// Get a random UInt16
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random UInt16</returns>
		public static UInt16 NextUInt16(this Random random) => random.NextUInt16(UInt16.MaxValue);

		/// <summary>
		/// Get a random UInt16
		/// </summary>
		/// <param name="random"></param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random UInt16</returns>
		public static UInt16 NextUInt16(this Random random, UInt16 maxValue) => random.NextUInt16(0, maxValue);

		/// <summary>
		/// Get a random UInt16
		/// </summary>
		/// <param name="random"></param>
		/// <param name="minValue">The minimum value</param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random UInt16</returns>
		public static UInt16 NextUInt16(this Random random, UInt16 minValue, UInt16 maxValue) => (UInt16)random.NextUInt32(minValue, maxValue);

	}

}
