// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

using Vector2Int = Godot.Vector2I;
using Vector3Int = Godot.Vector3I;
using Vector4Int = Godot.Vector4I;

namespace Ju.Math
{
	public static class GodotVector2IntIntSwizzleExtensions
	{
#pragma warning disable IDE1006

		public static Vector2Int xx(this Vector2Int v)
		{
			return new Vector2Int(v.X, v.X);
		}

		public static Vector2Int yx(this Vector2Int v)
		{
			return new Vector2Int(v.Y, v.X);
		}

		public static Vector2Int xy(this Vector2Int v)
		{
			return new Vector2Int(v.X, v.Y);
		}

		public static Vector2Int yy(this Vector2Int v)
		{
			return new Vector2Int(v.Y, v.Y);
		}

		public static Vector3Int xxx(this Vector2Int v)
		{
			return new Vector3Int(v.X, v.X, v.X);
		}

		public static Vector3Int yxx(this Vector2Int v)
		{
			return new Vector3Int(v.Y, v.X, v.X);
		}

		public static Vector3Int xyx(this Vector2Int v)
		{
			return new Vector3Int(v.X, v.Y, v.X);
		}

		public static Vector3Int yyx(this Vector2Int v)
		{
			return new Vector3Int(v.Y, v.Y, v.X);
		}

		public static Vector3Int xxy(this Vector2Int v)
		{
			return new Vector3Int(v.X, v.X, v.Y);
		}

		public static Vector3Int yxy(this Vector2Int v)
		{
			return new Vector3Int(v.Y, v.X, v.Y);
		}

		public static Vector3Int xyy(this Vector2Int v)
		{
			return new Vector3Int(v.X, v.Y, v.Y);
		}

		public static Vector3Int yyy(this Vector2Int v)
		{
			return new Vector3Int(v.Y, v.Y, v.Y);
		}

		public static Vector4Int xxxx(this Vector2Int v)
		{
			return new Vector4Int(v.X, v.X, v.X, v.X);
		}

		public static Vector4Int yxxx(this Vector2Int v)
		{
			return new Vector4Int(v.Y, v.X, v.X, v.X);
		}

		public static Vector4Int xyxx(this Vector2Int v)
		{
			return new Vector4Int(v.X, v.Y, v.X, v.X);
		}

		public static Vector4Int yyxx(this Vector2Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.X, v.X);
		}

		public static Vector4Int xxyx(this Vector2Int v)
		{
			return new Vector4Int(v.X, v.X, v.Y, v.X);
		}

		public static Vector4Int yxyx(this Vector2Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Y, v.X);
		}

		public static Vector4Int xyyx(this Vector2Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Y, v.X);
		}

		public static Vector4Int yyyx(this Vector2Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Y, v.X);
		}

		public static Vector4Int xxxy(this Vector2Int v)
		{
			return new Vector4Int(v.X, v.X, v.X, v.Y);
		}

		public static Vector4Int yxxy(this Vector2Int v)
		{
			return new Vector4Int(v.Y, v.X, v.X, v.Y);
		}

		public static Vector4Int xyxy(this Vector2Int v)
		{
			return new Vector4Int(v.X, v.Y, v.X, v.Y);
		}

		public static Vector4Int yyxy(this Vector2Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.X, v.Y);
		}

		public static Vector4Int xxyy(this Vector2Int v)
		{
			return new Vector4Int(v.X, v.X, v.Y, v.Y);
		}

		public static Vector4Int yxyy(this Vector2Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Y, v.Y);
		}

		public static Vector4Int xyyy(this Vector2Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Y, v.Y);
		}

		public static Vector4Int yyyy(this Vector2Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Y, v.Y);
		}

#pragma warning restore IDE1006
	}
}

#endif
