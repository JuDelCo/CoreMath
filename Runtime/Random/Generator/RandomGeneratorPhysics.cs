// SPDX-License-Identifier: MIT
// Copyright (c) 2016-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math.Random
{
	public partial class RandomGenerator
	{
		public Ray Ray(Vector3f position)
		{
			return Random.Ray(position, random);
		}

		public Plane Plane(Vector3f point)
		{
			return Random.Plane(point, random);
		}

		public Sphere Sphere(Vector3f position, float minRadius, float maxRadius)
		{
			return Random.Sphere(position, minRadius, maxRadius, random);
		}
	}
}
