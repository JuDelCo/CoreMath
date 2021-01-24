// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Ray
	{
		public static implicit operator UnityEngine.Ray(Ray r)
		{
			return new UnityEngine.Ray(r.origin, r.direction);
		}

		public static implicit operator Ray(UnityEngine.Ray r)
		{
			return new Ray(r.origin, r.direction);
		}
	}
}

#endif
