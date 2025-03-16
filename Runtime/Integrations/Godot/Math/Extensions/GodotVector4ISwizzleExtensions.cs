// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

using Vector2Int = Godot.Vector2I;
using Vector3Int = Godot.Vector3I;
using Vector4Int = Godot.Vector4I;

namespace Ju.Math
{
	public static class GodotVector4ISwizzleExtensions
	{
#pragma warning disable IDE1006

		public static Vector2Int xx(this Vector4Int v)
		{
			return new Vector2Int(v.X, v.X);
		}

		public static Vector2Int yx(this Vector4Int v)
		{
			return new Vector2Int(v.Y, v.X);
		}

		public static Vector2Int zx(this Vector4Int v)
		{
			return new Vector2Int(v.Z, v.X);
		}

		public static Vector2Int wx(this Vector4Int v)
		{
			return new Vector2Int(v.W, v.X);
		}

		public static Vector2Int xy(this Vector4Int v)
		{
			return new Vector2Int(v.X, v.Y);
		}

		public static Vector2Int yy(this Vector4Int v)
		{
			return new Vector2Int(v.Y, v.Y);
		}

		public static Vector2Int zy(this Vector4Int v)
		{
			return new Vector2Int(v.Z, v.Y);
		}

		public static Vector2Int wy(this Vector4Int v)
		{
			return new Vector2Int(v.W, v.Y);
		}

		public static Vector2Int xz(this Vector4Int v)
		{
			return new Vector2Int(v.X, v.Z);
		}

		public static Vector2Int yz(this Vector4Int v)
		{
			return new Vector2Int(v.Y, v.Z);
		}

		public static Vector2Int zz(this Vector4Int v)
		{
			return new Vector2Int(v.Z, v.Z);
		}

		public static Vector2Int wz(this Vector4Int v)
		{
			return new Vector2Int(v.W, v.Z);
		}

		public static Vector2Int xw(this Vector4Int v)
		{
			return new Vector2Int(v.X, v.W);
		}

		public static Vector2Int yw(this Vector4Int v)
		{
			return new Vector2Int(v.Y, v.W);
		}

		public static Vector2Int zw(this Vector4Int v)
		{
			return new Vector2Int(v.Z, v.W);
		}

		public static Vector2Int ww(this Vector4Int v)
		{
			return new Vector2Int(v.W, v.W);
		}

		public static Vector3Int xxx(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.X, v.X);
		}

