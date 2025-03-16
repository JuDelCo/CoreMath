// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public partial struct Vector4i
	{
		public static implicit operator Godot.Vector2(Vector4i v)
		{
			return new Godot.Vector2(v.x, v.y);
		}

		public static implicit operator Godot.Vector2I(Vector4i v)
		{
			return new Godot.Vector2I(v.x, v.y);
		}

		public static implicit operator Godot.Vector3(Vector4i v)
		{
			return new Godot.Vector3(v.x, v.y, v.z);
		}

		public static implicit operator Godot.Vector3I(Vector4i v)
		{
			return new Godot.Vector3I(v.x, v.y, v.z);
		}

		public static implicit operator Godot.Vector4(Vector4i v)
		{
			return new Godot.Vector4(v.x, v.y, v.z, v.w);
		}

		public static implicit operator Godot.Vector4I(Vector4i v)
		{
			return new Godot.Vector4I(v.x, v.y, v.z, v.w);
		}

		// ---

		public static explicit operator Vector4i(Godot.Vector2 v)
		{
			return new Vector4i(Math.Round(v.X), Math.Round(v.Y), 0, 0);
		}

		public static implicit operator Vector4i(Godot.Vector2I v)
		{
			return new Vector4i(v.X, v.Y, 0, 0);
		}

		public static explicit operator Vector4i(Godot.Vector3 v)
		{
			return new Vector4i(Math.Round(v.X), Math.Round(v.Y), Math.Round(v.Z), 0);
		}

		public static implicit operator Vector4i(Godot.Vector3I v)
		{
			return new Vector4i(v.X, v.Y, v.Z, 0);
		}

		public static explicit operator Vector4i(Godot.Vector4 v)
		{
			return new Vector4i(Math.Round(v.X), Math.Round(v.Y), Math.Round(v.Z), Math.Round(v.W));
		}

		public static explicit operator Vector4i(Godot.Vector4I v)
		{
			return new Vector4i(v.X, v.Y, v.Z, v.W);
		}
	}
}

#endif
