// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public static class GodotVector3Extensions
	{
		public static Godot.Vector3I RoundToVector3i(this Godot.Vector3 v)
		{
			return new Godot.Vector3I(Math.Round(v.X), Math.Round(v.Y), Math.Round(v.Z));
		}

		public static Godot.Vector3I FloorToVector3i(this Godot.Vector3 v)
		{
			return new Godot.Vector3I(Math.Floor(v.X), Math.Floor(v.Y), Math.Floor(v.Z));
		}

		public static Godot.Vector3I CeilToVector3i(this Godot.Vector3 v)
		{
			return new Godot.Vector3I(Math.Ceil(v.X), Math.Ceil(v.Y), Math.Ceil(v.Z));
		}

		public static Godot.Vector3 WithX(this Godot.Vector3 v, float value)
		{
			return new Godot.Vector3(value, v.Y, v.Z);
		}

		public static Godot.Vector3 WithY(this Godot.Vector3 v, float value)
		{
			return new Godot.Vector3(v.X, value, v.Z);
		}

		public static Godot.Vector3 WithZ(this Godot.Vector3 v, float value)
		{
			return new Godot.Vector3(v.X, v.Y, value);
		}
	}
}

#endif
