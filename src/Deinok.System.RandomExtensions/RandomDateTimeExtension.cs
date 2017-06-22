namespace System {

	public static class RandomDateTimeExtension{

		public static DateTime NextDateTime(this Random random){
			return new DateTime(random.Next());
		}

		public static DateTime NextDateTime(this Random random, DateTime min, DateTime max){
			TimeSpan validRange = max - min;
			return min.AddMilliseconds(random.NextDouble(0, validRange.TotalMilliseconds));
		}
	}


}
