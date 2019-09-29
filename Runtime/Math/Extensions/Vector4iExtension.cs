
namespace Ju.Math
{
	public partial struct Vector4i
	{
		public static Vector4i zero    = new Vector4i( 0,  0,  0,  1);
		public static Vector4i one     = new Vector4i( 1,  1,  1,  1);
		public static Vector4i right   = new Vector4i( 1,  0,  0,  1);
		public static Vector4i left    = new Vector4i(-1,  0,  0,  1);
		public static Vector4i up      = new Vector4i( 0,  1,  0,  1);
		public static Vector4i down    = new Vector4i( 0, -1,  0,  1);
		public static Vector4i forward = new Vector4i( 0,  0,  1,  1);
		public static Vector4i back    = new Vector4i( 0,  0, -1,  1);

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

		public static implicit operator Vector3i(Vector4i vector)
		{
			return new Vector3i(vector.x, vector.y, vector.z);
		}

		public static implicit operator Vector4f(Vector4i vector)
		{
			return new Vector4f(vector.x, vector.y, vector.z, vector.w);
		}

		public float length
		{
			get { return Math.Sqrt((x * x + y * y) + (z * z + w * w)); }
		}

		public float lengthSqr
		{
			get { return ((x * x + y * y) + (z * z + w * w)); }
		}

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
			if (alpha > 1f)
			{
				alpha = 1f;
			}

			return a * (1f - alpha) + b * alpha;
		}

		public static Vector4f Normalize(Vector4i v)
		{
			return v / v.length;
		}

		public static Vector4f Lerp(Vector4i a, Vector4i b, float alpha, bool extrapolate = false)
		{
			alpha = extrapolate ? alpha : Math.Clamp01(alpha);
			return a * (1f - alpha) + b * alpha;
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
