using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordGenTest
{
	class Vertex
	{
		public float posX, posY, posZ, texU, texV;
		public ArxColor color;

		public Vertex(Vector<float> vec, float u, float v, ArxColor color)
		{
			posX = vec[0];
			posY = vec[1];
			posZ = vec[2];
			texU = u;
			texV = v;
			this.color = color;
		}
	}
}
