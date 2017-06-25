using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Deinok.System.RandomExtensions.Tests {

	/// <summary>
	/// Test char
	/// </summary>
	public class RandomCharExtensionTest:BaseRandomTest{

		/// <summary>
		/// Test NextChar
		/// </summary>
		[Fact]
		public void NextCharTest(){
			this.GenerateRandomChar().Take(10000).ToList().ForEach(character => {
				Assert.IsType<char>(character);
				Assert.True(character >= 0 && character <= char.MaxValue);
			});
		}

		/// <summary>
		/// Test NextCharAscii
		/// </summary>
		[Fact]
		public void NextCharAsciiTest(){
			this.GenerateRandomCharAscii().Take(10000).ToList().ForEach(character => {	 
				Assert.IsType<char>(character);
				Assert.True(character >= 0 && character <= 127);
			});
		}

		/// <summary>
		/// Test NextCharPrintableAscii
		/// </summary>
		[Fact]
		public void NextCharPrintableAsciiTest(){
			this.GenerateRandomCharPrintableAscii().Take(10000).ToList().ForEach(character => {
				Assert.IsType<char>(character);
				Assert.True(character >= 32 && character <= 126);
			});
		}

		private IEnumerable<char> GenerateRandomChar(){
			while (true) {
				yield return this.Random.NextChar();
			}
		}

		private IEnumerable<char> GenerateRandomCharAscii(){
			while (true) {
				yield return this.Random.NextCharAscii();
			}
		}

		private IEnumerable<char> GenerateRandomCharPrintableAscii(){
			while (true) {
				yield return this.Random.NextCharPrintableAscii();
			}
		}

	}

}
