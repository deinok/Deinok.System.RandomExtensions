namespace System {

	public static class RandomBoolExtension {

		public static bool NextBool(this Random random){
			return random.Next() % 2 == 0;
		}

	}

}
