using System.Collections.Generic;
using System.Linq;

namespace System {

	/// <summary>
	/// An extension to random to generate chars
	/// </summary>
	public static class RandomCharExtension {

		/// <summary>
		/// Get a random char
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random char</returns>
		public static char NextChar(this Random random){
			return (char)random.NextUInt32(char.MaxValue);
		}

		/// <summary>
		/// Get a random char
		/// </summary>
		/// <param name="random"></param>
		/// <param name="chars">Available chars</param>
		/// <returns>A random char</returns>
		public static char NextChar(this Random random,IEnumerable<char> chars){
			chars = chars.Distinct();
			return chars.ElementAt(random.NextInt32(chars.Count()));
		}

		/// <summary>
		/// Get a random ASCII char
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random ASCII char</returns>
		public static char NextCharAscii(this Random random){
			return (char)random.NextUInt16(127);
		}

		/// <summary>
		/// Get a random printable ASCII char
		/// </summary>
		/// <param name="random"></param>
		/// <returns>A random printable ASCII char</returns>
		public static char NextCharPrintableAscii(this Random random){
			return (char)random.NextUInt16(32,126);
		}

	}

}
