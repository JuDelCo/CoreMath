
namespace Ju.Math
{
	public partial struct Matrix3
	{
		public static Matrix3 zero     = new Matrix3(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);
		public static Matrix3 identity = new Matrix3(1f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 1f);

		public static explicit operator Matrix3(Matrix4 m)
		{
			return new Matrix3(m.m00, m.m01, m.m02, m.m10, m.m11, m.m12, m.m20, m.m21, m.m22);
		}

		public static explicit operator Matrix3(Quat q)
		{
			return q.ToMatrix3();
		}

		public Vector3f column0
		{
			get { return new Vector3f(m00, m01, m02); }
		}

		public Vector3f column1
		{
			get { return new Vector3f(m10, m11, m12); }
		}

		public Vector3f column2
		{
			get { return new Vector3f(m20, m21, m22); }
		}

		public Vector3f row0
		{
			get { return new Vector3f(m00, m10, m20); }
		}

		public Vector3f row1
		{
			get { return new Vector3f(m01, m11, m21); }
		}

		public Vector3f row2
		{
			get { return new Vector3f(m02, m12, m22); }
		}

		public static Matrix3 Adjugate(Matrix3 m)
		{
			return new Matrix3(
				(m.m11 * m.m22 - m.m21 * m.m12), (-m.m01 * m.m22 + m.m21 * m.m02), (m.m01 * m.m12 - m.m11 * m.m02),
				(-m.m10 * m.m22 + m.m20 * m.m12), (m.m00 * m.m22 - m.m20 * m.m02), (-m.m00 * m.m12 + m.m10 * m.m02),
				(m.m10 * m.m21 - m.m20 * m.m11), (-m.m00 * m.m21 + m.m20 * m.m01), (m.m00 * m.m11 - m.m10 * m.m01)
			);
		}

		public static float Determinant(Matrix3 m)
		{
			return (
				m.m00 * (m.m11 * m.m22 - m.m21 * m.m12)
				- m.m10 * (m.m01 * m.m22 - m.m21 * m.m02)
				+ m.m20 * (m.m01 * m.m12 - m.m11 * m.m02)
			);
		}

		public static Matrix3 Inverse(Matrix3 m)
		{
			return Adjugate(m) / Determinant(m);
		}

		public static Matrix3 Transpose(Matrix3 m)
		{
			return new Matrix3(
				m.m00, m.m10, m.m20,
				m.m01, m.m11, m.m21,
				m.m02, m.m12, m.m22
			);
		}

		public static Vector2f DecomposeMatrixGetPosition(Matrix3 m)
		{
			return new Vector2f(m.m20, m.m21);
		}

		public static Vector2f DecomposeMatrixGetScale(Matrix3 m)
		{
			return new Vector2f(m.m00, m.m11);
		}

		public static float DecomposeMatrixGetOrientation(Matrix3 m)
		{
			return Math.Atan2(m.m10, m.m00);
		}
	}

	public static class Matrix3Extension
	{
		public static Quat ToQuaternion(this Matrix3 m)
		{
			return new Quat(m);
		}
	}
}
