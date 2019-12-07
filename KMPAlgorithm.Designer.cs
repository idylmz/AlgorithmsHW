namespace AlgorithmsHW
{
    partial class KMPAlgorithm
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
            this.txtWholeString = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtDisabledResult = new System.Windows.Forms.TextBox();
            this.btnFindKey = new System.Windows.Forms.Button();
            this.lblIndexes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWholeString
            // 
            this.txtWholeString.Location = new System.Drawing.Point(360, 97);
            this.txtWholeString.Multiline = true;
            this.txtWholeString.Name = "txtWholeString";
            this.txtWholeString.Size = new System.Drawing.Size(618, 179);
            this.txtWholeString.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(474, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Please enter your string first:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter your search key:";
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(528, 369);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(251, 31);
            this.txtSearchKey.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(461, 425);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 31);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result:";
            // 
            // txtDisabledResult
            // 
            this.txtDisabledResult.Enabled = false;
            this.txtDisabledResult.Location = new System.Drawing.Point(360, 521);
            this.txtDisabledResult.Multiline = true;
            this.txtDisabledResult.Name = "txtDisabledResult";
            this.txtDisabledResult.Size = new System.Drawing.Size(618, 179);
            this.txtDisabledResult.TabIndex = 5;
            // 
            // btnFindKey
            // 
            this.btnFindKey.Location = new System.Drawing.Point(886, 369);
            this.btnFindKey.Name = "btnFindKey";
            this.btnFindKey.Size = new System.Drawing.Size(130, 38);
            this.btnFindKey.TabIndex = 6;
            this.btnFindKey.Text = "Find";
            this.btnFindKey.UseVisualStyleBackColor = true;
            this.btnFindKey.Click += new System.EventHandler(this.btnFindKey_Click);
            // 
            // lblIndexes
            // 
            this.lblIndexes.AutoSize = true;
            this.lblIndexes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexes.Location = new System.Drawing.Point(461, 474);
            this.lblIndexes.Name = "lblIndexes";
            this.lblIndexes.Size = new System.Drawing.Size(117, 31);
            this.lblIndexes.TabIndex = 7;
            this.lblIndexes.Text = "Indexes:";
            // 
            // KMPAlgorithm
            // 
            this.AcceptButton = this.btnFindKey;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 829);
            this.Controls.Add(this.lblIndexes);
            this.Controls.Add(this.btnFindKey);
            this.Controls.Add(this.txtDisabledResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtSearchKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtWholeString);
            this.Name = "KMPAlgorithm";
            this.Text = "KMPAlgorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWholeString;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtDisabledResult;
        private System.Windows.Forms.Button btnFindKey;
        private System.Windows.Forms.Label lblIndexes;
    }
}