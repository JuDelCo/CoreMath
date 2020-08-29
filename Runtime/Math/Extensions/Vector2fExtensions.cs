
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

		public static implicit operator Vector3f(Vector2f vector)
		{
			return new Vector3f(vector);
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
			if (alpha > 1f)
			{
				alpha = 1f;
			}

			return a * (1f - alpha) + b * alpha;
		}

		public static Vector2f Normalize(Vector2f v)
		{
			return v / v.length;
		}

		public static Vector2f Lerp(Vector2f a, Vector2f b, float alpha, bool extrapolate = false)
		{
			alpha = extrapolate ? alpha : Math.Clamp01(alpha);
			return a * (1f - alpha) + b * alpha;
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

		public static Vector2f Rotate(Vector2f v, float radians)
		{
			return Vector2f.AngleToVector(v.angle + radians) * v.length;
		}

		public static Vector2f AngleToVector(float radians)
		{
			return new Vector2f(Math.Cos(radians), Math.Sin(radians));
		}

		public static float Angle(Vector2f a, Vector2f b)
		{
			return Math.Acos(Math.Clamp(Vector2f.Dot(Normalize(a), Normalize(b)), -1f, 1f));
		}

		public static Vector2f Perpendicular(Vector2f a, Vector2f b)
		{
			return new Vector2f(-1f * (b.y - a.y), b.x - a.x);
		}

		public static Vector2f Perpendicular(Vector2f v)
		{
			return new Vector2f(-v.y, v.x);
		}

		public static Vector2f PointOnCircle(Vector2f center, float radius, float radians)
		{
			return new Vector2f(
				Math.Cos(radians) * radius + center.x,
				Math.Sin(radians) * radius + center.x
			);
		}
	}
}
