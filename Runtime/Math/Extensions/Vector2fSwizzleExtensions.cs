// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public static class Vector2fSwizzleExtensions
	{
#pragma warning disable IDE1006

		public static Vector2f xx(this Vector2f v)
		{
			return new Vector2f(v.x, v.x);
		}

		public static Vector2f yx(this Vector2f v)
		{
			return new Vector2f(v.y, v.x);
		}

		public static Vector2f xy(this Vector2f v)
		{
			return new Vector2f(v.x, v.y);
		}

		public static Vector2f yy(this Vector2f v)
		{
			return new Vector2f(v.y, v.y);
		}

		public static Vector3f xxx(this Vector2f v)
		{
			return new Vector3f(v.x, v.x, v.x);
		}

		public static Vector3f yxx(this Vector2f v)
		{
			return new Vector3f(v.y, v.x, v.x);
		}

		public static Vector3f xyx(this Vector2f v)
		{
			return new Vector3f(v.x, v.y, v.x);
		}

		public static Vector3f yyx(this Vector2f v)
		{
			return new Vector3f(v.y, v.y, v.x);
		}

		public static Vector3f xxy(this Vector2f v)
		{
			return new Vector3f(v.x, v.x, v.y);
		}

		public static Vector3f yxy(this Vector2f v)
		{
			return new Vector3f(v.y, v.x, v.y);
		}

		public static Vector3f xyy(this Vector2f v)
		{
			return new Vector3f(v.x, v.y, v.y);
		}

		public static Vector3f yyy(this Vector2f v)
		{
			return new Vector3f(v.y, v.y, v.y);
		}

		public static Vector4f xxxx(this Vector2f v)
		{
			return new Vector4f(v.x, v.x, v.x, v.x);
		}

		public static Vector4f yxxx(this Vector2f v)
		{
			return new Vector4f(v.y, v.x, v.x, v.x);
		}

		public static Vector4f xyxx(this Vector2f v)
		{
			return new Vector4f(v.x, v.y, v.x, v.x);
		}

		public static Vector4f yyxx(this Vector2f v)
		{
			return new Vector4f(v.y, v.y, v.x, v.x);
		}

		public static Vector4f xxyx(this Vector2f v)
		{
			return new Vector4f(v.x, v.x, v.y, v.x);
		}

		public static Vector4f yxyx(this Vector2f v)
		{
			return new Vector4f(v.y, v.x, v.y, v.x);
		}

		public static Vector4f xyyx(this Vector2f v)
		{
			return new Vector4f(v.x, v.y, v.y, v.x);
		}

		public static Vector4f yyyx(this Vector2f v)
		{
			return new Vector4f(v.y, v.y, v.y, v.x);
		}

		public static Vector4f xxxy(this Vector2f v)
		{
			return new Vector4f(v.x, v.x, v.x, v.y);
		}

		public static Vector4f yxxy(this Vector2f v)
		{
			return new Vector4f(v.y, v.x, v.x, v.y);
		}

		public static Vector4f xyxy(this Vector2f v)
		{
			return new Vector4f(v.x, v.y, v.x, v.y);
		}

		public static Vector4f yyxy(this Vector2f v)
		{
			return new Vector4f(v.y, v.y, v.x, v.y);
		}

		public static Vector4f xxyy(this Vector2f v)
		{
			return new Vector4f(v.x, v.x, v.y, v.y);
		}

		public static Vector4f yxyy(this Vector2f v)
		{
			return new Vector4f(v.y, v.x, v.y, v.y);
		}

		public static Vector4f xyyy(this Vector2f v)
		{
			return new Vector4f(v.x, v.y, v.y, v.y);
		}

		public static Vector4f yyyy(this Vector2f v)
		{
			return new Vector4f(v.y, v.y, v.y, v.y);
		}

#pragma warning restore IDE1006
	}
}
