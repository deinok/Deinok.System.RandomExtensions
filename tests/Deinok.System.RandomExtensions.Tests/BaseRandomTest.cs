using System;

namespace Deinok.System.RandomExtensions.Tests {

	public abstract class BaseRandomTest{

		protected Random Random { get; } = new Random();

		public BaseRandomTest() { }

    }

}
