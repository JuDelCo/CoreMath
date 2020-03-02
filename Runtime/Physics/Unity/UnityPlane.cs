
#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Plane
	{
		public static implicit operator UnityEngine.Plane(Plane p)
		{
			return new UnityEngine.Plane(p.normal, p.distance);
		}

		public static implicit operator Plane(UnityEngine.Plane p)
		{
			return new Plane(p.normal, p.distance);
		}
	}
}

#endif
