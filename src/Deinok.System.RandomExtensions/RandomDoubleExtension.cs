namespace System {

	/// <summary>
	/// An extension to Random to generate doubles
	/// </summary>
	public static class RandomDoubleExtension {

		/// <summary>
		/// Get a random double
		/// </summary>
		/// <param name="random"></param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random double</returns>
		public static double NextDouble(this Random random, double maxValue) => random.NextDouble(0, maxValue);

		/// <summary>
		/// Get a random double
		/// </summary>
		/// <param name="random"></param>
		/// <param name="minValue">The minimum value</param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random double</returns>
		public static double NextDouble(this Random random, double minValue, double maxValue) {
			return random.NextDouble() * (maxValue - minValue) + maxValue;
		}

	}

}
