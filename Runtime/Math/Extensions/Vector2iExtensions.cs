// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public partial struct Vector2i
	{
		public static readonly Vector2i zero = new Vector2i(0, 0);
		public static readonly Vector2i one = new Vector2i(1, 1);
		public static readonly Vector2i right = new Vector2i(1, 0);
		public static readonly Vector2i left = new Vector2i(-1, 0);
		public static readonly Vector2i up = new Vector2i(0, 1);
		public static readonly Vector2i down = new Vector2i(0, -1);

		public int this[int i]
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

		public static implicit operator Vector2f(Vector2i vector)
		{
			return new Vector2f(vector.x, vector.y);
		}

		public static implicit operator Vector3f(Vector2i vector)
		{
			return new Vector3f(vector.x, vector.y, 0f);
		}

		public static implicit operator Vector3i(Vector2i vector)
		{
			return new Vector3i(vector.x, vector.y, 0);
		}

		public static implicit operator Vector4f(Vector2i vector)
		{
			return new Vector4f(vector.x, vector.y, 0f, 0f);
		}

		public static implicit operator Vector4i(Vector2i vector)
		{
			return new Vector4i(vector.x, vector.y, 0, 0);
		}

		public Vector2i WithX(int value)
		{
			return new Vector2i(value, y);
		}

		public Vector2i WithY(int value)
		{
			return new Vector2i(x, value);
		}

#pragma warning disable IDE1006

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

		public static float Cross(Vector2i a, Vector2i b)
		{
			return a.x * b.y - a.y * b.x;
		}

		public static float Distance(Vector2i a, Vector2i b)
		{
			return (a - b).length;
		}

		public static float DistanceSqr(Vector2i a, Vector2i b)
		{
			return (a - b).lengthSqr;
		}

		public static float Dot(Vector2i a, Vector2i b)
		{
			return (a.x * b.x + a.y * b.y);
		}

		public static Vector2f Mix(Vector2i a, Vector2i b, float alpha)
		{
			return Lerp(a, b, alpha);
		}

		public static Vector2f Normalize(Vector2i v)
		{
			var length = v.length;

			if (length > Math.Epsilon)
			{
				return v / length;
			}

			return Vector2f.zero;
		}

		public static Vector2f Lerp(Vector2i a, Vector2i b, float alpha)
		{
			return a + (alpha * (b - a));
		}

		public static Vector2f LerpClamped(Vector2i a, Vector2i b, float alpha)
		{
			return a + (Math.Clamp01(alpha) * (b - a));
		}

		public static Vector2f Reflect(Vector2i incident, Vector2i normal)
		{
			return incident - 2 * Dot(normal, incident) * normal;
		}

		public static Vector2f Refract(Vector2i incident, Vector2i normal, float eta)
		{
			var dNI = Dot(normal, incident);
			var k = 1 - eta * eta * (1 - dNI * dNI);

			if (k < 0)
			{
				return Vector2f.zero;
			}

			return eta * incident - (eta * dNI + Math.Sqrt(k)) * normal;
		}

		// Rotate 2D vector by the provided radians.
		public static Vector2f Rotate(Vector2i v, float radians)
		{
			return Vector2f.AngleToVector(v.angle + radians) * v.length;
		}

		// Angle formed by two 2D vectors.
		public static float Angle(Vector2i a, Vector2i b)
		{
			return Math.Acos(Math.Clamp(Vector2f.Dot(Normalize(a), Normalize(b)), -1f, 1f));
		}

		// Perpendicular 2D normal to a line formed by two 2D points.
		public static Vector2f PerpendicularToLine(Vector2i a, Vector2i b)
		{
			return new Vector2f(-1f * (b.y - a.y), b.x - a.x);
		}

		public static Vector2i PerpendicularCW(Vector2i v)
		{
			return new Vector2i(v.y, -v.x);
		}

		public static Vector2i PerpendicularCCW(Vector2i v)
		{
			return new Vector2i(-v.y, v.x);
		}

		// 2D point contained in a circle of the provided radius at the provided radians.
		public static Vector2f PointOnCircle(Vector2i center, float radius, float radians)
		{
			return new Vector2f(
				Math.Cos(radians) * radius + center.x,
				Math.Sin(radians) * radius + center.x
			);
		}
	}
}
