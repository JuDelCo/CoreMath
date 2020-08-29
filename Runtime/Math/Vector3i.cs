
namespace Ju.Math
{
	public partial struct Vector3i
	{
		public int x;
		public int y;
		public int z;

		public Vector3i(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static Vector3i operator +(Vector3i a, Vector3i b)
		{
			return new Vector3i(a.x + b.x, a.y + b.y, a.z + b.z);
		}

		public static Vector3i operator +(Vector3i a, int v)
		{
			return new Vector3i(a.x + v, a.y + v, a.z + v);
		}

		public static Vector3i operator +(int v, Vector3i a)
		{
			return new Vector3i(a.x + v, a.y + v, a.z + v);
		}

		public static Vector3f operator +(Vector3i a, float v)
		{
			return new Vector3f(a.x + v, a.y + v, a.z + v);
		}

		public static Vector3f operator +(float v, Vector3i a)
		{
			return new Vector3f(a.x + v, a.y + v, a.z + v);
		}

		public static Vector3i operator -(Vector3i a, Vector3i b)
		{
			return new Vector3i(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		public static Vector3i operator -(Vector3i a, int v)
		{
			return new Vector3i(a.x - v, a.y - v, a.z - v);
		}

		public static Vector3i operator -(int v, Vector3i a)
		{
			return new Vector3i(v - a.x, v - a.y, v - a.z);
		}

		public static Vector3f operator -(Vector3i a, float v)
		{
			return new Vector3f(a.x - v, a.y - v, a.z - v);
		}

		public static Vector3f operator -(float v, Vector3i a)
		{
			return new Vector3f(v - a.x, v - a.y, v - a.z);
		}

		public static Vector3i operator -(Vector3i v)
		{
			return new Vector3i(-v.x, -v.y, -v.z);
		}

		public static Vector3i operator *(Vector3i a, Vector3i b)
		{
			return new Vector3i(a.x * b.x, a.y * b.y, a.z * b.z);
		}

		public static Vector3i operator *(Vector3i a, int v)
		{
			return new Vector3i(a.x * v, a.y * v, a.z * v);
		}

		public static Vector3i operator *(int v, Vector3i a)
		{
			return new Vector3i(a.x * v, a.y * v, a.z * v);
		}

		public static Vector3f operator *(Vector3i a, float v)
		{
			return new Vector3f(a.x * v, a.y * v, a.z * v);
		}

		public static Vector3f operator *(float v, Vector3i a)
		{
			return new Vector3f(a.x * v, a.y * v, a.z * v);
		}

		public static Vector3i operator /(Vector3i a, Vector3i b)
		{
			return new Vector3i(a.x / b.x, a.y / b.y, a.z / b.z);
		}

		public static Vector3i operator /(Vector3i a, int v)
		{
			return new Vector3i(a.x / v, a.y / v, a.z / v);
		}

		public static Vector3i operator /(int v, Vector3i a)
		{
			return new Vector3i(v / a.x, v / a.y, v / a.z);
		}

		public static Vector3f operator /(Vector3i a, float v)
		{
			return new Vector3f(a.x / v, a.y / v, a.z / v);
		}

		public static Vector3f operator /(float v, Vector3i a)
		{
			return new Vector3f(v / a.x, v / a.y, v / a.z);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;
				hash = hash * 23 + x.GetHashCode();
				hash = hash * 23 + y.GetHashCode();
				hash = hash * 23 + z.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			return (obj is Vector3i vector && (this == vector));
		}

		public static bool operator ==(Vector3i a, Vector3i b)
		{
			return (a.x == b.x && a.y == b.y && a.z == b.z);
		}

		public static bool operator !=(Vector3i a, Vector3i b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return "[ " + x + " , " + y + " , " + z + " ]";
		}
	}
}
