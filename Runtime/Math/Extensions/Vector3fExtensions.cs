// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public partial struct Vector3f
	{
		public static Vector3f zero = new Vector3f(0f, 0f, 0f);
		public static Vector3f one = new Vector3f(1f, 1f, 1f);
		public static Vector3f right = new Vector3f(1f, 0f, 0f);
		public static Vector3f left = new Vector3f(-1f, 0f, 0f);
		public static Vector3f up = new Vector3f(0f, 1f, 0f);
		public static Vector3f down = new Vector3f(0f, -1f, 0f);
		public static Vector3f forward = new Vector3f(0f, 0f, 1f);
		public static Vector3f back = new Vector3f(0f, 0f, -1f);

		public Vector3f(Vector2f v) : this(v, 0f)
		{
		}

		public Vector3f(Vector2f v, float z)
		{
			this.x = v.x;
			this.y = v.y;
			this.z = z;
		}

		public float this[int i]
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

		public static implicit operator Vector4f(Vector3f vector)
		{
			return new Vector4f(vector);
		}

		public static implicit operator Vector2f(Vector3f vector)
		{
			return new Vector2f(vector.x, vector.y);
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

		public static Vector3i Ceil(Vector3f v)
		{
			return new Vector3i(Math.Ceil(v.x), Math.Ceil(v.y), Math.Ceil(v.z));
		}

		public static Vector3f Cross(Vector3f a, Vector3f b)
		{
			return new Vector3f(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
		}

		public static float Distance(Vector3f a, Vector3f b)
		{
			return (a - b).length;
		}

		public static float DistanceSqr(Vector3f a, Vector3f b)
		{
			return (a - b).lengthSqr;
		}

		public static float Dot(Vector3f a, Vector3f b)
		{
			return (a.x * b.x + a.y * b.y) + a.z * b.z;
		}

		public static Vector3i Floor(Vector3f v)
		{
			return new Vector3i(Math.Floor(v.x), Math.Floor(v.y), Math.Floor(v.z));
		}

		public static Vector3f Mix(Vector3f a, Vector3f b, float alpha)
		{
			return Lerp(a, b, alpha);
		}

		public static Vector3f Normalize(Vector3f v)
		{
			var length = v.length;

			if (length > Math.Epsilon)
			{
				return v / length;
			}

			return Vector3f.zero;
		}

		public static Vector3f Lerp(Vector3f a, Vector3f b, float alpha)
		{
			return a + (alpha * (b - a));
		}

		public static Vector3f LerpClamped(Vector3f a, Vector3f b, float alpha)
		{
			return a + (Math.Clamp01(alpha) * (b - a));
		}

		public static Vector3f Reflect(Vector3f incident, Vector3f normal)
		{
			return incident - 2 * Dot(normal, incident) * normal;
		}

		public static Vector3f Refract(Vector3f incident, Vector3f normal, float eta)
		{
			var dNI = Dot(normal, incident);
			var k = 1 - eta * eta * (1 - dNI * dNI);

			if (k < 0)
			{
				return Vector3f.zero;
			}

			return eta * incident - (eta * dNI + Math.Sqrt(k)) * normal;
		}

		// Project 3D vector in a plane formed by the provided normal.
		public static Vector3f ProjectOnPlane(Vector3f vector, Vector3f normal)
		{
			return vector - normal * Dot(vector, normal);
		}

		// Project 3D direction vector in a plane formed by the provided normal (will be normalized).
		public static Vector3f ProjectDirectionOnPlane(Vector3f direction, Vector3f normal)
		{
			return Normalize(ProjectOnPlane(direction, normal));
		}

		// Angle formed by two 3D vectors.
		public static float Angle(Vector3f a, Vector3f b)
		{
			if (Math.Sqrt(a.lengthSqr * b.lengthSqr) < Math.Epsilon)
			{
				return 0f;
			}

			return Math.Acos(Math.Clamp(Vector3f.Dot(Vector3f.Normalize(a), Vector3f.Normalize(b)), -1f, 1f));
		}

		// Angle formed by two 3D vectors along a provided axis.
		public static float SignedAngle(Vector3f from, Vector3f to, Vector3f axis)
		{
			var angle = Vector3f.Angle(from, to);
			var cross = Vector3f.Cross(from, to);
			var sign = Math.Sign(axis.x * cross.x + axis.y * cross.y + axis.z * cross.z);

			return angle * sign;
		}

		public static Vector3f MoveTowards(Vector3f from, Vector3f to, float maxDelta)
		{
			var a = (to - from);
			var length = a.length;

			if (length <= maxDelta || length == 0f)
			{
				return to;
			}

			return from + ((a / length) * maxDelta);
		}

		public static Vector3i Round(Vector3f v)
		{
			return new Vector3i(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z));
		}
	}
}
