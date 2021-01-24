// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public partial struct Matrix4
	{
		public float m00;
		public float m01;
		public float m02;
		public float m03;
		public float m10;
		public float m11;
		public float m12;
		public float m13;
		public float m20;
		public float m21;
		public float m22;
		public float m23;
		public float m30;
		public float m31;
		public float m32;
		public float m33;

		public Matrix4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
		{
			this.m00 = m00;
			this.m01 = m01;
			this.m02 = m02;
			this.m03 = m03;
			this.m10 = m10;
			this.m11 = m11;
			this.m12 = m12;
			this.m13 = m13;
			this.m20 = m20;
			this.m21 = m21;
			this.m22 = m22;
			this.m23 = m23;
			this.m30 = m30;
			this.m31 = m31;
			this.m32 = m32;
			this.m33 = m33;
		}

		public static Matrix4 operator +(Matrix4 a, Matrix4 b)
		{
			return new Matrix4(
				a.m00 + b.m00, a.m01 + b.m01, a.m02 + b.m02, a.m03 + b.m03,
				a.m10 + b.m10, a.m11 + b.m11, a.m12 + b.m12, a.m13 + b.m13,
				a.m20 + b.m20, a.m21 + b.m21, a.m22 + b.m22, a.m23 + b.m23,
				a.m30 + b.m30, a.m31 + b.m31, a.m32 + b.m32, a.m33 + b.m33
			);
		}

		public static Matrix4 operator +(Matrix4 m, float v)
		{
			return new Matrix4(
				m.m00 + v, m.m01 + v, m.m02 + v, m.m03 + v,
				m.m10 + v, m.m11 + v, m.m12 + v, m.m13 + v,
				m.m20 + v, m.m21 + v, m.m22 + v, m.m23 + v,
				m.m30 + v, m.m31 + v, m.m32 + v, m.m33 + v
			);
		}

		public static Matrix4 operator +(float v, Matrix4 m)
		{
			return new Matrix4(
				v + m.m00, v + m.m01, v + m.m02, v + m.m03,
				v + m.m10, v + m.m11, v + m.m12, v + m.m13,
				v + m.m20, v + m.m21, v + m.m22, v + m.m23,
				v + m.m30, v + m.m31, v + m.m32, v + m.m33
			);
		}

		public static Matrix4 operator -(Matrix4 a, Matrix4 b)
		{
			return new Matrix4(
				a.m00 - b.m00, a.m01 - b.m01, a.m02 - b.m02, a.m03 - b.m03,
				a.m10 - b.m10, a.m11 - b.m11, a.m12 - b.m12, a.m13 - b.m13,
				a.m20 - b.m20, a.m21 - b.m21, a.m22 - b.m22, a.m23 - b.m23,
				a.m30 - b.m30, a.m31 - b.m31, a.m32 - b.m32, a.m33 - b.m33
			);
		}

		public static Matrix4 operator -(Matrix4 m, float v)
		{
			return new Matrix4(
				m.m00 - v, m.m01 - v, m.m02 - v, m.m03 - v,
				m.m10 - v, m.m11 - v, m.m12 - v, m.m13 - v,
				m.m20 - v, m.m21 - v, m.m22 - v, m.m23 - v,
				m.m30 - v, m.m31 - v, m.m32 - v, m.m33 - v
			);
		}

		public static Matrix4 operator -(float v, Matrix4 m)
		{
			return new Matrix4(
				v - m.m00, v - m.m01, v - m.m02, v - m.m03,
				v - m.m10, v - m.m11, v - m.m12, v - m.m13,
				v - m.m20, v - m.m21, v - m.m22, v - m.m23,
				v - m.m30, v - m.m31, v - m.m32, v - m.m33
			);
		}

		public static Matrix4 operator *(Matrix4 a, Matrix4 b)
		{
			return new Matrix4(
				((a.m00 * b.m00 + a.m10 * b.m01) + (a.m20 * b.m02 + a.m30 * b.m03)),
				((a.m01 * b.m00 + a.m11 * b.m01) + (a.m21 * b.m02 + a.m31 * b.m03)),
				((a.m02 * b.m00 + a.m12 * b.m01) + (a.m22 * b.m02 + a.m32 * b.m03)),
				((a.m03 * b.m00 + a.m13 * b.m01) + (a.m23 * b.m02 + a.m33 * b.m03)),
				((a.m00 * b.m10 + a.m10 * b.m11) + (a.m20 * b.m12 + a.m30 * b.m13)),
				((a.m01 * b.m10 + a.m11 * b.m11) + (a.m21 * b.m12 + a.m31 * b.m13)),
				((a.m02 * b.m10 + a.m12 * b.m11) + (a.m22 * b.m12 + a.m32 * b.m13)),
				((a.m03 * b.m10 + a.m13 * b.m11) + (a.m23 * b.m12 + a.m33 * b.m13)),
				((a.m00 * b.m20 + a.m10 * b.m21) + (a.m20 * b.m22 + a.m30 * b.m23)),
				((a.m01 * b.m20 + a.m11 * b.m21) + (a.m21 * b.m22 + a.m31 * b.m23)),
				((a.m02 * b.m20 + a.m12 * b.m21) + (a.m22 * b.m22 + a.m32 * b.m23)),
				((a.m03 * b.m20 + a.m13 * b.m21) + (a.m23 * b.m22 + a.m33 * b.m23)),
				((a.m00 * b.m30 + a.m10 * b.m31) + (a.m20 * b.m32 + a.m30 * b.m33)),
				((a.m01 * b.m30 + a.m11 * b.m31) + (a.m21 * b.m32 + a.m31 * b.m33)),
				((a.m02 * b.m30 + a.m12 * b.m31) + (a.m22 * b.m32 + a.m32 * b.m33)),
				((a.m03 * b.m30 + a.m13 * b.m31) + (a.m23 * b.m32 + a.m33 * b.m33))
			);
		}

		public static Vector4f operator *(Matrix4 m, Vector4f v)
		{
			return new Vector4f(
				(m.m00 * v.x + m.m10 * v.y) + (m.m20 * v.z + m.m30 * v.w),
				(m.m01 * v.x + m.m11 * v.y) + (m.m21 * v.z + m.m31 * v.w),
				(m.m02 * v.x + m.m12 * v.y) + (m.m22 * v.z + m.m32 * v.w),
				(m.m03 * v.x + m.m13 * v.y) + (m.m23 * v.z + m.m33 * v.w)
			);
		}

		public static Matrix4 operator *(Matrix4 m, float v)
		{
			return new Matrix4(
				m.m00 * v, m.m01 * v, m.m02 * v, m.m03 * v,
				m.m10 * v, m.m11 * v, m.m12 * v, m.m13 * v,
				m.m20 * v, m.m21 * v, m.m22 * v, m.m23 * v,
				m.m30 * v, m.m31 * v, m.m32 * v, m.m33 * v
			);
		}

		public static Matrix4 operator *(float v, Matrix4 m)
		{
			return new Matrix4(
				v * m.m00, v * m.m01, v * m.m02, v * m.m03,
				v * m.m10, v * m.m11, v * m.m12, v * m.m13,
				v * m.m20, v * m.m21, v * m.m22, v * m.m23,
				v * m.m30, v * m.m31, v * m.m32, v * m.m33
			);
		}

		public static Matrix4 operator /(Matrix4 m, float v)
		{
			return new Matrix4(
				m.m00 / v, m.m01 / v, m.m02 / v, m.m03 / v,
				m.m10 / v, m.m11 / v, m.m12 / v, m.m13 / v,
				m.m20 / v, m.m21 / v, m.m22 / v, m.m23 / v,
				m.m30 / v, m.m31 / v, m.m32 / v, m.m33 / v
			);
		}

		public static Matrix4 operator /(float v, Matrix4 m)
		{
			return new Matrix4(
				v / m.m00, v / m.m01, v / m.m02, v / m.m03,
				v / m.m10, v / m.m11, v / m.m12, v / m.m13,
				v / m.m20, v / m.m21, v / m.m22, v / m.m23,
				v / m.m30, v / m.m31, v / m.m32, v / m.m33
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
				hash = (hash * 23) ^ m03.GetHashCode();
				hash = (hash * 23) ^ m10.GetHashCode();
				hash = (hash * 23) ^ m11.GetHashCode();
				hash = (hash * 23) ^ m12.GetHashCode();
				hash = (hash * 23) ^ m13.GetHashCode();
				hash = (hash * 23) ^ m20.GetHashCode();
				hash = (hash * 23) ^ m21.GetHashCode();
				hash = (hash * 23) ^ m22.GetHashCode();
				hash = (hash * 23) ^ m23.GetHashCode();
				hash = (hash * 23) ^ m30.GetHashCode();
				hash = (hash * 23) ^ m31.GetHashCode();
				hash = (hash * 23) ^ m32.GetHashCode();
				hash = (hash * 23) ^ m33.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			return (obj is Matrix4 matrix && (this == matrix));
		}

		public static bool operator ==(Matrix4 a, Matrix4 b)
		{
			return (
				a.m00 == b.m00 &&
				a.m01 == b.m01 &&
				a.m02 == b.m02 &&
				a.m03 == b.m03 &&
				a.m10 == b.m10 &&
				a.m11 == b.m11 &&
				a.m12 == b.m12 &&
				a.m13 == b.m13 &&
				a.m20 == b.m20 &&
				a.m21 == b.m21 &&
				a.m22 == b.m22 &&
				a.m23 == b.m23 &&
				a.m30 == b.m30 &&
				a.m31 == b.m31 &&
				a.m32 == b.m32 &&
				a.m33 == b.m33
			);
		}

		public static bool operator !=(Matrix4 a, Matrix4 b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return $"[ {{ {m00} , {m01} , {m02} , {m03} }} , {{ {m10} , {m11} , {m12} , {m13} }} , {{ {m20} , {m21} , {m22} , {m23} }} , {{ {m30} , {m31} , {m32} , {m33} }} ]";
		}
	}
}
