// SPDX-License-Identifier: MIT
// Copyright (c) 2016-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math.Random
{
	public static partial class Random
	{
		public static Ray Ray(Vector3f position, System.Random random = null)
		{
			return new Ray(position, Direction3D(random));
		}

		public static Plane Plane(Vector3f point, System.Random random = null)
		{
			return new Plane(Direction3D(random), point);
		}

		public static Sphere Sphere(Vector3f position, float minRadius, float maxRadius, System.Random random = null)
		{
			return new Sphere(position, Float(minRadius, maxRadius, random));
		}
	}
}
