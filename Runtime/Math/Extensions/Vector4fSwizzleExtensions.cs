
namespace Ju.Math
{
	public static class Vector4fSwizzleExtensions
	{
#pragma warning disable IDE1006

		public static Vector2f xx(this Vector4f v)
		{
			return new Vector2f(v.x, v.x);
		}

		public static Vector2f yx(this Vector4f v)
		{
			return new Vector2f(v.y, v.x);
		}

		public static Vector2f zx(this Vector4f v)
		{
			return new Vector2f(v.z, v.x);
		}

		public static Vector2f wx(this Vector4f v)
		{
			return new Vector2f(v.w, v.x);
		}

		public static Vector2f xy(this Vector4f v)
		{
			return new Vector2f(v.x, v.y);
		}

		public static Vector2f yy(this Vector4f v)
		{
			return new Vector2f(v.y, v.y);
		}

		public static Vector2f zy(this Vector4f v)
		{
			return new Vector2f(v.z, v.y);
		}

		public static Vector2f wy(this Vector4f v)
		{
			return new Vector2f(v.w, v.y);
		}

		public static Vector2f xz(this Vector4f v)
		{
			return new Vector2f(v.x, v.z);
		}

		public static Vector2f yz(this Vector4f v)
		{
			return new Vector2f(v.y, v.z);
		}

		public static Vector2f zz(this Vector4f v)
		{
			return new Vector2f(v.z, v.z);
		}

		public static Vector2f wz(this Vector4f v)
		{
			return new Vector2f(v.w, v.z);
		}

		public static Vector2f xw(this Vector4f v)
		{
			return new Vector2f(v.x, v.w);
		}

		public static Vector2f yw(this Vector4f v)
		{
			return new Vector2f(v.y, v.w);
		}

		public static Vector2f zw(this Vector4f v)
		{
			return new Vector2f(v.z, v.w);
		}

		public static Vector2f ww(this Vector4f v)
		{
			return new Vector2f(v.w, v.w);
		}

		public static Vector3f xxx(this Vector4f v)
		{
			return new Vector3f(v.x, v.x, v.x);
		}

		public static Vector3f yxx(this Vector4f v)
		{
			return new Vector3f(v.y, v.x, v.x);
		}

		public static Vector3f zxx(this Vector4f v)
		{
			return new Vector3f(v.z, v.x, v.x);
		}

		public static Vector3f wxx(this Vector4f v)
		{
			return new Vector3f(v.w, v.x, v.x);
		}

		public static Vector3f xyx(this Vector4f v)
		{
			return new Vector3f(v.x, v.y, v.x);
		}

		public static Vector3f yyx(this Vector4f v)
		{
			return new Vector3f(v.y, v.y, v.x);
		}

		public static Vector3f zyx(this Vector4f v)
		{
			return new Vector3f(v.z, v.y, v.x);
		}

		public static Vector3f wyx(this Vector4f v)
		{
			return new Vector3f(v.w, v.y, v.x);
		}

		public static Vector3f xzx(this Vector4f v)
		{
			return new Vector3f(v.x, v.z, v.x);
		}

		public static Vector3f yzx(this Vector4f v)
		{
			return new Vector3f(v.y, v.z, v.x);
		}

		public static Vector3f zzx(this Vector4f v)
		{
			return new Vector3f(v.z, v.z, v.x);
		}

		public static Vector3f wzx(this Vector4f v)
		{
			return new Vector3f(v.w, v.z, v.x);
		}

		public static Vector3f xwx(this Vector4f v)
		{
			return new Vector3f(v.x, v.w, v.x);
		}

		public static Vector3f ywx(this Vector4f v)
		{
			return new Vector3f(v.y, v.w, v.x);
		}

		public static Vector3f zwx(this Vector4f v)
		{
			return new Vector3f(v.z, v.w, v.x);
		}

