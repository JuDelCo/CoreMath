// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

using Vector2 = Godot.Vector2;
using Vector3 = Godot.Vector3;
using Vector4 = Godot.Vector4;

namespace Ju.Math
{
	public static class GodotVector2SwizzleExtensions
	{
#pragma warning disable IDE1006

		public static Vector2 xx(this Vector2 v)
		{
			return new Vector2(v.X, v.X);
		}

		public static Vector2 yx(this Vector2 v)
		{
			return new Vector2(v.Y, v.X);
		}

		public static Vector2 xy(this Vector2 v)
		{
			return new Vector2(v.X, v.Y);
		}

		public static Vector2 yy(this Vector2 v)
		{
			return new Vector2(v.Y, v.Y);
		}

		public static Vector3 xxx(this Vector2 v)
		{
			return new Vector3(v.X, v.X, v.X);
		}

		public static Vector3 yxx(this Vector2 v)
		{
			return new Vector3(v.Y, v.X, v.X);
		}

		public static Vector3 xyx(this Vector2 v)
		{
			return new Vector3(v.X, v.Y, v.X);
		}

		public static Vector3 yyx(this Vector2 v)
		{
			return new Vector3(v.Y, v.Y, v.X);
		}

		public static Vector3 xxy(this Vector2 v)
		{
			return new Vector3(v.X, v.X, v.Y);
		}

		public static Vector3 yxy(this Vector2 v)
		{
			return new Vector3(v.Y, v.X, v.Y);
		}

		public static Vector3 xyy(this Vector2 v)
		{
			return new Vector3(v.X, v.Y, v.Y);
		}

		public static Vector3 yyy(this Vector2 v)
		{
			return new Vector3(v.Y, v.Y, v.Y);
		}

		public static Vector4 xxxx(this Vector2 v)
		{
			return new Vector4(v.X, v.X, v.X, v.X);
		}

		public static Vector4 yxxx(this Vector2 v)
		{
			return new Vector4(v.Y, v.X, v.X, v.X);
		}

		public static Vector4 xyxx(this Vector2 v)
		{
			return new Vector4(v.X, v.Y, v.X, v.X);
		}

		public static Vector4 yyxx(this Vector2 v)
		{
			return new Vector4(v.Y, v.Y, v.X, v.X);
		}

		public static Vector4 xxyx(this Vector2 v)
		{
			return new Vector4(v.X, v.X, v.Y, v.X);
		}

		public static Vector4 yxyx(this Vector2 v)
		{
			return new Vector4(v.Y, v.X, v.Y, v.X);
		}

		public static Vector4 xyyx(this Vector2 v)
		{
			return new Vector4(v.X, v.Y, v.Y, v.X);
		}

		public static Vector4 yyyx(this Vector2 v)
		{
			return new Vector4(v.Y, v.Y, v.Y, v.X);
		}

		public static Vector4 xxxy(this Vector2 v)
		{
			return new Vector4(v.X, v.X, v.X, v.Y);
		}

		public static Vector4 yxxy(this Vector2 v)
		{
			return new Vector4(v.Y, v.X, v.X, v.Y);
		}

		public static Vector4 xyxy(this Vector2 v)
		{
			return new Vector4(v.X, v.Y, v.X, v.Y);
		}

		public static Vector4 yyxy(this Vector2 v)
		{
			return new Vector4(v.Y, v.Y, v.X, v.Y);
		}

		public static Vector4 xxyy(this Vector2 v)
		{
			return new Vector4(v.X, v.X, v.Y, v.Y);
		}

		public static Vector4 yxyy(this Vector2 v)
		{
			return new Vector4(v.Y, v.X, v.Y, v.Y);
		}

		public static Vector4 xyyy(this Vector2 v)
		{
			return new Vector4(v.X, v.Y, v.Y, v.Y);
		}

		public static Vector4 yyyy(this Vector2 v)
		{
			return new Vector4(v.Y, v.Y, v.Y, v.Y);
		}

#pragma warning restore IDE1006
	}
}

#endif
