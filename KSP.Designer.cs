namespace AlgorithmsHW
{
    partial class KSP
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblCityList = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.btnBruteCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(979, 523);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 123);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate with Greedy";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(112, 387);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersWidth = 82;
            this.dgvResult.RowTemplate.Height = 33;
            this.dgvResult.Size = new System.Drawing.Size(791, 424);
            this.dgvResult.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(742, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 37);
            this.label4.TabIndex = 45;
            this.label4.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 37);
            this.label3.TabIndex = 44;
            this.label3.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 37);
            this.label2.TabIndex = 43;
            this.label2.Text = "Item Name";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(674, 279);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(229, 31);
            this.txtValue.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1173, 772);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(155, 39);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(979, 271);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(155, 39);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblCityList
            // 
            this.lblCityList.AutoSize = true;
            this.lblCityList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityList.Location = new System.Drawing.Point(105, 17);
            this.lblCityList.Name = "lblCityList";
            this.lblCityList.Size = new System.Drawing.Size(271, 37);
            this.lblCityList.TabIndex = 36;
            this.lblCityList.Text = "Basket should be:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(112, 279);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(229, 31);
            this.txtItemName.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(390, 279);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(229, 31);
            this.txtWeight.TabIndex = 2;
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Location = new System.Drawing.Point(390, 17);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            this.dgvItemList.RowHeadersWidth = 82;
            this.dgvItemList.RowTemplate.Height = 33;
            this.dgvItemList.Size = new System.Drawing.Size(744, 203);
            this.dgvItemList.TabIndex = 50;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(979, 468);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(155, 31);
            this.txtCapacity.TabIndex = 51;
            // 
            // btnBruteCalculate
            // 
            this.btnBruteCalculate.Location = new System.Drawing.Point(979, 688);
            this.btnBruteCalculate.Name = "btnBruteCalculate";
            this.btnBruteCalculate.Size = new System.Drawing.Size(155, 123);
            this.btnBruteCalculate.TabIndex = 52;
            this.btnBruteCalculate.Text = "Calculate with Brute Force";
            this.btnBruteCalculate.UseVisualStyleBackColor = true;
            this.btnBruteCalculate.Click += new System.EventHandler(this.btnBruteCalculate_Click);
            // 
            // KSP
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 829);
            this.Controls.Add(this.btnBruteCalculate);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblCityList);
            this.Name = "KSP";
            this.Text = "KSP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblCityList;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Button btnBruteCalculate;
    }
}