// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2025 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Vector3f
	{
		public static implicit operator UnityEngine.Vector2(Vector3f v)
		{
			return new UnityEngine.Vector2(v.x, v.y);
		}

		public static explicit operator UnityEngine.Vector2Int(Vector3f v)
		{
			return new UnityEngine.Vector2Int(Math.Round(v.x), Math.Round(v.y));
		}

		public static implicit operator UnityEngine.Vector3(Vector3f v)
		{
			return new UnityEngine.Vector3(v.x, v.y, v.z);
		}

		public static explicit operator UnityEngine.Vector3Int(Vector3f v)
		{
			return new UnityEngine.Vector3Int(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z));
		}

		public static implicit operator UnityEngine.Vector4(Vector3f v)
		{
			return new UnityEngine.Vector4(v.x, v.y, v.z, 0f);
		}

		// ---

		public static implicit operator Vector3f(UnityEngine.Vector2 v)
		{
			return new Vector3f(v.x, v.y, 0f);
		}

		public static implicit operator Vector3f(UnityEngine.Vector2Int v)
		{
			return new Vector3f(v.x, v.y, 0f);
		}

		public static implicit operator Vector3f(UnityEngine.Vector3 v)
		{
			return new Vector3f(v.x, v.y, v.z);
		}

		public static implicit operator Vector3f(UnityEngine.Vector3Int v)
		{
			return new Vector3f(v.x, v.y, v.z);
		}

		public static implicit operator Vector3f(UnityEngine.Vector4 v)
		{
			return new Vector3f(v.x, v.y, v.z);
		}
	}
}

#endif
