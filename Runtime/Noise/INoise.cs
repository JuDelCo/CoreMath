// SPDX-License-Identifier: MIT
// Copyright (c) 2017-2021 Juan Delgado (@JuDelCo)

namespace Ju.Math.Random
{
	public interface INoise
	{
		void ChangeSeed(int seed);

		float Sample1D(float x);
		float Sample2D(float x, float y);
		float Sample3D(float x, float y, float z);
	}
}
