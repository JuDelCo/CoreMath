// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2025 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Quat
	{
		public static implicit operator UnityEngine.Quaternion(Quat q)
		{
			return new UnityEngine.Quaternion(q.x, q.y, q.z, q.w);
		}

		public static implicit operator Quat(UnityEngine.Quaternion q)
		{
			return new Quat(q.x, q.y, q.z, q.w);
		}
	}
}

#endif
