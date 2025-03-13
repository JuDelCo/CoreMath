// SPDX-License-Identifier: MIT
// Copyright (c) 2016-2025 Juan Delgado (@JuDelCo)

namespace Ju.Math.Random
{
	public partial class RandomGenerator
	{
		public Vector2f Direction2D()
		{
			return Random.Direction2D(random);
		}

		public Vector3f Direction3D()
		{
			return Random.Direction3D(random);
		}

		public Quat DirectionQuat()
		{
			return Random.DirectionQuat(random);
		}
	}
}
