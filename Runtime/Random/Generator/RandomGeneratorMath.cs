// SPDX-License-Identifier: MIT
// Copyright (c) 2016-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math.Random
{
	public partial class RandomGenerator
	{
		public Vector2i Vector2i(int min, int max)
		{
			return Random.Vector2i(min, max, random);
		}

		public Vector2i Vector2i(Vector2i min, Vector2i max)
		{
			return Random.Vector2i(min, max, random);
		}

		public Vector2f Vector2f()
		{
			return Random.Vector2f(random);
		}

		public Vector2f Vector2f(float min, float max)
		{
			return Random.Vector2f(min, max, random);
		}

		public Vector2f Vector2f(Vector2f min, Vector2f max)
		{
			return Random.Vector2f(min, max, random);
		}

		public Vector3i Vector3i(int min, int max)
		{
			return Random.Vector3i(min, max, random);
		}

		public Vector3i Vector3i(Vector3i min, Vector3i max)
		{
			return Random.Vector3i(min, max, random);
		}

		public Vector3f Vector3f()
		{
			return Random.Vector3f(random);
		}

		public Vector3f Vector3f(float min, float max)
		{
			return Random.Vector3f(min, max, random);
		}

		public Vector3f Vector3f(Vector3f min, Vector3f max)
		{
			return Random.Vector3f(min, max, random);
		}

		public Vector4i Vector4i(int min, int max)
		{
			return Random.Vector4i(min, max, random);
		}

		public Vector4i Vector4i(Vector4i min, Vector4i max)
		{
			return Random.Vector4i(min, max, random);
		}

		public Vector4f Vector4f()
		{
			return Random.Vector4f(random);
		}

		public Vector4f Vector4f(float min, float max)
		{
			return Random.Vector4f(min, max, random);
		}

		public Vector4f Vector4f(Vector4f min, Vector4f max)
		{
			return Random.Vector4f(min, max, random);
		}

		public Quat Quat()
		{
			return Random.Quat(random);
		}
	}
}
