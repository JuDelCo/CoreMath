// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public partial struct Vector4i
	{
		public static Vector4i zero = new Vector4i(0, 0, 0, 1);
		public static Vector4i one = new Vector4i(1, 1, 1, 1);
		public static Vector4i right = new Vector4i(1, 0, 0, 1);
		public static Vector4i left = new Vector4i(-1, 0, 0, 1);
		public static Vector4i up = new Vector4i(0, 1, 0, 1);
		public static Vector4i down = new Vector4i(0, -1, 0, 1);
		public static Vector4i forward = new Vector4i(0, 0, 1, 1);
		public static Vector4i back = new Vector4i(0, 0, -1, 1);

		public Vector4i(Vector3i v) : this(v, 1)
		{
		}

		public Vector4i(Vector3i v, int w)
		{
			this.x = v.x;
			this.y = v.y;
			this.z = v.z;
			this.w = w;
		}

		public int this[int i]
		{
			get
			{
				i %= 4;

				return i == 0 ? x : (i == 1 ? y : (i == 2 ? z : w));
			}
			set
			{
				i %= 4;

				if (i == 0)
				{
					x = value;
				}
				else if (i == 1)
				{
					y = value;
				}
				else if (i == 2)
				{
					z = value;
				}
				else
				{
					w = value;
				}
			}
		}

		public static implicit operator Vector2f(Vector4i vector)
		{
			return new Vector2f(vector.x, vector.y);
		}

		public static implicit operator Vector2i(Vector4i vector)
		{
			return new Vector2i(vector.x, vector.y);
		}

		public static implicit operator Vector3f(Vector4i vector)
		{
			return new Vector3f(vector.x, vector.y, vector.z);
		}

		public static implicit operator Vector3i(Vector4i vector)
		{
			return new Vector3i(vector.x, vector.y, vector.z);
		}

		public static implicit operator Vector4f(Vector4i vector)
		{
			return new Vector4f(vector.x, vector.y, vector.z, vector.w);
		}

#pragma warning disable IDE1006

		public float length
		{
			get { return Math.Sqrt((x * x + y * y) + (z * z + w * w)); }
		}

		public float lengthSqr
		{
			get { return ((x * x + y * y) + (z * z + w * w)); }
		}

		public Vector4f normalized
		{
			get { return Normalize(this); }
		}

#pragma warning restore IDE1006

		public static float Distance(Vector4i a, Vector4i b)
		{
			return (a - b).length;
		}

		public static float DistanceSqr(Vector4i a, Vector4i b)
		{
			return (a - b).lengthSqr;
		}

		public static float Dot(Vector4i a, Vector4i b)
		{
			return (a.x * b.x + a.y * b.y) + (a.z * b.z + a.w * b.w);
		}

		public static Vector4f Mix(Vector4i a, Vector4i b, float alpha)
		{
			return Lerp(a, b, alpha);
		}

		public static Vector4f Normalize(Vector4i v)
		{
			var length = v.length;

			if (length > Math.Epsilon)
			{
				return v / length;
			}

			return Vector4f.zero;
		}

		public static Vector4f Lerp(Vector4i a, Vector4i b, float alpha)
		{
			return a + (alpha * (b - a));
		}

		public static Vector4f LerpClamped(Vector4i a, Vector4i b, float alpha)
		{
			return a + (Math.Clamp01(alpha) * (b - a));
		}

		public static Vector4f Reflect(Vector4i incident, Vector4i normal)
		{
			return incident - 2 * Dot(normal, incident) * normal;
		}

		public static Vector4f Refract(Vector4i incident, Vector4i normal, float eta)
		{
			var dNI = Dot(normal, incident);
			var k = 1 - eta * eta * (1 - dNI * dNI);

			if (k < 0)
			{
				return Vector4f.zero;
			}

			return eta * incident - (eta * dNI + Math.Sqrt(k)) * normal;
		}
	}
}
