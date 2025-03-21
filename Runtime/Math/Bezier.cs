﻿// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2025 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public static class Bezier
	{
		public static Vector2f GetLinearPoint(float t, Vector2f p0, Vector2f p1)
		{
			// P₀ + t(P₁-P₀)
			return p0 + (t * (p1 - p0));
		}

		public static Vector2f GetQuadraticPoint(float t, Vector2f p0, Vector2f p1, Vector2f p2)
		{
			// (1-t)²P₀ + 2(1-t)tP₁ + t²P₂
			float u = 1f - t;
			return ((u * u) * p0) + (2f * u * t * p1) + ((t * t) * p2);
		}

		public static Vector2f GetCubicPoint(float t, Vector2f p0, Vector2f p1, Vector2f p2, Vector2f p3)
		{
			// (1-t)³P₀ + 3(1-t)²tP₁ + 3(1-t)t²P₂ + t³P₃
			float u = 1f - t;
			return ((u * u * u) * p0) + (3f * (u * u) * t * p1) + (3f * u * (t * t) * p2) + ((t * t * t) * p3);
		}

		public static Vector3f GetLinearPoint(float t, Vector3f p0, Vector3f p1)
		{
			// P₀ + t(P₁-P₀)
			return p0 + (t * (p1 - p0));
		}

		public static Vector3f GetQuadraticPoint(float t, Vector3f p0, Vector3f p1, Vector3f p2)
		{
			// (1-t)²P₀ + 2(1-t)tP₁ + t²P₂
			float u = 1f - t;
			return ((u * u) * p0) + (2f * u * t * p1) + ((t * t) * p2);
		}

		public static Vector3f GetCubicPoint(float t, Vector3f p0, Vector3f p1, Vector3f p2, Vector3f p3)
		{
			// (1-t)³P₀ + 3(1-t)²tP₁ + 3(1-t)t²P₂ + t³P₃
			float u = 1f - t;
			return ((u * u * u) * p0) + (3f * (u * u) * t * p1) + (3f * u * (t * t) * p2) + ((t * t * t) * p3);
		}
	}
}
