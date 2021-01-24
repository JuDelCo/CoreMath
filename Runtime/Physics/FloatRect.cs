// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public partial struct FloatRect
	{
		public float x;
		public float y;
		public float width;
		public float height;

		public FloatRect(float x, float y, float width, float height)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
		}

		public FloatRect(Vector2f position, Vector2f size)
		{
			x = position.x;
			y = position.y;
			width = size.x;
			height = size.y;
		}

#pragma warning disable IDE1006

		public Vector2f position
		{
			get { return new Vector2f(x, y); }
			set
			{
				x = value.x;
				y = value.y;
			}
		}

		public Vector2f size
		{
			get { return new Vector2f(width, height); }
			set
			{
				width = value.x;
				height = value.y;
			}
		}

		public float xMin
		{
			get { return x; }
		}

		public float xMax
		{
			get { return (xMin + width); }
		}

		public float yMin
		{
			get { return y; }
		}

		public float yMax
		{
			get { return (yMin + height); }
		}

		public float left
		{
			get { return xMin; }
		}

		public float right
		{
			get { return xMax; }
		}

		public float top
		{
			get { return yMin; }
		}

		public float bottom
		{
			get { return yMax; }
		}

		public float halfWidth
		{
			get { return (width / 2f); }
		}

		public float halfHeight
		{
			get { return (height / 2f); }
		}

		public Vector2f center
		{
			get { return new Vector2f(x + halfWidth, y + halfHeight); }
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

		public override bool Equals(object obj)
		{
			return (obj is FloatRect rect && (this == rect));
		}

		public static bool operator ==(FloatRect a, FloatRect b)
		{
			return (a.x == b.x && a.y == b.y && a.width == b.width && a.height == b.height);
		}

		public static bool operator !=(FloatRect a, FloatRect b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return $"[ {x} , {y} , {width} , {height} ]";
		}
	}
}
