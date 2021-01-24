// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Vector2f
	{
		public static implicit operator UnityEngine.Vector2(Vector2f v)
		{
			return new UnityEngine.Vector2(v.x, v.y);
		}

		public static implicit operator Vector2f(UnityEngine.Vector2 v)
		{
			return new Vector2f(v.x, v.y);
		}
	}
}

#endif
