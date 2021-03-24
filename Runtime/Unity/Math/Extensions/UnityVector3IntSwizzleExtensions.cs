// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

using Vector2Int = UnityEngine.Vector2Int;
using Vector3Int = UnityEngine.Vector3Int;
using Vector4 = UnityEngine.Vector4;

namespace Ju.Math
{
	public static class UnityVector3IntSwizzleExtensions
	{
#pragma warning disable IDE1006

		public static Vector2Int xx(this Vector3Int v)
		{
			return new Vector2Int(v.x, v.x);
		}

		public static Vector2Int yx(this Vector3Int v)
		{
			return new Vector2Int(v.y, v.x);
		}

		public static Vector2Int zx(this Vector3Int v)
		{
			return new Vector2Int(v.z, v.x);
		}

		public static Vector2Int xy(this Vector3Int v)
		{
			return new Vector2Int(v.x, v.y);
		}

		public static Vector2Int yy(this Vector3Int v)
		{
			return new Vector2Int(v.y, v.y);
		}

		public static Vector2Int zy(this Vector3Int v)
		{
			return new Vector2Int(v.z, v.y);
		}

		public static Vector2Int xz(this Vector3Int v)
		{
			return new Vector2Int(v.x, v.z);
		}

		public static Vector2Int yz(this Vector3Int v)
		{
			return new Vector2Int(v.y, v.z);
		}

		public static Vector2Int zz(this Vector3Int v)
		{
			return new Vector2Int(v.z, v.z);
		}

		public static Vector3Int xxx(this Vector3Int v)
		{
			return new Vector3Int(v.x, v.x, v.x);
		}

		public static Vector3Int yxx(this Vector3Int v)
		{
			return new Vector3Int(v.y, v.x, v.x);
		}

		public static Vector3Int zxx(this Vector3Int v)
		{
			return new Vector3Int(v.z, v.x, v.x);
		}

		public static Vector3Int xyx(this Vector3Int v)
		{
			return new Vector3Int(v.x, v.y, v.x);
		}

		public static Vector3Int yyx(this Vector3Int v)
		{
			return new Vector3Int(v.y, v.y, v.x);
		}

		public static Vector3Int zyx(this Vector3Int v)
		{
			return new Vector3Int(v.z, v.y, v.x);
		}

		public static Vector3Int xzx(this Vector3Int v)
		{
			return new Vector3Int(v.x, v.z, v.x);
		}

		public static Vector3Int yzx(this Vector3Int v)
		{
			return new Vector3Int(v.y, v.z, v.x);
		}

		public static Vector3Int zzx(this Vector3Int v)
		{
			return new Vector3Int(v.z, v.z, v.x);
		}

		public static Vector3Int xxy(this Vector3Int v)
		{
			return new Vector3Int(v.x, v.x, v.y);
		}

		public static Vector3Int yxy(this Vector3Int v)
		{
			return new Vector3Int(v.y, v.x, v.y);
		}

		public static Vector3Int zxy(this Vector3Int v)
		{
			return new Vector3Int(v.z, v.x, v.y);
		}

		public static Vector3Int xyy(this Vector3Int v)
		{
			return new Vector3Int(v.x, v.y, v.y);
		}

		public static Vector3Int yyy(this Vector3Int v)
		{
			return new Vector3Int(v.y, v.y, v.y);
		}

		public static Vector3Int zyy(this Vector3Int v)
		{
			return new Vector3Int(v.z, v.y, v.y);
		}

		public static Vector3Int xzy(this Vector3Int v)
		{
			return new Vector3Int(v.x, v.z, v.y);
		}

		public static Vector3Int yzy(this Vector3Int v)
		{
			return new Vector3Int(v.y, v.z, v.y);
		}

		public static Vector3Int zzy(this Vector3Int v)
		{
			return new Vector3Int(v.z, v.z, v.y);
		}

		public static Vector3Int xxz(this Vector3Int v)
		{
			return new Vector3Int(v.x, v.x, v.z);
		}

