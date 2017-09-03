namespace System {

	/// <summary>
	/// An extension to Random to generate IntPtrs
	/// </summary>
	public static class RandomIntPtrExtension {

		/// <summary>
		/// Get a random IntPtr
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random IntPtr</returns>
		public static IntPtr NextIntPtr(this Random random) => random.NextIntPtr(new IntPtr(Int64.MaxValue));

		/// <summary>
		/// Get a random IntPtr
		/// </summary>
		/// <param name="random"></param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random IntPtr</returns>
		public static IntPtr NextIntPtr(this Random random, IntPtr maxValue) => random.NextIntPtr(new IntPtr(0), maxValue);

		/// <summary>
		/// Get a random IntPtr
		/// </summary>
		/// <param name="random"></param>
		/// <param name="minValue">The minimum value</param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random IntPtr</returns>
		public static IntPtr NextIntPtr(this Random random, IntPtr minValue, IntPtr maxValue) {
			return new IntPtr(random.NextInt64(minValue.ToInt64(), maxValue.ToInt64()));
		}

	}

}
