// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct IntRect
	{
		public static implicit operator UnityEngine.Rect(IntRect r)
		{
			return new UnityEngine.Rect(r.x, r.y, r.width, r.height);
		}
	}
}

#endif