		public static Vector3Int yxz(this Vector3Int v)
		{
			return new Vector3Int(v.y, v.x, v.z);
		}

		public static Vector3Int zxz(this Vector3Int v)
		{
			return new Vector3Int(v.z, v.x, v.z);
		}

		public static Vector3Int xyz(this Vector3Int v)
		{
			return new Vector3Int(v.x, v.y, v.z);
		}

		public static Vector3Int yyz(this Vector3Int v)
		{
			return new Vector3Int(v.y, v.y, v.z);
		}

		public static Vector3Int zyz(this Vector3Int v)
		{
			return new Vector3Int(v.z, v.y, v.z);
		}

		public static Vector3Int xzz(this Vector3Int v)
		{
			return new Vector3Int(v.x, v.z, v.z);
		}

		public static Vector3Int yzz(this Vector3Int v)
		{
			return new Vector3Int(v.y, v.z, v.z);
		}

		public static Vector3Int zzz(this Vector3Int v)
		{
			return new Vector3Int(v.z, v.z, v.z);
		}

		public static Vector4 xxxx(this Vector3Int v)
		{
			return new Vector4(v.x, v.x, v.x, v.x);
		}

		public static Vector4 yxxx(this Vector3Int v)
		{
			return new Vector4(v.y, v.x, v.x, v.x);
		}

		public static Vector4 zxxx(this Vector3Int v)
		{
			return new Vector4(v.z, v.x, v.x, v.x);
		}

		public static Vector4 xyxx(this Vector3Int v)
		{
			return new Vector4(v.x, v.y, v.x, v.x);
		}

		public static Vector4 yyxx(this Vector3Int v)
		{
			return new Vector4(v.y, v.y, v.x, v.x);
		}

		public static Vector4 zyxx(this Vector3Int v)
		{
			return new Vector4(v.z, v.y, v.x, v.x);
		}

		public static Vector4 xzxx(this Vector3Int v)
		{
			return new Vector4(v.x, v.z, v.x, v.x);
		}

		public static Vector4 yzxx(this Vector3Int v)
		{
			return new Vector4(v.y, v.z, v.x, v.x);
		}

		public static Vector4 zzxx(this Vector3Int v)
		{
			return new Vector4(v.z, v.z, v.x, v.x);
		}

		public static Vector4 xxyx(this Vector3Int v)
		{
			return new Vector4(v.x, v.x, v.y, v.x);
		}

		public static Vector4 yxyx(this Vector3Int v)
		{
			return new Vector4(v.y, v.x, v.y, v.x);
		}

		public static Vector4 zxyx(this Vector3Int v)
		{
			return new Vector4(v.z, v.x, v.y, v.x);
		}

		public static Vector4 xyyx(this Vector3Int v)
		{
			return new Vector4(v.x, v.y, v.y, v.x);
		}

		public static Vector4 yyyx(this Vector3Int v)
		{
			return new Vector4(v.y, v.y, v.y, v.x);
		}

		public static Vector4 zyyx(this Vector3Int v)
		{
			return new Vector4(v.z, v.y, v.y, v.x);
		}

		public static Vector4 xzyx(this Vector3Int v)
		{
			return new Vector4(v.x, v.z, v.y, v.x);
		}

		public static Vector4 yzyx(this Vector3Int v)
		{
			return new Vector4(v.y, v.z, v.y, v.x);
		}

		public static Vector4 zzyx(this Vector3Int v)
		{
			return new Vector4(v.z, v.z, v.y, v.x);
		}

		public static Vector4 xxzx(this Vector3Int v)
		{
			return new Vector4(v.x, v.x, v.z, v.x);
		}

		public static Vector4 yxzx(this Vector3Int v)
		{
			return new Vector4(v.y, v.x, v.z, v.x);
		}

		public static Vector4 zxzx(this Vector3Int v)
		{
			return new Vector4(v.z, v.x, v.z, v.x);
		}

		public static Vector4 xyzx(this Vector3Int v)
		{
			return new Vector4(v.x, v.y, v.z, v.x);
		}

