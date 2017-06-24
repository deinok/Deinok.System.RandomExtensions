using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Deinok.System.RandomExtensions.Tests {

	public class RandomBoolExtensionTest:BaseRandomTest{

        [Fact]
        public void NextBoolTest() {
			Assert.IsType<bool>(this.Random.NextBool());
        }

		[Fact]
		public void Test2(){
			int numberElements = 1000000;
			int maxPercentage = 60;
			int maxTrues = (numberElements * maxPercentage) / 100;
			int minPercentage = 40;
			int minTrues = (numberElements * minPercentage) / 100;
			int numberTrues =this.GenerateRandomBools().Take(numberElements).Count(boolVal=>boolVal);
			Assert.True(numberTrues <= maxTrues && numberTrues >= minTrues);
		}

		private IEnumerable<bool> GenerateRandomBools(){
			while (true) {
				yield return this.Random.NextBool();
			}
		}

    }

}
