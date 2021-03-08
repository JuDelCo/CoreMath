// SPDX-License-Identifier: MIT
// Author: Scrawk, modified by JuDelCo
// Source: https://github.com/Scrawk/Procedural-Noise

namespace Ju.Random
{
	using Ju.Math;

	public class ValueNoise : INoise
	{
		private readonly NoiseUtil.PermutationTable perm;

		public ValueNoise(int seed)
		{
			perm = new NoiseUtil.PermutationTable(1024, 255, seed);
		}

		public void ChangeSeed(int seed)
		{
			perm.Build(seed);
		}

		public float Sample1D(float x)
		{
			int ix0;
			float fx0;
			float s, n0, n1;

			ix0 = Math.Floor(x); // Integer part of x
			fx0 = x - ix0;       // Fractional part of x

			s = Fade(fx0);

			n0 = perm[ix0];
			n1 = perm[ix0 + 1];

			// Rescale from 0 to 255 to -1 to 1
			float n = Math.Lerp(n0, n1, s) * perm.Inverse;
			n = n * 2.0f - 1.0f;

			return n;
		}

		public float Sample2D(float x, float y)
		{
			int ix0, iy0;
			float fx0, fy0, s, t, nx0, nx1, n0, n1;

			ix0 = Math.Floor(x); // Integer part of x
			iy0 = Math.Floor(y); // Integer part of y

			fx0 = x - ix0;       // Fractional part of x
			fy0 = y - iy0;       // Fractional part of y

			t = Fade(fy0);
			s = Fade(fx0);

			nx0 = perm[ix0, iy0];
			nx1 = perm[ix0, iy0 + 1];

			n0 = Math.Lerp(nx0, nx1, t);

			nx0 = perm[ix0 + 1, iy0];
			nx1 = perm[ix0 + 1, iy0 + 1];

			n1 = Math.Lerp(nx0, nx1, t);

			// Rescale from 0 to 255 to -1 to 1
			float n = Math.Lerp(n0, n1, s) * perm.Inverse;
			n = n * 2.0f - 1.0f;

			return n;
		}

		public float Sample3D(float x, float y, float z)
		{
			int ix0, iy0, iz0;
			float fx0, fy0, fz0;
			float s, t, r;
			float nxy0, nxy1, nx0, nx1, n0, n1;

			ix0 = Math.Floor(x); // Integer part of x
			iy0 = Math.Floor(y); // Integer part of y
			iz0 = Math.Floor(z); // Integer part of z
			fx0 = x - ix0;       // Fractional part of x
			fy0 = y - iy0;       // Fractional part of y
			fz0 = z - iz0;       // Fractional part of z

			r = Fade(fz0);
			t = Fade(fy0);
			s = Fade(fx0);

			nxy0 = perm[ix0, iy0, iz0];
			nxy1 = perm[ix0, iy0, iz0 + 1];
			nx0 = Math.Lerp(nxy0, nxy1, r);

			nxy0 = perm[ix0, iy0 + 1, iz0];
			nxy1 = perm[ix0, iy0 + 1, iz0 + 1];
			nx1 = Math.Lerp(nxy0, nxy1, r);

			n0 = Math.Lerp(nx0, nx1, t);

			nxy0 = perm[ix0 + 1, iy0, iz0];
			nxy1 = perm[ix0 + 1, iy0, iz0 + 1];
			nx0 = Math.Lerp(nxy0, nxy1, r);

			nxy0 = perm[ix0 + 1, iy0 + 1, iz0];
			nxy1 = perm[ix0 + 1, iy0 + 1, iz0 + 1];
			nx1 = Math.Lerp(nxy0, nxy1, r);

			n1 = Math.Lerp(nx0, nx1, t);

			// Rescale from 0 to 255 to -1 to 1
			float n = Math.Lerp(n0, n1, s) * perm.Inverse;
			n = n * 2.0f - 1.0f;

			return n;
		}

		private float Fade(float t)
		{
			return t * t * t * (t * (t * 6.0f - 15.0f) + 10.0f);
		}
	}
}
