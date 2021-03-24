// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public partial struct Vector2f
	{
		public static Vector2f zero = new Vector2f(0f, 0f);
		public static Vector2f one = new Vector2f(1f, 1f);
		public static Vector2f right = new Vector2f(1f, 0f);
		public static Vector2f left = new Vector2f(-1f, 0f);
		public static Vector2f up = new Vector2f(0f, 1f);
		public static Vector2f down = new Vector2f(0f, -1f);

		public float this[int i]
		{
			get
			{
				i %= 2;

				return i == 0 ? x : y;
			}
			set
			{
				i %= 2;

				if (i == 0)
				{
					x = value;
				}
				else
				{
					y = value;
				}
			}
		}

		public static explicit operator Vector2i(Vector2f vector)
		{
			return new Vector2i(Math.Round(vector.x), Math.Round(vector.y));
		}

		public static implicit operator Vector3f(Vector2f vector)
		{
			return new Vector3f(vector.x, vector.y, 0f);
		}

		public static explicit operator Vector3i(Vector2f vector)
		{
			return new Vector3i(Math.Round(vector.x), Math.Round(vector.y), 0);
		}

		public static implicit operator Vector4f(Vector2f vector)
		{
			return new Vector4f(vector.x, vector.y, 0f, 0f);
		}

		public static explicit operator Vector4i(Vector2f vector)
		{
			return new Vector4i(Math.Round(vector.x), Math.Round(vector.y), 0, 0);
		}

#pragma warning disable IDE1006

		// Angle in radians
		public float angle
		{
			get { return Math.Atan2(y, x); }
		}

		public float length
		{
			get { return Math.Sqrt(x * x + y * y); }
		}

		public float lengthSqr
		{
			get { return (x * x + y * y); }
		}

		public Vector2f normalized
		{
			get { return Normalize(this); }
		}

#pragma warning restore IDE1006

		public static Vector2i Ceil(Vector2f v)
		{
			return new Vector2i(Math.Ceil(v.x), Math.Ceil(v.y));
		}

		public static float Cross(Vector2f a, Vector2f b)
		{
			return a.x * b.y - a.y * b.x;
		}

		public static float Distance(Vector2f a, Vector2f b)
		{
			return (a - b).length;
		}

		public static float DistanceSqr(Vector2f a, Vector2f b)
		{
			return (a - b).lengthSqr;
		}

		public static float Dot(Vector2f a, Vector2f b)
		{
			return (a.x * b.x + a.y * b.y);
		}

		public static Vector2i Floor(Vector2f v)
		{
			return new Vector2i(Math.Floor(v.x), Math.Floor(v.y));
		}

		public static Vector2f Mix(Vector2f a, Vector2f b, float alpha)
		{
			return Lerp(a, b, alpha);
		}

		public static Vector2f Normalize(Vector2f v)
		{
			var length = v.length;

			if (length > Math.Epsilon)
			{
				return v / length;
			}

			return Vector2f.zero;
		}

		public static Vector2f Lerp(Vector2f a, Vector2f b, float alpha)
		{
			return a + (alpha * (b - a));
		}

		public static Vector2f LerpClamped(Vector2f a, Vector2f b, float alpha)
		{
			return a + (Math.Clamp01(alpha) * (b - a));
		}

		public static Vector2f Reflect(Vector2f incident, Vector2f normal)
		{
			return incident - 2 * Dot(normal, incident) * normal;
		}

		public static Vector2f Refract(Vector2f incident, Vector2f normal, float eta)
		{
			var dNI = Dot(normal, incident);
			var k = 1 - eta * eta * (1 - dNI * dNI);

			if (k < 0)
			{
				return Vector2f.zero;
			}

			return eta * incident - (eta * dNI + Math.Sqrt(k)) * normal;
		}

		public static Vector2i Round(Vector2f v)
		{
			return new Vector2i(Math.Round(v.x), Math.Round(v.y));
		}

		// Rotate 2D vector by the provided radians.
		public static Vector2f Rotate(Vector2f v, float radians)
		{
			return Vector2f.AngleToVector(v.angle + radians) * v.length;
		}

		// Normalized angle 2D vector contained in a circle using the provided radians.
		public static Vector2f AngleToVector(float radians)
		{
			return new Vector2f(Math.Cos(radians), Math.Sin(radians));
		}

		// Angle formed by two 2D vectors.
		public static float Angle(Vector2f a, Vector2f b)
		{
			return Math.Acos(Math.Clamp(Vector2f.Dot(Normalize(a), Normalize(b)), -1f, 1f));
		}

		// Perpendicular 2D normal to a line formed by two 2D points.
		public static Vector2f PerpendicularToLine(Vector2f a, Vector2f b)
		{
			return new Vector2f(-1f * (b.y - a.y), b.x - a.x);
		}

		public static Vector2f PerpendicularCW(Vector2f v)
		{
			return new Vector2f(v.y, -v.x);
		}

		public static Vector2f PerpendicularCCW(Vector2f v)
		{
			return new Vector2f(-v.y, v.x);
		}

		// 2D point contained in a circle of the provided radius at the provided radians.
		public static Vector2f PointOnCircle(Vector2f center, float radius, float radians)
		{
			return new Vector2f(
				Math.Cos(radians) * radius + center.x,
				Math.Sin(radians) * radius + center.x
			);
		}
	}
}