		public static Vector4 yyzx(this Vector3Int v)
		{
			return new Vector4(v.y, v.y, v.z, v.x);
		}

		public static Vector4 zyzx(this Vector3Int v)
		{
			return new Vector4(v.z, v.y, v.z, v.x);
		}

		public static Vector4 xzzx(this Vector3Int v)
		{
			return new Vector4(v.x, v.z, v.z, v.x);
		}

		public static Vector4 yzzx(this Vector3Int v)
		{
			return new Vector4(v.y, v.z, v.z, v.x);
		}

		public static Vector4 zzzx(this Vector3Int v)
		{
			return new Vector4(v.z, v.z, v.z, v.x);
		}

		public static Vector4 xxxy(this Vector3Int v)
		{
			return new Vector4(v.x, v.x, v.x, v.y);
		}

		public static Vector4 yxxy(this Vector3Int v)
		{
			return new Vector4(v.y, v.x, v.x, v.y);
		}

		public static Vector4 zxxy(this Vector3Int v)
		{
			return new Vector4(v.z, v.x, v.x, v.y);
		}

		public static Vector4 xyxy(this Vector3Int v)
		{
			return new Vector4(v.x, v.y, v.x, v.y);
		}

		public static Vector4 yyxy(this Vector3Int v)
		{
			return new Vector4(v.y, v.y, v.x, v.y);
		}

		public static Vector4 zyxy(this Vector3Int v)
		{
			return new Vector4(v.z, v.y, v.x, v.y);
		}

		public static Vector4 xzxy(this Vector3Int v)
		{
			return new Vector4(v.x, v.z, v.x, v.y);
		}

		public static Vector4 yzxy(this Vector3Int v)
		{
			return new Vector4(v.y, v.z, v.x, v.y);
		}

		public static Vector4 zzxy(this Vector3Int v)
		{
			return new Vector4(v.z, v.z, v.x, v.y);
		}

		public static Vector4 xxyy(this Vector3Int v)
		{
			return new Vector4(v.x, v.x, v.y, v.y);
		}

		public static Vector4 yxyy(this Vector3Int v)
		{
			return new Vector4(v.y, v.x, v.y, v.y);
		}

		public static Vector4 zxyy(this Vector3Int v)
		{
			return new Vector4(v.z, v.x, v.y, v.y);
		}

		public static Vector4 xyyy(this Vector3Int v)
		{
			return new Vector4(v.x, v.y, v.y, v.y);
		}

		public static Vector4 yyyy(this Vector3Int v)
		{
			return new Vector4(v.y, v.y, v.y, v.y);
		}

		public static Vector4 zyyy(this Vector3Int v)
		{
			return new Vector4(v.z, v.y, v.y, v.y);
		}

		public static Vector4 xzyy(this Vector3Int v)
		{
			return new Vector4(v.x, v.z, v.y, v.y);
		}

		public static Vector4 yzyy(this Vector3Int v)
		{
			return new Vector4(v.y, v.z, v.y, v.y);
		}

		public static Vector4 zzyy(this Vector3Int v)
		{
			return new Vector4(v.z, v.z, v.y, v.y);
		}

		public static Vector4 xxzy(this Vector3Int v)
		{
			return new Vector4(v.x, v.x, v.z, v.y);
		}

		public static Vector4 yxzy(this Vector3Int v)
		{
			return new Vector4(v.y, v.x, v.z, v.y);
		}

		public static Vector4 zxzy(this Vector3Int v)
		{
			return new Vector4(v.z, v.x, v.z, v.y);
		}

		public static Vector4 xyzy(this Vector3Int v)
		{
			return new Vector4(v.x, v.y, v.z, v.y);
		}

		public static Vector4 yyzy(this Vector3Int v)
		{
			return new Vector4(v.y, v.y, v.z, v.y);
		}

		public static Vector4 zyzy(this Vector3Int v)
		{
			return new Vector4(v.z, v.y, v.z, v.y);
		}

		public static Vector4 xzzy(this Vector3Int v)
		{
			return new Vector4(v.x, v.z, v.z, v.y);
		}

