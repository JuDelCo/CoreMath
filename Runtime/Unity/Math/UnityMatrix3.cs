// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2025 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Matrix3
	{
		public static implicit operator UnityEngine.Matrix4x4(Matrix3 m)
		{
			var unityMatrix = UnityEngine.Matrix4x4.identity;
			unityMatrix.m00 = m.m00;
			unityMatrix.m01 = m.m10;
			unityMatrix.m02 = m.m20;
			unityMatrix.m10 = m.m01;
			unityMatrix.m11 = m.m11;
			unityMatrix.m12 = m.m21;
			unityMatrix.m20 = m.m02;
			unityMatrix.m21 = m.m12;
			unityMatrix.m22 = m.m22;

			return unityMatrix;
		}
	}
}

#endif
