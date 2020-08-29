
namespace Ju.Math
{
	public partial struct Matrix4
	{
		public static Matrix4 zero = new Matrix4(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);
		public static Matrix4 identity = new Matrix4(1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f);

		public static explicit operator Matrix4(Matrix3 m)
		{
			return new Matrix4(m.m00, m.m01, m.m02, 0f, m.m10, m.m11, m.m12, 0f, m.m20, m.m21, m.m22, 0f, 0f, 0f, 0f, 1f);
		}

		public static explicit operator Matrix4(Quat q)
		{
			return q.ToMatrix4();
		}

#pragma warning disable IDE1006

		public Vector4f column0
		{
			get { return new Vector4f(m00, m01, m02, m03); }
		}

		public Vector4f column1
		{
			get { return new Vector4f(m10, m11, m12, m13); }
		}

		public Vector4f column2
		{
			get { return new Vector4f(m20, m21, m22, m23); }
		}

		public Vector4f column3
		{
			get { return new Vector4f(m30, m31, m32, m33); }
		}

		public Vector4f row0
		{
			get { return new Vector4f(m00, m10, m20, m30); }
		}

		public Vector4f row1
		{
			get { return new Vector4f(m01, m11, m21, m31); }
		}

		public Vector4f row2
		{
			get { return new Vector4f(m02, m12, m22, m32); }
		}

		public Vector4f row3
		{
			get { return new Vector4f(m03, m13, m23, m33); }
		}

#pragma warning restore IDE1006

		public static Matrix4 Adjugate(Matrix4 m)
		{
			return new Matrix4(
				(m.m11 * (m.m22 * m.m33 - m.m32 * m.m23) - m.m21 * (m.m12 * m.m33 - m.m32 * m.m13) + m.m31 * (m.m12 * m.m23 - m.m22 * m.m13)),
				(-m.m01 * (m.m22 * m.m33 - m.m32 * m.m23) + m.m21 * (m.m02 * m.m33 - m.m32 * m.m03) - m.m31 * (m.m02 * m.m23 - m.m22 * m.m03)),
				(m.m01 * (m.m12 * m.m33 - m.m32 * m.m13) - m.m11 * (m.m02 * m.m33 - m.m32 * m.m03) + m.m31 * (m.m02 * m.m13 - m.m12 * m.m03)),
				(-m.m01 * (m.m12 * m.m23 - m.m22 * m.m13) + m.m11 * (m.m02 * m.m23 - m.m22 * m.m03) - m.m21 * (m.m02 * m.m13 - m.m12 * m.m03)),
				(-m.m10 * (m.m22 * m.m33 - m.m32 * m.m23) + m.m20 * (m.m12 * m.m33 - m.m32 * m.m13) - m.m30 * (m.m12 * m.m23 - m.m22 * m.m13)),
				(m.m00 * (m.m22 * m.m33 - m.m32 * m.m23) - m.m20 * (m.m02 * m.m33 - m.m32 * m.m03) + m.m30 * (m.m02 * m.m23 - m.m22 * m.m03)),
				(-m.m00 * (m.m12 * m.m33 - m.m32 * m.m13) + m.m10 * (m.m02 * m.m33 - m.m32 * m.m03) - m.m30 * (m.m02 * m.m13 - m.m12 * m.m03)),
				(m.m00 * (m.m12 * m.m23 - m.m22 * m.m13) - m.m10 * (m.m02 * m.m23 - m.m22 * m.m03) + m.m20 * (m.m02 * m.m13 - m.m12 * m.m03)),
				(m.m10 * (m.m21 * m.m33 - m.m31 * m.m23) - m.m20 * (m.m11 * m.m33 - m.m31 * m.m13) + m.m30 * (m.m11 * m.m23 - m.m21 * m.m13)),
				(-m.m00 * (m.m21 * m.m33 - m.m31 * m.m23) + m.m20 * (m.m01 * m.m33 - m.m31 * m.m03) - m.m30 * (m.m01 * m.m23 - m.m21 * m.m03)),
				(m.m00 * (m.m11 * m.m33 - m.m31 * m.m13) - m.m10 * (m.m01 * m.m33 - m.m31 * m.m03) + m.m30 * (m.m01 * m.m13 - m.m11 * m.m03)),
				(-m.m00 * (m.m11 * m.m23 - m.m21 * m.m13) + m.m10 * (m.m01 * m.m23 - m.m21 * m.m03) - m.m20 * (m.m01 * m.m13 - m.m11 * m.m03)),
				(-m.m10 * (m.m21 * m.m32 - m.m31 * m.m22) + m.m20 * (m.m11 * m.m32 - m.m31 * m.m12) - m.m30 * (m.m11 * m.m22 - m.m21 * m.m12)),
				(m.m00 * (m.m21 * m.m32 - m.m31 * m.m22) - m.m20 * (m.m01 * m.m32 - m.m31 * m.m02) + m.m30 * (m.m01 * m.m22 - m.m21 * m.m02)),
				(-m.m00 * (m.m11 * m.m32 - m.m31 * m.m12) + m.m10 * (m.m01 * m.m32 - m.m31 * m.m02) - m.m30 * (m.m01 * m.m12 - m.m11 * m.m02)),
				(m.m00 * (m.m11 * m.m22 - m.m21 * m.m12) - m.m10 * (m.m01 * m.m22 - m.m21 * m.m02) + m.m20 * (m.m01 * m.m12 - m.m11 * m.m02))
			);
		}

