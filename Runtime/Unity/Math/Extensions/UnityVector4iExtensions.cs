
#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public static class UnityVector4iExtensions
	{
		public static Vector4i RoundToVector4i(this UnityEngine.Vector4 v)
		{
			return new Vector4i(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z), Math.Round(v.w));
		}

		public static Vector4i FloorToVector4i(this UnityEngine.Vector4 v)
		{
			return new Vector4i(Math.Floor(v.x), Math.Floor(v.y), Math.Floor(v.z), Math.Floor(v.w));
		}

		public static Vector4i CeilToVector4i(this UnityEngine.Vector4 v)
		{
			return new Vector4i(Math.Ceil(v.x), Math.Ceil(v.y), Math.Ceil(v.z), Math.Ceil(v.w));
		}
	}
}

#endif
