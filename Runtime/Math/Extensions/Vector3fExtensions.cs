
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
			if (alpha > 1f)
			{
				alpha = 1f;
			}

			return a * (1f - alpha) + b * alpha;
		}

		public static Vector3f Normalize(Vector3f v)
		{
			return v / v.length;
		}

		public static Vector3f Lerp(Vector3f a, Vector3f b, float alpha, bool extrapolate = false)
		{
			alpha = extrapolate ? alpha : Math.Clamp01(alpha);
			return a * (1f - alpha) + b * alpha;
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

		public static float Angle(Vector3f a, Vector3f b)
		{
			if (Math.Sqrt(a.lengthSqr * b.lengthSqr) < Math.Epsilon)
			{
				return 0f;
			}

			return Math.Acos(Math.Clamp(Vector3f.Dot(Vector3f.Normalize(a), Vector3f.Normalize(b)), -1f, 1f));
		}

		public static float SignedAngle(Vector3f from, Vector3f to, Vector3f axis)
		{
			var angle = Vector3f.Angle(from, to);
			var cross = Vector3f.Cross(from, to);
			var sign = Math.Sign(axis.x * cross.x + axis.y * cross.y + axis.z * cross.z);

			return angle * sign;
		}

		public static Vector3i Round(Vector3f v)
		{
			return new Vector3i(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z));
		}
	}
}
