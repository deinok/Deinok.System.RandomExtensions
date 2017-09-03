namespace System {

	/// <summary>
	/// An extension to Random to generate UIntPtrs
	/// </summary>
	public static class RandomUIntPtrExtension {

		/// <summary>
		/// Get a random UIntPtr
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random UIntPtr</returns>
		public static UIntPtr NextUIntPtr(this Random random) => random.NextUIntPtr(new UIntPtr(UInt64.MaxValue));

		/// <summary>
		/// Get a random UIntPtr
		/// </summary>
		/// <param name="random"></param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random UIntPtr</returns>
		public static UIntPtr NextUIntPtr(this Random random, UIntPtr maxValue) => random.NextUIntPtr(new UIntPtr(0), maxValue);

		/// <summary>
		/// Get a random UIntPtr
		/// </summary>
		/// <param name="random"></param>
		/// <param name="minValue">The minimum value</param>
		/// <param name="maxValue">The maximum value</param>
		/// <returns>A random UIntPtr</returns>
		public static UIntPtr NextUIntPtr(this Random random, UIntPtr minValue, UIntPtr maxValue) {
			return new UIntPtr(random.NextUInt64(minValue.ToUInt64(), maxValue.ToUInt64()));
		}

	}

}
