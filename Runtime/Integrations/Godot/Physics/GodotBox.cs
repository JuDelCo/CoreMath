// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public partial struct Box
	{
		public static implicit operator Godot.Aabb(Box b)
		{
			return new Godot.Aabb(b.center, b.size);
		}

		public static implicit operator Box(Godot.Aabb b)
		{
			return new Box(b.GetCenter(), b.Size);
		}
	}
}

#endif
