// SPDX-License-Identifier: MIT
// Copyright (c) 2016-2025 Juan Delgado (@JuDelCo)

namespace Ju.Math.Random
{
	public static partial class Random
	{
		public static Vector2f Direction2D(System.Random random = null)
		{
			return (new Vector2f(Float(-1f, 1f, random), Float(-1f, 1f, random))).normalized;
		}

		public static Vector3f Direction3D(System.Random random = null)
		{
			return (new Vector3f(Float(-1f, 1f, random), Float(-1f, 1f, random), Float(-1f, 1f, random))).normalized;
		}

		public static Quat DirectionQuat(System.Random random = null)
		{
			return (new Quat(Float(-1f, 1f, random), Float(-1f, 1f, random), Float(-1f, 1f, random), Float(-1, 1f, random))).normalized;
		}
	}
}
