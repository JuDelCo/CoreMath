
#if UNITY_2018_3_OR_NEWER

using Transform = UnityEngine.Transform;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;

namespace Ju.Math
{
	public static partial class TwoBoneIK
	{
		public static void Calculate(Transform top, Transform mid, Transform low, Vector3 target, Vector3 hint, ref Quaternion topLocalRotation, ref Quaternion midLocalRotation)
		{
			Quat tempTopLocalRotation = topLocalRotation;
			Quat tempMidLocalRotation = midLocalRotation;
			Calculate(top.position, mid.position, low.position, target, hint, top.rotation, mid.rotation, ref tempTopLocalRotation, ref tempMidLocalRotation);
			topLocalRotation = tempTopLocalRotation;
			midLocalRotation = tempMidLocalRotation;
		}
	}
}

#endif
