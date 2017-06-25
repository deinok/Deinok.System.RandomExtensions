using System.Collections.Generic;
using System.Linq;

namespace System {

	/// <summary>
	/// An extension to random to generate strings
	/// </summary>
	public static class RandomStringExtension {

		/// <summary>
		/// Get a random string
		/// </summary>
		/// <param name="random"></param>
		/// <param name="length">The length of the string</param>
		/// <returns>A random string</returns>
		public static string NextString(this Random random,int length){
			return new string(new char[length]
				.Select(selector => random.NextChar())
				.ToArray()
			);
		}

		/// <summary>
		/// Get a random string
		/// </summary>
		/// <param name="random"></param>
		/// <param name="length">The length of the string</param>
		/// <param name="chars">Available chars</param>
		/// <returns>A random string</returns>
		public static string NextString(this Random random,int length,IEnumerable<char> chars){
			return new string(new char[length]
				.Select(selector => random.NextChar(chars))
				.ToArray()
			);
		}

		/// <summary>
		/// Get a random ASCII string
		/// </summary>
		/// <param name="random"></param>
		/// <param name="length">The length of the string</param>
		/// <returns>A random ASCII string</returns>
		public static string NextStringAscii(this Random random,int length){
			return new string(new char[length]
				.Select(selector => random.NextCharAscii())
				.ToArray()
			);
		}

		/// <summary>
		/// Get a random printable ASCII string
		/// </summary>
		/// <param name="random"></param>
		/// <param name="length">The length of the string</param>
		/// <returns>A random printable ASCII string</returns>
		public static string NextStringPrintableAscii(this Random random,int length){
			return new string(new char[length]
				.Select(selector => random.NextCharPrintableAscii())
				.ToArray()
			);
		}

	}

}
