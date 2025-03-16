// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

using Vector2Int = Godot.Vector2I;
using Vector3Int = Godot.Vector3I;
using Vector4Int = Godot.Vector4I;

namespace Ju.Math
{
	public static class GodotVector3IntSwizzleExtensions
	{
#pragma warning disable IDE1006

		public static Vector2Int xx(this Vector3Int v)
		{
			return new Vector2Int(v.X, v.X);
		}

		public static Vector2Int yx(this Vector3Int v)
		{
			return new Vector2Int(v.Y, v.X);
		}

		public static Vector2Int zx(this Vector3Int v)
		{
			return new Vector2Int(v.Z, v.X);
		}

		public static Vector2Int xy(this Vector3Int v)
		{
			return new Vector2Int(v.X, v.Y);
		}

		public static Vector2Int yy(this Vector3Int v)
		{
			return new Vector2Int(v.Y, v.Y);
		}

		public static Vector2Int zy(this Vector3Int v)
		{
			return new Vector2Int(v.Z, v.Y);
		}

		public static Vector2Int xz(this Vector3Int v)
		{
			return new Vector2Int(v.X, v.Z);
		}

		public static Vector2Int yz(this Vector3Int v)
		{
			return new Vector2Int(v.Y, v.Z);
		}

		public static Vector2Int zz(this Vector3Int v)
		{
			return new Vector2Int(v.Z, v.Z);
		}

		public static Vector3Int xxx(this Vector3Int v)
		{
			return new Vector3Int(v.X, v.X, v.X);
		}

		public static Vector3Int yxx(this Vector3Int v)
		{
			return new Vector3Int(v.Y, v.X, v.X);
		}

		public static Vector3Int zxx(this Vector3Int v)
		{
			return new Vector3Int(v.Z, v.X, v.X);
		}

		public static Vector3Int xyx(this Vector3Int v)
		{
			return new Vector3Int(v.X, v.Y, v.X);
		}

		public static Vector3Int yyx(this Vector3Int v)
		{
			return new Vector3Int(v.Y, v.Y, v.X);
		}

		public static Vector3Int zyx(this Vector3Int v)
		{
			return new Vector3Int(v.Z, v.Y, v.X);
		}

		public static Vector3Int xzx(this Vector3Int v)
		{
			return new Vector3Int(v.X, v.Z, v.X);
		}

		public static Vector3Int yzx(this Vector3Int v)
		{
			return new Vector3Int(v.Y, v.Z, v.X);
		}

		public static Vector3Int zzx(this Vector3Int v)
		{
			return new Vector3Int(v.Z, v.Z, v.X);
		}

		public static Vector3Int xxy(this Vector3Int v)
		{
			return new Vector3Int(v.X, v.X, v.Y);
		}

		public static Vector3Int yxy(this Vector3Int v)
		{
			return new Vector3Int(v.Y, v.X, v.Y);
		}

		public static Vector3Int zxy(this Vector3Int v)
		{
			return new Vector3Int(v.Z, v.X, v.Y);
		}

		public static Vector3Int xyy(this Vector3Int v)
		{
			return new Vector3Int(v.X, v.Y, v.Y);
		}

		public static Vector3Int yyy(this Vector3Int v)
		{
			return new Vector3Int(v.Y, v.Y, v.Y);
		}

		public static Vector3Int zyy(this Vector3Int v)
		{
			return new Vector3Int(v.Z, v.Y, v.Y);
		}

		public static Vector3Int xzy(this Vector3Int v)
		{
			return new Vector3Int(v.X, v.Z, v.Y);
		}

		public static Vector3Int yzy(this Vector3Int v)
		{
			return new Vector3Int(v.Y, v.Z, v.Y);
		}

		public static Vector3Int zzy(this Vector3Int v)
		{
			return new Vector3Int(v.Z, v.Z, v.Y);
		}

		public static Vector3Int xxz(this Vector3Int v)
		{
			return new Vector3Int(v.X, v.X, v.Z);
		}

		public static Vector3Int yxz(this Vector3Int v)
		{
			return new Vector3Int(v.Y, v.X, v.Z);
		}

		public static Vector3Int zxz(this Vector3Int v)
		{
			return new Vector3Int(v.Z, v.X, v.Z);
		}

		public static Vector3Int xyz(this Vector3Int v)
		{
			return new Vector3Int(v.X, v.Y, v.Z);
		}

		public static Vector3Int yyz(this Vector3Int v)
		{
			return new Vector3Int(v.Y, v.Y, v.Z);
		}

		public static Vector3Int zyz(this Vector3Int v)
		{
			return new Vector3Int(v.Z, v.Y, v.Z);
		}

		public static Vector3Int xzz(this Vector3Int v)
		{
			return new Vector3Int(v.X, v.Z, v.Z);
		}

		public static Vector3Int yzz(this Vector3Int v)
		{
			return new Vector3Int(v.Y, v.Z, v.Z);
		}

		public static Vector3Int zzz(this Vector3Int v)
		{
			return new Vector3Int(v.Z, v.Z, v.Z);
		}

		public static Vector4Int xxxx(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.X, v.X, v.X);
		}

