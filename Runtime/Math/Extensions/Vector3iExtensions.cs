
namespace Ju.Math
{
	public partial struct Vector3i
	{
		public static Vector3i zero = new Vector3i(0, 0, 0);
		public static Vector3i one = new Vector3i(1, 1, 1);
		public static Vector3i right = new Vector3i(1, 0, 0);
		public static Vector3i left = new Vector3i(-1, 0, 0);
		public static Vector3i up = new Vector3i(0, 1, 0);
		public static Vector3i down = new Vector3i(0, -1, 0);
		public static Vector3i forward = new Vector3i(0, 0, 1);
		public static Vector3i back = new Vector3i(0, 0, -1);

		public Vector3i(Vector2i v) : this(v, 0)
		{
		}

		public Vector3i(Vector2i v, int z)
		{
			this.x = v.x;
			this.y = v.y;
			this.z = z;
		}

		public static implicit operator Vector4i(Vector3i vector)
		{
			return new Vector4i(vector);
		}

		public static implicit operator Vector2i(Vector3i vector)
		{
			return new Vector2i(vector.x, vector.y);
		}

		public static implicit operator Vector3f(Vector3i vector)
		{
			return new Vector3f(vector.x, vector.y, vector.z);
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
			if (alpha > 1f)
			{
				alpha = 1f;
			}

			return a * (1f - alpha) + b * alpha;
		}

		public static Vector3f Normalize(Vector3i v)
		{
			return v / v.length;
		}

		public static Vector3f Lerp(Vector3i a, Vector3i b, float alpha, bool extrapolate = false)
		{
			alpha = extrapolate ? alpha : Math.Clamp01(alpha);
			return a * (1f - alpha) + b * alpha;
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
