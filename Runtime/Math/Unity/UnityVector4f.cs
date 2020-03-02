
#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Vector4f
	{
		public static implicit operator UnityEngine.Vector4(Vector4f v)
		{
			return new UnityEngine.Vector4(v.x, v.y, v.z, v.w);
		}

		public static implicit operator Vector4f(UnityEngine.Vector4 v)
		{
			return new Vector4f(v.x, v.y, v.z, v.w);
		}
	}
}

#endif
