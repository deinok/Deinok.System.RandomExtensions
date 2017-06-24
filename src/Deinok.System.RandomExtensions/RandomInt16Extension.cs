namespace System {

	/// <summary>
	/// An extension to Random to generate Int16s
	/// </summary>
	public static class RandomInt16Extension{

		/// <summary>
		/// Get a random Int16
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random Int16</returns>
		public static Int16 NextInt16(this Random random) => random.NextInt16(Int16.MaxValue);

		/// <summary>
		/// Get a random Int16
		/// </summary>
		/// <param name="random"></param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random Int16</returns>
		public static Int16 NextInt16(this Random random, Int16 maxValue) => random.NextInt16(0, maxValue);

		/// <summary>
		/// Get a random Int16
		/// </summary>
		/// <param name="random"></param>
		/// <param name="minValue">The minimum value</param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random Int16</returns>
		public static Int16 NextInt16(this Random random, Int16 minValue, Int16 maxValue){
			short longRand = BitConverter.ToInt16(random.NextBytes(2), 0);
			return (Int16)(Math.Abs(longRand % (maxValue - minValue)) + minValue);
		}

	}

}
