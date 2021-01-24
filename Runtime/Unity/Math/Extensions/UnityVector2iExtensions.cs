// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public static class UnityVector2iExtensions
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
	}
}

#endif
