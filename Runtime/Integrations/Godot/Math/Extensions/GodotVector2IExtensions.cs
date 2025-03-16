// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public static class GodotVector2IExtensions
	{
		public static Godot.Vector2I WithX(this Godot.Vector2I v, int value)
		{
			return new Godot.Vector2I(value, v.Y);
		}

		public static Godot.Vector2I WithY(this Godot.Vector2I v, int value)
		{
			return new Godot.Vector2I(v.X, value);
		}
	}
}

#endif
