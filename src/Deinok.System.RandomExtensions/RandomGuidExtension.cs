namespace System {

	public static class RandomGuidExtension {

		public static Guid NextGuid(this Random random){
			return Guid.NewGuid();
		}

	}

}
