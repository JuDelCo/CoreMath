// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Vector3i
	{
		public static implicit operator UnityEngine.Vector2(Vector3i v)
		{
			return new UnityEngine.Vector2(v.x, v.y);
		}

		public static implicit operator UnityEngine.Vector2Int(Vector3i v)
		{
			return new UnityEngine.Vector2Int(v.x, v.y);
		}

		public static implicit operator UnityEngine.Vector3(Vector3i v)
		{
			return new UnityEngine.Vector3(v.x, v.y, v.z);
		}

		public static implicit operator UnityEngine.Vector3Int(Vector3i v)
		{
			return new UnityEngine.Vector3Int(v.x, v.y, v.z);
		}

		public static implicit operator UnityEngine.Vector4(Vector3i v)
		{
			return new UnityEngine.Vector4(v.x, v.y, v.z, 0f);
		}

		// ---

		public static explicit operator Vector3i(UnityEngine.Vector2 v)
		{
			return new Vector3i(Math.Round(v.x), Math.Round(v.y), 0);
		}

		public static implicit operator Vector3i(UnityEngine.Vector2Int v)
		{
			return new Vector3i(v.x, v.y, 0);
		}

		public static explicit operator Vector3i(UnityEngine.Vector3 v)
		{
			return new Vector3i(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z));
		}

		public static implicit operator Vector3i(UnityEngine.Vector3Int v)
		{
			return new Vector3i(v.x, v.y, v.z);
		}

		public static explicit operator Vector3i(UnityEngine.Vector4 v)
		{
			return new Vector3i(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z));
		}
	}
}

#endif
