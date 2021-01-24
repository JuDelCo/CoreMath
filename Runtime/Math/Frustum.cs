// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public static partial class Frustum
	{
		// Frustrum projection matrix.
		public static Matrix4 FrustumProj(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			var m = Matrix4.identity;
			m.m00 = (2f * zNear) / (right - left);
			m.m11 = (2f * zNear) / (top - bottom);
			m.m20 = (right + left) / (right - left);
			m.m21 = (top + bottom) / (top - bottom);
			m.m22 = -(zFar + zNear) / (zFar - zNear);
			m.m23 = -1f;
			m.m32 = -(2f * zFar * zNear) / (zFar - zNear);

			return m;
		}

		// Orthographic parallel viewing volume.
		public static Matrix4 Orthographic(float left, float right, float bottom, float top, float zNear, float zFar, float zoom = 2f)
		{
			var m = Matrix4.identity;
			m.m00 = zoom / (right - left);
			m.m11 = zoom / (top - bottom);
			m.m22 = -2f / (zFar - zNear);
			m.m30 = -(right + left) / (right - left);
			m.m31 = -(top + bottom) / (top - bottom);
			m.m32 = -(zFar + zNear) / (zFar - zNear);

			return m;
		}

		// Matrix for projecting two-dimensional coordinates onto the screen.
		public static Matrix4 Orthographic(float left, float right, float bottom, float top, float zoom = 2f)
		{
			var m = Matrix4.identity;
			m.m00 = zoom / (right - left);
			m.m11 = zoom / (top - bottom);
			m.m22 = -1f;
			m.m30 = -(right + left) / (right - left);
			m.m31 = -(top + bottom) / (top - bottom);

			return m;
		}

		// Perspective transformation matrix.
		public static Matrix4 Perspective(float fov, float aspect, float zNear, float zFar)
		{
			var tanHalfFov = Math.Tan(fov / 2f);

			var m = Matrix4.zero;
			m.m00 = 1f / (aspect * tanHalfFov);
			m.m11 = 1f / (tanHalfFov);
			m.m22 = -(zFar + zNear) / (zFar - zNear);
			m.m23 = -1f;
			m.m32 = -(2f * zFar * zNear) / (zFar - zNear);

			return m;
		}

		// Symmetric perspective-view frustum with far plane at infinite.
		public static Matrix4 InfinitePerspective(float fov, float aspect, float zNear)
		{
			var range = Math.Tan(fov / 2f) * (double)zNear;
			var l = -range * aspect;
			var r = range * aspect;
			var b = -range;
			var t = range;

			var m = Matrix4.identity;
			m.m00 = (float)((2f * zNear) / (r - l));
			m.m11 = (float)((2f * zNear) / (t - b));
			m.m22 = -1f;
			m.m23 = -1f;
			m.m32 = -2f * zNear;

			return m;
		}

		// Perspective projection matrix based on a field of view.
		public static Matrix4 PerspectiveFov(float fov, float width, float height, float zNear, float zFar)
		{
			var h = Math.Cos(fov / 2f) / Math.Sin(fov / 2f);
			var w = h * (height / width);

			var m = Matrix4.zero;
			m.m00 = w;
			m.m11 = h;
			m.m22 = -(zFar + zNear) / (zFar - zNear);
			m.m23 = -1f;
			m.m32 = -(2f * zFar * zNear) / (zFar - zNear);

			return m;
		}

		// Map the specified object coordinates (obj.x, obj.y, obj.z) into window coordinates.
		public static Vector3f Project(Vector3f obj, Matrix4 model, Matrix4 proj, FloatRect viewport)
		{
			var tmp = proj * (model * (Vector4f)obj);
			tmp /= tmp.w;

			tmp = tmp * 0.5f + 0.5f;
			tmp.x = tmp.x * viewport.width + viewport.x;
			tmp.y = tmp.y * viewport.height + viewport.y;

			return (Vector3f)tmp;
		}

		// Map the specified window coordinates (win.x, win.y, win.z) into object coordinates.
		public static Vector3f UnProject(Vector3f win, Matrix4 model, Matrix4 proj, FloatRect viewport)
		{
			var tmp = (Vector4f)win;
			tmp.x = (tmp.x - viewport.x) / viewport.width;
			tmp.y = (tmp.y - viewport.y) / viewport.height;
			tmp = tmp * 2f - 1f;

			var unp = Math.Inverse(proj) * tmp;
			unp /= unp.w;
			var obj = Math.Inverse(model) * unp;

			return (Vector3f)(obj / obj.w);
		}

		// Map the specified window coordinates (win.x, win.y, win.z) into object coordinates (faster but less precise).
		public static Vector3f UnProjectFaster(Vector3f win, Matrix4 model, Matrix4 proj, FloatRect viewport)
		{
			var tmp = (Vector4f)win;
			tmp.x = (tmp.x - viewport.x) / viewport.width;
			tmp.y = (tmp.y - viewport.y) / viewport.height;
			tmp = tmp * 2f - 1f;

			var obj = Math.Inverse(proj * model) * tmp;

			return (Vector3f)(obj / obj.w);
		}
	}
}
