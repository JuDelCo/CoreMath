// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public partial struct Matrix3
	{
		public static implicit operator Godot.Basis(Matrix3 m)
		{
			return new Godot.Basis(
				new Godot.Vector3(m.m00, m.m01, m.m02), // Column 0
				new Godot.Vector3(m.m10, m.m11, m.m12), // Column 1
				new Godot.Vector3(m.m20, m.m21, m.m22)  // Column 2
			);
		}

		public static implicit operator Matrix3(Godot.Basis basis)
		{
			var m = Matrix3.identity;
			m.m00 = basis[0].X;
			m.m01 = basis[0].Y;
			m.m02 = basis[0].Z;
			m.m10 = basis[1].X;
			m.m11 = basis[1].Y;
			m.m12 = basis[1].Z;
			m.m20 = basis[2].X;
			m.m21 = basis[2].Y;
			m.m22 = basis[2].Z;

			return m;
		}
	}
}

#endif
