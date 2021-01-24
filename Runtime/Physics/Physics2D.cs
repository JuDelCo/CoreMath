// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public static partial class Physics2D
	{
		public static bool CheckCollisionPointRec(Vector2f point, FloatRect r)
		{
			// return !(point.x < r.left || point.x > r.right || point.y < r.top || point.y > r.bottom);
			// return !(point.x < r.left || point.x > r.right || point.y < r.top || point.y > r.bottom);

			bool collision = false;

			if ((point.x >= r.left) && (point.x <= r.right) &&
				(point.y >= r.top) && (point.y <= r.bottom))
			{
				collision = true;
			}

			return collision;
		}

		public static bool CheckCollisionPointCircle(Vector3f point, Sphere s)
		{
			return CheckCollisionCircles(new Sphere(point, 0), s);
		}

		public static bool CheckCollisionPointTriangle(Vector2f point, Vector2f p1, Vector2f p2, Vector2f p3)
		{
			bool collision = false;

			float alpha = ((p2.y - p3.y) * (point.x - p3.x) + (p3.x - p2.x) * (point.y - p3.y)) / ((p2.y - p3.y) * (p1.x - p3.x) + (p3.x - p2.x) * (p1.y - p3.y));
			float beta = ((p3.y - p1.y) * (point.x - p3.x) + (p1.x - p3.x) * (point.y - p3.y)) / ((p2.y - p3.y) * (p1.x - p3.x) + (p3.x - p2.x) * (p1.y - p3.y));
			float gamma = (1.0f - alpha - beta);

			if ((alpha > 0) && (beta > 0) & (gamma > 0))
			{
				collision = true;
			}

			return collision;
		}

		public static bool RayIntersection(Ray r1, Ray r2, out Vector2f intersection)
		{
			var a = (Vector2f)r1.position;
			var b = a + (Vector2f)r1.direction;
			var c = (Vector2f)r2.position;
			var d = c + (Vector2f)r2.direction;

			var lineA = (b - a);
			var lineB = (d - c);

			if (Math.Cross(lineA, lineB) == 0)
			{
				intersection = new Vector2f(float.NaN, float.NaN);

				return false;
			}

			var x = (((c.y - a.y) * lineA.x * lineB.x + lineA.y * lineB.x * a.x - lineB.y * lineA.x * c.x) / (lineA.y * lineB.x - lineB.y * lineA.x));
			var y = (a.y + (lineA.y / lineA.x) * (x - a.x));

			intersection = new Vector2f(x, y);

			return true;
		}

		public static bool CheckCollisionRecs(FloatRect a, FloatRect b)
		{
			/*return (
				(r.x <= rect.x) && (rect.x + rect.width) <= (r.x + r.width) &&
				(r.y <= rect.y) && (rect.y + rect.height) <= (r.y + r.height)
			);*/

			/*return (
				(r.x <= rect.x) && (rect.x + rect.width) <= (r.x + r.width) &&
				(r.y <= rect.y) && (rect.y + rect.height) <= (r.y + r.height)
			);*/

			bool collision = false;

			var offset = Math.Abs(a.center - b.center);

			if ((offset.x <= (a.halfWidth + b.halfWidth)) &&
				((offset.y <= (a.halfHeight + b.halfHeight))))
			{
				collision = true;
			}

			return collision;
		}

		public static bool CheckCollisionCircleRec(FloatRect a, Sphere b)
		{
			var offset = Math.Abs((Vector2f)b.position - a.center);

			if (offset.x > (a.halfWidth + b.radius) ||
				offset.y > (a.halfHeight + b.radius))
			{
				return false;
			}

			if (CheckCollisionPointRec(b.position, a))
			{
				return true;
			}

			if (CheckCollisionPointCircle(new Vector3f(a.left, a.top, 0), b) ||
				CheckCollisionPointCircle(new Vector3f(a.left, a.bottom, 0), b) ||
				CheckCollisionPointCircle(new Vector3f(a.right, a.top, 0), b) ||
				CheckCollisionPointCircle(new Vector3f(a.right, a.bottom, 0), b))
			{
				return true;
			}

			return false;
		}

		public static bool CheckCollisionCircles(Sphere a, Sphere b)
		{
			bool collision = false;

			if (Math.DistanceSqr(b.position, a.position) <= Math.Sqr(a.radius + b.radius))
			{
				collision = true;
			}

			return collision;
		}
	}
}
