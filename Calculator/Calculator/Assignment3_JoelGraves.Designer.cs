namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdAddition = new System.Windows.Forms.RadioButton();
            this.rdSubtraction = new System.Windows.Forms.RadioButton();
            this.rdMulti = new System.Windows.Forms.RadioButton();
            this.rdDiv = new System.Windows.Forms.RadioButton();
            this.rdSquare = new System.Windows.Forms.RadioButton();
            this.rdRaise = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLOp = new System.Windows.Forms.TextBox();
            this.txtROp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblExpr = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left Operand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Right Operand";
            // 
            // rdAddition
            // 
            this.rdAddition.AutoSize = true;
            this.rdAddition.Location = new System.Drawing.Point(22, 39);
            this.rdAddition.Name = "rdAddition";
            this.rdAddition.Size = new System.Drawing.Size(79, 19);
            this.rdAddition.TabIndex = 1;
            this.rdAddition.TabStop = true;
            this.rdAddition.Text = "+ Addition";
            this.rdAddition.UseVisualStyleBackColor = true;
            // 
            // rdSubtraction
            // 
            this.rdSubtraction.AutoSize = true;
            this.rdSubtraction.Location = new System.Drawing.Point(22, 73);
            this.rdSubtraction.Name = "rdSubtraction";
            this.rdSubtraction.Size = new System.Drawing.Size(94, 19);
            this.rdSubtraction.TabIndex = 1;
            this.rdSubtraction.TabStop = true;
            this.rdSubtraction.Text = "- Subtraction";
            this.rdSubtraction.UseVisualStyleBackColor = true;
            // 
            // rdMulti
            // 
            this.rdMulti.AutoSize = true;
            this.rdMulti.Location = new System.Drawing.Point(22, 110);
            this.rdMulti.Name = "rdMulti";
            this.rdMulti.Size = new System.Drawing.Size(106, 19);
            this.rdMulti.TabIndex = 1;
            this.rdMulti.TabStop = true;
            this.rdMulti.Text = "* Multiplication";
            this.rdMulti.UseVisualStyleBackColor = true;
            // 
            // rdDiv
            // 
            this.rdDiv.AutoSize = true;
            this.rdDiv.Location = new System.Drawing.Point(22, 145);
            this.rdDiv.Name = "rdDiv";
            this.rdDiv.Size = new System.Drawing.Size(74, 19);
            this.rdDiv.TabIndex = 1;
            this.rdDiv.TabStop = true;
            this.rdDiv.Text = "/ Division";
            this.rdDiv.UseVisualStyleBackColor = true;
            // 
            // rdSquare
            // 
            this.rdSquare.AutoSize = true;
            this.rdSquare.Location = new System.Drawing.Point(22, 177);
            this.rdSquare.Name = "rdSquare";
            this.rdSquare.Size = new System.Drawing.Size(94, 19);
            this.rdSquare.TabIndex = 1;
            this.rdSquare.TabStop = true;
            this.rdSquare.Text = "Square Root";
            this.rdSquare.UseVisualStyleBackColor = true;
            // 
            // rdRaise
            // 
            this.rdRaise.AutoSize = true;
            this.rdRaise.Location = new System.Drawing.Point(22, 218);
            this.rdRaise.Name = "rdRaise";
            this.rdRaise.Size = new System.Drawing.Size(95, 19);
            this.rdRaise.TabIndex = 1;
            this.rdRaise.TabStop = true;
            this.rdRaise.Text = "Raise Power";
            this.rdRaise.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "(will use the left Operand Value)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rdAddition);
            this.groupBox1.Controls.Add(this.rdRaise);
            this.groupBox1.Controls.Add(this.rdSubtraction);
            this.groupBox1.Controls.Add(this.rdSquare);
            this.groupBox1.Controls.Add(this.rdMulti);
            this.groupBox1.Controls.Add(this.rdDiv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(150, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 251);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // txtLOp
            // 
            this.txtLOp.Location = new System.Drawing.Point(16, 48);
            this.txtLOp.Name = "txtLOp";
            this.txtLOp.Size = new System.Drawing.Size(100, 20);
            this.txtLOp.TabIndex = 4;
            // 
            // txtROp
            // 
            this.txtROp.Location = new System.Drawing.Point(393, 48);
            this.txtROp.Name = "txtROp";
            this.txtROp.Size = new System.Drawing.Size(100, 20);
            this.txtROp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Expression:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Result:";
            // 
            // lblExpr
            // 
            this.lblExpr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblExpr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExpr.Location = new System.Drawing.Point(172, 313);
            this.lblExpr.Name = "lblExpr";
            this.lblExpr.Size = new System.Drawing.Size(219, 30);
            this.lblExpr.TabIndex = 7;
            // 
            // lblRes
            // 
            this.lblRes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRes.Location = new System.Drawing.Point(172, 378);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(219, 29);
            this.lblRes.TabIndex = 8;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(41, 436);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(113, 41);
            this.btnCal.TabIndex = 9;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(203, 436);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Calculator";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(393, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 41);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 520);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblExpr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtROp);
            this.Controls.Add(this.txtLOp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdAddition;
        private System.Windows.Forms.RadioButton rdSubtraction;
        private System.Windows.Forms.RadioButton rdMulti;
        private System.Windows.Forms.RadioButton rdDiv;
        private System.Windows.Forms.RadioButton rdSquare;
        private System.Windows.Forms.RadioButton rdRaise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLOp;
        private System.Windows.Forms.TextBox txtROp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblExpr;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

