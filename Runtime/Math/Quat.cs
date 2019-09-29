
namespace Ju.Math
{
	public partial struct Quat
	{
		public float x;
		public float y;
		public float z;
		public float w;

		public Quat(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public static Quat operator +(Quat a, Quat b)
		{
			return new Quat(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		}

		public static Quat operator +(Quat q, float v)
		{
			return new Quat(q.x + v, q.y + v, q.z + v, q.w + v);
		}

		public static Quat operator +(float v, Quat q)
		{
			return new Quat(v + q.x, v + q.y, v + q.z, v + q.w);
		}

		public static Quat operator -(Quat a, Quat b)
		{
			return new Quat(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		}

		public static Quat operator -(Quat q, float v)
		{
			return new Quat(q.x - v, q.y - v, q.z - v, q.w - v);
		}

		public static Quat operator -(float v, Quat q)
		{
			return new Quat(v - q.x, v - q.y, v - q.z, v - q.w);
		}

		public static Quat operator -(Quat v)
		{
			return new Quat(-v.x, -v.y, -v.z, -v.w);
		}

		public static Quat operator *(Quat p, Quat q)
		{
			return new Quat(
				(p.w * q.x + p.x * q.w + p.y * q.z - p.z * q.y),
				(p.w * q.y + p.y * q.w + p.z * q.x - p.x * q.z),
				(p.w * q.z + p.z * q.w + p.x * q.y - p.y * q.x),
				(p.w * q.w - p.x * q.x - p.y * q.y - p.z * q.z)
			);
		}

		public static Vector4f operator *(Quat q, Vector4f v)
		{
			return new Vector4f((q * (Vector3f)v), v.w);
		}

		public static Vector3f operator *(Quat q, Vector3f v)
		{
			var qv = new Vector3f(q.x, q.y, q.z);
			var uv = Vector3f.Cross(qv, v);
			var uuv = Vector3f.Cross(qv, uv);
			return v + ((uv * q.w) + uuv) * 2f;
		}

		public static Vector3f operator *(Vector3f v, Quat q)
		{
			return Inverse(q) * v;
		}

		public static Vector4f operator *(Vector4f v, Quat q)
		{
			return Inverse(q) * v;
		}

		public static Quat operator *(Quat q, float v)
		{
			return new Quat(q.x * v, q.y * v, q.z * v, q.w * v);
		}

		public static Quat operator *(float v, Quat q)
		{
			return new Quat(v * q.x, v * q.y, v * q.z, v * q.w);
		}

		public static Quat operator /(Quat q, float v)
		{
			return new Quat(q.x / v, q.y / v, q.z / v, q.w / v);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;
				hash = hash * 23 + x.GetHashCode();
				hash = hash * 23 + y.GetHashCode();
				hash = hash * 23 + z.GetHashCode();
				hash = hash * 23 + w.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			return (obj is Quat && (this == (Quat)obj));
		}

		public static bool operator ==(Quat a, Quat b)
		{
			return (a.x == b.x && a.y == b.y && a.z == b.z && a.w == b.w);
		}

		public static bool operator !=(Quat a, Quat b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return "[ " + x + " , " + y + " , " + z + " , " + w + " ]";
		}
	}
}
