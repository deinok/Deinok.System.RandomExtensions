namespace System {

	public static class RandomCharExtension {

		public static char NextChar(this Random random){
			string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
			return chars[random.Next(chars.Length - 1)];
		}

	}

}
