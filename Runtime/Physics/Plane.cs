// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

using System;

namespace Ju.Math
{
	[Serializable]
	public partial struct Plane : IEquatable<Plane>
	{
		public Vector3f normal;
		public float distance;

		public Plane(Vector3f normal, float distance)
		{
			this.normal = Vector3f.Normalize(normal);
			this.distance = distance;
		}

		public Plane(Vector3f normal, Vector3f point)
		{
			this.normal = Vector3f.Normalize(normal);
			this.distance = -Vector3f.Dot(this.normal, point);
		}

		public Plane(Vector3f a, Vector3f b, Vector3f c)
		{
			this.normal = Vector3f.Normalize(Vector3f.Cross(b - a, c - a));
			this.distance = -Vector3f.Dot(this.normal, a);
		}

		public Vector3f ClosestPoint(Vector3f point)
		{
			var pointToPlaneDistance = Vector3f.Dot(normal, point) + distance;

			return point - (normal * pointToPlaneDistance);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;
				hash = hash * 23 + normal.GetHashCode();
				hash = hash * 23 + distance.GetHashCode();
				return hash;
			}
		}

		public bool Equals(Plane other)
		{
			return (this == other);
		}

		public override bool Equals(object obj)
		{
			return (obj is Plane plane && (this == plane));
		}

		public static bool operator ==(Plane a, Plane b)
		{
			return (a.normal == b.normal && a.distance == b.distance);
		}

		public static bool operator !=(Plane a, Plane b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return $"[ {normal} , {distance} ]";
		}
	}
}
