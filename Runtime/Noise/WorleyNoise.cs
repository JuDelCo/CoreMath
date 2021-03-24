// SPDX-License-Identifier: MIT
// Author: Steven Worley, implemented by Scrawk, modified by JuDelCo
// Source: https://github.com/Scrawk/Procedural-Noise/blob/master/Assets/ProceduralNoise/Noise/WorleyNoise.cs

namespace Ju.Math.Random
{
	using Ju.Math;

	public class WorleyNoise : INoise
	{
		public enum DistanceFunction { Euclidean, Manhattan, Chebyshev };
		public enum CombinationFunction { D0, D1_D0, D2_D0 };

		public float Jitter { get; set; }
		public DistanceFunction Distance { get; set; }
		public CombinationFunction Combination { get; set; }

		private NoiseUtil.PermutationTable Perm { get; set; }
		private const float K = 1.0f / 7.0f;
		private const float Ko = 3.0f / 7.0f;
		private static readonly float[] offsetF = new float[] { -0.5f, 0.5f, 1.5f };

		public WorleyNoise(int seed, float jitter, DistanceFunction distanceFunc = DistanceFunction.Euclidean, CombinationFunction combinationFunc = CombinationFunction.D1_D0)
		{
			Jitter = jitter;
			Distance = distanceFunc;
			Combination = combinationFunc;

			Perm = new NoiseUtil.PermutationTable(1024, 255, seed);
		}

		public void ChangeSeed(int seed)
		{
			Perm.Build(seed);
		}

		public float Sample1D(float x)
		{
			int Pi0 = Math.Floor(x);
			float Pf0 = Math.Frac(x);

			var pX = new Vector3f();
			pX.x = Perm[Pi0 - 1];
			pX.y = Perm[Pi0];
			pX.z = Perm[Pi0 + 1];

			float d0, d1, d2;
			float F0 = float.PositiveInfinity;
			float F1 = float.PositiveInfinity;
			float F2 = float.PositiveInfinity;

			int px, py, pz;
			float oxx, oxy, oxz;

			px = Perm[(int)pX.x];
			py = Perm[(int)pX.y];
			pz = Perm[(int)pX.z];

			oxx = Math.Frac(px * K) - Ko;
			oxy = Math.Frac(py * K) - Ko;
			oxz = Math.Frac(pz * K) - Ko;

			d0 = Distance1D(Pf0, offsetF[0] + Jitter * oxx);
			d1 = Distance1D(Pf0, offsetF[1] + Jitter * oxy);
			d2 = Distance1D(Pf0, offsetF[2] + Jitter * oxz);

			if (d0 < F0) { F2 = F1; F1 = F0; F0 = d0; }
			else if (d0 < F1) { F2 = F1; F1 = d0; }
			else if (d0 < F2) { F2 = d0; }

			if (d1 < F0) { F2 = F1; F1 = F0; F0 = d1; }
			else if (d1 < F1) { F2 = F1; F1 = d1; }
			else if (d1 < F2) { F2 = d1; }

			if (d2 < F0) { F2 = F1; F1 = F0; F0 = d2; }
			else if (d2 < F1) { F2 = F1; F1 = d2; }
			else if (d2 < F2) { F2 = d2; }

			return Combine(F0, F1, F2);
		}

		public float Sample2D(float x, float y)
		{
			int Pi0 = Math.Floor(x);
			int Pi1 = Math.Floor(y);

			float Pf0 = Math.Frac(x);
			float Pf1 = Math.Frac(y);

			var pX = new Vector3f();
			pX.x = Perm[Pi0 - 1];
			pX.y = Perm[Pi0];
			pX.z = Perm[Pi0 + 1];

			float d0, d1, d2;
			float F0 = float.PositiveInfinity;
			float F1 = float.PositiveInfinity;
			float F2 = float.PositiveInfinity;

			int px, py, pz;
			float oxx, oxy, oxz;
			float oyx, oyy, oyz;

			for (int i = 0; i < 3; ++i)
			{
				px = Perm[(int)pX[i], Pi1 - 1];
				py = Perm[(int)pX[i], Pi1];
				pz = Perm[(int)pX[i], Pi1 + 1];

				oxx = Math.Frac(px * K) - Ko;
				oxy = Math.Frac(py * K) - Ko;
				oxz = Math.Frac(pz * K) - Ko;

				oyx = Math.Mod(Math.Floor(px * K), 7.0f) * K - Ko;
				oyy = Math.Mod(Math.Floor(py * K), 7.0f) * K - Ko;
				oyz = Math.Mod(Math.Floor(pz * K), 7.0f) * K - Ko;

				d0 = Distance2D(Pf0, Pf1, offsetF[i] + Jitter * oxx, -0.5f + Jitter * oyx);
				d1 = Distance2D(Pf0, Pf1, offsetF[i] + Jitter * oxy, 0.5f + Jitter * oyy);
				d2 = Distance2D(Pf0, Pf1, offsetF[i] + Jitter * oxz, 1.5f + Jitter * oyz);

				if (d0 < F0) { F2 = F1; F1 = F0; F0 = d0; }
				else if (d0 < F1) { F2 = F1; F1 = d0; }
				else if (d0 < F2) { F2 = d0; }

				if (d1 < F0) { F2 = F1; F1 = F0; F0 = d1; }
				else if (d1 < F1) { F2 = F1; F1 = d1; }
				else if (d1 < F2) { F2 = d1; }

				if (d2 < F0) { F2 = F1; F1 = F0; F0 = d2; }
				else if (d2 < F1) { F2 = F1; F1 = d2; }
				else if (d2 < F2) { F2 = d2; }
			}

			return Combine(F0, F1, F2);
		}

