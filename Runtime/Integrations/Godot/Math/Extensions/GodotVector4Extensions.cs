// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public static class GodotVector4Extensions
	{
		public static Godot.Vector4I RoundToVector4i(this Godot.Vector4 v)
		{
			return new Godot.Vector4I(Math.Round(v.X), Math.Round(v.Y), Math.Round(v.Z), Math.Round(v.W));
		}

		public static Godot.Vector4I FloorToVector4i(this Godot.Vector4 v)
		{
			return new Godot.Vector4I(Math.Floor(v.X), Math.Floor(v.Y), Math.Floor(v.Z), Math.Floor(v.W));
		}

		public static Godot.Vector4I CeilToVector4i(this Godot.Vector4 v)
		{
			return new Godot.Vector4I(Math.Ceil(v.X), Math.Ceil(v.Y), Math.Ceil(v.Z), Math.Ceil(v.W));
		}

		public static Godot.Vector4 WithX(this Godot.Vector4 v, float value)
		{
			return new Godot.Vector4(value, v.Y, v.Z, v.W);
		}

		public static Godot.Vector4 WithY(this Godot.Vector4 v, float value)
		{
			return new Godot.Vector4(v.X, value, v.Z, v.W);
		}

		public static Godot.Vector4 WithZ(this Godot.Vector4 v, float value)
		{
			return new Godot.Vector4(v.X, v.Y, value, v.W);
		}

		public static Godot.Vector4 WithW(this Godot.Vector4 v, float value)
		{
			return new Godot.Vector4(v.X, v.Y, v.Z, value);
		}
	}
}

#endif
