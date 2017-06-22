namespace System {

	public static class RandomEnumExtension {

		public static E NextEnum<E>(this Random random){
			Array values = Enum.GetValues(typeof(E));
			return (E) values.GetValue(random.Next(values.Length));
		}

	}

}
