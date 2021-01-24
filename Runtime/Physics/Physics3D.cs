// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public static partial class Physics3D
	{
		public static bool CheckCollisionPointSphere(Vector3f point, Sphere s)
		{
			return CheckCollisionSpheres(new Sphere(point, 0), s);
		}

		public static bool CheckCollisionSpheres(Sphere a, Sphere b)
		{
			bool collision = false;

			if (Math.DistanceSqr(b.position, a.position) <= Math.Sqr(a.radius + b.radius))
			{
				collision = true;
			}

			return collision;
		}
	}
}
