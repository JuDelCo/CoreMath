
#if UNITY_2018_3_OR_NEWER

using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;
using Vector4 = UnityEngine.Vector4;

namespace Ju.Math
{
	public static class UnityVector3SwizzleExtensions
	{
		public static Vector2 xx(this Vector3 v)
		{
			return new Vector2(v.x, v.x);
		}

		public static Vector2 yx(this Vector3 v)
		{
			return new Vector2(v.y, v.x);
		}

		public static Vector2 zx(this Vector3 v)
		{
			return new Vector2(v.z, v.x);
		}

		public static Vector2 xy(this Vector3 v)
		{
			return new Vector2(v.x, v.y);
		}

		public static Vector2 yy(this Vector3 v)
		{
			return new Vector2(v.y, v.y);
		}

		public static Vector2 zy(this Vector3 v)
		{
			return new Vector2(v.z, v.y);
		}

		public static Vector2 xz(this Vector3 v)
		{
			return new Vector2(v.x, v.z);
		}

		public static Vector2 yz(this Vector3 v)
		{
			return new Vector2(v.y, v.z);
		}

		public static Vector2 zz(this Vector3 v)
		{
			return new Vector2(v.z, v.z);
		}

		public static Vector3 xxx(this Vector3 v)
		{
			return new Vector3(v.x, v.x, v.x);
		}

		public static Vector3 yxx(this Vector3 v)
		{
			return new Vector3(v.y, v.x, v.x);
		}

		public static Vector3 zxx(this Vector3 v)
		{
			return new Vector3(v.z, v.x, v.x);
		}

		public static Vector3 xyx(this Vector3 v)
		{
			return new Vector3(v.x, v.y, v.x);
		}

		public static Vector3 yyx(this Vector3 v)
		{
			return new Vector3(v.y, v.y, v.x);
		}

		public static Vector3 zyx(this Vector3 v)
		{
			return new Vector3(v.z, v.y, v.x);
		}

		public static Vector3 xzx(this Vector3 v)
		{
			return new Vector3(v.x, v.z, v.x);
		}

		public static Vector3 yzx(this Vector3 v)
		{
			return new Vector3(v.y, v.z, v.x);
		}

		public static Vector3 zzx(this Vector3 v)
		{
			return new Vector3(v.z, v.z, v.x);
		}

		public static Vector3 xxy(this Vector3 v)
		{
			return new Vector3(v.x, v.x, v.y);
		}

		public static Vector3 yxy(this Vector3 v)
		{
			return new Vector3(v.y, v.x, v.y);
		}

		public static Vector3 zxy(this Vector3 v)
		{
			return new Vector3(v.z, v.x, v.y);
		}

		public static Vector3 xyy(this Vector3 v)
		{
			return new Vector3(v.x, v.y, v.y);
		}

		public static Vector3 yyy(this Vector3 v)
		{
			return new Vector3(v.y, v.y, v.y);
		}

		public static Vector3 zyy(this Vector3 v)
		{
			return new Vector3(v.z, v.y, v.y);
		}

		public static Vector3 xzy(this Vector3 v)
		{
			return new Vector3(v.x, v.z, v.y);
		}

		public static Vector3 yzy(this Vector3 v)
		{
			return new Vector3(v.y, v.z, v.y);
		}

		public static Vector3 zzy(this Vector3 v)
		{
			return new Vector3(v.z, v.z, v.y);
		}

		public static Vector3 xxz(this Vector3 v)
		{
			return new Vector3(v.x, v.x, v.z);
		}

		public static Vector3 yxz(this Vector3 v)
		{
			return new Vector3(v.y, v.x, v.z);
		}

		public static Vector3 zxz(this Vector3 v)
		{
			return new Vector3(v.z, v.x, v.z);
		}

		public static Vector3 xyz(this Vector3 v)
		{
			return new Vector3(v.x, v.y, v.z);
		}

		public static Vector3 yyz(this Vector3 v)
		{
			return new Vector3(v.y, v.y, v.z);
		}

		public static Vector3 zyz(this Vector3 v)
		{
			return new Vector3(v.z, v.y, v.z);
		}

		public static Vector3 xzz(this Vector3 v)
		{
			return new Vector3(v.x, v.z, v.z);
		}

		public static Vector3 yzz(this Vector3 v)
		{
			return new Vector3(v.y, v.z, v.z);
		}

		public static Vector3 zzz(this Vector3 v)
		{
			return new Vector3(v.z, v.z, v.z);
		}

		public static Vector4 xxxx(this Vector3 v)
		{
			return new Vector4(v.x, v.x, v.x, v.x);
		}

		public static Vector4 yxxx(this Vector3 v)
		{
			return new Vector4(v.y, v.x, v.x, v.x);
		}

		public static Vector4 zxxx(this Vector3 v)
		{
			return new Vector4(v.z, v.x, v.x, v.x);
		}

		public static Vector4 xyxx(this Vector3 v)
		{
			return new Vector4(v.x, v.y, v.x, v.x);
		}

		public static Vector4 yyxx(this Vector3 v)
		{
			return new Vector4(v.y, v.y, v.x, v.x);
		}

