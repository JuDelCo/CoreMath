
#if UNITY_2018_3_OR_NEWER

using Transform = UnityEngine.Transform;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;

namespace Ju.Math
{
	public static partial class ThreeBoneIK
	{
		public static void Calculate(Transform top, Transform topMid, Transform lowMid, Transform low, Vector3 target, Vector3 hint, Vector3 lowHint, ref Quaternion topLocalRotation, ref Quaternion topMidLocalRotation, ref Quaternion lowMidLocalRotation)
		{
			Quat tempTopLocalRotation = topLocalRotation;
			Quat tempTopMidLocalRotation = topMidLocalRotation;
			Quat tempLowMidLocalRotation = lowMidLocalRotation;
			Calculate(top.position, topMid.position, lowMid.position, low.position, target, hint, lowHint, top.rotation, topMid.rotation, lowMid.rotation, ref tempTopLocalRotation, ref tempTopMidLocalRotation, ref tempLowMidLocalRotation);
			topLocalRotation = tempTopLocalRotation;
			topMidLocalRotation = tempTopMidLocalRotation;
			lowMidLocalRotation = tempLowMidLocalRotation;
		}
	}
}

#endif
