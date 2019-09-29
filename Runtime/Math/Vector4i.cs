
namespace Ju.Math
{
	public partial struct Vector4i
	{
		public int x;
		public int y;
		public int z;
		public int w;

		public Vector4i(int x, int y, int z, int w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public static Vector4i operator +(Vector4i a, Vector4i b)
		{
			return new Vector4i(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		}

		public static Vector4i operator +(Vector4i a, int v)
		{
			return new Vector4i(a.x + v, a.y + v, a.z + v, a.w + v);
		}

		public static Vector4i operator +(int v, Vector4i a)
		{
			return new Vector4i(a.x + v, a.y + v, a.z + v, a.w + v);
		}

		public static Vector4f operator +(Vector4i a, float v)
		{
			return new Vector4f(a.x + v, a.y + v, a.z + v, a.w + v);
		}

		public static Vector4f operator +(float v, Vector4i a)
		{
			return new Vector4f(a.x + v, a.y + v, a.z + v, a.w + v);
		}

		public static Vector4i operator -(Vector4i a, Vector4i b)
		{
			return new Vector4i(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		}

		public static Vector4i operator -(Vector4i a, int v)
		{
			return new Vector4i(a.x - v, a.y - v, a.z - v, a.w - v);
		}

		public static Vector4i operator -(int v, Vector4i a)
		{
			return new Vector4i(v - a.x, v - a.y, v - a.z, v - a.w);
		}

		public static Vector4f operator -(Vector4i a, float v)
		{
			return new Vector4f(a.x - v, a.y - v, a.z - v, a.w - v);
		}

		public static Vector4f operator -(float v, Vector4i a)
		{
			return new Vector4f(v - a.x, v - a.y, v - a.z, v - a.w);
		}

		public static Vector4i operator -(Vector4i v)
		{
			return new Vector4i(-v.x, -v.y, -v.z, -v.w);
		}

		public static Vector4i operator *(Vector4i a, Vector4i b)
		{
			return new Vector4i(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
		}

		public static Vector4i operator *(Vector4i a, int v)
		{
			return new Vector4i(a.x * v, a.y * v, a.z * v, a.w * v);
		}

		public static Vector4i operator *(int v, Vector4i a)
		{
			return new Vector4i(a.x * v, a.y * v, a.z * v, a.w * v);
		}

		public static Vector4f operator *(Vector4i a, float v)
		{
			return new Vector4f(a.x * v, a.y * v, a.z * v, a.w * v);
		}

		public static Vector4f operator *(float v, Vector4i a)
		{
			return new Vector4f(a.x * v, a.y * v, a.z * v, a.w * v);
		}

		public static Vector4i operator /(Vector4i a, Vector4i b)
		{
			return new Vector4i(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
		}

		public static Vector4i operator /(Vector4i a, int v)
		{
			return new Vector4i(a.x / v, a.y / v, a.z / v, a.w / v);
		}

		public static Vector4i operator /(int v, Vector4i a)
		{
			return new Vector4i(v / a.x, v / a.y, v / a.z, v / a.w);
		}

		public static Vector4f operator /(Vector4i a, float v)
		{
			return new Vector4f(a.x / v, a.y / v, a.z / v, a.w / v);
		}

		public static Vector4f operator /(float v, Vector4i a)
		{
			return new Vector4f(v / a.x, v / a.y, v / a.z, v / a.w);
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
			return (obj is Vector4i && (this == (Vector4i)obj));
		}

		public static bool operator ==(Vector4i a, Vector4i b)
		{
			return (a.x == b.x && a.y == b.y && a.z == b.z && a.w == b.w);
		}

		public static bool operator !=(Vector4i a, Vector4i b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return "[ " + x + " , " + y + " , " + z + " , " + w + " ]";
		}
	}
}
