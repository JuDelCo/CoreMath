// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public static class UnityVector3IntExtensions
	{
		public static UnityEngine.Vector3Int WithX(this UnityEngine.Vector3Int v, int value)
		{
			return new UnityEngine.Vector3Int(value, v.y, v.z);
		}

		public static UnityEngine.Vector3Int WithY(this UnityEngine.Vector3Int v, int value)
		{
			return new UnityEngine.Vector3Int(v.x, value, v.z);
		}

		public static UnityEngine.Vector3Int WithZ(this UnityEngine.Vector3Int v, int value)
		{
			return new UnityEngine.Vector3Int(v.x, v.y, value);
		}
	}
}

#endif
