using System;
using Xunit;

namespace Deinok.System.RandomExtensions.Tests {

	public class RandomByteExtensionTest:BaseRandomTest{

		[Fact]
		public void NextByteTest(){
			Assert.IsType<byte>(this.Random.NextByte());
		}

	}

}