		public float Sample3D(float x, float y, float z)
		{
			int Pi0 = Math.Floor(x);
			int Pi1 = Math.Floor(y);
			int Pi2 = Math.Floor(z);

			float Pf0 = Math.Frac(x);
			float Pf1 = Math.Frac(y);
			float Pf2 = Math.Frac(z);

			var pX = new Vector3f();
			pX.x = Perm[Pi0 - 1];
			pX.y = Perm[Pi0];
			pX.z = Perm[Pi0 + 1];

			var pY = new Vector3f();
			pY.x = Perm[Pi1 - 1];
			pY.y = Perm[Pi1];
			pY.z = Perm[Pi1 + 1];

			float d0, d1, d2;
			float F0 = 1e6f;
			float F1 = 1e6f;
			float F2 = 1e6f;

			int px, py, pz;
			float oxx, oxy, oxz;
			float oyx, oyy, oyz;
			float ozx, ozy, ozz;

			for (int i = 0; i < 3; ++i)
			{
				for (int j = 0; j < 3; ++j)
				{
					px = Perm[(int)pX[i], (int)pY[j], Pi2 - 1];
					py = Perm[(int)pX[i], (int)pY[j], Pi2];
					pz = Perm[(int)pX[i], (int)pY[j], Pi2 + 1];

					oxx = Math.Frac(px * K) - Ko;
					oxy = Math.Frac(py * K) - Ko;
					oxz = Math.Frac(pz * K) - Ko;

					oyx = Math.Mod(Math.Floor(px * K), 7.0f) * K - Ko;
					oyy = Math.Mod(Math.Floor(py * K), 7.0f) * K - Ko;
					oyz = Math.Mod(Math.Floor(pz * K), 7.0f) * K - Ko;

					px = Perm[px];
					py = Perm[py];
					pz = Perm[pz];

					ozx = Math.Frac(px * K) - Ko;
					ozy = Math.Frac(py * K) - Ko;
					ozz = Math.Frac(pz * K) - Ko;

					d0 = Distance3D(Pf0, Pf1, Pf2, offsetF[i] + Jitter * oxx, offsetF[j] + Jitter * oyx, -0.5f + Jitter * ozx);
					d1 = Distance3D(Pf0, Pf1, Pf2, offsetF[i] + Jitter * oxy, offsetF[j] + Jitter * oyy, 0.5f + Jitter * ozy);
					d2 = Distance3D(Pf0, Pf1, Pf2, offsetF[i] + Jitter * oxz, offsetF[j] + Jitter * oyz, 1.5f + Jitter * ozz);

					if (d0 < F0) { F2 = F1; F1 = F0; F0 = d0; }
					else if (d0 < F1) { F2 = F1; F1 = d0; }
					else if (d0 < F2) { F2 = d0; }

					if (d1 < F0) { F2 = F1; F1 = F0; F0 = d1; }
					else if (d1 < F1) { F2 = F1; F1 = d1; }
					else if (d1 < F2) { F2 = d1; }

					if (d2 < F0) { F2 = F1; F1 = F0; F0 = d2; }
					else if (d2 < F1) { F2 = F1; F1 = d2; }
					else if (d2 < F2) { F2 = d2; }
				}
			}

			return Combine(F0, F1, F2);
		}

		private float Distance1D(float p1x, float p2x)
		{
			switch (Distance)
			{
				case DistanceFunction.Euclidean:
					return (p1x - p2x) * (p1x - p2x);
				case DistanceFunction.Manhattan:
					return Math.Abs(p1x - p2x);
				case DistanceFunction.Chebyshev:
					return Math.Abs(p1x - p2x);
			}

			return 0;
		}

		private float Distance2D(float p1x, float p1y, float p2x, float p2y)
		{
			switch (Distance)
			{
				case DistanceFunction.Euclidean:
					return (p1x - p2x) * (p1x - p2x) + (p1y - p2y) * (p1y - p2y);
				case DistanceFunction.Manhattan:
					return Math.Abs(p1x - p2x) + Math.Abs(p1y - p2y);
				case DistanceFunction.Chebyshev:
					return Math.Max(Math.Abs(p1x - p2x), Math.Abs(p1y - p2y));
			}

			return 0;
		}

		private float Distance3D(float p1x, float p1y, float p1z, float p2x, float p2y, float p2z)
		{
			switch (Distance)
			{
				case DistanceFunction.Euclidean:
					return (p1x - p2x) * (p1x - p2x) + (p1y - p2y) * (p1y - p2y) + (p1z - p2z) * (p1z - p2z);
				case DistanceFunction.Manhattan:
					return Math.Abs(p1x - p2x) + Math.Abs(p1y - p2y) + Math.Abs(p1z - p2z);
				case DistanceFunction.Chebyshev:
					return Math.Max(Math.Max(Math.Abs(p1x - p2x), Math.Abs(p1y - p2y)), Math.Abs(p1z - p2z));
			}

			return 0;
		}

		private float Combine(float f0, float f1, float f2)
		{
			switch (Combination)
			{
				case CombinationFunction.D0:
					return f0;
				case CombinationFunction.D1_D0:
					return f1 - f0;
				case CombinationFunction.D2_D0:
					return f2 - f0;
			}

			return 0;
		}
	}
}