		public static Vector3f wwx(this Vector4f v)
		{
			return new Vector3f(v.w, v.w, v.x);
		}

		public static Vector3f xxy(this Vector4f v)
		{
			return new Vector3f(v.x, v.x, v.y);
		}

		public static Vector3f yxy(this Vector4f v)
		{
			return new Vector3f(v.y, v.x, v.y);
		}

		public static Vector3f zxy(this Vector4f v)
		{
			return new Vector3f(v.z, v.x, v.y);
		}

		public static Vector3f wxy(this Vector4f v)
		{
			return new Vector3f(v.w, v.x, v.y);
		}

		public static Vector3f xyy(this Vector4f v)
		{
			return new Vector3f(v.x, v.y, v.y);
		}

		public static Vector3f yyy(this Vector4f v)
		{
			return new Vector3f(v.y, v.y, v.y);
		}

		public static Vector3f zyy(this Vector4f v)
		{
			return new Vector3f(v.z, v.y, v.y);
		}

		public static Vector3f wyy(this Vector4f v)
		{
			return new Vector3f(v.w, v.y, v.y);
		}

		public static Vector3f xzy(this Vector4f v)
		{
			return new Vector3f(v.x, v.z, v.y);
		}

		public static Vector3f yzy(this Vector4f v)
		{
			return new Vector3f(v.y, v.z, v.y);
		}

		public static Vector3f zzy(this Vector4f v)
		{
			return new Vector3f(v.z, v.z, v.y);
		}

		public static Vector3f wzy(this Vector4f v)
		{
			return new Vector3f(v.w, v.z, v.y);
		}

		public static Vector3f xwy(this Vector4f v)
		{
			return new Vector3f(v.x, v.w, v.y);
		}

		public static Vector3f ywy(this Vector4f v)
		{
			return new Vector3f(v.y, v.w, v.y);
		}

		public static Vector3f zwy(this Vector4f v)
		{
			return new Vector3f(v.z, v.w, v.y);
		}

		public static Vector3f wwy(this Vector4f v)
		{
			return new Vector3f(v.w, v.w, v.y);
		}

		public static Vector3f xxz(this Vector4f v)
		{
			return new Vector3f(v.x, v.x, v.z);
		}

		public static Vector3f yxz(this Vector4f v)
		{
			return new Vector3f(v.y, v.x, v.z);
		}

		public static Vector3f zxz(this Vector4f v)
		{
			return new Vector3f(v.z, v.x, v.z);
		}

		public static Vector3f wxz(this Vector4f v)
		{
			return new Vector3f(v.w, v.x, v.z);
		}

		public static Vector3f xyz(this Vector4f v)
		{
			return new Vector3f(v.x, v.y, v.z);
		}

		public static Vector3f yyz(this Vector4f v)
		{
			return new Vector3f(v.y, v.y, v.z);
		}

		public static Vector3f zyz(this Vector4f v)
		{
			return new Vector3f(v.z, v.y, v.z);
		}

		public static Vector3f wyz(this Vector4f v)
		{
			return new Vector3f(v.w, v.y, v.z);
		}

		public static Vector3f xzz(this Vector4f v)
		{
			return new Vector3f(v.x, v.z, v.z);
		}

		public static Vector3f yzz(this Vector4f v)
		{
			return new Vector3f(v.y, v.z, v.z);
		}

		public static Vector3f zzz(this Vector4f v)
		{
			return new Vector3f(v.z, v.z, v.z);
		}

		public static Vector3f wzz(this Vector4f v)
		{
			return new Vector3f(v.w, v.z, v.z);
		}

		public static Vector3f xwz(this Vector4f v)
		{
			return new Vector3f(v.x, v.w, v.z);
		}

		public static Vector3f ywz(this Vector4f v)
		{
			return new Vector3f(v.y, v.w, v.z);
		}

		public static Vector3f zwz(this Vector4f v)
		{
			return new Vector3f(v.z, v.w, v.z);
		}

