// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Vector3i
	{
		public static implicit operator UnityEngine.Vector3(Vector3i v)
		{
			return new UnityEngine.Vector3(v.x, v.y, v.z);
		}

		public static implicit operator UnityEngine.Vector3Int(Vector3i v)
		{
			return new UnityEngine.Vector3Int(v.x, v.y, v.z);
		}

		public static explicit operator Vector3i(UnityEngine.Vector3 v)
		{
			return new Vector3i(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z));
		}

		public static implicit operator Vector3i(UnityEngine.Vector3Int v)
		{
			return new Vector3i(v.x, v.y, v.z);
		}
	}
}

#endif
