// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

namespace Ju.Math
{
	public partial struct Matrix4
	{
		public static implicit operator Godot.Transform3D(Matrix4 m)
		{
			return new Godot.Transform3D(
				((Godot.Basis) (Matrix3) m),
				new Godot.Vector3(m.m30, m.m31, m.m32)
			);
		}

		public static implicit operator Matrix4(Godot.Transform3D transform3D)
		{
			var m = Matrix4.identity;
			m.m00 = transform3D.Basis[0].X;
			m.m01 = transform3D.Basis[0].Y;
			m.m02 = transform3D.Basis[0].Z;
			m.m10 = transform3D.Basis[1].X;
			m.m11 = transform3D.Basis[1].Y;
			m.m12 = transform3D.Basis[1].Z;
			m.m20 = transform3D.Basis[2].X;
			m.m21 = transform3D.Basis[2].Y;
			m.m22 = transform3D.Basis[2].Z;
			m.m30 = transform3D.Origin.X;
			m.m31 = transform3D.Origin.Y;
			m.m32 = transform3D.Origin.Z;
			m.m33 = 1;

			return m;
		}
	}
}

#endif
