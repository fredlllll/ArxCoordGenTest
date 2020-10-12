using MathNet.Numerics.Distributions;
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

		private ArxColor GetColor()
		{
			var col = btnPickColor.BackColor;
			return new ArxColor(col.R, col.G, col.B, col.A);
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

			var p = Polygon.Create(GetOffset(), GetEulers(), GetScale(), GetColor());
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

			var color = GetColor();

			var top = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0, 0.5f * scale, 0 }),
				eulers + Vector<float>.Build.Dense(new float[] { 180, 0, 0 }), scale, color);
			var bottom = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0, -0.5f * scale, 0 }), eulers, scale, color);
			var left = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { -0.5f * scale, 0, 0 }),
				eulers + Vector<float>.Build.Dense(new float[] { 0, 0, 90 }), scale, color);
			var right = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0.5f * scale, 0, 0 }),
				eulers + Vector<float>.Build.Dense(new float[] { 0, 0, -90 }), scale, color);
			var front = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0, 0, -0.5f * scale }),
				eulers + Vector<float>.Build.Dense(new float[] { -90, 0, 0 }), scale, color);
			var back = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0, 0, 0.5f * scale }),
				eulers + Vector<float>.Build.Dense(new float[] { 90, 0, 0 }), scale, color);

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
			var color = GetColor();

			var top = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0, 0.5f * scale, 0 }), eulers, scale, color);
			var bottom = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0, -0.5f * scale, 0 }),
				eulers + Vector<float>.Build.Dense(new float[] { 180, 0, 0 }), scale, color);
			var left = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { -0.5f * scale, 0, 0 }),
				eulers + Vector<float>.Build.Dense(new float[] { 0, 0, -90 }), scale, color);
			var right = Polygon.Create(offset + Vector<float>.Build.Dense(new float[] { 0.5f * scale, 0, 0 }),
				eulers + Vector<float>.Build.Dense(new float[] { 0, 0, 90 }), scale, color);

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

			txtOut.Text = JsonConvert.SerializeObject(output, chkPretty.Checked ? Formatting.Indented : Formatting.None);
		}

		void SetPolyType(PolyType type)
		{
			for (int i = 0; i < lstType.Items.Count; i++)
			{
				var v = lstType.Items[i];
				lstType.SetItemChecked(i, false);
				var itemPolyType = (PolyType)Enum.Parse(typeof(PolyType), v.ToString());
				if (type.HasFlag(itemPolyType))
				{
					lstType.SetItemChecked(i, true);
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var values = System.Enum.GetValues(typeof(PolyType));
			foreach (var v in values)
			{
				string s = v.ToString();
				lstType.Items.Add(s);
			}

			SetPolyType(PolyType.QUAD | PolyType.NO_SHADOW);
		}

		private void btnPickColor_Click(object sender, EventArgs e)
		{
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				btnPickColor.BackColor = colorDialog.Color;
				btnPickColor.ForeColor = colorDialog.Color.GetBrightness() > 0.5f ? Color.Black : Color.White;
			}
		}
	}
}
