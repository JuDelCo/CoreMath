// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

using System.Collections.Generic;

namespace Ju.Math
{
	public static class Bresenham
	{
		public static IEnumerable<Vector2i> Line(Vector2i a, Vector2i b)
		{
			if (a == b)
			{
				yield return a;
				yield break;
			}

			var diff = b - a;

			var da = Vector2i.zero;
			var db = Vector2i.zero;

			if (diff.x < 0)
			{
				da.x = -1;
				db.x = -1;
			}
			else if (diff.x > 0)
			{
				da.x = 1;
				db.x = 1;
			}

			if (diff.y < 0)
			{
				da.y = -1;
			}
			else if (diff.y > 0)
			{
				da.y = 1;
			}

			var longest = Math.Abs(diff.x);
			var shortest = Math.Abs(diff.y);

			if (!(longest > shortest))
			{
				longest = Math.Abs(diff.y);
				shortest = Math.Abs(diff.x);

				if (diff.y < 0)
				{
					db.y = -1;
				}
				else if (diff.y > 0)
				{
					db.y = 1;
				}

				db.x = 0;
			}

			int numerator = longest >> 1;

			for (int i = 0; i <= longest; ++i)
			{
				yield return a;

				numerator += shortest;

				if (!(numerator < longest))
				{
					numerator -= longest;
					a.x += da.x;
					a.y += da.y;
				}
				else
				{
					a.x += db.x;
					a.y += db.y;
				}
			}
		}
	}
}
