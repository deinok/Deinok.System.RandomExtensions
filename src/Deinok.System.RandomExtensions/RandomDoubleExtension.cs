namespace System {

	public static class RandomDoubleExtension {

		public static double NextDouble(this Random random, double maxValue){
			return random.NextDouble(0, maxValue);
		}
		public static double NextDouble(this Random random, double minValue, double maxValue){
			return random.NextDouble() * (maxValue - minValue) + maxValue;
		}

	}

}
