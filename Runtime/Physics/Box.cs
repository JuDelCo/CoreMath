// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2025 Juan Delgado (@JuDelCo)

using System;

namespace Ju.Math
{
	[Serializable]
	public partial struct Box : IEquatable<Box>
	{
		private Vector3f centerPosition;
		private Vector3f boxSize;

		public Box(Vector3f center, Vector3f size)
		{
			this.centerPosition = center;
			this.boxSize = size;
		}

#pragma warning disable IDE1006

		public Vector3f center
		{
			get { return centerPosition; }
			set { centerPosition = value; }
		}

		public Vector3f extents
		{
			get { return (size / 2f); }
			set { boxSize = value * 2f; }
		}

		public Vector3f size
		{
			get { return boxSize; }
			set { boxSize = value; }
		}

		public Vector3f min
		{
			get { return (centerPosition - extents); }
		}

		public Vector3f max
		{
			get { return (centerPosition + extents); }
		}

#pragma warning restore IDE1006

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;
				hash = hash * 23 + min.GetHashCode();
				hash = hash * 23 + max.GetHashCode();
				return hash;
			}
		}

		public bool Equals(Box other)
		{
			return (this == other);
		}

		public override bool Equals(object obj)
		{
			return (obj is Box box && (this == box));
		}

		public static bool operator ==(Box a, Box b)
		{
			return (a.centerPosition == b.centerPosition && a.boxSize == b.boxSize);
		}

		public static bool operator !=(Box a, Box b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return $"[ {centerPosition} , {boxSize} ]";
		}
	}
}
