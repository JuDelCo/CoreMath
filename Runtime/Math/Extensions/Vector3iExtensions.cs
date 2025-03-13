// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2025 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public partial struct Vector3i
	{
		public static readonly Vector3i zero = new Vector3i(0, 0, 0);
		public static readonly Vector3i one = new Vector3i(1, 1, 1);
		public static readonly Vector3i right = new Vector3i(1, 0, 0);
		public static readonly Vector3i left = new Vector3i(-1, 0, 0);
		public static readonly Vector3i up = new Vector3i(0, 1, 0);
		public static readonly Vector3i down = new Vector3i(0, -1, 0);
		public static readonly Vector3i forward = new Vector3i(0, 0, 1);
		public static readonly Vector3i back = new Vector3i(0, 0, -1);

		public Vector3i(Vector2i v) : this(v, 0)
		{
		}

		public Vector3i(Vector2i v, int z)
		{
			this.x = v.x;
			this.y = v.y;
			this.z = z;
		}

		public int this[int i]
		{
			get
			{
				i %= 3;

				return i == 0 ? x : (i == 1 ? y : z);
			}
			set
			{
				i %= 3;

				if (i == 0)
				{
					x = value;
				}
				else if (i == 1)
				{
					y = value;
				}
				else
				{
					z = value;
				}
			}
		}

		public static implicit operator Vector2f(Vector3i vector)
		{
			return new Vector2f(vector.x, vector.y);
		}

		public static implicit operator Vector2i(Vector3i vector)
		{
			return new Vector2i(vector.x, vector.y);
		}

		public static implicit operator Vector3f(Vector3i vector)
		{
			return new Vector3f(vector.x, vector.y, vector.z);
		}

		public static implicit operator Vector4f(Vector3i vector)
		{
			return new Vector4f(vector.x, vector.y, vector.z, 0f);
		}

		public static implicit operator Vector4i(Vector3i vector)
		{
			return new Vector4i(vector.x, vector.y, vector.z, 0);
		}

		public Vector3i WithX(int value)
		{
			return new Vector3i(value, y, z);
		}

		public Vector3i WithY(int value)
		{
			return new Vector3i(x, value, z);
		}

		public Vector3i WithZ(int value)
		{
			return new Vector3i(x, y, value);
		}

#pragma warning disable IDE1006

		public float length
		{
			get { return Math.Sqrt((x * x + y * y) + z * z); }
		}

		public float lengthSqr
		{
			get { return ((x * x + y * y) + z * z); }
		}

		public Vector3f normalized
		{
			get { return Normalize(this); }
		}

#pragma warning restore IDE1006

		public static Vector3i Cross(Vector3i a, Vector3i b)
		{
			return new Vector3i(a.y * b.z - b.y * a.z, a.z * b.x - b.z * a.x, a.x * b.y - b.x * a.y);
		}

		public static float Distance(Vector3i a, Vector3i b)
		{
			return (a - b).length;
		}

		public static float DistanceSqr(Vector3i a, Vector3i b)
		{
			return (a - b).lengthSqr;
		}

		public static float Dot(Vector3i a, Vector3i b)
		{
			return (a.x * b.x + a.y * b.y) + a.z * b.z;
		}

		public static Vector3f Mix(Vector3i a, Vector3i b, float alpha)
		{
			return Lerp(a, b, alpha);
		}

		public static Vector3f Normalize(Vector3i v)
		{
			var length = v.length;

			if (length > Math.Epsilon)
			{
				return v / length;
			}

			return Vector3f.zero;
		}

		public static Vector3f Lerp(Vector3i a, Vector3i b, float alpha)
		{
			return a + (alpha * (b - a));
		}

		public static Vector3f LerpClamped(Vector3i a, Vector3i b, float alpha)
		{
			return a + (Math.Clamp01(alpha) * (b - a));
		}

		public static Vector3f Reflect(Vector3i incident, Vector3i normal)
		{
			return incident - 2 * Dot(normal, incident) * normal;
		}

		public static Vector3f Refract(Vector3i incident, Vector3i normal, float eta)
		{
			var dNI = Dot(normal, incident);
			var k = 1 - eta * eta * (1 - dNI * dNI);

			if (k < 0)
			{
				return Vector3f.zero;
			}

			return eta * incident - (eta * dNI + Math.Sqrt(k)) * normal;
		}
	}
}
