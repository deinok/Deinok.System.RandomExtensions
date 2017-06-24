namespace System {

	/// <summary>
	/// An extension to random to generate DateTimes
	/// </summary>
	public static class RandomDateTimeExtension{

		/// <summary>
		/// Get a random DateTime
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random DateTime</returns>
		public static DateTime NextDateTime(this Random random){
			return new DateTime(random.Next());
		}

		/// <summary>
		/// Get a random DateTime
		/// </summary>
		/// <param name="random"></param>
		/// <param name="min">The minimum DateTime</param>
		/// <param name="max">The maximum DateTime</param>
		/// <returns>A random DateTime</returns>
		public static DateTime NextDateTime(this Random random, DateTime min, DateTime max){
			TimeSpan validRange = max - min;
			return min.AddMilliseconds(random.NextDouble(0, validRange.TotalMilliseconds));
		}

	}

}
