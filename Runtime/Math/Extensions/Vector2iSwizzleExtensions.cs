// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public static class Vector2iSwizzleExtensions
	{
#pragma warning disable IDE1006

		public static Vector2i xx(this Vector2i v)
		{
			return new Vector2i(v.x, v.x);
		}

		public static Vector2i yx(this Vector2i v)
		{
			return new Vector2i(v.y, v.x);
		}

		public static Vector2i xy(this Vector2i v)
		{
			return new Vector2i(v.x, v.y);
		}

		public static Vector2i yy(this Vector2i v)
		{
			return new Vector2i(v.y, v.y);
		}

		public static Vector3i xxx(this Vector2i v)
		{
			return new Vector3i(v.x, v.x, v.x);
		}

		public static Vector3i yxx(this Vector2i v)
		{
			return new Vector3i(v.y, v.x, v.x);
		}

		public static Vector3i xyx(this Vector2i v)
		{
			return new Vector3i(v.x, v.y, v.x);
		}

		public static Vector3i yyx(this Vector2i v)
		{
			return new Vector3i(v.y, v.y, v.x);
		}

		public static Vector3i xxy(this Vector2i v)
		{
			return new Vector3i(v.x, v.x, v.y);
		}

		public static Vector3i yxy(this Vector2i v)
		{
			return new Vector3i(v.y, v.x, v.y);
		}

		public static Vector3i xyy(this Vector2i v)
		{
			return new Vector3i(v.x, v.y, v.y);
		}

		public static Vector3i yyy(this Vector2i v)
		{
			return new Vector3i(v.y, v.y, v.y);
		}

		public static Vector4i xxxx(this Vector2i v)
		{
			return new Vector4i(v.x, v.x, v.x, v.x);
		}

		public static Vector4i yxxx(this Vector2i v)
		{
			return new Vector4i(v.y, v.x, v.x, v.x);
		}

		public static Vector4i xyxx(this Vector2i v)
		{
			return new Vector4i(v.x, v.y, v.x, v.x);
		}

		public static Vector4i yyxx(this Vector2i v)
		{
			return new Vector4i(v.y, v.y, v.x, v.x);
		}

		public static Vector4i xxyx(this Vector2i v)
		{
			return new Vector4i(v.x, v.x, v.y, v.x);
		}

		public static Vector4i yxyx(this Vector2i v)
		{
			return new Vector4i(v.y, v.x, v.y, v.x);
		}

		public static Vector4i xyyx(this Vector2i v)
		{
			return new Vector4i(v.x, v.y, v.y, v.x);
		}

		public static Vector4i yyyx(this Vector2i v)
		{
			return new Vector4i(v.y, v.y, v.y, v.x);
		}

		public static Vector4i xxxy(this Vector2i v)
		{
			return new Vector4i(v.x, v.x, v.x, v.y);
		}

		public static Vector4i yxxy(this Vector2i v)
		{
			return new Vector4i(v.y, v.x, v.x, v.y);
		}

		public static Vector4i xyxy(this Vector2i v)
		{
			return new Vector4i(v.x, v.y, v.x, v.y);
		}

		public static Vector4i yyxy(this Vector2i v)
		{
			return new Vector4i(v.y, v.y, v.x, v.y);
		}

		public static Vector4i xxyy(this Vector2i v)
		{
			return new Vector4i(v.x, v.x, v.y, v.y);
		}

		public static Vector4i yxyy(this Vector2i v)
		{
			return new Vector4i(v.y, v.x, v.y, v.y);
		}

		public static Vector4i xyyy(this Vector2i v)
		{
			return new Vector4i(v.x, v.y, v.y, v.y);
		}

		public static Vector4i yyyy(this Vector2i v)
		{
			return new Vector4i(v.y, v.y, v.y, v.y);
		}

#pragma warning restore IDE1006
	}
}
