
namespace Ju.Math
{
	public partial struct Vector3f
	{
		public float x;
		public float y;
		public float z;

		public Vector3f(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static Vector3f operator +(Vector3f a, Vector3f b)
		{
			return new Vector3f(a.x + b.x, a.y + b.y, a.z + b.z);
		}

		public static Vector3f operator +(Vector3f a, Vector3i b)
		{
			return new Vector3f(a.x + b.x, a.y + b.y, a.z + b.z);
		}

		public static Vector3f operator +(Vector3i a, Vector3f b)
		{
			return new Vector3f(a.x + b.x, a.y + b.y, a.z + b.z);
		}

		public static Vector3f operator +(Vector3f a, int v)
		{
			return new Vector3f(a.x + v, a.y + v, a.z + v);
		}

		public static Vector3f operator +(int v, Vector3f a)
		{
			return new Vector3f(a.x + v, a.y + v, a.z + v);
		}

		public static Vector3f operator +(Vector3f a, float v)
		{
			return new Vector3f(a.x + v, a.y + v, a.z + v);
		}

		public static Vector3f operator +(float v, Vector3f a)
		{
			return new Vector3f(a.x + v, a.y + v, a.z + v);
		}

		public static Vector3f operator -(Vector3f a, Vector3f b)
		{
			return new Vector3f(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		public static Vector3f operator -(Vector3f a, Vector3i b)
		{
			return new Vector3f(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		public static Vector3f operator -(Vector3i a, Vector3f b)
		{
			return new Vector3f(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		public static Vector3f operator -(Vector3f a, int v)
		{
			return new Vector3f(a.x - v, a.y - v, a.z - v);
		}

		public static Vector3f operator -(int v, Vector3f a)
		{
			return new Vector3f(v - a.x, v - a.y, v - a.z);
		}

		public static Vector3f operator -(Vector3f a, float v)
		{
			return new Vector3f(a.x - v, a.y - v, a.z - v);
		}

		public static Vector3f operator -(float v, Vector3f a)
		{
			return new Vector3f(v - a.x, v - a.y, v - a.z);
		}

		public static Vector3f operator -(Vector3f v)
		{
			return new Vector3f(-v.x, -v.y, -v.z);
		}

		public static Vector3f operator *(Vector3f a, Vector3f b)
		{
			return new Vector3f(a.x * b.x, a.y * b.y, a.z * b.z);
		}

		public static Vector3f operator *(Vector3f a, Vector3i b)
		{
			return new Vector3f(a.x * b.x, a.y * b.y, a.z * b.z);
		}

		public static Vector3f operator *(Vector3i a, Vector3f b)
		{
			return new Vector3f(a.x * b.x, a.y * b.y, a.z * b.z);
		}

		public static Vector3f operator *(Vector3f a, int v)
		{
			return new Vector3f(a.x * v, a.y * v, a.z * v);
		}

		public static Vector3f operator *(int v, Vector3f a)
		{
			return new Vector3f(a.x * v, a.y * v, a.z * v);
		}

		public static Vector3f operator *(Vector3f a, float v)
		{
			return new Vector3f(a.x * v, a.y * v, a.z * v);
		}

		public static Vector3f operator *(float v, Vector3f a)
		{
			return new Vector3f(a.x * v, a.y * v, a.z * v);
		}

		public static Vector3f operator /(Vector3f a, Vector3f b)
		{
			return new Vector3f(a.x / b.x, a.y / b.y, a.z / b.z);
		}

		public static Vector3f operator /(Vector3f a, Vector3i b)
		{
			return new Vector3f(a.x / b.x, a.y / b.y, a.z / b.z);
		}

		public static Vector3f operator /(Vector3i a, Vector3f b)
		{
			return new Vector3f(a.x / b.x, a.y / b.y, a.z / b.z);
		}

		public static Vector3f operator /(Vector3f a, int v)
		{
			return new Vector3f(a.x / v, a.y / v, a.z / v);
		}

		public static Vector3f operator /(int v, Vector3f a)
		{
			return new Vector3f(v / a.x, v / a.y, v / a.z);
		}

		public static Vector3f operator /(Vector3f a, float v)
		{
			return new Vector3f(a.x / v, a.y / v, a.z / v);
		}

		public static Vector3f operator /(float v, Vector3f a)
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
			return (obj is Vector3f vector && (this == vector));
		}

		public static bool operator ==(Vector3f a, Vector3f b)
		{
			return (a.x == b.x && a.y == b.y && a.z == b.z);
		}

		public static bool operator !=(Vector3f a, Vector3f b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return $"[ {x} , {y} , {z} ]";
		}
	}
}
