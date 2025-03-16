// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public static class GodotVector3IExtensions
	{
		public static Godot.Vector3I WithX(this Godot.Vector3I v, int value)
		{
			return new Godot.Vector3I(value, v.Y, v.Z);
		}

		public static Godot.Vector3I WithY(this Godot.Vector3I v, int value)
		{
			return new Godot.Vector3I(v.X, value, v.Z);
		}

		public static Godot.Vector3I WithZ(this Godot.Vector3I v, int value)
		{
			return new Godot.Vector3I(v.X, v.Y, value);
		}
	}
}

#endif
