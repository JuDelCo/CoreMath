// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public static class GodotIntRectExtensions
	{
		public static IntRect RoundToIntRect(this Godot.Rect2 r)
		{
			return new IntRect(Math.Round(r.Position.X), Math.Round(r.Position.Y), Math.Round(r.Size.X), Math.Round(r.Size.Y));
		}

		public static IntRect FloorToIntRect(this Godot.Rect2 r)
		{
			return new IntRect(Math.Floor(r.Position.X), Math.Floor(r.Position.Y), Math.Floor(r.Size.X), Math.Floor(r.Size.Y));
		}

		public static IntRect CeilToIntRect(this Godot.Rect2 r)
		{
			return new IntRect(Math.Ceil(r.Position.X), Math.Ceil(r.Position.Y), Math.Ceil(r.Size.X), Math.Ceil(r.Size.Y));
		}
	}
}

#endif
