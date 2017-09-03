namespace System {

	/// <summary>
	/// An extension to Random to generate decimals
	/// </summary>
	public static class RandomDecimalExtension {

		/// <summary>
		/// Get a random decimal
		/// </summary>
		/// <param name="random"></param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random decimal</returns>
		public static decimal NextDecimal(this Random random, decimal maxValue) => random.NextDecimal(0, maxValue);

		/// <summary>
		/// Get a random decimal
		/// </summary>
		/// <param name="random"></param>
		/// <param name="minValue">The minimum value</param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random decimal</returns>
		public static decimal NextDecimal(this Random random, decimal minValue, decimal maxValue) {
			return (decimal)random.NextDouble((double)minValue, (double)maxValue);
		}

	}

}
