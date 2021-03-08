// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public static partial class Math
	{
		public static Vector2f Abs(Vector2f value)
		{
			return new Vector2f(Abs(value.x), Abs(value.y));
		}

		public static Vector3f Abs(Vector3f value)
		{
			return new Vector3f(Abs(value.x), Abs(value.y), Abs(value.z));
		}

		public static Vector4f Abs(Vector4f value)
		{
			return new Vector4f(Abs(value.x), Abs(value.y), Abs(value.z), Abs(value.w));
		}

		public static Matrix3 Adjugate(Matrix3 m)
		{
			return Matrix3.Adjugate(m);
		}

		public static Matrix4 Adjugate(Matrix4 m)
		{
			return Matrix4.Adjugate(m);
		}

		public static Quat Conjugate(Quat q)
		{
			return Quat.Conjugate(q);
		}

		public static Vector2i Ceil(Vector2f v)
		{
			return Vector2f.Ceil(v);
		}

		public static Vector3i Ceil(Vector3f v)
		{
			return Vector3f.Ceil(v);
		}

		public static Vector4i Ceil(Vector4f v)
		{
			return Vector4f.Ceil(v);
		}

		public static IntRect Ceil(FloatRect r)
		{
			return FloatRect.Ceil(r);
		}

		public static float Cross(Vector2f a, Vector2f b)
		{
			return Vector2f.Cross(a, b);
		}

		public static float Cross(Vector2i a, Vector2i b)
		{
			return Vector2i.Cross(a, b);
		}

		public static Vector3f Cross(Vector3f a, Vector3f b)
		{
			return Vector3f.Cross(a, b);
		}

		public static Vector3i Cross(Vector3i a, Vector3i b)
		{
			return Vector3i.Cross(a, b);
		}

		public static Quat Cross(Quat a, Quat b)
		{
			return Quat.Cross(a, b);
		}

		// Angle difference between two angles in radians.
		public static float DeltaAngle(float radiansA, float radiansB)
		{
			return AngleDiff(radiansA, radiansB);
		}

		public static float Determinant(Matrix3 m)
		{
			return Matrix3.Determinant(m);
		}

		public static float Determinant(Matrix4 m)
		{
			return Matrix4.Determinant(m);
		}

		public static float Distance(Vector2f a, Vector2f b)
		{
			return Vector2f.Distance(a, b);
		}

		public static float Distance(Vector2i a, Vector2i b)
		{
			return Vector2i.Distance(a, b);
		}

		public static float Distance(Vector3f a, Vector3f b)
		{
			return Vector3f.Distance(a, b);
		}

		public static float Distance(Vector3i a, Vector3i b)
		{
			return Vector3i.Distance(a, b);
		}

		public static float Distance(Vector4f a, Vector4f b)
		{
			return Vector4f.Distance(a, b);
		}

		public static float Distance(Vector4i a, Vector4i b)
		{
			return Vector4i.Distance(a, b);
		}

		public static float DistanceSqr(Vector2f a, Vector2f b)
		{
			return Vector2f.DistanceSqr(a, b);
		}

		public static float DistanceSqr(Vector2i a, Vector2i b)
		{
			return Vector2i.DistanceSqr(a, b);
		}

		public static float DistanceSqr(Vector3f a, Vector3f b)
		{
			return Vector3f.DistanceSqr(a, b);
		}

		public static float DistanceSqr(Vector3i a, Vector3i b)
		{
			return Vector3i.DistanceSqr(a, b);
		}

		public static float DistanceSqr(Vector4f a, Vector4f b)
		{
			return Vector4f.DistanceSqr(a, b);
		}

		public static float DistanceSqr(Vector4i a, Vector4i b)
		{
			return Vector4i.DistanceSqr(a, b);
		}

		public static float Dot(Vector2f a, Vector2f b)
		{
			return Vector2f.Dot(a, b);
		}

		public static float Dot(Vector2i a, Vector2i b)
		{
			return Vector2i.Dot(a, b);
		}

		public static float Dot(Vector3f a, Vector3f b)
		{
			return Vector3f.Dot(a, b);
		}

		public static float Dot(Vector3i a, Vector3i b)
		{
			return Vector3i.Dot(a, b);
		}

		public static float Dot(Vector4f a, Vector4f b)
		{
			return Vector4f.Dot(a, b);
		}

		public static float Dot(Vector4i a, Vector4i b)
		{
			return Vector4i.Dot(a, b);
		}

		public static float Dot(Quat a, Quat b)
		{
			return Quat.Dot(a, b);
		}

		public static Quat EulerAngles(Vector3f eulerAngles)
		{
			return new Quat(eulerAngles);
		}

		public static Vector3f EulerAngles(Quat q)
		{
			return q.eulerAngles;
		}

		public static Vector2i Floor(Vector2f v)
		{
			return Vector2f.Floor(v);
		}

		public static Vector3i Floor(Vector3f v)
		{
			return Vector3f.Floor(v);
		}

		public static Vector4i Floor(Vector4f v)
		{
			return Vector4f.Floor(v);
		}

		public static IntRect Floor(FloatRect r)
		{
			return FloatRect.Floor(r);
		}

		public static Matrix3 Inverse(Matrix3 m)
		{
			return Matrix3.Inverse(m);
		}

		public static Matrix4 Inverse(Matrix4 m)
		{
			return Matrix4.Inverse(m);
		}

		public static Quat Inverse(Quat q)
		{
			return Quat.Inverse(q);
		}

		public static Quat MatrixToQuat(Matrix3 m)
		{
			return m.ToQuaternion();
		}

		public static Quat MatrixToQuat(Matrix4 m)
		{
			return m.ToQuaternion();
		}

		public static Vector2f Mix(Vector2f a, Vector2f b, float alpha)
		{
			return Vector2f.Mix(a, b, alpha);
		}

		public static Vector2f Mix(Vector2i a, Vector2i b, float alpha)
		{
			return Vector2i.Mix(a, b, alpha);
		}

		public static Vector3f Mix(Vector3f a, Vector3f b, float alpha)
		{
			return Vector3f.Mix(a, b, alpha);
		}

		public static Vector3f Mix(Vector3i a, Vector3i b, float alpha)
		{
			return Vector3i.Mix(a, b, alpha);
		}

		public static Vector4f Mix(Vector4f a, Vector4f b, float alpha)
		{
			return Vector4f.Mix(a, b, alpha);
		}

		public static Vector4f Mix(Vector4i a, Vector4i b, float alpha)
		{
			return Vector4i.Mix(a, b, alpha);
		}

		public static Quat Mix(Quat a, Quat b, float alpha)
		{
			return Quat.Mix(a, b, alpha);
		}

		public static Vector2f Normalize(Vector2f v)
		{
			return Vector2f.Normalize(v);
		}

		public static Vector2f Normalize(Vector2i v)
		{
			return Vector2i.Normalize(v);
		}

		public static Vector3f Normalize(Vector3f v)
		{
			return Vector3f.Normalize(v);
		}

		public static Vector3f Normalize(Vector3i v)
		{
			return Vector3i.Normalize(v);
		}

		public static Vector4f Normalize(Vector4f v)
		{
			return Vector4f.Normalize(v);
		}

		public static Vector4f Normalize(Vector4i v)
		{
			return Vector4i.Normalize(v);
		}

		public static Quat Normalize(Quat q)
		{
			return Quat.Normalize(q);
		}

		public static Vector2f Lerp(Vector2f a, Vector2f b, float alpha)
		{
			return Vector2f.Lerp(a, b, alpha);
		}

		public static Vector2f LerpClamped(Vector2f a, Vector2f b, float alpha)
		{
			return Vector2f.LerpClamped(a, b, alpha);
		}

		public static Vector2f Lerp(Vector2i a, Vector2i b, float alpha)
		{
			return Vector2i.Lerp(a, b, alpha);
		}

		public static Vector2f LerpClamped(Vector2i a, Vector2i b, float alpha)
		{
			return Vector2i.LerpClamped(a, b, alpha);
		}

		public static Vector3f Lerp(Vector3f a, Vector3f b, float alpha)
		{
			return Vector3f.Lerp(a, b, alpha);
		}

		public static Vector3f LerpClamped(Vector3f a, Vector3f b, float alpha)
		{
			return Vector3f.LerpClamped(a, b, alpha);
		}

		public static Vector3f Lerp(Vector3i a, Vector3i b, float alpha)
		{
			return Vector3i.Lerp(a, b, alpha);
		}

		public static Vector3f LerpClamped(Vector3i a, Vector3i b, float alpha)
		{
			return Vector3i.LerpClamped(a, b, alpha);
		}

		public static Vector4f Lerp(Vector4f a, Vector4f b, float alpha)
		{
			return Vector4f.Lerp(a, b, alpha);
		}

		public static Vector4f LerpClamped(Vector4f a, Vector4f b, float alpha)
		{
			return Vector4f.LerpClamped(a, b, alpha);
		}

		public static Vector4f Lerp(Vector4i a, Vector4i b, float alpha)
		{
			return Vector4i.Lerp(a, b, alpha);
		}

		public static Vector4f LerpClamped(Vector4i a, Vector4i b, float alpha)
		{
			return Vector4i.LerpClamped(a, b, alpha);
		}

		public static Quat Lerp(Quat a, Quat b, float alpha)
		{
			return Quat.Lerp(a, b, alpha);
		}

		public static Quat LerpClamped(Quat a, Quat b, float alpha)
		{
			return Quat.LerpClamped(a, b, alpha);
		}

		public static Quat Slerp(Quat a, Quat b, float alpha)
		{
			return Quat.Slerp(a, b, alpha);
		}

		public static Quat SlerpClamped(Quat a, Quat b, float alpha)
		{
			return Quat.SlerpClamped(a, b, alpha);
		}

		public static Quat Squad(Quat q1, Quat q2, Quat s1, Quat s2, float h)
		{
			return Quat.Squad(q1, q2, s1, s2, h);
		}

		public static Quat LookAt(Vector3f eye, Vector3f center, Vector3f up)
		{
			return Quat.LookAt(eye, center, up);
		}

		public static Matrix3 QuatToMatrix3(Quat q)
		{
			return q.ToMatrix3();
		}

		public static Matrix4 QuatToMatrix4(Quat q)
		{
			return q.ToMatrix4();
		}

		public static Vector2f Reflect(Vector2f incident, Vector2f normal)
		{
			return Vector2f.Reflect(incident, normal);
		}

		public static Vector2f Reflect(Vector2i incident, Vector2i normal)
		{
			return Vector2i.Reflect(incident, normal);
		}

		public static Vector3f Reflect(Vector3f incident, Vector3f normal)
		{
			return Vector3f.Reflect(incident, normal);
		}

		public static Vector3f Reflect(Vector3i incident, Vector3i normal)
		{
			return Vector3i.Reflect(incident, normal);
		}

		public static Vector4f Reflect(Vector4f incident, Vector4f normal)
		{
			return Vector4f.Reflect(incident, normal);
		}

		public static Vector4f Reflect(Vector4i incident, Vector4i normal)
		{
			return Vector4i.Reflect(incident, normal);
		}

		public static Vector2f Rotate(Vector2f v, float radians)
		{
			return Vector2f.Rotate(v, radians);
		}

		public static Vector2f Rotate(Vector2i v, float radians)
		{
			return Vector2i.Rotate(v, radians);
		}

		public static Quat Rotate(Quat q, float radians, Vector3f v)
		{
			return Quat.Rotate(q, radians, v);
		}

		public static Vector2i Round(Vector2f v)
		{
			return Vector2f.Round(v);
		}

		public static Vector3i Round(Vector3f v)
		{
			return Vector3f.Round(v);
		}

		public static Vector4i Round(Vector4f v)
		{
			return Vector4f.Round(v);
		}

		public static IntRect Round(FloatRect r)
		{
			return FloatRect.Round(r);
		}

		public static Matrix3 Transpose(Matrix3 m)
		{
			return Matrix3.Transpose(m);
		}

		public static Matrix4 Transpose(Matrix4 m)
		{
			return Matrix4.Transpose(m);
		}

		// Normalized angle 2D vector contained in a circle using the provided radians.
		public static Vector2f AngleToVector(float radians)
		{
			return Vector2f.AngleToVector(radians);
		}

		// Angle formed by two 2D vectors.
		public static float Angle(Vector2f a, Vector2f b)
		{
			return Vector2f.Angle(a, b);
		}

		// Angle formed by two 2D vectors.
		public static float Angle(Vector2i a, Vector2i b)
		{
			return Vector2i.Angle(a, b);
		}

		// Perpendicular 2D normal to a line formed by two 2D points.
		public static Vector2f PerpendicularToLine(Vector2f a, Vector2f b)
		{
			return Vector2f.PerpendicularToLine(a, b);
		}

		// Perpendicular 2D normal to a line formed by two 2D points.
		public static Vector2f PerpendicularToLine(Vector2i a, Vector2i b)
		{
			return Vector2i.PerpendicularToLine(a, b);
		}

		public static Vector2f PerpendicularCW(Vector2f v)
		{
			return Vector2f.PerpendicularCW(v);
		}

		public static Vector2f PerpendicularCCW(Vector2f v)
		{
			return Vector2f.PerpendicularCCW(v);
		}

		public static Vector2i PerpendicularCW(Vector2i v)
		{
			return Vector2i.PerpendicularCW(v);
		}

		public static Vector2i PerpendicularCCW(Vector2i v)
		{
			return Vector2i.PerpendicularCCW(v);
		}

		// 2D point contained in a circle of the provided radius at the provided radians.
		public static Vector2f PointOnCircle(Vector2f center, float radius, float radians)
		{
			return Vector2f.PointOnCircle(center, radius, radians);
		}

		// 2D point contained in a circle of the provided radius at the provided radians.
		public static Vector2f PointOnCircle(Vector2i center, float radius, float radians)
		{
			return Vector2i.PointOnCircle(center, radius, radians);
		}

		public static Matrix4 Rotate(float radians, Vector3f v)
		{
			return Matrix4.Rotate(radians, v);
		}

		public static Matrix4 RotateX(float radians)
		{
			return Matrix4.RotateX(radians);
		}

		public static Matrix4 RotateY(float radians)
		{
			return Matrix4.RotateY(radians);
		}

		public static Matrix4 RotateZ(float radians)
		{
			return Matrix4.RotateZ(radians);
		}

		public static Matrix4 Scale(float x, float y, float z)
		{
			return Matrix4.Scale(x, y, z);
		}

		public static Matrix4 Scale(Vector3f v)
		{
			return Matrix4.Scale(v);
		}

		public static Matrix4 Scale(float s)
		{
			return Matrix4.Scale(s);
		}

		public static Matrix4 Translate(float x, float y, float z)
		{
			return Matrix4.Translate(x, y, z);
		}

		public static Matrix4 Translate(Vector3f v)
		{
			return Matrix4.Translate(v);
		}

		public static Vector2f DecomposeMatrixGetPosition(Matrix3 m)
		{
			return Matrix3.DecomposeMatrixGetPosition(m);
		}

		public static Vector2f DecomposeMatrixGetScale(Matrix3 m)
		{
			return Matrix3.DecomposeMatrixGetScale(m);
		}

		public static float DecomposeMatrixGetOrientation(Matrix3 m)
		{
			return Matrix3.DecomposeMatrixGetOrientation(m);
		}

		public static Vector3f DecomposeMatrixGetPosition(Matrix4 m)
		{
			return Matrix4.DecomposeMatrixGetPosition(m);
		}

		public static Vector3f DecomposeMatrixGetScale(Matrix4 m)
		{
			return Matrix4.DecomposeMatrixGetScale(m);
		}

		public static Quat DecomposeMatrixGetOrientation(Matrix4 m)
		{
			return Matrix4.DecomposeMatrixGetOrientation(m);
		}

		public static Quat DecomposeMatrixGetOrientation(Matrix4 m, Vector3f scale)
		{
			return Matrix4.DecomposeMatrixGetOrientation(m, scale);
		}
	}
}
