// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2025 Juan Delgado (@JuDelCo)

#if UNITY_2018_3_OR_NEWER

namespace Ju.Math
{
	public partial struct Matrix4
	{
		public static implicit operator UnityEngine.Matrix4x4(Matrix4 m)
		{
			var unityMatrix = UnityEngine.Matrix4x4.identity;
			unityMatrix.m00 = m.m00;
			unityMatrix.m01 = m.m10;
			unityMatrix.m02 = m.m20;
			unityMatrix.m03 = m.m30;
			unityMatrix.m10 = m.m01;
			unityMatrix.m11 = m.m11;
			unityMatrix.m12 = m.m21;
			unityMatrix.m13 = m.m31;
			unityMatrix.m20 = m.m02;
			unityMatrix.m21 = m.m12;
			unityMatrix.m22 = m.m22;
			unityMatrix.m23 = m.m32;
			unityMatrix.m30 = m.m03;
			unityMatrix.m31 = m.m13;
			unityMatrix.m32 = m.m23;
			unityMatrix.m33 = m.m33;

			return unityMatrix;
		}

		public static implicit operator Matrix4(UnityEngine.Matrix4x4 unityMatrix)
		{
			var m = Matrix4.identity;
			m.m00 = unityMatrix.m00;
			m.m01 = unityMatrix.m10;
			m.m02 = unityMatrix.m20;
			m.m03 = unityMatrix.m30;
			m.m10 = unityMatrix.m01;
			m.m11 = unityMatrix.m11;
			m.m12 = unityMatrix.m21;
			m.m13 = unityMatrix.m31;
			m.m20 = unityMatrix.m02;
			m.m21 = unityMatrix.m12;
			m.m22 = unityMatrix.m22;
			m.m23 = unityMatrix.m32;
			m.m30 = unityMatrix.m03;
			m.m31 = unityMatrix.m13;
			m.m32 = unityMatrix.m23;
			m.m33 = unityMatrix.m33;

			return m;
		}
	}
}

#endif
