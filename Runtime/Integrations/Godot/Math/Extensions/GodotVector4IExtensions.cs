// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public static class GodotVector4IExtensions
	{
		public static Godot.Vector4I WithX(this Godot.Vector4I v, int value)
		{
			return new Godot.Vector4I(value, v.Y, v.Z, v.W);
		}

		public static Godot.Vector4I WithY(this Godot.Vector4I v, int value)
		{
			return new Godot.Vector4I(v.X, value, v.Z, v.W);
		}

		public static Godot.Vector4I WithZ(this Godot.Vector4I v, int value)
		{
			return new Godot.Vector4I(v.X, v.Y, value, v.W);
		}

		public static Godot.Vector4I WithW(this Godot.Vector4I v, int value)
		{
			return new Godot.Vector4I(v.X, v.Y, v.Z, value);
		}
	}
}

#endif
