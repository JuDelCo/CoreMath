// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public partial struct IntRect
	{
		public static implicit operator Godot.Rect2I(IntRect r)
		{
			return new Godot.Rect2I(r.x, r.y, r.width, r.height);
		}

		public static implicit operator IntRect(Godot.Rect2I r)
		{
			return new IntRect(r.Position.X, r.Position.Y, r.Size.X, r.Size.Y);
		}
	}
}

#endif
