
#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Vector3i
	{
		public static implicit operator UnityEngine.Vector3(Vector3i v)
		{
			return new UnityEngine.Vector3(v.x, v.y, v.z);
		}
	}
}

#endif
