// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

using Transform = Godot.Transform3D;
using Vector3 = Godot.Vector3;
using Quaternion = Godot.Quaternion;

namespace Ju.Math
{
	public static partial class TwoBoneIK
	{
		public static void Calculate(Transform top, Transform mid, Transform low, Vector3 target, Vector3 hint, ref Quaternion topLocalRotation, ref Quaternion midLocalRotation)
		{
			Quat tempTopLocalRotation = topLocalRotation;
			Quat tempMidLocalRotation = midLocalRotation;
			Calculate(top.Origin, mid.Origin, low.Origin, target, hint, top.Basis.GetRotationQuaternion(), mid.Basis.GetRotationQuaternion(), ref tempTopLocalRotation, ref tempMidLocalRotation);
			topLocalRotation = tempTopLocalRotation;
			midLocalRotation = tempMidLocalRotation;
		}
	}
}

#endif
