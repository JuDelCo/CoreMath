// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

using System;

namespace Ju.Math
{
	[Serializable]
	public partial struct Vector2f : IEquatable<Vector2f>
	{
		public float x;
		public float y;

		public Vector2f(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		public static Vector2f operator +(Vector2f a, Vector2f b)
		{
			return new Vector2f(a.x + b.x, a.y + b.y);
		}

		public static Vector2f operator +(Vector2f a, Vector2i b)
		{
			return new Vector2f(a.x + b.x, a.y + b.y);
		}

		public static Vector2f operator +(Vector2i a, Vector2f b)
		{
			return new Vector2f(a.x + b.x, a.y + b.y);
		}

		public static Vector2f operator +(Vector2f a, int v)
		{
			return new Vector2f(a.x + v, a.y + v);
		}

		public static Vector2f operator +(int v, Vector2f a)
		{
			return new Vector2f(a.x + v, a.y + v);
		}

		public static Vector2f operator +(Vector2f a, float v)
		{
			return new Vector2f(a.x + v, a.y + v);
		}

		public static Vector2f operator +(float v, Vector2f a)
		{
			return new Vector2f(a.x + v, a.y + v);
		}

		public static Vector2f operator -(Vector2f a, Vector2f b)
		{
			return new Vector2f(a.x - b.x, a.y - b.y);
		}

		public static Vector2f operator -(Vector2f a, Vector2i b)
		{
			return new Vector2f(a.x - b.x, a.y - b.y);
		}

		public static Vector2f operator -(Vector2i a, Vector2f b)
		{
			return new Vector2f(a.x - b.x, a.y - b.y);
		}

		public static Vector2f operator -(Vector2f a, int v)
		{
			return new Vector2f(a.x - v, a.y - v);
		}

		public static Vector2f operator -(int v, Vector2f a)
		{
			return new Vector2f(v - a.x, v - a.y);
		}

		public static Vector2f operator -(Vector2f a, float v)
		{
			return new Vector2f(a.x - v, a.y - v);
		}

		public static Vector2f operator -(float v, Vector2f a)
		{
			return new Vector2f(v - a.x, v - a.y);
		}

		public static Vector2f operator -(Vector2f v)
		{
			return new Vector2f(-v.x, -v.y);
		}

		public static Vector2f operator *(Vector2f a, Vector2f b)
		{
			return new Vector2f(a.x * b.x, a.y * b.y);
		}

		public static Vector2f operator *(Vector2f a, Vector2i b)
		{
			return new Vector2f(a.x * b.x, a.y * b.y);
		}

		public static Vector2f operator *(Vector2i a, Vector2f b)
		{
			return new Vector2f(a.x * b.x, a.y * b.y);
		}

		public static Vector2f operator *(Vector2f a, int v)
		{
			return new Vector2f(a.x * v, a.y * v);
		}

		public static Vector2f operator *(int v, Vector2f a)
		{
			return new Vector2f(a.x * v, a.y * v);
		}

		public static Vector2f operator *(Vector2f a, float v)
		{
			return new Vector2f(a.x * v, a.y * v);
		}

		public static Vector2f operator *(float v, Vector2f a)
		{
			return new Vector2f(a.x * v, a.y * v);
		}

		public static Vector2f operator /(Vector2f a, Vector2f b)
		{
			return new Vector2f(a.x / b.x, a.y / b.y);
		}

		public static Vector2f operator /(Vector2f a, Vector2i b)
		{
			return new Vector2f(a.x / b.x, a.y / b.y);
		}

		public static Vector2f operator /(Vector2i a, Vector2f b)
		{
			return new Vector2f(a.x / b.x, a.y / b.y);
		}

		public static Vector2f operator /(Vector2f a, int v)
		{
			return new Vector2f(a.x / v, a.y / v);
		}

		public static Vector2f operator /(int v, Vector2f a)
		{
			return new Vector2f(v / a.x, v / a.y);
		}

		public static Vector2f operator /(Vector2f a, float v)
		{
			return new Vector2f(a.x / v, a.y / v);
		}

		public static Vector2f operator /(float v, Vector2f a)
		{
			return new Vector2f(v / a.x, v / a.y);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;
				hash = hash * 23 + x.GetHashCode();
				hash = hash * 23 + y.GetHashCode();
				return hash;
			}
		}

		public bool Equals(Vector2f other)
		{
			return (this == other);
		}

		public override bool Equals(object obj)
		{
			return (obj is Vector2f vector && (this == vector));
		}

		public static bool operator ==(Vector2f a, Vector2f b)
		{
			return (a.x == b.x && a.y == b.y);
		}

		public static bool operator !=(Vector2f a, Vector2f b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return $"[ {x} , {y} ]";
		}
	}
}
