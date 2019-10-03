
namespace Ju.Math
{
	public static partial class Math
	{
		public const float Pi = (float)System.Math.PI;
		public const float Tau = (float)(System.Math.PI * 2f);
		public const float Epsilon = 0.00001f;
		public const float Deg2Rad = 0.0174532925199432957692369076848861271344287188854172f;
		public const float Rad2Deg = 57.295779513082320876798154814105170332405472466564321f;

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

		public static float Exp(float value)
		{
			return (float)System.Math.Exp(value);
		}

		public static int Floor(float value)
		{
			return (int)System.Math.Floor(value);
		}

		public static float Lerp(float a, float b, float alpha, bool extrapolate = false)
		{
			alpha = extrapolate ? alpha : Math.Clamp01(alpha);
			return a * (1f - alpha) + b * alpha;
		}

		public static float Log(float value)
		{
			return (float)System.Math.Log(value);
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
			if (alpha > 1f)
			{
				alpha = 1f;
			}

			return a * (1f - alpha) + b * alpha;
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

		public static int Repeat(int value, int length)
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
	}
}
