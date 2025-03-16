// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public partial struct Quat
	{
		public static implicit operator Godot.Quaternion(Quat q)
		{
			return new Godot.Quaternion(q.x, q.y, q.z, q.w);
		}

		public static implicit operator Quat(Godot.Quaternion q)
		{
			return new Quat(q.X, q.Y, q.Z, q.W);
		}
	}
}

#endif
