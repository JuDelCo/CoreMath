// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2025 Juan Delgado (@JuDelCo)

#if GODOT4_3_OR_GREATER

using Transform = Godot.Transform3D;
using Vector3 = Godot.Vector3;
using Quaternion = Godot.Quaternion;

namespace Ju.Math
{
	public static partial class ThreeBoneIK
	{
		public static void Calculate(Transform top, Transform topMid, Transform lowMid, Transform low, Vector3 target, Vector3 hint, Vector3 lowHint, ref Quaternion topLocalRotation, ref Quaternion topMidLocalRotation, ref Quaternion lowMidLocalRotation)
		{
			Quat tempTopLocalRotation = topLocalRotation;
			Quat tempTopMidLocalRotation = topMidLocalRotation;
			Quat tempLowMidLocalRotation = lowMidLocalRotation;
			Calculate(top.Origin, topMid.Origin, lowMid.Origin, low.Origin, target, hint, lowHint, top.Basis.GetRotationQuaternion(), topMid.Basis.GetRotationQuaternion(), lowMid.Basis.GetRotationQuaternion(), ref tempTopLocalRotation, ref tempTopMidLocalRotation, ref tempLowMidLocalRotation);
			topLocalRotation = tempTopLocalRotation;
			topMidLocalRotation = tempTopMidLocalRotation;
			lowMidLocalRotation = tempLowMidLocalRotation;
		}
	}
}

#endif
