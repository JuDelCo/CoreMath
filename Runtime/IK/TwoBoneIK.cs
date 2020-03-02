
namespace Ju.Math
{
	public static partial class TwoBoneIK
	{
		public static void Calculate(Vector3f top, Vector3f mid, Vector3f low, Vector3f target, Vector3f hint, Quat topRotation, Quat midRotation, ref Quat topLocalRotation, ref Quat midLocalRotation)
		{
			// Epsilon is used to prevent the chain to be fully extended (in order to prevent float point errors).
			float epsilon = 0.0001f;
			float lengthTopMid = (mid - top).length;
			float lengthMidLow = (low - mid).length;
			float lengthTopLow = (low - top).length;
			float lengthTopTarget = Math.Clamp((target - top).length, epsilon, lengthTopMid + lengthMidLow - epsilon);

			// Get angle difference using current and desired angle for mid.
			// Axis is multiplied by the inverse of mid global rotation in order to make the new rotation in local space (this is done every time).
			float currentMidAngle = Math.TriangleAngle(lengthTopLow, lengthTopMid, lengthMidLow);
			float desiredMidAngle = Math.TriangleAngle(lengthTopTarget, lengthTopMid, lengthMidLow);
			float midAngleDiff = (currentMidAngle - desiredMidAngle);
			Vector3f midAxis = Vector3f.Normalize(Vector3f.Cross(top - mid, mid - low));
			Quat finalMidRotation = new Quat(midAngleDiff, Quat.Inverse(midRotation) * midAxis);
			midLocalRotation = midLocalRotation * finalMidRotation;

			// Rotate low in global space.
			Vector3f rotatedLow = (new Quat(midAngleDiff, midAxis) * (low - mid)) + mid;

			// Get angle difference by calculating the angle between top-low-target.
			float topAngleDiff = Vector3f.Angle(rotatedLow - top, target - top);
			Vector3f topAxis = Vector3f.Normalize(Vector3f.Cross(rotatedLow - top, target - top));
			Quat finalTopRotation = new Quat(topAngleDiff, Quat.Inverse(topRotation) * topAxis);
			topLocalRotation = topLocalRotation * finalTopRotation;

			// Rotate mid and low (again) in global space.
			Vector3f rotatedMid = (new Quat(topAngleDiff, topAxis) * (mid - top)) + top;
			Vector3f lastRotatedLow = (new Quat(topAngleDiff, topAxis) * new Quat(midAngleDiff, midAxis) * (low - mid)) + rotatedMid;

			// Get a plane using top and the normal top-low (rotated).
			// This will be used to calculate how many degrees needs top to be rotated in order to align mid with hint position (top and low won't be moved).
			Vector3f planeNormal = Vector3f.Normalize(top - lastRotatedLow);
			var plane = new Plane(planeNormal, top);
			Vector3f projectedMid = plane.ClosestPoint(rotatedMid);
			Vector3f projectedHint = plane.ClosestPoint(hint);
			float angleDiff = Vector3f.SignedAngle(top - projectedMid, top - projectedHint, plane.normal);
			Quat finalAdjustTopRotation = new Quat(angleDiff, Quat.Inverse(topRotation) * planeNormal);
			topLocalRotation = finalAdjustTopRotation * topLocalRotation;
		}
	}
}
