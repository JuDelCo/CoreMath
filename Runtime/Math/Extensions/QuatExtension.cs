
namespace Ju.Math
{
	public partial struct Quat
	{
		public static Quat identity = new Quat(0f, 0f, 0f, 1f);

		public static explicit operator Quat(Matrix3 m)
		{
			return new Quat(m);
		}

		public static explicit operator Quat(Matrix4 m)
		{
			return new Quat(m);
		}

		public Quat(Vector3f u, Vector3f v)
		{
			var localW = Vector3f.Cross(u, v);
			var dot = Vector3f.Dot(u, v);
			var q = Normalize(new Quat(localW.x, localW.y, localW.z, 1f + dot));

			this.x = q.x;
			this.y = q.y;
			this.z = q.z;
			this.w = q.w;
		}

		public Quat(Vector3f eulerAngles)
		{
			var h = eulerAngles / 2f;
			var c = new Vector3f(Math.Cos(h.x), Math.Cos(h.y), Math.Cos(h.z));
			var s = new Vector3f(Math.Sin(h.x), Math.Sin(h.y), Math.Sin(h.z));

			this.x = s.x * c.y * c.z - c.x * s.y * s.z;
			this.y = c.x * s.y * c.z + s.x * c.y * s.z;
			this.z = c.x * c.y * s.z - s.x * s.y * c.z;
			this.w = c.x * c.y * c.z + s.x * s.y * s.z;
		}

		public Quat(float radians, Vector3f axis)
		{
			var s = Math.Sin(radians * 0.5f);
			var c = Math.Cos(radians * 0.5f);

			this.x = axis.x * s;
			this.y = axis.y * s;
			this.z = axis.z * s;
			this.w = c;
		}

		public Quat(Matrix3 m)
		{
			var fourXSquaredMinus1 = m.m00 - m.m11 - m.m22;
			var fourYSquaredMinus1 = m.m11 - m.m00 - m.m22;
			var fourZSquaredMinus1 = m.m22 - m.m00 - m.m11;
			var fourWSquaredMinus1 = m.m00 + m.m11 + m.m22;
			var biggestIndex = 0;
			var fourBiggestSquaredMinus1 = fourWSquaredMinus1;

			if (fourXSquaredMinus1 > fourBiggestSquaredMinus1)
			{
				fourBiggestSquaredMinus1 = fourXSquaredMinus1;
				biggestIndex = 1;
			}

			if (fourYSquaredMinus1 > fourBiggestSquaredMinus1)
			{
				fourBiggestSquaredMinus1 = fourYSquaredMinus1;
				biggestIndex = 2;
			}

			if (fourZSquaredMinus1 > fourBiggestSquaredMinus1)
			{
				fourBiggestSquaredMinus1 = fourZSquaredMinus1;
				biggestIndex = 3;
			}

			var biggestVal = Math.Sqrt(fourBiggestSquaredMinus1 + 1f) * 0.5f;
			var mult = 0.25f / biggestVal;

			if (biggestIndex == 0)
			{
				this.x = (m.m12 - m.m21) * mult;
				this.y = (m.m20 - m.m02) * mult;
				this.z = (m.m01 - m.m10) * mult;
				this.w = biggestVal;
			}
			else if (biggestIndex == 1)
			{
				this.x = biggestVal;
				this.y = (m.m01 + m.m10) * mult;
				this.z = (m.m20 + m.m02) * mult;
				this.w = (m.m12 - m.m21) * mult;
			}
			else if (biggestIndex == 2)
			{
				this.x = (m.m01 + m.m10) * mult;
				this.y = biggestVal;
				this.z = (m.m12 + m.m21) * mult;
				this.w = (m.m20 - m.m02) * mult;
			}
			else
			{
				this.x = (m.m20 + m.m02) * mult;
				this.y = (m.m12 + m.m21) * mult;
				this.z = biggestVal;
				this.w = (m.m01 - m.m10) * mult;
			}
		}

		public Quat(Matrix4 m) : this((Matrix3)m)
		{
		}

		public float length
		{
			get { return Math.Sqrt((x * x + y * y) + (z * z + w * w)); }
		}

		public float angle
		{
			get { return Math.Acos(w) * 2f; }
		}

		public Vector3f axis
		{
			get
			{
				var s1 = 1f - w * w;

				if (s1 < 0f)
				{
					return Vector3f.forward;
				}

				var s2 = 1f / Math.Sqrt(s1);

				return new Vector3f((x * s2), (y * s2), (z * s2));
			}
		}

		public float pitch
		{
			get { return Math.Atan2(2f * (y * z + w * x), (w * w - x * x - y * y + z * z)); }
		}

