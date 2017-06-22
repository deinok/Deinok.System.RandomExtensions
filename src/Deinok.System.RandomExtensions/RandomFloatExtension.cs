namespace System {

	public static class RandomFloatExtension{

		public static float NextFloat(this Random random){
			return (float)random.NextDouble();
		}

		public static float NextFloat(this Random random, float maxValue){
			return (float)random.NextDouble(maxValue);
		}

		public static float NextFloat(this Random random, float minValue, float maxValue){
			return (float)random.NextDouble(minValue, maxValue);
		}

	}

}
