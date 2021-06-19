// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public static class UnityVector2IntExtensions
	{
		public static UnityEngine.Vector2Int WithX(this UnityEngine.Vector2Int v, int value)
		{
			return new UnityEngine.Vector2Int(value, v.y);
		}

		public static UnityEngine.Vector2Int WithY(this UnityEngine.Vector2Int v, int value)
		{
			return new UnityEngine.Vector2Int(v.x, value);
		}
	}
}

#endif
