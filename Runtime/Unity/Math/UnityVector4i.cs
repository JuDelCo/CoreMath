
#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Vector4i
	{
		public static implicit operator UnityEngine.Vector4(Vector4i v)
		{
			return new UnityEngine.Vector4(v.x, v.y, v.z, v.w);
		}

		public static explicit operator Vector4i(UnityEngine.Vector4 v)
		{
			return new Vector4i(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z), Math.Round(v.w));
		}
	}
}

#endif
