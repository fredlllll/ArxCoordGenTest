using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Providers.LinearAlgebra;
using System.Windows.Forms;

namespace CoordGenTest
{
	class Polygon
	{
		public readonly Vertex[] vertices = new Vertex[4];
		public int tex;
		public SavedVector3 norm;
		public SavedVector3 norm2;
		public readonly SavedVector3[] normals = new SavedVector3[4];
		public float transval;
		public float area;
		public PolyType type;
		public short room;
		public short paddy;

		public static Polygon Create(Vector<float> center, Vector<float> eulers, float scale)
		{
			Polygon p = new Polygon();

			var a = Vector<float>.Build.Dense(new float[] { -0.5f, 0, -0.5f });
			var b = Vector<float>.Build.Dense(new float[] { 0.5f, 0, -0.5f });
			var c = Vector<float>.Build.Dense(new float[] { -0.5f, 0, 0.5f });
			var d = Vector<float>.Build.Dense(new float[] { 0.5f, 0, 0.5f });

			var m = Helper.CreateRotationMatrix(eulers);
			m = m * Helper.CreateScaleMatrix(scale);

			a *= m;
			b *= m;
			c *= m;
			d *= m;

			a += center;
			b += center;
			c += center;
			d += center;

			p.vertices[0] = new Vertex(a, 0, 0);
			p.vertices[1] = new Vertex(b, 1, 0);
			p.vertices[2] = new Vertex(c, 0, 1);
			p.vertices[3] = new Vertex(d, 1, 1);

			var n = Vector<float>.Build.Dense(new float[] { 0, 1, 0 });
			n *= m;
			n = n.Normalize(1);

			p.norm = new SavedVector3(n);
			p.norm2 = new SavedVector3(n);
			p.normals[0] = new SavedVector3(n);
			p.normals[1] = new SavedVector3(n);
			p.normals[2] = new SavedVector3(n);
			p.normals[3] = new SavedVector3(n);

			p.type = PolyType.QUAD;

			p.area = scale*scale;
			return p;
		}
	}
}
