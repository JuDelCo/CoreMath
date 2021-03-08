// SPDX-License-Identifier: Unlicense
// FastFloor Source: http://www.codeproject.com/Tips/700780/Fast-floor-ceiling-functions
// PermutationTable Source: https://github.com/Scrawk/Procedural-Noise/blob/master/Assets/ProceduralNoise/Noise/PermutationTable.cs

using System.Runtime.CompilerServices;

namespace Ju.Random
{
	using Ju.Math;

	public class NoiseUtil
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FastFloor(double x)
		{
			int xi = (int)x;
			return x < xi ? xi - 1 : xi;
		}

		public class PermutationTable
		{
			public float Inverse { get; private set; }

			private int seed;
			private int[] table;
			private readonly int size;
			private readonly int max;
			private readonly int wrap;

			public PermutationTable(int size, int max, int seed)
			{
				this.size = size;
				this.max = Math.Max(1, max);
				wrap = size - 1;
				Inverse = 1.0f / this.max;

				Build(seed);
			}

			public void Build(int seed)
			{
				if (this.seed == seed && table != null)
				{
					return;
				}

				this.seed = seed;
				table = new int[size];

				var random = new System.Random(this.seed);

				for (int i = 0; i < size; i++)
				{
					table[i] = random.Next();
				}
			}

			public int this[int i] { get { return table[i & wrap] & max; } }
			public int this[int i, int j] { get { return table[(j + table[i & wrap]) & wrap] & max; } }
			public int this[int i, int j, int k] { get { return table[(k + table[(j + table[i & wrap]) & wrap]) & wrap] & max; } }
		}
	}
}
