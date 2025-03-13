// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2025 Juan Delgado (@JuDelCo)

namespace Ju.Math
{
	public static partial class Math
	{
		public const float Pi = 3.14159265359f;
		public const float Tau = 6.28318530717959f;
		public const float Epsilon = 0.000001f;
		public const float GoldenRatio = 1.61803398875f;
		public const float Sqrt2 = 1.41421356237f;
		public const float Deg2Rad = Tau / 360f;
		public const float Rad2Deg = 360f / Tau;
		public const float Infinity = float.PositiveInfinity;
		public const float NegativeInfinity = float.NegativeInfinity;

		public static int Abs(int value)
		{
			return System.Math.Abs(value);
		}

		public static float Abs(float value)
		{
			return System.Math.Abs(value);
		}

		public static float Acos(float value)
		{
			return (float)System.Math.Acos(value);
		}

		// Angle difference between two angles in radians.
		public static float AngleDiff(float radiansA, float radiansB)
		{
			var num = Math.Repeat(radiansB - radiansA, 2 * Math.Pi);

			if (num > Math.Pi)
			{
				num -= (2 * Math.Pi);
			}

			return num;
		}

		public static bool Approximately(float a, float b, float tolerance = Math.Epsilon)
		{
			return Math.Abs(a - b) <= tolerance;
		}

		public static float Asin(float value)
		{
			return (float)System.Math.Asin(value);
		}

		public static float Atan(float value)
		{
			return (float)System.Math.Atan(value);
		}

		public static float Atan2(float y, float x)
		{
			return (float)System.Math.Atan2(y, x);
		}

		public static float Atan2xy(float x, float y)
		{
			return (float)System.Math.Atan2(y, x);
		}

		public static int Ceil(float value)
		{
			return (int)System.Math.Ceiling(value);
		}

		public static bool Between(int value, int min, int max)
		{
			return (value >= min && value <= max);
		}

		public static bool Between(float value, float min, float max)
		{
			return (value >= min && value <= max);
		}

		public static int Clamp(int value, int min, int max)
		{
			return Min(max, Max(min, value));
		}

		public static float Clamp(float value, float min, float max)
		{
			return Min(max, Max(min, value));
		}

		public static float Clamp01(float value)
		{
			return Clamp(value, 0f, 1f);
		}

		public static float Cos(float value)
		{
			return (float)System.Math.Cos(value);
		}

		// Smoothing rate dictates the proportion of target reached after one second.
		// 1 will be inmediate target value, 0 will be always the source value (no smoothing in both cases).
		public static float DampSmooth(float smoothing, float dt)
		{
			return (1f - Pow((1f - smoothing), dt));
		}

		// Lambda rate has a range between zero and infinity (which expresses the fact that will never reach b when damping).
		// Is sightly faster than the Pow based version.
		public static float DampLambda(float lambda, float dt)
		{
			return (1f - Exp(-lambda * dt));
		}

		public static float Exp(float value)
		{
			return (float)System.Math.Exp(value);
		}

		public static int FigureLength(int value)
		{
			return Floor(Log10(value) + 1);
		}

		public static int Floor(float value)
		{
			return (int)System.Math.Floor(value);
		}

		public static float Frac(float value)
		{
			return value - Math.Floor(value);
		}

		public static float Lerp(float a, float b, float alpha)
		{
			return a + (alpha * (b - a));
		}

		public static float LerpClamped(float a, float b, float alpha)
		{
			return a + (Math.Clamp01(alpha) * (b - a));
		}

		public static int LerpRounded(int a, int b, float alpha)
		{
			return Round(Lerp(a, b, alpha));
		}

		public static int LerpRoundedClamped(int a, int b, float alpha)
		{
			return Round(LerpClamped(a, b, alpha));
		}

		public static float LerpInverse(float a, float b, float value)
		{
			return (value - a) / (b - a);
		}

		public static float LerpInverseClamped(float a, float b, float value)
		{
			value = Math.Clamp(value, a, b);
			return (value - a) / (b - a);
		}

		public static float Log(float value)
		{
			return (float)System.Math.Log(value);
		}

		public static float Log(float value, float newBase)
		{
			return (float)System.Math.Log(value, newBase);
		}

		public static float Log10(float value)
		{
			return (float)System.Math.Log10(value);
		}

		public static float Map01(float value, float min, float max)
		{
			return (value - min) * 1f / (max - min);
		}

