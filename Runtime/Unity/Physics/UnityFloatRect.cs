// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2025 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct FloatRect
	{
		public static implicit operator UnityEngine.Rect(FloatRect r)
		{
			return new UnityEngine.Rect(r.x, r.y, r.width, r.height);
		}

		public static implicit operator FloatRect(UnityEngine.Rect r)
		{
			return new FloatRect(r.x, r.y, r.width, r.height);
		}
	}
}

#endif
