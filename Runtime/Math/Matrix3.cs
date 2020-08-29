
namespace Ju.Math
{
	public partial struct Matrix3
	{
		public float m00;
		public float m01;
		public float m02;
		public float m10;
		public float m11;
		public float m12;
		public float m20;
		public float m21;
		public float m22;

		public Matrix3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
		{
			this.m00 = m00;
			this.m01 = m01;
			this.m02 = m02;
			this.m10 = m10;
			this.m11 = m11;
			this.m12 = m12;
			this.m20 = m20;
			this.m21 = m21;
			this.m22 = m22;
		}

		public static Matrix3 operator +(Matrix3 a, Matrix3 b)
		{
			return new Matrix3(
				a.m00 + b.m00, a.m01 + b.m01, a.m02 + b.m02,
				a.m10 + b.m10, a.m11 + b.m11, a.m12 + b.m12,
				a.m20 + b.m20, a.m21 + b.m21, a.m22 + b.m22
			);
		}

		public static Matrix3 operator +(Matrix3 m, float v)
		{
			return new Matrix3(
				m.m00 + v, m.m01 + v, m.m02 + v,
				m.m10 + v, m.m11 + v, m.m12 + v,
				m.m20 + v, m.m21 + v, m.m22 + v
			);
		}

		public static Matrix3 operator +(float v, Matrix3 m)
		{
			return new Matrix3(
				v + m.m00, v + m.m01, v + m.m02,
				v + m.m10, v + m.m11, v + m.m12,
				v + m.m20, v + m.m21, v + m.m22
			);
		}

		public static Matrix3 operator -(Matrix3 a, Matrix3 b)
		{
			return new Matrix3(
				a.m00 - b.m00, a.m01 - b.m01, a.m02 - b.m02,
				a.m10 - b.m10, a.m11 - b.m11, a.m12 - b.m12,
				a.m20 - b.m20, a.m21 - b.m21, a.m22 - b.m22
			);
		}

		public static Matrix3 operator -(Matrix3 m, float v)
		{
			return new Matrix3(
				m.m00 - v, m.m01 - v, m.m02 - v,
				m.m10 - v, m.m11 - v, m.m12 - v,
				m.m20 - v, m.m21 - v, m.m22 - v
			);
		}

		public static Matrix3 operator -(float v, Matrix3 m)
		{
			return new Matrix3(
				v - m.m00, v - m.m01, v - m.m02,
				v - m.m10, v - m.m11, v - m.m12,
				v - m.m20, v - m.m21, v - m.m22
			);
		}

		public static Matrix3 operator *(Matrix3 a, Matrix3 b)
		{
			return new Matrix3(
				((a.m00 * b.m00 + a.m10 * b.m01) + a.m20 * b.m02), ((a.m01 * b.m00 + a.m11 * b.m01) + a.m21 * b.m02), ((a.m02 * b.m00 + a.m12 * b.m01) + a.m22 * b.m02),
				((a.m00 * b.m10 + a.m10 * b.m11) + a.m20 * b.m12), ((a.m01 * b.m10 + a.m11 * b.m11) + a.m21 * b.m12), ((a.m02 * b.m10 + a.m12 * b.m11) + a.m22 * b.m12),
				((a.m00 * b.m20 + a.m10 * b.m21) + a.m20 * b.m22), ((a.m01 * b.m20 + a.m11 * b.m21) + a.m21 * b.m22), ((a.m02 * b.m20 + a.m12 * b.m21) + a.m22 * b.m22)
			);
		}

		public static Vector3f operator *(Matrix3 m, Vector3f v)
		{
			return new Vector3f(
				(m.m00 * v.x + m.m10 * v.y) + m.m20 * v.z,
				(m.m01 * v.x + m.m11 * v.y) + m.m21 * v.z,
				(m.m02 * v.x + m.m12 * v.y) + m.m22 * v.z
			);
		}

		public static Matrix3 operator *(Matrix3 m, float v)
		{
			return new Matrix3(
				m.m00 * v, m.m01 * v, m.m02 * v,
				m.m10 * v, m.m11 * v, m.m12 * v,
				m.m20 * v, m.m21 * v, m.m22 * v
			);
		}

		public static Matrix3 operator *(float v, Matrix3 m)
		{
			return new Matrix3(
				v * m.m00, v * m.m01, v * m.m02,
				v * m.m10, v * m.m11, v * m.m12,
				v * m.m20, v * m.m21, v * m.m22
			);
		}

		public static Matrix3 operator /(Matrix3 m, float v)
		{
			return new Matrix3(
				m.m00 / v, m.m01 / v, m.m02 / v,
				m.m10 / v, m.m11 / v, m.m12 / v,
				m.m20 / v, m.m21 / v, m.m22 / v
			);
		}

		public static Matrix3 operator /(float v, Matrix3 m)
		{
			return new Matrix3(
				v / m.m00, v / m.m01, v / m.m02,
				v / m.m10, v / m.m11, v / m.m12,
				v / m.m20, v / m.m21, v / m.m22
			);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;
				hash = (hash * 23) ^ m00.GetHashCode();
				hash = (hash * 23) ^ m01.GetHashCode();
				hash = (hash * 23) ^ m02.GetHashCode();
				hash = (hash * 23) ^ m10.GetHashCode();
				hash = (hash * 23) ^ m11.GetHashCode();
				hash = (hash * 23) ^ m12.GetHashCode();
				hash = (hash * 23) ^ m20.GetHashCode();
				hash = (hash * 23) ^ m21.GetHashCode();
				hash = (hash * 23) ^ m22.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			return (obj is Matrix3 matrix && (this == matrix));
		}

		public static bool operator ==(Matrix3 a, Matrix3 b)
		{
			return (
				a.m00 == b.m00 &&
				a.m01 == b.m01 &&
				a.m02 == b.m02 &&
				a.m10 == b.m10 &&
				a.m11 == b.m11 &&
				a.m12 == b.m12 &&
				a.m20 == b.m20 &&
				a.m21 == b.m21 &&
				a.m22 == b.m22
			);
		}

		public static bool operator !=(Matrix3 a, Matrix3 b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return "[ " +
				"{ " + m00 + " , " + m01 + " , " + m02 + " } , " +
				"{ " + m10 + " , " + m11 + " , " + m12 + " } , " +
				"{ " + m20 + " , " + m21 + " , " + m22 + " } ]";
		}
	}
}
