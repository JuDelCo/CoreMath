
namespace Ju.Math
{
	public partial struct Vector4f
	{
		public static Vector4f zero = new Vector4f(0f, 0f, 0f, 1f);
		public static Vector4f one = new Vector4f(1f, 1f, 1f, 1f);
		public static Vector4f right = new Vector4f(1f, 0f, 0f, 1f);
		public static Vector4f left = new Vector4f(-1f, 0f, 0f, 1f);
		public static Vector4f up = new Vector4f(0f, 1f, 0f, 1f);
		public static Vector4f down = new Vector4f(0f, -1f, 0f, 1f);
		public static Vector4f forward = new Vector4f(0f, 0f, 1f, 1f);
		public static Vector4f back = new Vector4f(0f, 0f, -1f, 1f);

		public Vector4f(Vector3f v) : this(v, 1f)
		{
		}

		public Vector4f(Vector3f v, float w)
		{
			this.x = v.x;
			this.y = v.y;
			this.z = v.z;
			this.w = w;
		}

		public static implicit operator Vector3f(Vector4f vector)
		{
			return new Vector3f(vector.x, vector.y, vector.z);
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

		public static Vector4i Ceil(Vector4f v)
		{
			return new Vector4i(Math.Ceil(v.x), Math.Ceil(v.y), Math.Ceil(v.z), Math.Ceil(v.w));
		}

		public static float Distance(Vector4f a, Vector4f b)
		{
			return (a - b).length;
		}

		public static float DistanceSqr(Vector4f a, Vector4f b)
		{
			return (a - b).lengthSqr;
		}

		public static float Dot(Vector4f a, Vector4f b)
		{
			return (a.x * b.x + a.y * b.y) + (a.z * b.z + a.w * b.w);
		}

		public static Vector4i Floor(Vector4f v)
		{
			return new Vector4i(Math.Floor(v.x), Math.Floor(v.y), Math.Floor(v.z), Math.Floor(v.w));
		}

		public static Vector4f Mix(Vector4f a, Vector4f b, float alpha)
		{
			return Lerp(a, b, alpha);
		}

		public static Vector4f Normalize(Vector4f v)
		{
			var length = v.length;

			if (length > Math.Epsilon)
			{
				return v / length;
			}

			return Vector4f.zero;
		}

		public static Vector4f Lerp(Vector4f a, Vector4f b, float alpha, bool extrapolate = false)
		{
			alpha = extrapolate ? alpha : Math.Clamp01(alpha);
			return a * (1f - alpha) + b * alpha;
		}

		public static Vector4f Reflect(Vector4f incident, Vector4f normal)
		{
			return incident - 2 * Dot(normal, incident) * normal;
		}

		public static Vector4f Refract(Vector4f incident, Vector4f normal, float eta)
		{
			var dNI = Dot(normal, incident);
			var k = 1 - eta * eta * (1 - dNI * dNI);

			if (k < 0)
			{
				return Vector4f.zero;
			}

			return eta * incident - (eta * dNI + Math.Sqrt(k)) * normal;
		}

		public static Vector4i Round(Vector4f v)
		{
			return new Vector4i(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z), Math.Round(v.w));
		}
	}
}