		public static Vector3Int yxx(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.X, v.X);
		}

		public static Vector3Int zxx(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.X, v.X);
		}

		public static Vector3Int wxx(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.X, v.X);
		}

		public static Vector3Int xyx(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.Y, v.X);
		}

		public static Vector3Int yyx(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.Y, v.X);
		}

		public static Vector3Int zyx(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.Y, v.X);
		}

		public static Vector3Int wyx(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.Y, v.X);
		}

		public static Vector3Int xzx(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.Z, v.X);
		}

		public static Vector3Int yzx(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.Z, v.X);
		}

		public static Vector3Int zzx(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.Z, v.X);
		}

		public static Vector3Int wzx(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.Z, v.X);
		}

		public static Vector3Int xwx(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.W, v.X);
		}

		public static Vector3Int ywx(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.W, v.X);
		}

		public static Vector3Int zwx(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.W, v.X);
		}

		public static Vector3Int wwx(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.W, v.X);
		}

		public static Vector3Int xxy(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.X, v.Y);
		}

		public static Vector3Int yxy(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.X, v.Y);
		}

		public static Vector3Int zxy(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.X, v.Y);
		}

		public static Vector3Int wxy(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.X, v.Y);
		}

		public static Vector3Int xyy(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.Y, v.Y);
		}

		public static Vector3Int yyy(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.Y, v.Y);
		}

		public static Vector3Int zyy(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.Y, v.Y);
		}

		public static Vector3Int wyy(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.Y, v.Y);
		}

		public static Vector3Int xzy(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.Z, v.Y);
		}

		public static Vector3Int yzy(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.Z, v.Y);
		}

		public static Vector3Int zzy(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.Z, v.Y);
		}

		public static Vector3Int wzy(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.Z, v.Y);
		}

		public static Vector3Int xwy(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.W, v.Y);
		}

		public static Vector3Int ywy(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.W, v.Y);
		}

		public static Vector3Int zwy(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.W, v.Y);
		}

		public static Vector3Int wwy(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.W, v.Y);
		}

		public static Vector3Int xxz(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.X, v.Z);
		}

		public static Vector3Int yxz(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.X, v.Z);
		}

		public static Vector3Int zxz(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.X, v.Z);
		}

		public static Vector3Int wxz(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.X, v.Z);
		}

		public static Vector3Int xyz(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.Y, v.Z);
		}

		public static Vector3Int yyz(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.Y, v.Z);
		}

		public static Vector3Int zyz(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.Y, v.Z);
		}

		public static Vector3Int wyz(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.Y, v.Z);
		}

		public static Vector3Int xzz(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.Z, v.Z);
		}

		public static Vector3Int yzz(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.Z, v.Z);
		}

		public static Vector3Int zzz(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.Z, v.Z);
		}

		public static Vector3Int wzz(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.Z, v.Z);
		}

		public static Vector3Int xwz(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.W, v.Z);
		}

		public static Vector3Int ywz(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.W, v.Z);
		}

		public static Vector3Int zwz(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.W, v.Z);
		}

		public static Vector3Int wwz(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.W, v.Z);
		}

		public static Vector3Int xxw(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.X, v.W);
		}

		public static Vector3Int yxw(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.X, v.W);
		}

		public static Vector3Int zxw(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.X, v.W);
		}

		public static Vector3Int wxw(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.X, v.W);
		}

		public static Vector3Int xyw(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.Y, v.W);
		}

		public static Vector3Int yyw(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.Y, v.W);
		}

		public static Vector3Int zyw(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.Y, v.W);
		}

		public static Vector3Int wyw(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.Y, v.W);
		}

		public static Vector3Int xzw(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.Z, v.W);
		}

		public static Vector3Int yzw(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.Z, v.W);
		}

		public static Vector3Int zzw(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.Z, v.W);
		}

		public static Vector3Int wzw(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.Z, v.W);
		}

		public static Vector3Int xww(this Vector4Int v)
		{
			return new Vector3Int(v.X, v.W, v.W);
		}

		public static Vector3Int yww(this Vector4Int v)
		{
			return new Vector3Int(v.Y, v.W, v.W);
		}

		public static Vector3Int zww(this Vector4Int v)
		{
			return new Vector3Int(v.Z, v.W, v.W);
		}

		public static Vector3Int www(this Vector4Int v)
		{
			return new Vector3Int(v.W, v.W, v.W);
		}

		public static Vector4Int xxxx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.X, v.X);
		}

		public static Vector4Int yxxx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.X, v.X);
		}

		public static Vector4Int zxxx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.X, v.X);
		}

		public static Vector4Int wxxx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.X, v.X);
		}

		public static Vector4Int xyxx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.X, v.X);
		}

		public static Vector4Int yyxx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.X, v.X);
		}

		public static Vector4Int zyxx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.X, v.X);
		}

		public static Vector4Int wyxx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.X, v.X);
		}

		public static Vector4Int xzxx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.X, v.X);
		}

		public static Vector4Int yzxx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.X, v.X);
		}

		public static Vector4Int zzxx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.X, v.X);
		}

		public static Vector4Int wzxx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.X, v.X);
		}

		public static Vector4Int xwxx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.X, v.X);
		}

		public static Vector4Int ywxx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.X, v.X);
		}

		public static Vector4Int zwxx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.X, v.X);
		}

		public static Vector4Int wwxx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.X, v.X);
		}

		public static Vector4Int xxyx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.Y, v.X);
		}

		public static Vector4Int yxyx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Y, v.X);
		}

		public static Vector4Int zxyx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Y, v.X);
		}

		public static Vector4Int wxyx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.Y, v.X);
		}

		public static Vector4Int xyyx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Y, v.X);
		}

		public static Vector4Int yyyx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Y, v.X);
		}

		public static Vector4Int zyyx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Y, v.X);
		}

		public static Vector4Int wyyx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.Y, v.X);
		}

		public static Vector4Int xzyx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Y, v.X);
		}

		public static Vector4Int yzyx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Y, v.X);
		}

		public static Vector4Int zzyx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Y, v.X);
		}

		public static Vector4Int wzyx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.Y, v.X);
		}

		public static Vector4Int xwyx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.Y, v.X);
		}

		public static Vector4Int ywyx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.Y, v.X);
		}

		public static Vector4Int zwyx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.Y, v.X);
		}

		public static Vector4Int wwyx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.Y, v.X);
		}

		public static Vector4Int xxzx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.Z, v.X);
		}

		public static Vector4Int yxzx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Z, v.X);
		}

		public static Vector4Int zxzx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Z, v.X);
		}

		public static Vector4Int wxzx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.Z, v.X);
		}

		public static Vector4Int xyzx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Z, v.X);
		}

		public static Vector4Int yyzx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Z, v.X);
		}

		public static Vector4Int zyzx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Z, v.X);
		}

		public static Vector4Int wyzx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.Z, v.X);
		}

		public static Vector4Int xzzx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Z, v.X);
		}

		public static Vector4Int yzzx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Z, v.X);
		}

		public static Vector4Int zzzx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Z, v.X);
		}

		public static Vector4Int wzzx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.Z, v.X);
		}

		public static Vector4Int xwzx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.Z, v.X);
		}

		public static Vector4Int ywzx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.Z, v.X);
		}

		public static Vector4Int zwzx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.Z, v.X);
		}

		public static Vector4Int wwzx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.Z, v.X);
		}

		public static Vector4Int xxwx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.W, v.X);
		}

		public static Vector4Int yxwx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.W, v.X);
		}

		public static Vector4Int zxwx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.W, v.X);
		}

		public static Vector4Int wxwx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.W, v.X);
		}

		public static Vector4Int xywx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.W, v.X);
		}

		public static Vector4Int yywx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.W, v.X);
		}

		public static Vector4Int zywx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.W, v.X);
		}

		public static Vector4Int wywx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.W, v.X);
		}

		public static Vector4Int xzwx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.W, v.X);
		}

		public static Vector4Int yzwx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.W, v.X);
		}

		public static Vector4Int zzwx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.W, v.X);
		}

		public static Vector4Int wzwx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.W, v.X);
		}

		public static Vector4Int xwwx(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.W, v.X);
		}

		public static Vector4Int ywwx(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.W, v.X);
		}

		public static Vector4Int zwwx(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.W, v.X);
		}

		public static Vector4Int wwwx(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.W, v.X);
		}

		public static Vector4Int xxxy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.X, v.Y);
		}

		public static Vector4Int yxxy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.X, v.Y);
		}

		public static Vector4Int zxxy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.X, v.Y);
		}

		public static Vector4Int wxxy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.X, v.Y);
		}

		public static Vector4Int xyxy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.X, v.Y);
		}

		public static Vector4Int yyxy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.X, v.Y);
		}

		public static Vector4Int zyxy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.X, v.Y);
		}

		public static Vector4Int wyxy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.X, v.Y);
		}

		public static Vector4Int xzxy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.X, v.Y);
		}

		public static Vector4Int yzxy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.X, v.Y);
		}

		public static Vector4Int zzxy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.X, v.Y);
		}

		public static Vector4Int wzxy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.X, v.Y);
		}

		public static Vector4Int xwxy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.X, v.Y);
		}

		public static Vector4Int ywxy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.X, v.Y);
		}

		public static Vector4Int zwxy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.X, v.Y);
		}

		public static Vector4Int wwxy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.X, v.Y);
		}

		public static Vector4Int xxyy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.Y, v.Y);
		}

		public static Vector4Int yxyy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Y, v.Y);
		}

		public static Vector4Int zxyy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Y, v.Y);
		}

		public static Vector4Int wxyy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.Y, v.Y);
		}

		public static Vector4Int xyyy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Y, v.Y);
		}

		public static Vector4Int yyyy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Y, v.Y);
		}

		public static Vector4Int zyyy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Y, v.Y);
		}

		public static Vector4Int wyyy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.Y, v.Y);
		}

		public static Vector4Int xzyy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Y, v.Y);
		}

		public static Vector4Int yzyy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Y, v.Y);
		}

		public static Vector4Int zzyy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Y, v.Y);
		}

		public static Vector4Int wzyy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.Y, v.Y);
		}

		public static Vector4Int xwyy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.Y, v.Y);
		}

		public static Vector4Int ywyy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.Y, v.Y);
		}

		public static Vector4Int zwyy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.Y, v.Y);
		}

		public static Vector4Int wwyy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.Y, v.Y);
		}

		public static Vector4Int xxzy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.Z, v.Y);
		}

		public static Vector4Int yxzy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Z, v.Y);
		}

		public static Vector4Int zxzy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Z, v.Y);
		}

		public static Vector4Int wxzy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.Z, v.Y);
		}

		public static Vector4Int xyzy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Z, v.Y);
		}

		public static Vector4Int yyzy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Z, v.Y);
		}

		public static Vector4Int zyzy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Z, v.Y);
		}

		public static Vector4Int wyzy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.Z, v.Y);
		}

		public static Vector4Int xzzy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Z, v.Y);
		}

		public static Vector4Int yzzy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Z, v.Y);
		}

		public static Vector4Int zzzy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Z, v.Y);
		}

		public static Vector4Int wzzy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.Z, v.Y);
		}

		public static Vector4Int xwzy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.Z, v.Y);
		}

		public static Vector4Int ywzy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.Z, v.Y);
		}

		public static Vector4Int zwzy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.Z, v.Y);
		}

		public static Vector4Int wwzy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.Z, v.Y);
		}

		public static Vector4Int xxwy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.W, v.Y);
		}

		public static Vector4Int yxwy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.W, v.Y);
		}

		public static Vector4Int zxwy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.W, v.Y);
		}

		public static Vector4Int wxwy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.W, v.Y);
		}

		public static Vector4Int xywy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.W, v.Y);
		}

		public static Vector4Int yywy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.W, v.Y);
		}

		public static Vector4Int zywy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.W, v.Y);
		}

		public static Vector4Int wywy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.W, v.Y);
		}

		public static Vector4Int xzwy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.W, v.Y);
		}

		public static Vector4Int yzwy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.W, v.Y);
		}

		public static Vector4Int zzwy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.W, v.Y);
		}

		public static Vector4Int wzwy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.W, v.Y);
		}

		public static Vector4Int xwwy(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.W, v.Y);
		}

		public static Vector4Int ywwy(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.W, v.Y);
		}

		public static Vector4Int zwwy(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.W, v.Y);
		}

		public static Vector4Int wwwy(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.W, v.Y);
		}

		public static Vector4Int xxxz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.X, v.Z);
		}

		public static Vector4Int yxxz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.X, v.Z);
		}

		public static Vector4Int zxxz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.X, v.Z);
		}

		public static Vector4Int wxxz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.X, v.Z);
		}

		public static Vector4Int xyxz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.X, v.Z);
		}

		public static Vector4Int yyxz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.X, v.Z);
		}

		public static Vector4Int zyxz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.X, v.Z);
		}

		public static Vector4Int wyxz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.X, v.Z);
		}

		public static Vector4Int xzxz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.X, v.Z);
		}

		public static Vector4Int yzxz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.X, v.Z);
		}

		public static Vector4Int zzxz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.X, v.Z);
		}

		public static Vector4Int wzxz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.X, v.Z);
		}

		public static Vector4Int xwxz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.X, v.Z);
		}

		public static Vector4Int ywxz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.X, v.Z);
		}

		public static Vector4Int zwxz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.X, v.Z);
		}

		public static Vector4Int wwxz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.X, v.Z);
		}

		public static Vector4Int xxyz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.Y, v.Z);
		}

		public static Vector4Int yxyz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Y, v.Z);
		}

		public static Vector4Int zxyz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Y, v.Z);
		}

		public static Vector4Int wxyz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.Y, v.Z);
		}

		public static Vector4Int xyyz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Y, v.Z);
		}

		public static Vector4Int yyyz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Y, v.Z);
		}

		public static Vector4Int zyyz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Y, v.Z);
		}

		public static Vector4Int wyyz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.Y, v.Z);
		}

		public static Vector4Int xzyz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Y, v.Z);
		}

		public static Vector4Int yzyz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Y, v.Z);
		}

		public static Vector4Int zzyz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Y, v.Z);
		}

		public static Vector4Int wzyz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.Y, v.Z);
		}

		public static Vector4Int xwyz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.Y, v.Z);
		}

		public static Vector4Int ywyz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.Y, v.Z);
		}

		public static Vector4Int zwyz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.Y, v.Z);
		}

		public static Vector4Int wwyz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.Y, v.Z);
		}

		public static Vector4Int xxzz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.Z, v.Z);
		}

		public static Vector4Int yxzz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Z, v.Z);
		}

		public static Vector4Int zxzz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Z, v.Z);
		}

		public static Vector4Int wxzz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.Z, v.Z);
		}

		public static Vector4Int xyzz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Z, v.Z);
		}

		public static Vector4Int yyzz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Z, v.Z);
		}

		public static Vector4Int zyzz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Z, v.Z);
		}

		public static Vector4Int wyzz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.Z, v.Z);
		}

		public static Vector4Int xzzz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Z, v.Z);
		}

		public static Vector4Int yzzz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Z, v.Z);
		}

		public static Vector4Int zzzz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Z, v.Z);
		}

		public static Vector4Int wzzz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.Z, v.Z);
		}

		public static Vector4Int xwzz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.Z, v.Z);
		}

		public static Vector4Int ywzz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.Z, v.Z);
		}

		public static Vector4Int zwzz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.Z, v.Z);
		}

		public static Vector4Int wwzz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.Z, v.Z);
		}

		public static Vector4Int xxwz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.W, v.Z);
		}

		public static Vector4Int yxwz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.W, v.Z);
		}

		public static Vector4Int zxwz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.W, v.Z);
		}

		public static Vector4Int wxwz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.W, v.Z);
		}

		public static Vector4Int xywz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.W, v.Z);
		}

		public static Vector4Int yywz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.W, v.Z);
		}

		public static Vector4Int zywz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.W, v.Z);
		}

		public static Vector4Int wywz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.W, v.Z);
		}

		public static Vector4Int xzwz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.W, v.Z);
		}

		public static Vector4Int yzwz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.W, v.Z);
		}

		public static Vector4Int zzwz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.W, v.Z);
		}

		public static Vector4Int wzwz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.W, v.Z);
		}

		public static Vector4Int xwwz(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.W, v.Z);
		}

		public static Vector4Int ywwz(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.W, v.Z);
		}

		public static Vector4Int zwwz(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.W, v.Z);
		}

		public static Vector4Int wwwz(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.W, v.Z);
		}

		public static Vector4Int xxxw(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.X, v.W);
		}

		public static Vector4Int yxxw(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.X, v.W);
		}

		public static Vector4Int zxxw(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.X, v.W);
		}

		public static Vector4Int wxxw(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.X, v.W);
		}

		public static Vector4Int xyxw(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.X, v.W);
		}

		public static Vector4Int yyxw(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.X, v.W);
		}

		public static Vector4Int zyxw(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.X, v.W);
		}

		public static Vector4Int wyxw(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.X, v.W);
		}

		public static Vector4Int xzxw(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.X, v.W);
		}

		public static Vector4Int yzxw(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.X, v.W);
		}

		public static Vector4Int zzxw(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.X, v.W);
		}

		public static Vector4Int wzxw(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.X, v.W);
		}

		public static Vector4Int xwxw(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.X, v.W);
		}

		public static Vector4Int ywxw(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.X, v.W);
		}

		public static Vector4Int zwxw(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.X, v.W);
		}

		public static Vector4Int wwxw(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.X, v.W);
		}

		public static Vector4Int xxyw(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.Y, v.W);
		}

		public static Vector4Int yxyw(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Y, v.W);
		}

		public static Vector4Int zxyw(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Y, v.W);
		}

		public static Vector4Int wxyw(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.Y, v.W);
		}

		public static Vector4Int xyyw(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Y, v.W);
		}

		public static Vector4Int yyyw(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Y, v.W);
		}

		public static Vector4Int zyyw(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Y, v.W);
		}

		public static Vector4Int wyyw(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.Y, v.W);
		}

		public static Vector4Int xzyw(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Y, v.W);
		}

		public static Vector4Int yzyw(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Y, v.W);
		}

		public static Vector4Int zzyw(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Y, v.W);
		}

		public static Vector4Int wzyw(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.Y, v.W);
		}

		public static Vector4Int xwyw(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.Y, v.W);
		}

		public static Vector4Int ywyw(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.Y, v.W);
		}

		public static Vector4Int zwyw(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.Y, v.W);
		}

		public static Vector4Int wwyw(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.Y, v.W);
		}

		public static Vector4Int xxzw(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.Z, v.W);
		}

		public static Vector4Int yxzw(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.Z, v.W);
		}

		public static Vector4Int zxzw(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.Z, v.W);
		}

		public static Vector4Int wxzw(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.Z, v.W);
		}

		public static Vector4Int xyzw(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.Z, v.W);
		}

		public static Vector4Int yyzw(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.Z, v.W);
		}

		public static Vector4Int zyzw(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.Z, v.W);
		}

		public static Vector4Int wyzw(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.Z, v.W);
		}

		public static Vector4Int xzzw(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.Z, v.W);
		}

		public static Vector4Int yzzw(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.Z, v.W);
		}

		public static Vector4Int zzzw(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.Z, v.W);
		}

		public static Vector4Int wzzw(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.Z, v.W);
		}

		public static Vector4Int xwzw(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.Z, v.W);
		}

		public static Vector4Int ywzw(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.Z, v.W);
		}

		public static Vector4Int zwzw(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.Z, v.W);
		}

		public static Vector4Int wwzw(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.Z, v.W);
		}

		public static Vector4Int xxww(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.X, v.W, v.W);
		}

		public static Vector4Int yxww(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.X, v.W, v.W);
		}

		public static Vector4Int zxww(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.X, v.W, v.W);
		}

		public static Vector4Int wxww(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.X, v.W, v.W);
		}

		public static Vector4Int xyww(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Y, v.W, v.W);
		}

		public static Vector4Int yyww(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Y, v.W, v.W);
		}

		public static Vector4Int zyww(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Y, v.W, v.W);
		}

		public static Vector4Int wyww(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Y, v.W, v.W);
		}

		public static Vector4Int xzww(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.Z, v.W, v.W);
		}

		public static Vector4Int yzww(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.Z, v.W, v.W);
		}

		public static Vector4Int zzww(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.Z, v.W, v.W);
		}

		public static Vector4Int wzww(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.Z, v.W, v.W);
		}

		public static Vector4Int xwww(this Vector4Int v)
		{
			return new Vector4Int(v.X, v.W, v.W, v.W);
		}

		public static Vector4Int ywww(this Vector4Int v)
		{
			return new Vector4Int(v.Y, v.W, v.W, v.W);
		}

		public static Vector4Int zwww(this Vector4Int v)
		{
			return new Vector4Int(v.Z, v.W, v.W, v.W);
		}

		public static Vector4Int wwww(this Vector4Int v)
		{
			return new Vector4Int(v.W, v.W, v.W, v.W);
		}

#pragma warning restore IDE1006
	}
}

#endif
