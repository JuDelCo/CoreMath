// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

using System;

namespace Ju.Math
{
	public partial struct Vector2i : IEquatable<Vector2i>
	{
		public int x;
		public int y;

		public Vector2i(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public static Vector2i operator +(Vector2i a, Vector2i b)
		{
			return new Vector2i(a.x + b.x, a.y + b.y);
		}

		public static Vector2i operator +(Vector2i a, int v)
		{
			return new Vector2i(a.x + v, a.y + v);
		}

		public static Vector2i operator +(int v, Vector2i a)
		{
			return new Vector2i(a.x + v, a.y + v);
		}

		public static Vector2f operator +(Vector2i a, float v)
		{
			return new Vector2f(a.x + v, a.y + v);
		}

		public static Vector2f operator +(float v, Vector2i a)
		{
			return new Vector2f(a.x + v, a.y + v);
		}

		public static Vector2i operator -(Vector2i a, Vector2i b)
		{
			return new Vector2i(a.x - b.x, a.y - b.y);
		}

		public static Vector2i operator -(Vector2i a, int v)
		{
			return new Vector2i(a.x - v, a.y - v);
		}

		public static Vector2i operator -(int v, Vector2i a)
		{
			return new Vector2i(v - a.x, v - a.y);
		}

		public static Vector2f operator -(Vector2i a, float v)
		{
			return new Vector2f(a.x - v, a.y - v);
		}

		public static Vector2f operator -(float v, Vector2i a)
		{
			return new Vector2f(v - a.x, v - a.y);
		}

		public static Vector2i operator -(Vector2i v)
		{
			return new Vector2i(-v.x, -v.y);
		}

		public static Vector2i operator *(Vector2i a, Vector2i b)
		{
			return new Vector2i(a.x * b.x, a.y * b.y);
		}

		public static Vector2i operator *(Vector2i a, int v)
		{
			return new Vector2i(a.x * v, a.y * v);
		}

		public static Vector2i operator *(int v, Vector2i a)
		{
			return new Vector2i(a.x * v, a.y * v);
		}

		public static Vector2f operator *(Vector2i a, float v)
		{
			return new Vector2f(a.x * v, a.y * v);
		}

		public static Vector2f operator *(float v, Vector2i a)
		{
			return new Vector2f(a.x * v, a.y * v);
		}

		public static Vector2i operator /(Vector2i a, Vector2i b)
		{
			return new Vector2i(a.x / b.x, a.y / b.y);
		}

		public static Vector2i operator /(Vector2i a, int v)
		{
			return new Vector2i(a.x / v, a.y / v);
		}

		public static Vector2i operator /(int v, Vector2i a)
		{
			return new Vector2i(v / a.x, v / a.y);
		}

		public static Vector2f operator /(Vector2i a, float v)
		{
			return new Vector2f(a.x / v, a.y / v);
		}

		public static Vector2f operator /(float v, Vector2i a)
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

		public bool Equals(Vector2i other)
		{
			return (this == other);
		}

		public override bool Equals(object obj)
		{
			return (obj is Vector2i vector && (this == vector));
		}

		public static bool operator ==(Vector2i a, Vector2i b)
		{
			return (a.x == b.x && a.y == b.y);
		}

		public static bool operator !=(Vector2i a, Vector2i b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return $"[ {x} , {y} ]";
		}
	}
}
