using System;

namespace Deinok.System.RandomExtensions.Tests {

	/// <summary>
	/// The base class to tests random
	/// </summary>
	public abstract class BaseRandomTest{

		/// <summary>
		/// A Random instance ready
		/// </summary>
		protected Random Random { get; } = new Random();

    }

}
