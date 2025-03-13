// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2025 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Vector4i
	{
		public static implicit operator UnityEngine.Vector2(Vector4i v)
		{
			return new UnityEngine.Vector2(v.x, v.y);
		}

		public static implicit operator UnityEngine.Vector2Int(Vector4i v)
		{
			return new UnityEngine.Vector2Int(v.x, v.y);
		}

		public static implicit operator UnityEngine.Vector3(Vector4i v)
		{
			return new UnityEngine.Vector3(v.x, v.y, v.z);
		}

		public static implicit operator UnityEngine.Vector3Int(Vector4i v)
		{
			return new UnityEngine.Vector3Int(v.x, v.y, v.z);
		}

		public static implicit operator UnityEngine.Vector4(Vector4i v)
		{
			return new UnityEngine.Vector4(v.x, v.y, v.z, v.w);
		}

		// ---

		public static explicit operator Vector4i(UnityEngine.Vector2 v)
		{
			return new Vector4i(Math.Round(v.x), Math.Round(v.y), 0, 0);
		}

		public static implicit operator Vector4i(UnityEngine.Vector2Int v)
		{
			return new Vector4i(v.x, v.y, 0, 0);
		}

		public static explicit operator Vector4i(UnityEngine.Vector3 v)
		{
			return new Vector4i(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z), 0);
		}

		public static implicit operator Vector4i(UnityEngine.Vector3Int v)
		{
			return new Vector4i(v.x, v.y, v.z, 0);
		}

		public static explicit operator Vector4i(UnityEngine.Vector4 v)
		{
			return new Vector4i(Math.Round(v.x), Math.Round(v.y), Math.Round(v.z), Math.Round(v.w));
		}
	}
}

#endif
