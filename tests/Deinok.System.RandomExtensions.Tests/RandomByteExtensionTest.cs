using System;
using Xunit;

namespace Deinok.System.RandomExtensions.Tests {

	/// <summary>
	/// Test of bytes
	/// </summary>
	public class RandomByteExtensionTest:BaseRandomTest{

		/// <summary>
		/// Test NextByte
		/// </summary>
		[Fact]
		public void NextByteTest(){
			Assert.IsType<byte>(this.Random.NextByte());
		}

	}

}
