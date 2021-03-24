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

		public static explicit operator UnityEngine.Vector2Int(Vector2f v)
		{
			return new UnityEngine.Vector2Int(Math.Round(v.x), Math.Round(v.y));
		}

		public static implicit operator UnityEngine.Vector3(Vector2f v)
		{
			return new UnityEngine.Vector3(v.x, v.y, 0f);
		}

		public static explicit operator UnityEngine.Vector3Int(Vector2f v)
		{
			return new UnityEngine.Vector3Int(Math.Round(v.x), Math.Round(v.y), 0);
		}

		public static implicit operator UnityEngine.Vector4(Vector2f v)
		{
			return new UnityEngine.Vector4(v.x, v.y, 0f, 0f);
		}

		// ---

		public static implicit operator Vector2f(UnityEngine.Vector2 v)
		{
			return new Vector2f(v.x, v.y);
		}

		public static implicit operator Vector2f(UnityEngine.Vector2Int v)
		{
			return new Vector2f(v.x, v.y);
		}

		public static implicit operator Vector2f(UnityEngine.Vector3 v)
		{
			return new Vector2f(v.x, v.y);
		}

		public static implicit operator Vector2f(UnityEngine.Vector3Int v)
		{
			return new Vector2f(v.x, v.y);
		}

		public static implicit operator Vector2f(UnityEngine.Vector4 v)
		{
			return new Vector2f(v.x, v.y);
		}
	}
}

#endif
