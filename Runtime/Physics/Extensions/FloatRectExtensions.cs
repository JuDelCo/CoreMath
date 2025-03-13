// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2025 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public partial struct FloatRect
	{
		public static implicit operator FloatRect(IntRect rect)
		{
			return new FloatRect(rect.position, rect.size);
		}

		public static FloatRect MinMax(Vector2f min, Vector2f max)
		{
			return new FloatRect(min.x, min.y, max.x - min.x, max.y - min.y);
		}

		public static FloatRect MinMax(float minX, float minY, float maxX, float maxY)
		{
			return new FloatRect(minX, minY, maxX - minX, maxY - minY);
		}

		public static IntRect Ceil(FloatRect r)
		{
			return new IntRect(Math.Ceil(r.x), Math.Ceil(r.y), Math.Ceil(r.width), Math.Ceil(r.height));
		}

		public static IntRect Floor(FloatRect r)
		{
			return new IntRect(Math.Floor(r.x), Math.Floor(r.y), Math.Floor(r.width), Math.Floor(r.height));
		}

		public static IntRect Round(FloatRect r)
		{
			return new IntRect(Math.Round(r.x), Math.Round(r.y), Math.Round(r.width), Math.Round(r.height));
		}
	}
}