		public static Vector3f wwz(this Vector4f v)
		{
			return new Vector3f(v.w, v.w, v.z);
		}

		public static Vector3f xxw(this Vector4f v)
		{
			return new Vector3f(v.x, v.x, v.w);
		}

		public static Vector3f yxw(this Vector4f v)
		{
			return new Vector3f(v.y, v.x, v.w);
		}

		public static Vector3f zxw(this Vector4f v)
		{
			return new Vector3f(v.z, v.x, v.w);
		}

		public static Vector3f wxw(this Vector4f v)
		{
			return new Vector3f(v.w, v.x, v.w);
		}

		public static Vector3f xyw(this Vector4f v)
		{
			return new Vector3f(v.x, v.y, v.w);
		}

		public static Vector3f yyw(this Vector4f v)
		{
			return new Vector3f(v.y, v.y, v.w);
		}

		public static Vector3f zyw(this Vector4f v)
		{
			return new Vector3f(v.z, v.y, v.w);
		}

		public static Vector3f wyw(this Vector4f v)
		{
			return new Vector3f(v.w, v.y, v.w);
		}

		public static Vector3f xzw(this Vector4f v)
		{
			return new Vector3f(v.x, v.z, v.w);
		}

		public static Vector3f yzw(this Vector4f v)
		{
			return new Vector3f(v.y, v.z, v.w);
		}

		public static Vector3f zzw(this Vector4f v)
		{
			return new Vector3f(v.z, v.z, v.w);
		}

		public static Vector3f wzw(this Vector4f v)
		{
			return new Vector3f(v.w, v.z, v.w);
		}

		public static Vector3f xww(this Vector4f v)
		{
			return new Vector3f(v.x, v.w, v.w);
		}

		public static Vector3f yww(this Vector4f v)
		{
			return new Vector3f(v.y, v.w, v.w);
		}

		public static Vector3f zww(this Vector4f v)
		{
			return new Vector3f(v.z, v.w, v.w);
		}

		public static Vector3f www(this Vector4f v)
		{
			return new Vector3f(v.w, v.w, v.w);
		}

		public static Vector4f xxxx(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.x, v.x);
		}

