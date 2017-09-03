namespace System {

	/// <summary>
	/// An Extension to Random to generate bools
	/// </summary>
	public static class RandomBoolExtension {

		/// <summary>
		/// Get a random bool
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random bool</returns>
		public static bool NextBool(this Random random) {
			return random.Next() % 2 == 0;
		}

	}

}
