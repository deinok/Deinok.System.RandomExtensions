namespace System {

	/// <summary>
	/// An extension to Random to generate Enums
	/// </summary>
	public static class RandomEnumExtension {

		/// <summary>
		/// Get a random enum
		/// </summary>
		/// <typeparam name="E">The enum type</typeparam>
		/// <param name="random"></param>
		/// <returns>A random enum</returns>
		public static E NextEnum<E>(this Random random) {
			Array values = Enum.GetValues(typeof(E));
			return (E)values.GetValue(random.Next(values.Length));
		}

	}

}
