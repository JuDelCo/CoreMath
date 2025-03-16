// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public partial struct Vector2i
	{
		public static implicit operator Godot.Vector2(Vector2i v)
		{
			return new Godot.Vector2(v.x, v.y);
		}

		public static implicit operator Godot.Vector2I(Vector2i v)
		{
			return new Godot.Vector2I(v.x, v.y);
		}

		public static implicit operator Godot.Vector3(Vector2i v)
		{
			return new Godot.Vector3(v.x, v.y, 0f);
		}

		public static implicit operator Godot.Vector3I(Vector2i v)
		{
			return new Godot.Vector3I(v.x, v.y, 0);
		}

		public static implicit operator Godot.Vector4(Vector2i v)
		{
			return new Godot.Vector4(v.x, v.y, 0f, 0f);
		}

		public static implicit operator Godot.Vector4I(Vector2i v)
		{
			return new Godot.Vector4I(v.x, v.y, 0, 0);
		}

		// ---

		public static explicit operator Vector2i(Godot.Vector2 v)
		{
			return new Vector2i(Math.Round(v.X), Math.Round(v.Y));
		}

		public static implicit operator Vector2i(Godot.Vector2I v)
		{
			return new Vector2i(v.X, v.Y);
		}

		public static explicit operator Vector2i(Godot.Vector3 v)
		{
			return new Vector2i(Math.Round(v.X), Math.Round(v.Y));
		}

		public static implicit operator Vector2i(Godot.Vector3I v)
		{
			return new Vector2i(v.X, v.Y);
		}

		public static explicit operator Vector2i(Godot.Vector4 v)
		{
			return new Vector2i(Math.Round(v.X), Math.Round(v.Y));
		}

		public static explicit operator Vector2i(Godot.Vector4I v)
		{
			return new Vector2i(v.X, v.Y);
		}
	}
}

#endif
