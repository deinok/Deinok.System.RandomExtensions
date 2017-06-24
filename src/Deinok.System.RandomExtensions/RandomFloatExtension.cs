namespace System {

	/// <summary>
	/// A extension to random to generate floats
	/// </summary>
	public static class RandomFloatExtension{

		/// <summary>
		/// Get a random float
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random float</returns>
		public static float NextFloat(this Random random){
			return (float)random.NextDouble();
		}

		/// <summary>
		/// Get a random float
		/// </summary>
		/// <param name="random"></param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random float</returns>
		public static float NextFloat(this Random random, float maxValue)=>random.NextFloat(0,maxValue);

		/// <summary>
		/// Get a random float
		/// </summary>
		/// <param name="random"></param>
		/// <param name="minValue">The minimum value</param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns></returns>
		public static float NextFloat(this Random random, float minValue, float maxValue){
			return (float)random.NextDouble(minValue, maxValue);
		}

	}

}