		public static Vector4 zyxx(this Vector3 v)
		{
			return new Vector4(v.z, v.y, v.x, v.x);
		}

		public static Vector4 xzxx(this Vector3 v)
		{
			return new Vector4(v.x, v.z, v.x, v.x);
		}

		public static Vector4 yzxx(this Vector3 v)
		{
			return new Vector4(v.y, v.z, v.x, v.x);
		}

		public static Vector4 zzxx(this Vector3 v)
		{
			return new Vector4(v.z, v.z, v.x, v.x);
		}

		public static Vector4 xxyx(this Vector3 v)
		{
			return new Vector4(v.x, v.x, v.y, v.x);
		}

		public static Vector4 yxyx(this Vector3 v)
		{
			return new Vector4(v.y, v.x, v.y, v.x);
		}

		public static Vector4 zxyx(this Vector3 v)
		{
			return new Vector4(v.z, v.x, v.y, v.x);
		}

		public static Vector4 xyyx(this Vector3 v)
		{
			return new Vector4(v.x, v.y, v.y, v.x);
		}

		public static Vector4 yyyx(this Vector3 v)
		{
			return new Vector4(v.y, v.y, v.y, v.x);
		}

		public static Vector4 zyyx(this Vector3 v)
		{
			return new Vector4(v.z, v.y, v.y, v.x);
		}

		public static Vector4 xzyx(this Vector3 v)
		{
			return new Vector4(v.x, v.z, v.y, v.x);
		}

		public static Vector4 yzyx(this Vector3 v)
		{
			return new Vector4(v.y, v.z, v.y, v.x);
		}

		public static Vector4 zzyx(this Vector3 v)
		{
			return new Vector4(v.z, v.z, v.y, v.x);
		}

		public static Vector4 xxzx(this Vector3 v)
		{
			return new Vector4(v.x, v.x, v.z, v.x);
		}

		public static Vector4 yxzx(this Vector3 v)
		{
			return new Vector4(v.y, v.x, v.z, v.x);
		}

		public static Vector4 zxzx(this Vector3 v)
		{
			return new Vector4(v.z, v.x, v.z, v.x);
		}

		public static Vector4 xyzx(this Vector3 v)
		{
			return new Vector4(v.x, v.y, v.z, v.x);
		}

		public static Vector4 yyzx(this Vector3 v)
		{
			return new Vector4(v.y, v.y, v.z, v.x);
		}

		public static Vector4 zyzx(this Vector3 v)
		{
			return new Vector4(v.z, v.y, v.z, v.x);
		}

		public static Vector4 xzzx(this Vector3 v)
		{
			return new Vector4(v.x, v.z, v.z, v.x);
		}

		public static Vector4 yzzx(this Vector3 v)
		{
			return new Vector4(v.y, v.z, v.z, v.x);
		}

		public static Vector4 zzzx(this Vector3 v)
		{
			return new Vector4(v.z, v.z, v.z, v.x);
		}

		public static Vector4 xxxy(this Vector3 v)
		{
			return new Vector4(v.x, v.x, v.x, v.y);
		}

		public static Vector4 yxxy(this Vector3 v)
		{
			return new Vector4(v.y, v.x, v.x, v.y);
		}

		public static Vector4 zxxy(this Vector3 v)
		{
			return new Vector4(v.z, v.x, v.x, v.y);
		}

		public static Vector4 xyxy(this Vector3 v)
		{
			return new Vector4(v.x, v.y, v.x, v.y);
		}

		public static Vector4 yyxy(this Vector3 v)
		{
			return new Vector4(v.y, v.y, v.x, v.y);
		}

		public static Vector4 zyxy(this Vector3 v)
		{
			return new Vector4(v.z, v.y, v.x, v.y);
		}

		public static Vector4 xzxy(this Vector3 v)
		{
			return new Vector4(v.x, v.z, v.x, v.y);
		}

		public static Vector4 yzxy(this Vector3 v)
		{
			return new Vector4(v.y, v.z, v.x, v.y);
		}

		public static Vector4 zzxy(this Vector3 v)
		{
			return new Vector4(v.z, v.z, v.x, v.y);
		}

		public static Vector4 xxyy(this Vector3 v)
		{
			return new Vector4(v.x, v.x, v.y, v.y);
		}

		public static Vector4 yxyy(this Vector3 v)
		{
			return new Vector4(v.y, v.x, v.y, v.y);
		}

		public static Vector4 zxyy(this Vector3 v)
		{
			return new Vector4(v.z, v.x, v.y, v.y);
		}

		public static Vector4 xyyy(this Vector3 v)
		{
			return new Vector4(v.x, v.y, v.y, v.y);
		}

		public static Vector4 yyyy(this Vector3 v)
		{
			return new Vector4(v.y, v.y, v.y, v.y);
		}

		public static Vector4 zyyy(this Vector3 v)
		{
			return new Vector4(v.z, v.y, v.y, v.y);
		}

		public static Vector4 xzyy(this Vector3 v)
		{
			return new Vector4(v.x, v.z, v.y, v.y);
		}

