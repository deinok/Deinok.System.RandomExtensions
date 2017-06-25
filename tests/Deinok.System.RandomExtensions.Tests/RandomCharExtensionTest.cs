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

	}

}
