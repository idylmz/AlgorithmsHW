namespace AlgorithmsHW
{
    partial class Bonus
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
            this.btnMinify = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNodeList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.btnTotalCalculation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMinify
            // 
            this.btnMinify.Location = new System.Drawing.Point(1183, 317);
            this.btnMinify.Name = "btnMinify";
            this.btnMinify.Size = new System.Drawing.Size(155, 39);
            this.btnMinify.TabIndex = 5;
            this.btnMinify.Text = "Minify";
            this.btnMinify.UseVisualStyleBackColor = true;
            this.btnMinify.Click += new System.EventHandler(this.btnMinify_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(972, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 37);
            this.label4.TabIndex = 45;
            this.label4.Text = "Power";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(722, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 37);
            this.label3.TabIndex = 44;
            this.label3.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 37);
            this.label2.TabIndex = 43;
            this.label2.Text = "Multiplier";
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(905, 234);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(229, 31);
            this.txtPower.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1183, 772);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(155, 39);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1183, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNodeList
            // 
            this.lblNodeList.AutoSize = true;
            this.lblNodeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNodeList.Location = new System.Drawing.Point(23, 9);
            this.lblNodeList.Name = "lblNodeList";
            this.lblNodeList.Size = new System.Drawing.Size(226, 37);
            this.lblNodeList.TabIndex = 36;
            this.lblNodeList.Text = "Nodes added: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Please, add nodes to the list:";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(664, 234);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(229, 31);
            this.txtBase.TabIndex = 2;
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(420, 234);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(229, 31);
            this.txtMultiplier.TabIndex = 1;
            // 
            // btnTotalCalculation
            // 
            this.btnTotalCalculation.Location = new System.Drawing.Point(1183, 395);
            this.btnTotalCalculation.Name = "btnTotalCalculation";
            this.btnTotalCalculation.Size = new System.Drawing.Size(155, 39);
            this.btnTotalCalculation.TabIndex = 47;
            this.btnTotalCalculation.Text = "Total";
            this.btnTotalCalculation.UseVisualStyleBackColor = true;
            this.btnTotalCalculation.Click += new System.EventHandler(this.btnTotalCalculation_Click);
            // 
            // Bonus
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 829);
            this.Controls.Add(this.btnTotalCalculation);
            this.Controls.Add(this.txtMultiplier);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.btnMinify);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNodeList);
            this.Controls.Add(this.label1);
            this.Name = "Bonus";
            this.Text = "Bonus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNodeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.Button btnTotalCalculation;
    }
}