// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public partial struct Vector2f
	{
		public static implicit operator Godot.Vector2(Vector2f v)
		{
			return new Godot.Vector2(v.x, v.y);
		}

		public static explicit operator Godot.Vector2I(Vector2f v)
		{
			return new Godot.Vector2I(Math.Round(v.x), Math.Round(v.y));
		}

		public static implicit operator Godot.Vector3(Vector2f v)
		{
			return new Godot.Vector3(v.x, v.y, 0f);
		}

		public static explicit operator Godot.Vector3I(Vector2f v)
		{
			return new Godot.Vector3I(Math.Round(v.x), Math.Round(v.y), 0);
		}

		public static implicit operator Godot.Vector4(Vector2f v)
		{
			return new Godot.Vector4(v.x, v.y, 0f, 0f);
		}

		public static implicit operator Godot.Vector4I(Vector2f v)
		{
			return new Godot.Vector4I(Math.Round(v.x), Math.Round(v.y), 0, 0);
		}

		// ---

		public static implicit operator Vector2f(Godot.Vector2 v)
		{
			return new Vector2f(v.X, v.Y);
		}

		public static implicit operator Vector2f(Godot.Vector2I v)
		{
			return new Vector2f(v.X, v.Y);
		}

		public static implicit operator Vector2f(Godot.Vector3 v)
		{
			return new Vector2f(v.X, v.Y);
		}

		public static implicit operator Vector2f(Godot.Vector3I v)
		{
			return new Vector2f(v.X, v.Y);
		}

		public static implicit operator Vector2f(Godot.Vector4 v)
		{
			return new Vector2f(v.X, v.Y);
		}

		public static implicit operator Vector2f(Godot.Vector4I v)
		{
			return new Vector2f(v.X, v.Y);
		}
	}
}

#endif