		public static float Map(float value, float oldMin, float oldMax, float newMin, float newMax)
		{
			return (((value - oldMin) * (newMax - newMin)) / (oldMax - oldMin)) + newMin;
		}

		public static int Max(int a, int b)
		{
			return System.Math.Max(a, b);
		}

		public static int Max(int a, int b, int c)
		{
			return Max(a, Max(b, c));
		}

		public static int Max(int a, int b, int c, int d)
		{
			return Max(a, Max(b, Max(c, d)));
		}

		public static float Max(float a, float b)
		{
			return System.Math.Max(a, b);
		}

		public static float Max(float a, float b, float c)
		{
			return Max(a, Max(b, c));
		}

		public static float Max(float a, float b, float c, float d)
		{
			return Max(a, Max(b, Max(c, d)));
		}

		public static float Mid(float a, float b)
		{
			return ((a + b) / 2f);
		}

		public static float Mid(float a, float b, float c)
		{
			return ((a + b + c) / 3f);
		}

		public static float Mid(float a, float b, float c, float d)
		{
			return ((a + b + c + d) / 4f);
		}

		public static int Min(int a, int b)
		{
			return System.Math.Min(a, b);
		}

		public static int Min(int a, int b, int c)
		{
			return Min(a, Min(b, c));
		}

		public static int Min(int a, int b, int c, int d)
		{
			return Min(a, Min(b, Min(c, d)));
		}

		public static float Min(float a, float b)
		{
			return System.Math.Min(a, b);
		}

		public static float Min(float a, float b, float c)
		{
			return Min(a, Min(b, c));
		}

		public static float Min(float a, float b, float c, float d)
		{
			return Min(a, Min(b, Min(c, d)));
		}

		public static float Mix(float a, float b, float alpha)
		{
			return Lerp(a, b, alpha);
		}

		public static float Mod(int value, int length)
		{
			return value - (length * Floor(value / length));
		}

		public static float Mod(float value, float length)
		{
			return value - (length * Floor(value / length));
		}

		public static float MoveTowards(float a, float b, float maxDelta)
		{
			if (Abs(b - a) <= maxDelta)
			{
				return b;
			}

			return a + Sign(b - a) * maxDelta;
		}

		public static float MoveTowardsAngle(float radiansA, float radiansB, float maxDelta)
		{
			float deltaAngle = AngleDiff(radiansA, radiansB);

			if (-maxDelta < deltaAngle && deltaAngle < maxDelta)
			{
				return radiansB;
			}

			radiansB = radiansA + deltaAngle;

			return MoveTowards(radiansA, radiansB, maxDelta);
		}

		public static float PingPong(float value, float length)
		{
			value = Math.Repeat(value, length * 2f);
			return length - Math.Abs(value - length);
		}

		public static float Pow(float value, float power)
		{
			return (float)System.Math.Pow(value, power);
		}

		public static float Remap(float oldMin, float oldMax, float newMin, float newMax, float value)
		{
			var alpha = LerpInverse(oldMin, oldMax, value);
			return Lerp(newMin, newMax, alpha);
		}

		public static int Repeat(int value, int length)
		{
			return ((value % length) + length) % length;
		}

		public static float Repeat(float value, float length)
		{
			return value - Math.Floor(value / length) * length;
		}

		public static int Round(float value)
		{
			return (int)System.Math.Round(value);
		}

		public static float Sin(float value)
		{
			return (float)System.Math.Sin(value);
		}

		public static int Sign(float value)
		{
			return System.Math.Sign(value);
		}

		public static int SignBinary(float value)
		{
			return value < 0f ? -1 : 1;
		}

		public static float Sqrt(float value)
		{
			return (float)System.Math.Sqrt(value);
		}

		public static int Sqr(int value)
		{
			return (value * value);
		}

		public static float Sqr(float value)
		{
			return (value * value);
		}

		public static float Tan(float value)
		{
			return (float)System.Math.Tan(value);
		}

		public static float ToDegrees(float radians)
		{
			return radians * Rad2Deg;
		}

		public static float ToRadians(float degrees)
		{
			return degrees * Deg2Rad;
		}

		// Angle needed between a and b so that their extremities are spaced with a specific length.
		public static float TriangleAngle(float lengthAB, float lengthA, float lengthB)
		{
			// https://en.wikipedia.org/wiki/Law_of_cosines
			return Math.Acos(Math.Clamp((lengthA * lengthA + lengthB * lengthB - lengthAB * lengthAB) / (2f * lengthA * lengthB), -1f, 1f));
		}
	}
}
