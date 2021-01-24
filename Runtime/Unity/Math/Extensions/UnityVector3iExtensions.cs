// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public static class UnityVector3iExtensions
	{
		public static Vector3i RoundToVector3i(this UnityEngine.Vector3 v)
		{
			return new Vector3i(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z));
		}

		public static Vector3i FloorToVector3i(this UnityEngine.Vector3 v)
		{
			return new Vector3i(Math.Floor(v.x), Math.Floor(v.y), Math.Floor(v.z));
		}

		public static Vector3i CeilToVector3i(this UnityEngine.Vector3 v)
		{
			return new Vector3i(Math.Ceil(v.x), Math.Ceil(v.y), Math.Ceil(v.z));
		}
	}
}

#endif
