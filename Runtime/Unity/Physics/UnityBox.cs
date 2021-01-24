// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Box
	{
		public static implicit operator UnityEngine.Bounds(Box b)
		{
			return new UnityEngine.Bounds(b.center, b.size);
		}

		public static implicit operator Box(UnityEngine.Bounds b)
		{
			return new Box(b.center, b.size);
		}
	}
}

#endif
