using MathNet.Numerics.LinearAlgebra;
using MathNet.Spatial.Euclidean;
using MathNet.Spatial.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordGenTest
{
	static class Helper
	{
		public static Matrix<float> CreateRotationMatrix(float x,float y, float z)
		{
			var rotX = Matrix3D.RotationAroundXAxis(Angle.FromDegrees(x)).ToSingle();
			var rotY = Matrix3D.RotationAroundXAxis(Angle.FromDegrees(y)).ToSingle();
			var rotZ = Matrix3D.RotationAroundXAxis(Angle.FromDegrees(z)).ToSingle();

			return rotX * rotY * rotZ;
		}

		public static Matrix<float> CreateRotationMatrix(Vector<float> eulers)
		{
			return CreateRotationMatrix(eulers[0], eulers[1], eulers[2]);
		}

		public static Matrix<float> CreateScaleMatrix(float scale)
		{
			return CreateScaleMatrix(scale, scale, scale);
		}

		public static Matrix<float> CreateScaleMatrix(float x, float y, float z)
		{
			return Matrix<float>.Build.DenseOfDiagonalArray(new float[] { x, y, z });
		}
	}
}
