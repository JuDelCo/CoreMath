// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

using System;

namespace Ju.Math
{
	public partial struct Vector4f : IEquatable<Vector4f>
	{
		public float x;
		public float y;
		public float z;
		public float w;

		public Vector4f(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public static Vector4f operator +(Vector4f a, Vector4f b)
		{
			return new Vector4f(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		}

		public static Vector4f operator +(Vector4f a, Vector4i b)
		{
			return new Vector4f(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		}

		public static Vector4f operator +(Vector4i a, Vector4f b)
		{
			return new Vector4f(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		}

		public static Vector4f operator +(Vector4f a, int v)
		{
			return new Vector4f(a.x + v, a.y + v, a.z + v, a.w + v);
		}

		public static Vector4f operator +(int v, Vector4f a)
		{
			return new Vector4f(a.x + v, a.y + v, a.z + v, a.w + v);
		}

		public static Vector4f operator +(Vector4f a, float v)
		{
			return new Vector4f(a.x + v, a.y + v, a.z + v, a.w + v);
		}

		public static Vector4f operator +(float v, Vector4f a)
		{
			return new Vector4f(a.x + v, a.y + v, a.z + v, a.w + v);
		}

		public static Vector4f operator -(Vector4f a, Vector4f b)
		{
			return new Vector4f(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		}

		public static Vector4f operator -(Vector4f a, Vector4i b)
		{
			return new Vector4f(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		}

		public static Vector4f operator -(Vector4i a, Vector4f b)
		{
			return new Vector4f(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		}

		public static Vector4f operator -(Vector4f a, int v)
		{
			return new Vector4f(a.x - v, a.y - v, a.z - v, a.w - v);
		}

		public static Vector4f operator -(int v, Vector4f a)
		{
			return new Vector4f(v - a.x, v - a.y, v - a.z, v - a.w);
		}

		public static Vector4f operator -(Vector4f a, float v)
		{
			return new Vector4f(a.x - v, a.y - v, a.z - v, a.w - v);
		}

		public static Vector4f operator -(float v, Vector4f a)
		{
			return new Vector4f(v - a.x, v - a.y, v - a.z, v - a.w);
		}

		public static Vector4f operator -(Vector4f v)
		{
			return new Vector4f(-v.x, -v.y, -v.z, -v.w);
		}

		public static Vector4f operator *(Vector4f a, Vector4f b)
		{
			return new Vector4f(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
		}

		public static Vector4f operator *(Vector4f a, Vector4i b)
		{
			return new Vector4f(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
		}

		public static Vector4f operator *(Vector4i a, Vector4f b)
		{
			return new Vector4f(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
		}

		public static Vector4f operator *(Vector4f a, int v)
		{
			return new Vector4f(a.x * v, a.y * v, a.z * v, a.w * v);
		}

		public static Vector4f operator *(int v, Vector4f a)
		{
			return new Vector4f(a.x * v, a.y * v, a.z * v, a.w * v);
		}

		public static Vector4f operator *(Vector4f a, float v)
		{
			return new Vector4f(a.x * v, a.y * v, a.z * v, a.w * v);
		}

		public static Vector4f operator *(float v, Vector4f a)
		{
			return new Vector4f(a.x * v, a.y * v, a.z * v, a.w * v);
		}

		public static Vector4f operator /(Vector4f a, Vector4f b)
		{
			return new Vector4f(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
		}

		public static Vector4f operator /(Vector4f a, Vector4i b)
		{
			return new Vector4f(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
		}

		public static Vector4f operator /(Vector4i a, Vector4f b)
		{
			return new Vector4f(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
		}

		public static Vector4f operator /(Vector4f a, int v)
		{
			return new Vector4f(a.x / v, a.y / v, a.z / v, a.w / v);
		}

		public static Vector4f operator /(int v, Vector4f a)
		{
			return new Vector4f(v / a.x, v / a.y, v / a.z, v / a.w);
		}

		public static Vector4f operator /(Vector4f a, float v)
		{
			return new Vector4f(a.x / v, a.y / v, a.z / v, a.w / v);
		}

		public static Vector4f operator /(float v, Vector4f a)
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

		public bool Equals(Vector4f other)
		{
			return (this == other);
		}

		public override bool Equals(object obj)
		{
			return (obj is Vector4f vector && (this == vector));
		}

		public static bool operator ==(Vector4f a, Vector4f b)
		{
			return (a.x == b.x && a.y == b.y && a.z == b.z && a.w == b.w);
		}

		public static bool operator !=(Vector4f a, Vector4f b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return $"[ {x} , {y} , {z} , {w} ]";
		}
	}
}
