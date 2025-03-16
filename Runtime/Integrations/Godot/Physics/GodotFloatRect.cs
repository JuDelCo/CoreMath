// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public partial struct FloatRect
	{
		public static implicit operator Godot.Rect2(FloatRect r)
		{
			return new Godot.Rect2(r.x, r.y, r.width, r.height);
		}

		public static implicit operator FloatRect(Godot.Rect2 r)
		{
			return new FloatRect(r.Position.X, r.Position.Y, r.Size.X, r.Size.Y);
		}
	}
}

#endif
