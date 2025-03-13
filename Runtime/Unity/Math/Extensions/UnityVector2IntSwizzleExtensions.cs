// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2025 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

using Vector2Int = UnityEngine.Vector2Int;
using Vector3Int = UnityEngine.Vector3Int;
using Vector4 = UnityEngine.Vector4;

namespace Ju.Math
{
	public static class UnityVector2IntIntSwizzleExtensions
	{
#pragma warning disable IDE1006

		public static Vector2Int xx(this Vector2Int v)
		{
			return new Vector2Int(v.x, v.x);
		}

		public static Vector2Int yx(this Vector2Int v)
		{
			return new Vector2Int(v.y, v.x);
		}

		public static Vector2Int xy(this Vector2Int v)
		{
			return new Vector2Int(v.x, v.y);
		}

		public static Vector2Int yy(this Vector2Int v)
		{
			return new Vector2Int(v.y, v.y);
		}

		public static Vector3Int xxx(this Vector2Int v)
		{
			return new Vector3Int(v.x, v.x, v.x);
		}

		public static Vector3Int yxx(this Vector2Int v)
		{
			return new Vector3Int(v.y, v.x, v.x);
		}

		public static Vector3Int xyx(this Vector2Int v)
		{
			return new Vector3Int(v.x, v.y, v.x);
		}

		public static Vector3Int yyx(this Vector2Int v)
		{
			return new Vector3Int(v.y, v.y, v.x);
		}

		public static Vector3Int xxy(this Vector2Int v)
		{
			return new Vector3Int(v.x, v.x, v.y);
		}

		public static Vector3Int yxy(this Vector2Int v)
		{
			return new Vector3Int(v.y, v.x, v.y);
		}

		public static Vector3Int xyy(this Vector2Int v)
		{
			return new Vector3Int(v.x, v.y, v.y);
		}

		public static Vector3Int yyy(this Vector2Int v)
		{
			return new Vector3Int(v.y, v.y, v.y);
		}

		public static Vector4 xxxx(this Vector2Int v)
		{
			return new Vector4(v.x, v.x, v.x, v.x);
		}

		public static Vector4 yxxx(this Vector2Int v)
		{
			return new Vector4(v.y, v.x, v.x, v.x);
		}

		public static Vector4 xyxx(this Vector2Int v)
		{
			return new Vector4(v.x, v.y, v.x, v.x);
		}

		public static Vector4 yyxx(this Vector2Int v)
		{
			return new Vector4(v.y, v.y, v.x, v.x);
		}

		public static Vector4 xxyx(this Vector2Int v)
		{
			return new Vector4(v.x, v.x, v.y, v.x);
		}

		public static Vector4 yxyx(this Vector2Int v)
		{
			return new Vector4(v.y, v.x, v.y, v.x);
		}

		public static Vector4 xyyx(this Vector2Int v)
		{
			return new Vector4(v.x, v.y, v.y, v.x);
		}

		public static Vector4 yyyx(this Vector2Int v)
		{
			return new Vector4(v.y, v.y, v.y, v.x);
		}

		public static Vector4 xxxy(this Vector2Int v)
		{
			return new Vector4(v.x, v.x, v.x, v.y);
		}

		public static Vector4 yxxy(this Vector2Int v)
		{
			return new Vector4(v.y, v.x, v.x, v.y);
		}

		public static Vector4 xyxy(this Vector2Int v)
		{
			return new Vector4(v.x, v.y, v.x, v.y);
		}

		public static Vector4 yyxy(this Vector2Int v)
		{
			return new Vector4(v.y, v.y, v.x, v.y);
		}

		public static Vector4 xxyy(this Vector2Int v)
		{
			return new Vector4(v.x, v.x, v.y, v.y);
		}

		public static Vector4 yxyy(this Vector2Int v)
		{
			return new Vector4(v.y, v.x, v.y, v.y);
		}

		public static Vector4 xyyy(this Vector2Int v)
		{
			return new Vector4(v.x, v.y, v.y, v.y);
		}

		public static Vector4 yyyy(this Vector2Int v)
		{
			return new Vector4(v.y, v.y, v.y, v.y);
		}

#pragma warning restore IDE1006
	}
}

#endif