		public static Vector4 yzyy(this Vector3 v)
		{
			return new Vector4(v.y, v.z, v.y, v.y);
		}

		public static Vector4 zzyy(this Vector3 v)
		{
			return new Vector4(v.z, v.z, v.y, v.y);
		}

		public static Vector4 xxzy(this Vector3 v)
		{
			return new Vector4(v.x, v.x, v.z, v.y);
		}

		public static Vector4 yxzy(this Vector3 v)
		{
			return new Vector4(v.y, v.x, v.z, v.y);
		}

		public static Vector4 zxzy(this Vector3 v)
		{
			return new Vector4(v.z, v.x, v.z, v.y);
		}

		public static Vector4 xyzy(this Vector3 v)
		{
			return new Vector4(v.x, v.y, v.z, v.y);
		}

		public static Vector4 yyzy(this Vector3 v)
		{
			return new Vector4(v.y, v.y, v.z, v.y);
		}

		public static Vector4 zyzy(this Vector3 v)
		{
			return new Vector4(v.z, v.y, v.z, v.y);
		}

		public static Vector4 xzzy(this Vector3 v)
		{
			return new Vector4(v.x, v.z, v.z, v.y);
		}

		public static Vector4 yzzy(this Vector3 v)
		{
			return new Vector4(v.y, v.z, v.z, v.y);
		}

		public static Vector4 zzzy(this Vector3 v)
		{
			return new Vector4(v.z, v.z, v.z, v.y);
		}

		public static Vector4 xxxz(this Vector3 v)
		{
			return new Vector4(v.x, v.x, v.x, v.z);
		}

		public static Vector4 yxxz(this Vector3 v)
		{
			return new Vector4(v.y, v.x, v.x, v.z);
		}

		public static Vector4 zxxz(this Vector3 v)
		{
			return new Vector4(v.z, v.x, v.x, v.z);
		}

		public static Vector4 xyxz(this Vector3 v)
		{
			return new Vector4(v.x, v.y, v.x, v.z);
		}

		public static Vector4 yyxz(this Vector3 v)
		{
			return new Vector4(v.y, v.y, v.x, v.z);
		}

		public static Vector4 zyxz(this Vector3 v)
		{
			return new Vector4(v.z, v.y, v.x, v.z);
		}

		public static Vector4 xzxz(this Vector3 v)
		{
			return new Vector4(v.x, v.z, v.x, v.z);
		}

		public static Vector4 yzxz(this Vector3 v)
		{
			return new Vector4(v.y, v.z, v.x, v.z);
		}

		public static Vector4 zzxz(this Vector3 v)
		{
			return new Vector4(v.z, v.z, v.x, v.z);
		}

		public static Vector4 xxyz(this Vector3 v)
		{
			return new Vector4(v.x, v.x, v.y, v.z);
		}

		public static Vector4 yxyz(this Vector3 v)
		{
			return new Vector4(v.y, v.x, v.y, v.z);
		}

		public static Vector4 zxyz(this Vector3 v)
		{
			return new Vector4(v.z, v.x, v.y, v.z);
		}

		public static Vector4 xyyz(this Vector3 v)
		{
			return new Vector4(v.x, v.y, v.y, v.z);
		}

		public static Vector4 yyyz(this Vector3 v)
		{
			return new Vector4(v.y, v.y, v.y, v.z);
		}

		public static Vector4 zyyz(this Vector3 v)
		{
			return new Vector4(v.z, v.y, v.y, v.z);
		}

		public static Vector4 xzyz(this Vector3 v)
		{
			return new Vector4(v.x, v.z, v.y, v.z);
		}

		public static Vector4 yzyz(this Vector3 v)
		{
			return new Vector4(v.y, v.z, v.y, v.z);
		}

		public static Vector4 zzyz(this Vector3 v)
		{
			return new Vector4(v.z, v.z, v.y, v.z);
		}

		public static Vector4 xxzz(this Vector3 v)
		{
			return new Vector4(v.x, v.x, v.z, v.z);
		}

		public static Vector4 yxzz(this Vector3 v)
		{
			return new Vector4(v.y, v.x, v.z, v.z);
		}

		public static Vector4 zxzz(this Vector3 v)
		{
			return new Vector4(v.z, v.x, v.z, v.z);
		}

		public static Vector4 xyzz(this Vector3 v)
		{
			return new Vector4(v.x, v.y, v.z, v.z);
		}

		public static Vector4 yyzz(this Vector3 v)
		{
			return new Vector4(v.y, v.y, v.z, v.z);
		}

		public static Vector4 zyzz(this Vector3 v)
		{
			return new Vector4(v.z, v.y, v.z, v.z);
		}

		public static Vector4 xzzz(this Vector3 v)
		{
			return new Vector4(v.x, v.z, v.z, v.z);
		}

		public static Vector4 yzzz(this Vector3 v)
		{
			return new Vector4(v.y, v.z, v.z, v.z);
		}

		public static Vector4 zzzz(this Vector3 v)
		{
			return new Vector4(v.z, v.z, v.z, v.z);
		}
	}
}

#endif
