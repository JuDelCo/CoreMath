// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2025 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public static class UnityVector2Extensions
	{
		public static Vector2i RoundToVector2i(this UnityEngine.Vector2 v)
		{
			return new Vector2i(Math.Round(v.x), Math.Round(v.y));
		}

		public static Vector2i FloorToVector2i(this UnityEngine.Vector2 v)
		{
			return new Vector2i(Math.Floor(v.x), Math.Floor(v.y));
		}

		public static Vector2i CeilToVector2i(this UnityEngine.Vector2 v)
		{
			return new Vector2i(Math.Ceil(v.x), Math.Ceil(v.y));
		}

		public static UnityEngine.Vector2 WithX(this UnityEngine.Vector2 v, float value)
		{
			return new UnityEngine.Vector2(value, v.y);
		}

		public static UnityEngine.Vector2 WithY(this UnityEngine.Vector2 v, float value)
		{
			return new UnityEngine.Vector2(v.x, value);
		}
	}
}

#endif
