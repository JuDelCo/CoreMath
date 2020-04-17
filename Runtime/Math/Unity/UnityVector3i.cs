
#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Vector3i
	{
		public static implicit operator UnityEngine.Vector3(Vector3i v)
		{
			return new UnityEngine.Vector3(v.x, v.y, v.z);
		}

		public static explicit operator Vector3i(UnityEngine.Vector3 v)
		{
			return new Vector3i(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z));
		}
	}
}

#endif