		public static Vector4f yxxx(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.x, v.x);
		}

		public static Vector4f zxxx(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.x, v.x);
		}

		public static Vector4f wxxx(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.x, v.x);
		}

		public static Vector4f xyxx(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.x, v.x);
		}

		public static Vector4f yyxx(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.x, v.x);
		}

		public static Vector4f zyxx(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.x, v.x);
		}

		public static Vector4f wyxx(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.x, v.x);
		}

		public static Vector4f xzxx(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.x, v.x);
		}

		public static Vector4f yzxx(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.x, v.x);
		}

		public static Vector4f zzxx(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.x, v.x);
		}

		public static Vector4f wzxx(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.x, v.x);
		}

		public static Vector4f xwxx(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.x, v.x);
		}

		public static Vector4f ywxx(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.x, v.x);
		}

		public static Vector4f zwxx(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.x, v.x);
		}

		public static Vector4f wwxx(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.x, v.x);
		}

		public static Vector4f xxyx(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.y, v.x);
		}

		public static Vector4f yxyx(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.y, v.x);
		}

		public static Vector4f zxyx(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.y, v.x);
		}

		public static Vector4f wxyx(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.y, v.x);
		}

		public static Vector4f xyyx(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.y, v.x);
		}

		public static Vector4f yyyx(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.y, v.x);
		}

		public static Vector4f zyyx(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.y, v.x);
		}

		public static Vector4f wyyx(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.y, v.x);
		}

		public static Vector4f xzyx(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.y, v.x);
		}

		public static Vector4f yzyx(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.y, v.x);
		}

		public static Vector4f zzyx(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.y, v.x);
		}

		public static Vector4f wzyx(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.y, v.x);
		}

		public static Vector4f xwyx(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.y, v.x);
		}

		public static Vector4f ywyx(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.y, v.x);
		}

		public static Vector4f zwyx(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.y, v.x);
		}

		public static Vector4f wwyx(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.y, v.x);
		}

		public static Vector4f xxzx(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.z, v.x);
		}

		public static Vector4f yxzx(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.z, v.x);
		}

		public static Vector4f zxzx(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.z, v.x);
		}

		public static Vector4f wxzx(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.z, v.x);
		}

		public static Vector4f xyzx(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.z, v.x);
		}

		public static Vector4f yyzx(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.z, v.x);
		}

		public static Vector4f zyzx(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.z, v.x);
		}

		public static Vector4f wyzx(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.z, v.x);
		}

		public static Vector4f xzzx(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.z, v.x);
		}

		public static Vector4f yzzx(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.z, v.x);
		}

		public static Vector4f zzzx(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.z, v.x);
		}

		public static Vector4f wzzx(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.z, v.x);
		}

		public static Vector4f xwzx(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.z, v.x);
		}

		public static Vector4f ywzx(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.z, v.x);
		}

		public static Vector4f zwzx(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.z, v.x);
		}

		public static Vector4f wwzx(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.z, v.x);
		}

		public static Vector4f xxwx(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.w, v.x);
		}

		public static Vector4f yxwx(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.w, v.x);
		}

		public static Vector4f zxwx(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.w, v.x);
		}

		public static Vector4f wxwx(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.w, v.x);
		}

		public static Vector4f xywx(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.w, v.x);
		}

		public static Vector4f yywx(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.w, v.x);
		}

		public static Vector4f zywx(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.w, v.x);
		}

		public static Vector4f wywx(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.w, v.x);
		}

		public static Vector4f xzwx(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.w, v.x);
		}

		public static Vector4f yzwx(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.w, v.x);
		}

		public static Vector4f zzwx(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.w, v.x);
		}

		public static Vector4f wzwx(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.w, v.x);
		}

		public static Vector4f xwwx(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.w, v.x);
		}

		public static Vector4f ywwx(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.w, v.x);
		}

		public static Vector4f zwwx(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.w, v.x);
		}

		public static Vector4f wwwx(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.w, v.x);
		}

		public static Vector4f xxxy(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.x, v.y);
		}

		public static Vector4f yxxy(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.x, v.y);
		}

		public static Vector4f zxxy(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.x, v.y);
		}

		public static Vector4f wxxy(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.x, v.y);
		}

		public static Vector4f xyxy(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.x, v.y);
		}

		public static Vector4f yyxy(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.x, v.y);
		}

		public static Vector4f zyxy(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.x, v.y);
		}

		public static Vector4f wyxy(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.x, v.y);
		}

		public static Vector4f xzxy(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.x, v.y);
		}

		public static Vector4f yzxy(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.x, v.y);
		}

		public static Vector4f zzxy(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.x, v.y);
		}

		public static Vector4f wzxy(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.x, v.y);
		}

		public static Vector4f xwxy(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.x, v.y);
		}

		public static Vector4f ywxy(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.x, v.y);
		}

		public static Vector4f zwxy(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.x, v.y);
		}

		public static Vector4f wwxy(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.x, v.y);
		}

		public static Vector4f xxyy(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.y, v.y);
		}

		public static Vector4f yxyy(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.y, v.y);
		}

		public static Vector4f zxyy(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.y, v.y);
		}

		public static Vector4f wxyy(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.y, v.y);
		}

		public static Vector4f xyyy(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.y, v.y);
		}

		public static Vector4f yyyy(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.y, v.y);
		}

		public static Vector4f zyyy(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.y, v.y);
		}

		public static Vector4f wyyy(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.y, v.y);
		}

		public static Vector4f xzyy(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.y, v.y);
		}

		public static Vector4f yzyy(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.y, v.y);
		}

		public static Vector4f zzyy(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.y, v.y);
		}

		public static Vector4f wzyy(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.y, v.y);
		}

		public static Vector4f xwyy(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.y, v.y);
		}

		public static Vector4f ywyy(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.y, v.y);
		}

		public static Vector4f zwyy(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.y, v.y);
		}

		public static Vector4f wwyy(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.y, v.y);
		}

		public static Vector4f xxzy(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.z, v.y);
		}

		public static Vector4f yxzy(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.z, v.y);
		}

		public static Vector4f zxzy(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.z, v.y);
		}

		public static Vector4f wxzy(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.z, v.y);
		}

		public static Vector4f xyzy(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.z, v.y);
		}

		public static Vector4f yyzy(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.z, v.y);
		}

		public static Vector4f zyzy(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.z, v.y);
		}

		public static Vector4f wyzy(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.z, v.y);
		}

		public static Vector4f xzzy(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.z, v.y);
		}

		public static Vector4f yzzy(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.z, v.y);
		}

		public static Vector4f zzzy(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.z, v.y);
		}

		public static Vector4f wzzy(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.z, v.y);
		}

		public static Vector4f xwzy(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.z, v.y);
		}

		public static Vector4f ywzy(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.z, v.y);
		}

		public static Vector4f zwzy(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.z, v.y);
		}

		public static Vector4f wwzy(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.z, v.y);
		}

		public static Vector4f xxwy(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.w, v.y);
		}

		public static Vector4f yxwy(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.w, v.y);
		}

		public static Vector4f zxwy(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.w, v.y);
		}

		public static Vector4f wxwy(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.w, v.y);
		}

		public static Vector4f xywy(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.w, v.y);
		}

		public static Vector4f yywy(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.w, v.y);
		}

		public static Vector4f zywy(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.w, v.y);
		}

		public static Vector4f wywy(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.w, v.y);
		}

		public static Vector4f xzwy(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.w, v.y);
		}

		public static Vector4f yzwy(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.w, v.y);
		}

		public static Vector4f zzwy(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.w, v.y);
		}

		public static Vector4f wzwy(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.w, v.y);
		}

		public static Vector4f xwwy(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.w, v.y);
		}

		public static Vector4f ywwy(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.w, v.y);
		}

		public static Vector4f zwwy(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.w, v.y);
		}

		public static Vector4f wwwy(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.w, v.y);
		}

		public static Vector4f xxxz(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.x, v.z);
		}

		public static Vector4f yxxz(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.x, v.z);
		}

		public static Vector4f zxxz(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.x, v.z);
		}

		public static Vector4f wxxz(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.x, v.z);
		}

		public static Vector4f xyxz(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.x, v.z);
		}

		public static Vector4f yyxz(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.x, v.z);
		}

		public static Vector4f zyxz(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.x, v.z);
		}

		public static Vector4f wyxz(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.x, v.z);
		}

		public static Vector4f xzxz(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.x, v.z);
		}

		public static Vector4f yzxz(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.x, v.z);
		}

		public static Vector4f zzxz(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.x, v.z);
		}

		public static Vector4f wzxz(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.x, v.z);
		}

		public static Vector4f xwxz(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.x, v.z);
		}

		public static Vector4f ywxz(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.x, v.z);
		}

		public static Vector4f zwxz(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.x, v.z);
		}

		public static Vector4f wwxz(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.x, v.z);
		}

		public static Vector4f xxyz(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.y, v.z);
		}

		public static Vector4f yxyz(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.y, v.z);
		}

		public static Vector4f zxyz(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.y, v.z);
		}

		public static Vector4f wxyz(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.y, v.z);
		}

		public static Vector4f xyyz(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.y, v.z);
		}

		public static Vector4f yyyz(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.y, v.z);
		}

		public static Vector4f zyyz(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.y, v.z);
		}

		public static Vector4f wyyz(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.y, v.z);
		}

		public static Vector4f xzyz(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.y, v.z);
		}

		public static Vector4f yzyz(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.y, v.z);
		}

		public static Vector4f zzyz(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.y, v.z);
		}

		public static Vector4f wzyz(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.y, v.z);
		}

		public static Vector4f xwyz(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.y, v.z);
		}

		public static Vector4f ywyz(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.y, v.z);
		}

		public static Vector4f zwyz(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.y, v.z);
		}

		public static Vector4f wwyz(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.y, v.z);
		}

		public static Vector4f xxzz(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.z, v.z);
		}

		public static Vector4f yxzz(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.z, v.z);
		}

		public static Vector4f zxzz(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.z, v.z);
		}

		public static Vector4f wxzz(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.z, v.z);
		}

		public static Vector4f xyzz(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.z, v.z);
		}

		public static Vector4f yyzz(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.z, v.z);
		}

		public static Vector4f zyzz(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.z, v.z);
		}

		public static Vector4f wyzz(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.z, v.z);
		}

		public static Vector4f xzzz(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.z, v.z);
		}

		public static Vector4f yzzz(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.z, v.z);
		}

		public static Vector4f zzzz(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.z, v.z);
		}

		public static Vector4f wzzz(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.z, v.z);
		}

		public static Vector4f xwzz(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.z, v.z);
		}

		public static Vector4f ywzz(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.z, v.z);
		}

		public static Vector4f zwzz(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.z, v.z);
		}

		public static Vector4f wwzz(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.z, v.z);
		}

		public static Vector4f xxwz(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.w, v.z);
		}

		public static Vector4f yxwz(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.w, v.z);
		}

		public static Vector4f zxwz(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.w, v.z);
		}

		public static Vector4f wxwz(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.w, v.z);
		}

		public static Vector4f xywz(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.w, v.z);
		}

		public static Vector4f yywz(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.w, v.z);
		}

		public static Vector4f zywz(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.w, v.z);
		}

		public static Vector4f wywz(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.w, v.z);
		}

		public static Vector4f xzwz(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.w, v.z);
		}

		public static Vector4f yzwz(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.w, v.z);
		}

		public static Vector4f zzwz(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.w, v.z);
		}

		public static Vector4f wzwz(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.w, v.z);
		}

		public static Vector4f xwwz(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.w, v.z);
		}

		public static Vector4f ywwz(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.w, v.z);
		}

		public static Vector4f zwwz(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.w, v.z);
		}

		public static Vector4f wwwz(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.w, v.z);
		}

		public static Vector4f xxxw(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.x, v.w);
		}

		public static Vector4f yxxw(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.x, v.w);
		}

		public static Vector4f zxxw(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.x, v.w);
		}

		public static Vector4f wxxw(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.x, v.w);
		}

		public static Vector4f xyxw(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.x, v.w);
		}

		public static Vector4f yyxw(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.x, v.w);
		}

		public static Vector4f zyxw(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.x, v.w);
		}

		public static Vector4f wyxw(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.x, v.w);
		}

		public static Vector4f xzxw(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.x, v.w);
		}

		public static Vector4f yzxw(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.x, v.w);
		}

		public static Vector4f zzxw(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.x, v.w);
		}

		public static Vector4f wzxw(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.x, v.w);
		}

		public static Vector4f xwxw(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.x, v.w);
		}

		public static Vector4f ywxw(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.x, v.w);
		}

		public static Vector4f zwxw(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.x, v.w);
		}

		public static Vector4f wwxw(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.x, v.w);
		}

		public static Vector4f xxyw(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.y, v.w);
		}

		public static Vector4f yxyw(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.y, v.w);
		}

		public static Vector4f zxyw(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.y, v.w);
		}

		public static Vector4f wxyw(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.y, v.w);
		}

		public static Vector4f xyyw(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.y, v.w);
		}

		public static Vector4f yyyw(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.y, v.w);
		}

		public static Vector4f zyyw(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.y, v.w);
		}

		public static Vector4f wyyw(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.y, v.w);
		}

		public static Vector4f xzyw(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.y, v.w);
		}

		public static Vector4f yzyw(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.y, v.w);
		}

		public static Vector4f zzyw(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.y, v.w);
		}

		public static Vector4f wzyw(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.y, v.w);
		}

		public static Vector4f xwyw(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.y, v.w);
		}

		public static Vector4f ywyw(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.y, v.w);
		}

		public static Vector4f zwyw(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.y, v.w);
		}

		public static Vector4f wwyw(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.y, v.w);
		}

		public static Vector4f xxzw(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.z, v.w);
		}

		public static Vector4f yxzw(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.z, v.w);
		}

		public static Vector4f zxzw(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.z, v.w);
		}

		public static Vector4f wxzw(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.z, v.w);
		}

		public static Vector4f xyzw(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.z, v.w);
		}

		public static Vector4f yyzw(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.z, v.w);
		}

		public static Vector4f zyzw(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.z, v.w);
		}

		public static Vector4f wyzw(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.z, v.w);
		}

		public static Vector4f xzzw(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.z, v.w);
		}

		public static Vector4f yzzw(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.z, v.w);
		}

		public static Vector4f zzzw(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.z, v.w);
		}

		public static Vector4f wzzw(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.z, v.w);
		}

		public static Vector4f xwzw(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.z, v.w);
		}

		public static Vector4f ywzw(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.z, v.w);
		}

		public static Vector4f zwzw(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.z, v.w);
		}

		public static Vector4f wwzw(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.z, v.w);
		}

		public static Vector4f xxww(this Vector4f v)
		{
			return new Vector4f(v.x, v.x, v.w, v.w);
		}

		public static Vector4f yxww(this Vector4f v)
		{
			return new Vector4f(v.y, v.x, v.w, v.w);
		}

		public static Vector4f zxww(this Vector4f v)
		{
			return new Vector4f(v.z, v.x, v.w, v.w);
		}

		public static Vector4f wxww(this Vector4f v)
		{
			return new Vector4f(v.w, v.x, v.w, v.w);
		}

		public static Vector4f xyww(this Vector4f v)
		{
			return new Vector4f(v.x, v.y, v.w, v.w);
		}

		public static Vector4f yyww(this Vector4f v)
		{
			return new Vector4f(v.y, v.y, v.w, v.w);
		}

		public static Vector4f zyww(this Vector4f v)
		{
			return new Vector4f(v.z, v.y, v.w, v.w);
		}

		public static Vector4f wyww(this Vector4f v)
		{
			return new Vector4f(v.w, v.y, v.w, v.w);
		}

		public static Vector4f xzww(this Vector4f v)
		{
			return new Vector4f(v.x, v.z, v.w, v.w);
		}

		public static Vector4f yzww(this Vector4f v)
		{
			return new Vector4f(v.y, v.z, v.w, v.w);
		}

		public static Vector4f zzww(this Vector4f v)
		{
			return new Vector4f(v.z, v.z, v.w, v.w);
		}

		public static Vector4f wzww(this Vector4f v)
		{
			return new Vector4f(v.w, v.z, v.w, v.w);
		}

		public static Vector4f xwww(this Vector4f v)
		{
			return new Vector4f(v.x, v.w, v.w, v.w);
		}

		public static Vector4f ywww(this Vector4f v)
		{
			return new Vector4f(v.y, v.w, v.w, v.w);
		}

		public static Vector4f zwww(this Vector4f v)
		{
			return new Vector4f(v.z, v.w, v.w, v.w);
		}

		public static Vector4f wwww(this Vector4f v)
		{
			return new Vector4f(v.w, v.w, v.w, v.w);
		}

#pragma warning restore IDE1006
	}
}
