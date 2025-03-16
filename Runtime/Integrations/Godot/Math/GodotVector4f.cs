// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public partial struct Vector4f
	{
		public static implicit operator Godot.Vector2(Vector4f v)
		{
			return new Godot.Vector2(v.x, v.y);
		}

		public static explicit operator Godot.Vector2I(Vector4f v)
		{
			return new Godot.Vector2I(Math.Round(v.x), Math.Round(v.y));
		}

		public static implicit operator Godot.Vector3(Vector4f v)
		{
			return new Godot.Vector3(v.x, v.y, v.z);
		}

		public static explicit operator Godot.Vector3I(Vector4f v)
		{
			return new Godot.Vector3I(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z));
		}

		public static implicit operator Godot.Vector4(Vector4f v)
		{
			return new Godot.Vector4(v.x, v.y, v.z, v.w);
		}

		public static implicit operator Godot.Vector4I(Vector4f v)
		{
			return new Godot.Vector4I(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z), Math.Round(v.w));
		}

		// ---

		public static implicit operator Vector4f(Godot.Vector2 v)
		{
			return new Vector4f(v.X, v.Y, 0f, 0f);
		}

		public static implicit operator Vector4f(Godot.Vector2I v)
		{
			return new Vector4f(v.X, v.Y, 0f, 0f);
		}

		public static implicit operator Vector4f(Godot.Vector3 v)
		{
			return new Vector4f(v.X, v.Y, v.Z, 0f);
		}

		public static implicit operator Vector4f(Godot.Vector3I v)
		{
			return new Vector4f(v.X, v.Y, v.Z, 0f);
		}

		public static implicit operator Vector4f(Godot.Vector4 v)
		{
			return new Vector4f(v.X, v.Y, v.Z, v.W);
		}

		public static implicit operator Vector4f(Godot.Vector4I v)
		{
			return new Vector4f(v.X, v.Y, v.Z, v.W);
		}
	}
}

#endif
