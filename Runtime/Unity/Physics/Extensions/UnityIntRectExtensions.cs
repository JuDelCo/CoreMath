
#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public static class UnityIntRectExtensions
	{
		public static IntRect RoundToIntRect(this UnityEngine.Rect r)
		{
			return new IntRect(Math.Round(r.x), Math.Round(r.y), Math.Round(r.width), Math.Round(r.height));
		}

		public static IntRect FloorToIntRect(this UnityEngine.Rect r)
		{
			return new IntRect(Math.Floor(r.x), Math.Floor(r.y), Math.Floor(r.width), Math.Floor(r.height));
		}

		public static IntRect CeilToIntRect(this UnityEngine.Rect r)
		{
			return new IntRect(Math.Ceil(r.x), Math.Ceil(r.y), Math.Ceil(r.width), Math.Ceil(r.height));
		}
	}
}

#endif
