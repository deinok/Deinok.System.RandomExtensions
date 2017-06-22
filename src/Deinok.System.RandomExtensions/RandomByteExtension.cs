namespace System {

	public static class RandomByteExtension {

		public static byte NextByte(this Random random){
			byte[] bytes = new byte[1];
			random.NextBytes(bytes);
			return bytes[0];
		}

	}

}
