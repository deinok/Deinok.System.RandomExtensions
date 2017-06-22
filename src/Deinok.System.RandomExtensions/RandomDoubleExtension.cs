namespace System {

	public static class RandomExtension {

		public static double NextDouble(this Random random, double maxValue){
			return random.NextDouble(0, maxValue);
		}
		public static double NextDouble(this Random random, double minValue, double maxValue){
			return random.NextDouble() * (maxValue - minValue) + maxValue;
		}

		public static bool NextBool(this Random random){
			return random.Next() % 2 == 0;
		}

	}

}