		public float yaw
		{
			get { return Math.Asin(-2f * (x * z - w * y)); }
		}

		public float roll
		{
			get { return Math.Atan2(2f * (x * y + w * z), (w * w + x * x - y * y - z * z)); }
		}

		public Vector3f eulerAngles
		{
			get { return new Vector3f(pitch, yaw, roll); }
		}

		public static Quat Conjugate(Quat q)
		{
			return new Quat(-q.x, -q.y, -q.z, q.w);
		}

		public static Quat Cross(Quat a, Quat b)
		{
			return new Quat(
				a.w * b.x + a.x * b.w + a.y * b.z - a.z * b.y,
				a.w * b.y + a.y * b.w + a.z * b.x - a.x * b.z,
				a.w * b.z + a.z * b.w + a.x * b.y - a.y * b.x,
				a.w * b.w - a.x * b.x - a.y * b.y - a.z * b.z
			);
		}

		public static float Dot(Quat a, Quat b)
		{
			return (a.x * b.x + a.y * b.y) + (a.z * b.z + a.w * b.w);
		}

		public static Quat Inverse(Quat q)
		{
			var lengthSqr = ((q.x * q.x + q.y * q.y) + (q.z * q.z + q.w * q.w));

			return Conjugate(q) / lengthSqr;
		}

		public static Quat Mix(Quat a, Quat b, float alpha)
		{
			var cosTheta = Dot(a, b);

			if (cosTheta > 1f - float.Epsilon)
			{
				return Lerp(a, b, alpha);
			}
			else
			{
				var angle = Math.Acos(cosTheta);

				return (Math.Sin((1f - alpha) * angle) * a + Math.Sin(alpha * angle) * b) / Math.Sin(angle);
			}
		}

		public static Quat Normalize(Quat q)
		{
			return q / q.length;
		}

		public static Quat Lerp(Quat a, Quat b, float alpha)
		{
			return new Quat(a.x * (1 - alpha) + b.x * alpha, a.y * (1 - alpha) + b.y * alpha, a.z * (1 - alpha) + b.z * alpha, a.w * (1 - alpha) + b.w * alpha);
		}

		public static Quat SLerp(Quat a, Quat b, float alpha)
		{
			var z = b;
			var cosTheta = Dot(a, b);

			if (cosTheta < 0f)
			{
				z = -b;
				cosTheta = -cosTheta;
			}

			if (cosTheta > 1f - float.Epsilon)
			{
				return Lerp(a, z, alpha);
			}
			else
			{
				var angle = Math.Acos(cosTheta);

				return (Math.Sin((1f - alpha) * angle) * a + Math.Sin(alpha * angle) * z) / Math.Sin(angle);
			}
		}

		public static Quat Squad(Quat q1, Quat q2, Quat s1, Quat s2, float h)
		{
			return Quat.Mix(Mix(q1, q2, h), Mix(s1, s2, h), 2 * (1 - h) * h);
		}

		public static Quat LookAt(Vector3f eye, Vector3f center, Vector3f up)
		{
			// http://www.macaronikazoo.com/?p=491

			var aimZ = Math.Normalize(center - eye);
			var aimY = Math.Normalize(up - aimZ * Math.Dot(up, aimZ));
			var aimX = Math.Normalize(Math.Cross(aimY, aimZ));

			var m = Matrix4.identity;

			m.m00 = aimX.x;
			m.m01 = aimX.y;
			m.m02 = aimX.z;

			m.m10 = aimY.x;
			m.m11 = aimY.y;
			m.m12 = aimY.z;

			m.m20 = aimZ.x;
			m.m21 = aimZ.y;
			m.m22 = aimZ.z;

			return m.ToQuaternion();
		}

		public static Quat Rotate(Quat q, float radians, Vector3f v)
		{
			return q * new Quat(radians, v);
		}
	}

	public static class QuatExtension
	{
		public static Matrix3 ToMatrix3(this Quat q)
		{
			return new Matrix3(
				(1f - 2f * (q.y * q.y + q.z * q.z)), (2f * (q.x * q.y + q.w * q.z)), (2f * (q.x * q.z - q.w * q.y)),
				(2f * (q.x * q.y - q.w * q.z)), (1f - 2f * (q.x * q.x + q.z * q.z)), (2f * (q.y * q.z + q.w * q.x)),
				(2f * (q.x * q.z + q.w * q.y)), (2f * (q.y * q.z - q.w * q.x)), (1f - 2f * (q.x * q.x + q.y * q.y))
			);
		}

		public static Matrix4 ToMatrix4(this Quat q)
		{
			return (Matrix4)q.ToMatrix3();
		}
	}
}
