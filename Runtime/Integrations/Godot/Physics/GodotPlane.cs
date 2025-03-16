// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public partial struct Plane
	{
		public static implicit operator Godot.Plane(Plane p)
		{
			return new Godot.Plane(p.normal, p.distance);
		}

		public static implicit operator Plane(Godot.Plane p)
		{
			return new Plane(p.Normal, p.D);
		}
	}
}

#endif
