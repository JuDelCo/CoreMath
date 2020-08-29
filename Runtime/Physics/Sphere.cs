
namespace Ju.Math
{
	public partial struct Sphere
	{
		public Vector3f position;
		public float radius;

		public Sphere(Vector3f position, float radius)
		{
			this.position = position;
			this.radius = radius;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;
				hash = hash * 23 + position.GetHashCode();
				hash = hash * 23 + radius.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			return (obj is Sphere sphere && (this == sphere));
		}

		public static bool operator ==(Sphere a, Sphere b)
		{
			return (a.position == b.position && a.radius == b.radius);
		}

		public static bool operator !=(Sphere a, Sphere b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return "[ " + position + " , " + radius + " ]";
		}
	}
}
