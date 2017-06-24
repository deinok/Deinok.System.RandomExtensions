using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Deinok.System.RandomExtensions.Tests {

	/// <summary>
	/// Tests of Bool
	/// </summary>
	public class RandomBoolExtensionTest:BaseRandomTest{

		/// <summary>
		/// Test NextBool
		/// </summary>
        [Fact]
        public void NextBoolTest() {
			Assert.IsType<bool>(this.Random.NextBool());
        }

		/// <summary>
		/// Test that random bool is between 40-60%
		/// </summary>
		[Fact]
		public void ProbabilityTest(){
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
