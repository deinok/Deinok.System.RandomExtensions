namespace System {

	/// <summary>
	/// An extension to Random to generate UInt64s
	/// </summary>
	public static class RandomUInt64Extension{

		/// <summary>
		/// Get a random UInt64
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random UInt64</returns>
		public static UInt64 NextUInt64(this Random random) => random.NextUInt64(UInt64.MaxValue);

		/// <summary>
		/// Get a random UInt64
		/// </summary>
		/// <param name="random"></param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random UInt64</returns>
		public static UInt64 NextUInt64(this Random random, UInt64 maxValue) => random.NextUInt64(0, maxValue);

		/// <summary>
		/// Get a random UInt64
		/// </summary>
		/// <param name="random"></param>
		/// <param name="minValue">The minimum value</param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random UInt64</returns>
		public static UInt64 NextUInt64(this Random random, UInt64 minValue, UInt64 maxValue){
			UInt64 ulongRand = BitConverter.ToUInt64(random.NextBytes(8), 0);
			return ulongRand % (maxValue - minValue) + minValue;
		}

	}

}
