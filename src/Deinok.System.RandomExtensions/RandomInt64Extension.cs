namespace System {

	/// <summary>
	/// An extension to Random to generate Int64s
	/// </summary>
	public static class RandomInt64Extension{

		/// <summary>
		/// Get a random Int64
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random float</returns>
		public static Int64 NextInt64(this Random random) => random.NextInt64(Int64.MaxValue);

		/// <summary>
		/// Get a random Int64
		/// </summary>
		/// <param name="random"></param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random float</returns>
		public static Int64 NextInt64(this Random random, Int64 maxValue) => random.NextInt64(0, maxValue);

		/// <summary>
		/// Get a random Int64
		/// </summary>
		/// <param name="random"></param>
		/// <param name="minValue">The minimum value</param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns></returns>
		public static Int64 NextInt64(this Random random, Int64 minValue, Int64 maxValue){
			long longRand = BitConverter.ToInt64(random.NextBytes(8), 0);
			return (Math.Abs(longRand % (maxValue - minValue)) + minValue);
		}

	}

}
