// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public static class UnityVector4Extensions
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

		public static UnityEngine.Vector4 WithX(this UnityEngine.Vector4 v, float value)
		{
			return new UnityEngine.Vector4(value, v.y, v.z, v.w);
		}

		public static UnityEngine.Vector4 WithY(this UnityEngine.Vector4 v, float value)
		{
			return new UnityEngine.Vector4(v.x, value, v.z, v.w);
		}

		public static UnityEngine.Vector4 WithZ(this UnityEngine.Vector4 v, float value)
		{
			return new UnityEngine.Vector4(v.x, v.y, value, v.w);
		}

		public static UnityEngine.Vector4 WithW(this UnityEngine.Vector4 v, float value)
		{
			return new UnityEngine.Vector4(v.x, v.y, v.z, value);
		}
	}
}

#endif
