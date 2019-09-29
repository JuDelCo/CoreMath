
namespace Ju.Math
{
	public partial struct IntRect
	{
		public static IntRect MinMax(Vector2i min, Vector2i max)
		{
			return new IntRect(min.x, min.y, max.x - min.x, max.y - min.y);
		}

		public static IntRect MinMax(int minX, int minY, int maxX, int maxY)
		{
			return new IntRect(minX, minY, maxX - minX, maxY - minY);
		}
	}
}
