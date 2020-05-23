
#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Vector3f
	{
		public static implicit operator UnityEngine.Vector3(Vector3f v)
		{
			return new UnityEngine.Vector3(v.x, v.y, v.z);
		}

		public static implicit operator Vector3f(UnityEngine.Vector3 v)
		{
			return new Vector3f(v.x, v.y, v.z);
		}
	}
}

#endif