		public static Vector4Int yxxx(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.X, v.X, v.X);
		}

		public static Vector4Int zxxx(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.X, v.X, v.X);
		}

		public static Vector4Int xyxx(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Y, v.X, v.X);
		}

		public static Vector4Int yyxx(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.X, v.X);
		}

		public static Vector4Int zyxx(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.X, v.X);
		}

		public static Vector4Int xzxx(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Z, v.X, v.X);
		}

		public static Vector4Int yzxx(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.X, v.X);
		}

		public static Vector4Int zzxx(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.X, v.X);
		}

		public static Vector4Int xxyx(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.X, v.Y, v.X);
		}

		public static Vector4Int yxyx(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Y, v.X);
		}

		public static Vector4Int zxyx(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Y, v.X);
		}

		public static Vector4Int xyyx(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Y, v.X);
		}

		public static Vector4Int yyyx(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Y, v.X);
		}

		public static Vector4Int zyyx(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Y, v.X);
		}

		public static Vector4Int xzyx(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Y, v.X);
		}

		public static Vector4Int yzyx(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Y, v.X);
		}

		public static Vector4Int zzyx(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Y, v.X);
		}

		public static Vector4Int xxzx(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.X, v.Z, v.X);
		}

		public static Vector4Int yxzx(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Z, v.X);
		}

		public static Vector4Int zxzx(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Z, v.X);
		}

		public static Vector4Int xyzx(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Z, v.X);
		}

		public static Vector4Int yyzx(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Z, v.X);
		}

		public static Vector4Int zyzx(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Z, v.X);
		}

		public static Vector4Int xzzx(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Z, v.X);
		}

		public static Vector4Int yzzx(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Z, v.X);
		}

		public static Vector4Int zzzx(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Z, v.X);
		}

		public static Vector4Int xxxy(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.X, v.X, v.Y);
		}

		public static Vector4Int yxxy(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.X, v.X, v.Y);
		}

		public static Vector4Int zxxy(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.X, v.X, v.Y);
		}

		public static Vector4Int xyxy(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Y, v.X, v.Y);
		}

		public static Vector4Int yyxy(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.X, v.Y);
		}

		public static Vector4Int zyxy(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.X, v.Y);
		}

		public static Vector4Int xzxy(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Z, v.X, v.Y);
		}

		public static Vector4Int yzxy(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.X, v.Y);
		}

		public static Vector4Int zzxy(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.X, v.Y);
		}

		public static Vector4Int xxyy(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.X, v.Y, v.Y);
		}

		public static Vector4Int yxyy(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Y, v.Y);
		}

		public static Vector4Int zxyy(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Y, v.Y);
		}

		public static Vector4Int xyyy(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Y, v.Y);
		}

		public static Vector4Int yyyy(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Y, v.Y);
		}

		public static Vector4Int zyyy(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Y, v.Y);
		}

		public static Vector4Int xzyy(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Y, v.Y);
		}

		public static Vector4Int yzyy(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Y, v.Y);
		}

		public static Vector4Int zzyy(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Y, v.Y);
		}

		public static Vector4Int xxzy(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.X, v.Z, v.Y);
		}

		public static Vector4Int yxzy(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Z, v.Y);
		}

		public static Vector4Int zxzy(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Z, v.Y);
		}

		public static Vector4Int xyzy(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Z, v.Y);
		}

		public static Vector4Int yyzy(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Z, v.Y);
		}

		public static Vector4Int zyzy(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Z, v.Y);
		}

		public static Vector4Int xzzy(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Z, v.Y);
		}

		public static Vector4Int yzzy(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Z, v.Y);
		}

		public static Vector4Int zzzy(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Z, v.Y);
		}

		public static Vector4Int xxxz(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.X, v.X, v.Z);
		}

		public static Vector4Int yxxz(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.X, v.X, v.Z);
		}

		public static Vector4Int zxxz(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.X, v.X, v.Z);
		}

		public static Vector4Int xyxz(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Y, v.X, v.Z);
		}

		public static Vector4Int yyxz(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.X, v.Z);
		}

		public static Vector4Int zyxz(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.X, v.Z);
		}

		public static Vector4Int xzxz(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Z, v.X, v.Z);
		}

		public static Vector4Int yzxz(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.X, v.Z);
		}

		public static Vector4Int zzxz(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.X, v.Z);
		}

		public static Vector4Int xxyz(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.X, v.Y, v.Z);
		}

		public static Vector4Int yxyz(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Y, v.Z);
		}

		public static Vector4Int zxyz(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Y, v.Z);
		}

		public static Vector4Int xyyz(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Y, v.Z);
		}

		public static Vector4Int yyyz(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Y, v.Z);
		}

		public static Vector4Int zyyz(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Y, v.Z);
		}

		public static Vector4Int xzyz(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Y, v.Z);
		}

		public static Vector4Int yzyz(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Y, v.Z);
		}

		public static Vector4Int zzyz(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Y, v.Z);
		}

		public static Vector4Int xxzz(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.X, v.Z, v.Z);
		}

		public static Vector4Int yxzz(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Z, v.Z);
		}

		public static Vector4Int zxzz(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Z, v.Z);
		}

		public static Vector4Int xyzz(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Z, v.Z);
		}

		public static Vector4Int yyzz(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Z, v.Z);
		}

		public static Vector4Int zyzz(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Z, v.Z);
		}

		public static Vector4Int xzzz(this Vector3Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Z, v.Z);
		}

		public static Vector4Int yzzz(this Vector3Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Z, v.Z);
		}

		public static Vector4Int zzzz(this Vector3Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Z, v.Z);
		}

#pragma warning restore IDE1006
	}
}

#endif
