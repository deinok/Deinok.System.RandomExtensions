namespace System {

	/// <summary>
	/// A extension to Random to generate Guid
	/// </summary>
	public static class RandomGuidExtension {

		/// <summary>
		/// Get a random Guid
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random Guid</returns>
		public static Guid NextGuid(this Random random) {
			return Guid.NewGuid();
		}

	}

}
