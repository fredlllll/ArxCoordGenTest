namespace CoordGenTest
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.radPlane = new System.Windows.Forms.RadioButton();
            this.radCube = new System.Windows.Forms.RadioButton();
            this.radCorridor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numZ = new System.Windows.Forms.NumericUpDown();
            this.numEulerZ = new System.Windows.Forms.NumericUpDown();
            this.numEulerY = new System.Windows.Forms.NumericUpDown();
            this.numEulerX = new System.Windows.Forms.NumericUpDown();
            this.numFZasdasd = new System.Windows.Forms.Label();
            this.labelas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numTex = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numTransval = new System.Windows.Forms.NumericUpDown();
            this.numRoom = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numPaddy = new System.Windows.Forms.NumericUpDown();
            this.lstType = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numScale = new System.Windows.Forms.NumericUpDown();
            this.chkPretty = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEulerZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEulerY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEulerX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTransval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaddy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
            this.SuspendLayout();
            // 
            // radPlane
            // 
            this.radPlane.AutoSize = true;
            this.radPlane.Location = new System.Drawing.Point(19, 15);
            this.radPlane.Name = "radPlane";
            this.radPlane.Size = new System.Drawing.Size(52, 17);
            this.radPlane.TabIndex = 0;
            this.radPlane.TabStop = true;
            this.radPlane.Text = "Plane";
            this.radPlane.UseVisualStyleBackColor = true;
            // 
            // radCube
            // 
            this.radCube.AutoSize = true;
            this.radCube.Location = new System.Drawing.Point(19, 38);
            this.radCube.Name = "radCube";
            this.radCube.Size = new System.Drawing.Size(50, 17);
            this.radCube.TabIndex = 1;
            this.radCube.TabStop = true;
            this.radCube.Text = "Cube";
            this.radCube.UseVisualStyleBackColor = true;
            // 
            // radCorridor
            // 
            this.radCorridor.AutoSize = true;
            this.radCorridor.Location = new System.Drawing.Point(19, 61);
            this.radCorridor.Name = "radCorridor";
            this.radCorridor.Size = new System.Drawing.Size(61, 17);
            this.radCorridor.TabIndex = 2;
            this.radCorridor.TabStop = true;
            this.radCorridor.Text = "Corridor";
            this.radCorridor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z:";
            // 
            // numX
            // 
            this.numX.DecimalPlaces = 5;
            this.numX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numX.Location = new System.Drawing.Point(158, 15);
            this.numX.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numX.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(120, 20);
            this.numX.TabIndex = 6;
            // 
            // numY
            // 
            this.numY.DecimalPlaces = 5;
            this.numY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numY.Location = new System.Drawing.Point(158, 38);
            this.numY.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numY.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(120, 20);
            this.numY.TabIndex = 7;
            // 
            // numZ
            // 
            this.numZ.DecimalPlaces = 5;
            this.numZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numZ.Location = new System.Drawing.Point(158, 61);
            this.numZ.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numZ.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numZ.Name = "numZ";
            this.numZ.Size = new System.Drawing.Size(120, 20);
            this.numZ.TabIndex = 8;
            // 
            // numEulerZ
            // 
            this.numEulerZ.DecimalPlaces = 5;
            this.numEulerZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEulerZ.Location = new System.Drawing.Point(370, 61);
            this.numEulerZ.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numEulerZ.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numEulerZ.Name = "numEulerZ";
            this.numEulerZ.Size = new System.Drawing.Size(120, 20);
            this.numEulerZ.TabIndex = 14;
            // 
            // numEulerY
            // 
            this.numEulerY.DecimalPlaces = 5;
            this.numEulerY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEulerY.Location = new System.Drawing.Point(370, 38);
            this.numEulerY.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numEulerY.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numEulerY.Name = "numEulerY";
            this.numEulerY.Size = new System.Drawing.Size(120, 20);
            this.numEulerY.TabIndex = 13;
            // 
            // numEulerX
            // 
            this.numEulerX.DecimalPlaces = 5;
            this.numEulerX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEulerX.Location = new System.Drawing.Point(370, 15);
            this.numEulerX.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numEulerX.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numEulerX.Name = "numEulerX";
            this.numEulerX.Size = new System.Drawing.Size(120, 20);
            this.numEulerX.TabIndex = 12;
            // 
            // numFZasdasd
            // 
            this.numFZasdasd.AutoSize = true;
            this.numFZasdasd.Location = new System.Drawing.Point(306, 65);
            this.numFZasdasd.Name = "numFZasdasd";
            this.numFZasdasd.Size = new System.Drawing.Size(44, 13);
            this.numFZasdasd.TabIndex = 11;
            this.numFZasdasd.Text = "Euler Z:";
            // 
            // labelas
            // 
            this.labelas.AutoSize = true;
            this.labelas.Location = new System.Drawing.Point(306, 40);
            this.labelas.Name = "labelas";
            this.labelas.Size = new System.Drawing.Size(44, 13);
            this.labelas.TabIndex = 10;
            this.labelas.Text = "Euler Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Euler X:";
            // 
            // txtOut
            // 
            this.txtOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOut.Location = new System.Drawing.Point(197, 138);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOut.Size = new System.Drawing.Size(591, 304);
            this.txtOut.TabIndex = 15;
            // 
            // btnGen
            // 
            this.btnGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGen.Location = new System.Drawing.Point(697, 12);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(91, 27);
            this.btnGen.TabIndex = 16;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tex:";
            // 
            // numTex
            // 
            this.numTex.Location = new System.Drawing.Point(50, 89);
            this.numTex.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numTex.Name = "numTex";
            this.numTex.Size = new System.Drawing.Size(106, 20);
            this.numTex.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Transval:";
            // 
            // numTransval
            // 
            this.numTransval.DecimalPlaces = 3;
            this.numTransval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numTransval.Location = new System.Drawing.Point(219, 89);
            this.numTransval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numTransval.Name = "numTransval";
            this.numTransval.Size = new System.Drawing.Size(106, 20);
            this.numTransval.TabIndex = 20;
            // 
            // numRoom
            // 
            this.numRoom.Location = new System.Drawing.Point(375, 89);
            this.numRoom.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numRoom.Name = "numRoom";
            this.numRoom.Size = new System.Drawing.Size(106, 20);
            this.numRoom.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Room:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Paddy:";
            // 
            // numPaddy
            // 
            this.numPaddy.Location = new System.Drawing.Point(533, 89);
            this.numPaddy.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numPaddy.Name = "numPaddy";
            this.numPaddy.Size = new System.Drawing.Size(106, 20);
            this.numPaddy.TabIndex = 24;
            // 
            // lstType
            // 
            this.lstType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstType.FormattingEnabled = true;
            this.lstType.Location = new System.Drawing.Point(12, 138);
            this.lstType.Name = "lstType";
            this.lstType.Size = new System.Drawing.Size(179, 304);
            this.lstType.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Scale:";
            // 
            // numScale
            // 
            this.numScale.DecimalPlaces = 5;
            this.numScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numScale.Location = new System.Drawing.Point(557, 15);
            this.numScale.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numScale.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numScale.Name = "numScale";
            this.numScale.Size = new System.Drawing.Size(120, 20);
            this.numScale.TabIndex = 28;
            this.numScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkPretty
            // 
            this.chkPretty.AutoSize = true;
            this.chkPretty.Checked = true;
            this.chkPretty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPretty.Location = new System.Drawing.Point(697, 45);
            this.chkPretty.Name = "chkPretty";
            this.chkPretty.Size = new System.Drawing.Size(78, 17);
            this.chkPretty.TabIndex = 29;
            this.chkPretty.Text = "Pretty Json";
            this.chkPretty.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkPretty);
            this.Controls.Add(this.numScale);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstType);
            this.Controls.Add(this.numPaddy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numTransval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numTex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.numEulerZ);
            this.Controls.Add(this.numEulerY);
            this.Controls.Add(this.numEulerX);
            this.Controls.Add(this.numFZasdasd);
            this.Controls.Add(this.labelas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numZ);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radCorridor);
            this.Controls.Add(this.radCube);
            this.Controls.Add(this.radPlane);
            this.Name = "Form1";
            this.Text = "CoordGenTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEulerZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEulerY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEulerX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTransval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaddy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.RadioButton radPlane;
		private System.Windows.Forms.RadioButton radCube;
		private System.Windows.Forms.RadioButton radCorridor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numX;
		private System.Windows.Forms.NumericUpDown numY;
		private System.Windows.Forms.NumericUpDown numZ;
		private System.Windows.Forms.NumericUpDown numEulerZ;
		private System.Windows.Forms.NumericUpDown numEulerY;
		private System.Windows.Forms.NumericUpDown numEulerX;
		private System.Windows.Forms.Label numFZasdasd;
		private System.Windows.Forms.Label labelas;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtOut;
		private System.Windows.Forms.Button btnGen;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numTex;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numTransval;
		private System.Windows.Forms.NumericUpDown numRoom;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown numPaddy;
		private System.Windows.Forms.CheckedListBox lstType;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown numScale;
		private System.Windows.Forms.CheckBox chkPretty;
	}
}