		public static Vector4 yzzy(this Vector3Int v)
		{
			return new Vector4(v.y, v.z, v.z, v.y);
		}

		public static Vector4 zzzy(this Vector3Int v)
		{
			return new Vector4(v.z, v.z, v.z, v.y);
		}

		public static Vector4 xxxz(this Vector3Int v)
		{
			return new Vector4(v.x, v.x, v.x, v.z);
		}

		public static Vector4 yxxz(this Vector3Int v)
		{
			return new Vector4(v.y, v.x, v.x, v.z);
		}

		public static Vector4 zxxz(this Vector3Int v)
		{
			return new Vector4(v.z, v.x, v.x, v.z);
		}

		public static Vector4 xyxz(this Vector3Int v)
		{
			return new Vector4(v.x, v.y, v.x, v.z);
		}

		public static Vector4 yyxz(this Vector3Int v)
		{
			return new Vector4(v.y, v.y, v.x, v.z);
		}

		public static Vector4 zyxz(this Vector3Int v)
		{
			return new Vector4(v.z, v.y, v.x, v.z);
		}

		public static Vector4 xzxz(this Vector3Int v)
		{
			return new Vector4(v.x, v.z, v.x, v.z);
		}

		public static Vector4 yzxz(this Vector3Int v)
		{
			return new Vector4(v.y, v.z, v.x, v.z);
		}

		public static Vector4 zzxz(this Vector3Int v)
		{
			return new Vector4(v.z, v.z, v.x, v.z);
		}

		public static Vector4 xxyz(this Vector3Int v)
		{
			return new Vector4(v.x, v.x, v.y, v.z);
		}

		public static Vector4 yxyz(this Vector3Int v)
		{
			return new Vector4(v.y, v.x, v.y, v.z);
		}

		public static Vector4 zxyz(this Vector3Int v)
		{
			return new Vector4(v.z, v.x, v.y, v.z);
		}

		public static Vector4 xyyz(this Vector3Int v)
		{
			return new Vector4(v.x, v.y, v.y, v.z);
		}

		public static Vector4 yyyz(this Vector3Int v)
		{
			return new Vector4(v.y, v.y, v.y, v.z);
		}

		public static Vector4 zyyz(this Vector3Int v)
		{
			return new Vector4(v.z, v.y, v.y, v.z);
		}

		public static Vector4 xzyz(this Vector3Int v)
		{
			return new Vector4(v.x, v.z, v.y, v.z);
		}

		public static Vector4 yzyz(this Vector3Int v)
		{
			return new Vector4(v.y, v.z, v.y, v.z);
		}

		public static Vector4 zzyz(this Vector3Int v)
		{
			return new Vector4(v.z, v.z, v.y, v.z);
		}

		public static Vector4 xxzz(this Vector3Int v)
		{
			return new Vector4(v.x, v.x, v.z, v.z);
		}

		public static Vector4 yxzz(this Vector3Int v)
		{
			return new Vector4(v.y, v.x, v.z, v.z);
		}

		public static Vector4 zxzz(this Vector3Int v)
		{
			return new Vector4(v.z, v.x, v.z, v.z);
		}

		public static Vector4 xyzz(this Vector3Int v)
		{
			return new Vector4(v.x, v.y, v.z, v.z);
		}

		public static Vector4 yyzz(this Vector3Int v)
		{
			return new Vector4(v.y, v.y, v.z, v.z);
		}

		public static Vector4 zyzz(this Vector3Int v)
		{
			return new Vector4(v.z, v.y, v.z, v.z);
		}

		public static Vector4 xzzz(this Vector3Int v)
		{
			return new Vector4(v.x, v.z, v.z, v.z);
		}

		public static Vector4 yzzz(this Vector3Int v)
		{
			return new Vector4(v.y, v.z, v.z, v.z);
		}

		public static Vector4 zzzz(this Vector3Int v)
		{
			return new Vector4(v.z, v.z, v.z, v.z);
		}

#pragma warning restore IDE1006
	}
}

#endif
