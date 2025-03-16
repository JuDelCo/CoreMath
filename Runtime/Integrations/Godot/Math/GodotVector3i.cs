// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public partial struct Vector3i
	{
		public static implicit operator Godot.Vector2(Vector3i v)
		{
			return new Godot.Vector2(v.x, v.y);
		}

		public static implicit operator Godot.Vector2I(Vector3i v)
		{
			return new Godot.Vector2I(v.x, v.y);
		}

		public static implicit operator Godot.Vector3(Vector3i v)
		{
			return new Godot.Vector3(v.x, v.y, v.z);
		}

		public static implicit operator Godot.Vector3I(Vector3i v)
		{
			return new Godot.Vector3I(v.x, v.y, v.z);
		}

		public static implicit operator Godot.Vector4(Vector3i v)
		{
			return new Godot.Vector4(v.x, v.y, v.z, 0f);
		}

		public static implicit operator Godot.Vector4I(Vector3i v)
		{
			return new Godot.Vector4I(v.x, v.y, v.z, 0);
		}

		// ---

		public static explicit operator Vector3i(Godot.Vector2 v)
		{
			return new Vector3i(Math.Round(v.X), Math.Round(v.Y), 0);
		}

		public static implicit operator Vector3i(Godot.Vector2I v)
		{
			return new Vector3i(v.X, v.Y, 0);
		}

		public static explicit operator Vector3i(Godot.Vector3 v)
		{
			return new Vector3i(Math.Round(v.X), Math.Round(v.Y), Math.Round(v.Z));
		}

		public static implicit operator Vector3i(Godot.Vector3I v)
		{
			return new Vector3i(v.X, v.Y, v.Z);
		}

		public static explicit operator Vector3i(Godot.Vector4 v)
		{
			return new Vector3i(Math.Round(v.X), Math.Round(v.Y), Math.Round(v.Z));
		}

		public static explicit operator Vector3i(Godot.Vector4I v)
		{
			return new Vector3i(v.X, v.Y, v.Z);
		}
	}
}

#endif
