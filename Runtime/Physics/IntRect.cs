// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

using System;

namespace Ju.Math
{
	[Serializable]
	public partial struct IntRect : IEquatable<IntRect>
	{
		public int x;
		public int y;
		public int width;
		public int height;

		public IntRect(int x, int y, int width, int height)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
		}

		public IntRect(Vector2i position, Vector2i size)
		{
			x = position.x;
			y = position.y;
			width = size.x;
			height = size.y;
		}

#pragma warning disable IDE1006

		public Vector2i position
		{
			get { return new Vector2i(x, y); }
			set
			{
				x = value.x;
				y = value.y;
			}
		}

		public Vector2i size
		{
			get { return new Vector2i(width, height); }
			set
			{
				width = value.x;
				height = value.y;
			}
		}

		public int xMin
		{
			get { return x; }
		}

		public int xMax
		{
			get { return (xMin + width); }
		}

		public int yMin
		{
			get { return y; }
		}

		public int yMax
		{
			get { return (yMin + height); }
		}

		public int left
		{
			get { return xMin; }
		}

		public int right
		{
			get { return xMax; }
		}

		public int top
		{
			get { return yMin; }
		}

		public int bottom
		{
			get { return yMax; }
		}

		public int halfWidth
		{
			get { return (width << 1); }
		}

		public int halfHeight
		{
			get { return (height << 1); }
		}

		public Vector2i center
		{
			get { return new Vector2i(x + halfWidth, y + halfHeight); }
		}

#pragma warning restore IDE1006

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;
				hash = hash * 23 + x.GetHashCode();
				hash = hash * 23 + y.GetHashCode();
				hash = hash * 23 + width.GetHashCode();
				hash = hash * 23 + height.GetHashCode();
				return hash;
			}
		}

		public bool Equals(IntRect other)
		{
			return (this == other);
		}

		public override bool Equals(object obj)
		{
			return (obj is IntRect rect && (this == rect));
		}

		public static bool operator ==(IntRect a, IntRect b)
		{
			return (a.x == b.x && a.y == b.y && a.width == b.width && a.height == b.height);
		}

		public static bool operator !=(IntRect a, IntRect b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return $"[ {x} , {y} , {width} , {height} ]";
		}
	}
}
