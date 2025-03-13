JuCore Math
=====================

JuCore Math is a linear algebra math library. It also contains 2D, 3D physics, noise generators, random functions and Inverse Kinematics methods.

Note: All angles are in radians (except using euler functions).

Any feedback is welcome !


See also
=====================

- [JuCore](https://github.com/JuDelCo/Core) - Core package base (service locator and useful services)
- [JuCore ECS](https://github.com/JuDelCo/CoreECS) - Deterministic lightweight ECS framework


Install
=====================

- For **Unity**, update the dependencies in the ```/Packages/manifest.json``` file in your project folder by adding:

```json
	"com.judelco.core.math": "https://github.com/JuDelCo/CoreMath.git#v1.11.0",
```

- For native **.NET projects**, **Godot**, etc... run the following command in the console of your .NET project to add the package:

```bash
	dotnet add package JuDelCo.Lib.CoreMath
```


Contents
=====================

#### Classes (Math)

- ```Math```
- ```Bezier```
- ```Bresenham```
- ```Frustum```
- ```Matrix3```
- ```Matrix4```
- ```Quat (Quaternion)```
- ```Vector2f```
- ```Vector2i```
- ```Vector3f```
- ```Vector3i```
- ```Vector4f```
- ```Vector4i```

#### Classes (Noise)

- ```ValueNoise```
- ```WorleyNoise```
- ```OpenSimplexNoise```
- ```OpenSimplex2FastNoise```
- ```OpenSimplex2SmoothNoise```

#### Classes (Random)

- ```Random```
- ```RandomMath```
- ```RandomNumber```
- ```RandomDirection```
- ```RandomPhysics```

#### Classes (Physics)

- ```Physics2D```
- ```Physics3D```
- ```Box```
- ```FloatRect```
- ```IntRect```
- ```Plane```
- ```Ray```
- ```Sphere```

#### Classes (Inverse Kinematics)

- ```TwoBoneIK```
- ```ThreeBoneIK```


The MIT License (MIT)
=====================

Copyright © 2017-2025 Juan Delgado (@JuDelCo)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
