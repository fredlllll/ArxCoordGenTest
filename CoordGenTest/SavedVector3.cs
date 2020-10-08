using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordGenTest
{
	public class SavedVector3
	{
		public float x, y, z;

		public SavedVector3(Vector<float> vec)
		{
			x = vec[0];
			y = vec[1];
			z = vec[2];
		}
	}
}
