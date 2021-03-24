// SPDX-License-Identifier: MIT
// Copyright (c) 2016-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math.Random
{
	public static partial class Random
	{
		public static Vector2i Vector2i(int min, int max, System.Random random = null)
		{
			return min + new Vector2i(Int(max - min, random), Int(max - min, random));
		}

		public static Vector2i Vector2i(Vector2i min, Vector2i max, System.Random random = null)
		{
			return min + new Vector2i(Int(max.x - min.x, random), Int(max.y - min.y, random));
		}

		public static Vector2f Vector2f(System.Random random = null)
		{
			return (new Vector2f(Float(-1f, 1f, random), Float(-1f, 1f, random))).normalized;
		}

		public static Vector2f Vector2f(float min, float max, System.Random random = null)
		{
			return min + new Vector2f(Float(max - min, random), Float(max - min, random));
		}

		public static Vector2f Vector2f(Vector2f min, Vector2f max, System.Random random = null)
		{
			return min + new Vector2f(Float(max.x - min.x, random), Float(max.y - min.y, random));
		}

		public static Vector3i Vector3i(int min, int max, System.Random random = null)
		{
			return min + new Vector3i(Int(max - min, random), Int(max - min, random), Int(max - min, random));
		}

		public static Vector3i Vector3i(Vector3i min, Vector3i max, System.Random random = null)
		{
			return min + new Vector3i(Int(max.x - min.x, random), Int(max.y - min.y, random), Int(max.z - min.z, random));
		}

		public static Vector3f Vector3f(System.Random random = null)
		{
			return (new Vector3f(Float(-1f, 1f, random), Float(-1f, 1f, random), Float(-1f, 1f, random))).normalized;
		}

		public static Vector3f Vector3f(float min, float max, System.Random random = null)
		{
			return min + new Vector3f(Float(max - min, random), Float(max - min, random), Float(max - min, random));
		}

		public static Vector3f Vector3f(Vector3f min, Vector3f max, System.Random random = null)
		{
			return min + new Vector3f(Float(max.x - min.x, random), Float(max.y - min.y, random), Float(max.z - min.z, random));
		}

		public static Vector4i Vector4i(int min, int max, System.Random random = null)
		{
			return min + new Vector4i(Int(max - min, random), Int(max - min, random), Int(max - min, random), Int(max - min, random));
		}

		public static Vector4i Vector4i(Vector4i min, Vector4i max, System.Random random = null)
		{
			return min + new Vector4i(Int(max.x - min.x, random), Int(max.y - min.y, random), Int(max.z - min.z, random), Int(max.w - min.w, random));
		}

		public static Vector4f Vector4f(System.Random random = null)
		{
			return (new Vector4f(Float(-1f, 1f, random), Float(-1f, 1f, random), Float(-1f, 1f, random), Float(-1, 1f, random))).normalized;
		}

		public static Vector4f Vector4f(float min, float max, System.Random random = null)
		{
			return min + new Vector4f(Float(max - min, random), Float(max - min, random), Float(max - min, random), Float(max - min, random));
		}

		public static Vector4f Vector4f(Vector4f min, Vector4f max, System.Random random = null)
		{
			return min + new Vector4f(Float(max.x - min.x, random), Float(max.y - min.y, random), Float(max.z - min.z, random), Float(max.w - min.w, random));
		}

		public static Quat Quat(System.Random random = null)
		{
			return (new Quat(Float(-1f, 1f, random), Float(-1f, 1f, random), Float(-1f, 1f, random), Float(-1, 1f, random))).normalized;
		}
	}
}
