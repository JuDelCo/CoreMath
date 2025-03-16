// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public static class GodotVector2Extensions
	{
		public static Godot.Vector2I RoundToVector2i(this Godot.Vector2 v)
		{
			return new Godot.Vector2I(Math.Round(v.X), Math.Round(v.Y));
		}

		public static Godot.Vector2I FloorToVector2i(this Godot.Vector2 v)
		{
			return new Godot.Vector2I(Math.Floor(v.X), Math.Floor(v.Y));
		}

		public static Godot.Vector2I CeilToVector2i(this Godot.Vector2 v)
		{
			return new Godot.Vector2I(Math.Ceil(v.X), Math.Ceil(v.Y));
		}

		public static Godot.Vector2 WithX(this Godot.Vector2 v, float value)
		{
			return new Godot.Vector2(value, v.Y);
		}

		public static Godot.Vector2 WithY(this Godot.Vector2 v, float value)
		{
			return new Godot.Vector2(v.X, value);
		}
	}
}

#endif
