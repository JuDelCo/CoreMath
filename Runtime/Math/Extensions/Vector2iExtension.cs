
namespace Ju.Math
{
	public partial struct Vector2i
	{
		public static Vector2i zero  = new Vector2i( 0,  0);
		public static Vector2i one   = new Vector2i( 1,  1);
		public static Vector2i right = new Vector2i( 1,  0);
		public static Vector2i left  = new Vector2i(-1,  0);
		public static Vector2i up    = new Vector2i( 0,  1);
		public static Vector2i down  = new Vector2i( 0, -1);

		public static implicit operator Vector3i(Vector2i vector)
		{
			return new Vector3i(vector);
		}

		public static implicit operator Vector2f(Vector2i vector)
		{
			return new Vector2f(vector.x, vector.y);
		}

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
			if (alpha > 1f)
			{
				alpha = 1f;
			}

			return a * (1f - alpha) + b * alpha;
		}

		public static Vector2f Normalize(Vector2i v)
		{
			return v / v.length;
		}

		public static Vector2f Lerp(Vector2i a, Vector2i b, float alpha, bool extrapolate = false)
		{
			alpha = extrapolate ? alpha : Math.Clamp01(alpha);
			return a * (1f - alpha) + b * alpha;
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

		public static Vector2f Rotate(Vector2i v, float radians)
		{
			return Vector2f.AngleToVector(v.angle + radians) * v.length;
		}

		public static float Angle(Vector2i a, Vector2i b)
		{
			return Math.Acos(Math.Clamp(Vector2f.Dot(Normalize(a), Normalize(b)), -1f, 1f));
		}

		public static Vector2f Perpendicular(Vector2i a, Vector2i b)
		{
			return new Vector2f(-1f * (b.y - a.y), b.x - a.x);
		}

		public static Vector2i Perpendicular(Vector2i v)
		{
			return new Vector2i(-v.y, v.x);
		}

		public static Vector2f PointOnCircle(Vector2i center, float radius, float radians)
		{
			return new Vector2f(
				Math.Cos(radians) * radius + center.x,
				Math.Sin(radians) * radius + center.x
			);
		}
	}
}
