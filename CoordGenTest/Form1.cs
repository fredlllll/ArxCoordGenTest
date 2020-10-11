using MathNet.Numerics.LinearAlgebra;
using MathNet.Spatial.Euclidean;
using MathNet.Spatial.Units;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoordGenTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private Vector<float> GetOffset()
		{
			return Vector<float>.Build.Dense(new float[] { (float)numX.Value, (float)numY.Value, (float)numZ.Value });
		}

		private Vector<float> GetEulers()
		{
			return Vector<float>.Build.DenseOfArray(new float[] { (float)numEulerX.Value, (float)numEulerY.Value, (float)numEulerZ.Value });
		}

		private int GetTex()
		{
			return (int)numTex.Value;
		}

		private float GetTransVal()
		{
			return (float)numTransval.Value;
		}

		private short GetRoom()
		{
			return (short)numRoom.Value;
		}

		private short GetPaddy()
		{
			return (short)numPaddy.Value;
		}

		private float GetScale()
		{
			return (float)numScale.Value;
		}

		private PolyType GetPolyType()
		{
			PolyType type = 0;

			foreach (var v in lstType.CheckedItems)
			{
				var tmp = (PolyType)Enum.Parse(typeof(PolyType), v.ToString());
				type |= tmp;
			}

			return type;
		}

		private void InitPoly(Polygon p)
		{
			p.tex = GetTex();
			p.transval = GetTransVal();
			p.room = GetRoom();
			p.paddy = GetPaddy();
			p.type |= GetPolyType();
		}

		private Polygon[] createPlane()
		{
			List<Polygon> polys = new List<Polygon>();

			var p = Polygon.Create(GetOffset(), GetEulers(), GetScale());
			InitPoly(p);
			polys.Add(p);

			return polys.ToArray();
		}

		private Polygon[] createCube()
		{
			List<Polygon> polys = new List<Polygon>();

			var offset = GetOffset();
			var eulers = GetEulers();
			var scale = GetScale();

			var top = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0, 0.5f, 0 }), eulers, scale);
			var bottom = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0, -0.5f, 0 }),
				eulers + Vector<float>.Build.Dense(new float[] {180,0,0 }), scale);
			var left = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { -0.5f, 0, 0 }),
				eulers + Vector<float>.Build.Dense(new float[] { 0, 0, 90 }), scale);
			var right = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0.5f, 0, 0 }),
				eulers + Vector<float>.Build.Dense(new float[] { 0, 0, -90 }), scale);
			var front = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0, 0, -0.5f }),
				eulers + Vector<float>.Build.Dense(new float[] { -90, 0, 0 }), scale);
			var back = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0, 0, 0.5f }),
				eulers + Vector<float>.Build.Dense(new float[] { 90, 0, 0 }), scale);

			polys.Add(top);
			polys.Add(bottom);
			polys.Add(left);
			polys.Add(right);
			polys.Add(front);
			polys.Add(back);

			foreach (var p in polys)
			{
				InitPoly(p);
			}

			return polys.ToArray();
		}

		private Polygon[] createCorridor()
		{
			List<Polygon> polys = new List<Polygon>();

			var offset = GetOffset();
			var eulers = GetEulers();
			var scale = GetScale();

			
			var top = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0, 0.5f, 0 }),
				eulers + Vector<float>.Build.Dense(new float[] { 180, 0, 0 }), scale);
			var bottom = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0, -0.5f, 0 }), eulers, scale);
			var left = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { -0.5f, 0, 0 }),
				eulers + Vector<float>.Build.Dense(new float[] { 0, 0, -90 }), scale);
			var right = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0.5f, 0, 0 }),
				eulers + Vector<float>.Build.Dense(new float[] { 0, 0, 90 }), scale);
			
			polys.Add(top);
			polys.Add(bottom);
			polys.Add(left);
			polys.Add(right);

			foreach (var p in polys)
			{
				InitPoly(p);
			}

			return polys.ToArray();
		}

		private void btnGen_Click(object sender, EventArgs e)
		{
			Polygon[] output = null;
			if (radPlane.Checked)
			{
				output = createPlane();
			}
			else if (radCube.Checked)
			{
				output = createCube();
			}
			else if (radCorridor.Checked)
			{
				output = createCorridor();
			}

			txtOut.Text = JsonConvert.SerializeObject(output, Formatting.Indented);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var values = System.Enum.GetValues(typeof(PolyType));
			foreach (var v in values)
			{
				string s = v.ToString();
				lstType.Items.Add(s);
			}
		}
	}
}
