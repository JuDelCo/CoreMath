
namespace Ju.Math
{
	public static partial class ThreeBoneIK
	{
		public static void Calculate(Vector3f top, Vector3f topMid, Vector3f lowMid, Vector3f low, Vector3f target, Vector3f hint, Vector3f lowHint, Quat topRotation, Quat topMidRotation, Quat lowMidRotation, ref Quat topLocalRotation, ref Quat topMidLocalRotation, ref Quat lowMidLocalRotation)
		{
			// Calculate the target for the first part of the algorithm (identical to the two bone IK).
			Vector3f targetLowHintDirection = Vector3f.Normalize(lowHint - target);
			float lengthLowMidLow = (lowMid - low).length;
			Vector3f targetTwoBoneIK = target + (targetLowHintDirection * lengthLowMidLow);

			// Epsilon is used to prevent the chain to be fully extended (in order to prevent float point errors).
			float epsilon = 0.0001f;
			float lengthTopTopMid = (topMid - top).length;
			float lengthTopMidLowMid = (lowMid - topMid).length;
			float lengthTopLowMid = (lowMid - top).length;
			float lengthTopTarget = Math.Clamp((targetTwoBoneIK - top).length, epsilon, lengthTopTopMid + lengthTopMidLowMid - epsilon);

			// Get angle difference using current and desired angle for topMid.
			// Axis is multiplied by the inverse of topMid global rotation in order to make the new rotation in local space (this is done every time).
			float currentTopMidAngle = Math.TriangleAngle(lengthTopLowMid, lengthTopTopMid, lengthTopMidLowMid);
			float desiredTopMidAngle = Math.TriangleAngle(lengthTopTarget, lengthTopTopMid, lengthTopMidLowMid);
			float topMidAngleDiff = (currentTopMidAngle - desiredTopMidAngle);
			Vector3f topMidAxis = Vector3f.Normalize(Vector3f.Cross(top - topMid, topMid - lowMid));
			Quat finalTopMidRotation = new Quat(topMidAngleDiff, Quat.Inverse(topMidRotation) * topMidAxis);
			topMidLocalRotation *= finalTopMidRotation;

			// Rotate lowMid in global space.
			Vector3f rotatedLowMid = (new Quat(topMidAngleDiff, topMidAxis) * (lowMid - topMid)) + topMid;

			// Get angle difference by calculating the angle between top-lowMid-targetTwoBoneIK.
			float topAngleDiff = Vector3f.Angle(rotatedLowMid - top, targetTwoBoneIK - top);
			Vector3f topAxis = Vector3f.Normalize(Vector3f.Cross(rotatedLowMid - top, targetTwoBoneIK - top));
			Quat finalTopRotation = new Quat(topAngleDiff, Quat.Inverse(topRotation) * topAxis);
			topLocalRotation *= finalTopRotation;

			// Rotate topMid and lowMid (again) in global space.
			Vector3f rotatedTopMid = (new Quat(topAngleDiff, topAxis) * (topMid - top)) + top;
			Vector3f lastRotatedLowMid = (new Quat(topAngleDiff, topAxis) * new Quat(topMidAngleDiff, topMidAxis) * (lowMid - topMid)) + rotatedTopMid;

			// Get a plane using top and the normal top-lowMid (rotated).
			// This will be used to calculate how many degrees needs top to be rotated in order to align topMid with hint position (top and lowMid won't be moved).
			Vector3f planeNormal = Vector3f.Normalize(top - lastRotatedLowMid);
			var plane = new Plane(planeNormal, top);
			Vector3f projectedTopMid = plane.ClosestPoint(rotatedTopMid);
			Vector3f projectedHint = plane.ClosestPoint(hint);
			float angleDiff = Vector3f.SignedAngle(top - projectedTopMid, top - projectedHint, planeNormal);
			Quat finalAdjustTopRotation = new Quat(angleDiff, Quat.Inverse(topRotation) * planeNormal);
			topLocalRotation = finalAdjustTopRotation * topLocalRotation;

			// Rotate (again) the global space positions (and lowMid rotation).
			//Vector3f lastRotatedTopMid = (new Quat(angleDiff, planeNormal) * (rotatedTopMid - top)) + top;
			Vector3f lastRotatedLow = (new Quat(angleDiff, planeNormal) * new Quat(topAngleDiff, topAxis) * new Quat(topMidAngleDiff, topMidAxis) * (low - lowMid)) + lastRotatedLowMid;
			Quat rotatedLowMidRotation = new Quat(angleDiff, planeNormal) * new Quat(topAngleDiff, topAxis) * new Quat(topMidAngleDiff, topMidAxis) * lowMidRotation;

			// Get angle difference by calculating the angle between low-lowMid-target.
			float midLowAngleDiff = Vector3f.Angle(lastRotatedLow - lastRotatedLowMid, target - lastRotatedLowMid);
			Vector3f midLowAxis = Vector3f.Normalize(Vector3f.Cross(lastRotatedLow - lastRotatedLowMid, target - lastRotatedLowMid));
			Quat finalMidLowRotation = new Quat(midLowAngleDiff, Quat.Inverse(rotatedLowMidRotation) * midLowAxis);
			lowMidLocalRotation *= finalMidLowRotation;
		}
	}
}