		public static float Determinant(Matrix4 m)
		{
			return (
				m.m00 * (m.m11 * (m.m22 * m.m33 - m.m32 * m.m23) - m.m21 * (m.m12 * m.m33 - m.m32 * m.m13) + m.m31 * (m.m12 * m.m23 - m.m22 * m.m13))
				- m.m10 * (m.m01 * (m.m22 * m.m33 - m.m32 * m.m23) - m.m21 * (m.m02 * m.m33 - m.m32 * m.m03) + m.m31 * (m.m02 * m.m23 - m.m22 * m.m03))
				+ m.m20 * (m.m01 * (m.m12 * m.m33 - m.m32 * m.m13) - m.m11 * (m.m02 * m.m33 - m.m32 * m.m03) + m.m31 * (m.m02 * m.m13 - m.m12 * m.m03))
				- m.m30 * (m.m01 * (m.m12 * m.m23 - m.m22 * m.m13) - m.m11 * (m.m02 * m.m23 - m.m22 * m.m03) + m.m21 * (m.m02 * m.m13 - m.m12 * m.m03))
			);
		}

		public static Matrix4 Inverse(Matrix4 m)
		{
			return Adjugate(m) / Determinant(m);
		}

		public static Matrix4 Transpose(Matrix4 m)
		{
			return new Matrix4(
				m.m00, m.m10, m.m20, m.m30,
				m.m01, m.m11, m.m21, m.m31,
				m.m02, m.m12, m.m22, m.m32,
				m.m03, m.m13, m.m23, m.m33
			);
		}

		public static Matrix4 Rotate(float radians, Vector3f v)
		{
			var c = Math.Cos(radians);
			var s = Math.Sin(radians);

			var axis = Math.Normalize(v);
			var temp = (1 - c) * axis;

			var m = Matrix4.identity;
			m.m00 = c + temp.x * axis.x;
			m.m01 = 0 + temp.x * axis.y + s * axis.z;
			m.m02 = 0 + temp.x * axis.z - s * axis.y;

			m.m10 = 0 + temp.y * axis.x - s * axis.z;
			m.m11 = c + temp.y * axis.y;
			m.m12 = 0 + temp.y * axis.z + s * axis.x;

			m.m20 = 0 + temp.z * axis.x + s * axis.y;
			m.m21 = 0 + temp.z * axis.y - s * axis.x;
			m.m22 = c + temp.z * axis.z;

			return m;
		}

		public static Matrix4 RotateX(float radians)
		{
			return Matrix4.Rotate(radians, Vector3f.right);
		}

		public static Matrix4 RotateY(float radians)
		{
			return Matrix4.Rotate(radians, Vector3f.up);
		}

		public static Matrix4 RotateZ(float radians)
		{
			return Matrix4.Rotate(radians, Vector3f.forward);
		}

		public static Matrix4 Scale(float x, float y, float z)
		{
			var m = Matrix4.identity;
			m.m00 = x;
			m.m11 = y;
			m.m22 = z;

			return m;
		}

		public static Matrix4 Scale(Vector3f v)
		{
			return Matrix4.Scale(v.x, v.y, v.z);
		}

		public static Matrix4 Scale(float s)
		{
			return Matrix4.Scale(s, s, s);
		}

		public static Matrix4 Translate(float x, float y, float z)
		{
			var m = Matrix4.identity;
			m.m30 = x;
			m.m31 = y;
			m.m32 = z;

			return m;
		}

		public static Matrix4 Translate(Vector3f v)
		{
			return Matrix4.Translate(v.x, v.y, v.z);
		}

		public static Vector3f DecomposeMatrixGetPosition(Matrix4 m)
		{
			return new Vector3f(m.m30, m.m31, m.m32);
		}

		public static Vector3f DecomposeMatrixGetScale(Matrix4 m)
		{
			return new Vector3f(
				(new Vector3f(m.m00, m.m01, m.m02)).length,
				(new Vector3f(m.m10, m.m11, m.m12)).length,
				(new Vector3f(m.m20, m.m21, m.m22)).length
			);
		}

		public static Quat DecomposeMatrixGetOrientation(Matrix4 m)
		{
			return DecomposeMatrixGetOrientation(m, DecomposeMatrixGetScale(m));
		}

		public static Quat DecomposeMatrixGetOrientation(Matrix4 m, Vector3f scale)
		{
			var rotation = Matrix3.identity;
			rotation.m00 = m.m00 / scale.x;
			rotation.m01 = m.m01 / scale.x;
			rotation.m02 = m.m02 / scale.x;
			rotation.m10 = m.m10 / scale.y;
			rotation.m11 = m.m11 / scale.y;
			rotation.m12 = m.m12 / scale.y;
			rotation.m20 = m.m20 / scale.z;
			rotation.m21 = m.m21 / scale.z;
			rotation.m22 = m.m22 / scale.z;

			return rotation.ToQuaternion();
		}
	}

	public static class Matrix4Extension
	{
		public static Quat ToQuaternion(this Matrix4 m)
		{
			return new Quat(m);
		}
	}
}
