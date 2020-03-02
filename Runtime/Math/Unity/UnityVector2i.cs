
#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Vector2i
	{
		public static implicit operator UnityEngine.Vector2(Vector2i v)
		{
			return new UnityEngine.Vector2(v.x, v.y);
		}
	}
}

#endif
