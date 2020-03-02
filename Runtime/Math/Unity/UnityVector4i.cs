
#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Vector4i
	{
		public static implicit operator UnityEngine.Vector4(Vector4i v)
		{
			return new UnityEngine.Vector4(v.x, v.y, v.z, v.w);
		}
	}
}

#endif
