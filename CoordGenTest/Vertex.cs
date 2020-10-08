using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordGenTest
{
	class Vertex
	{
		public float posX, posY, posZ, texU, texV;

		public Vertex(Vector<float> vec, float u, float v)
		{
			posX = vec[0];
			posY = vec[1];
			posZ = vec[2];
			this.texU = u;
			this.texV = v;
		}
	}
}
