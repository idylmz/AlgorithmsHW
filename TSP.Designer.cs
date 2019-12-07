namespace AlgorithmsHW
{
    partial class TSP
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
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCityList = new System.Windows.Forms.Label();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.txtNewCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsCityBox = new System.Windows.Forms.ListBox();
            this.dgvDistanceList = new System.Windows.Forms.DataGridView();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnTravel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistanceList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1071, 772);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(155, 39);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblCityList
            // 
            this.lblCityList.AutoSize = true;
            this.lblCityList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityList.Location = new System.Drawing.Point(115, 17);
            this.lblCityList.Name = "lblCityList";
            this.lblCityList.Size = new System.Drawing.Size(212, 37);
            this.lblCityList.TabIndex = 20;
            this.lblCityList.Text = "Cities added: ";
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(979, 241);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(155, 39);
            this.btnAddCity.TabIndex = 19;
            this.btnAddCity.Text = "Add City";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // txtNewCity
            // 
            this.txtNewCity.Location = new System.Drawing.Point(674, 241);
            this.txtNewCity.Name = "txtNewCity";
            this.txtNewCity.Size = new System.Drawing.Size(229, 31);
            this.txtNewCity.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Please, add cities to the list:";
            // 
            // lsCityBox
            // 
            this.lsCityBox.FormattingEnabled = true;
            this.lsCityBox.ItemHeight = 25;
            this.lsCityBox.Location = new System.Drawing.Point(674, 17);
            this.lsCityBox.Name = "lsCityBox";
            this.lsCityBox.Size = new System.Drawing.Size(460, 204);
            this.lsCityBox.TabIndex = 25;
            // 
            // dgvDistanceList
            // 
            this.dgvDistanceList.AllowUserToAddRows = false;
            this.dgvDistanceList.AllowUserToDeleteRows = false;
            this.dgvDistanceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistanceList.Location = new System.Drawing.Point(122, 331);
            this.dgvDistanceList.Name = "dgvDistanceList";
            this.dgvDistanceList.RowHeadersWidth = 82;
            this.dgvDistanceList.RowTemplate.Height = 33;
            this.dgvDistanceList.Size = new System.Drawing.Size(781, 480);
            this.dgvDistanceList.TabIndex = 31;
            this.dgvDistanceList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDistanceList_CellValueChanged);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(979, 331);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(155, 39);
            this.btnSaveData.TabIndex = 32;
            this.btnSaveData.Text = "Save Cities";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnTravel
            // 
            this.btnTravel.Location = new System.Drawing.Point(979, 431);
            this.btnTravel.Name = "btnTravel";
            this.btnTravel.Size = new System.Drawing.Size(155, 39);
            this.btnTravel.TabIndex = 33;
            this.btnTravel.Text = "Travel";
            this.btnTravel.UseVisualStyleBackColor = true;
            this.btnTravel.Click += new System.EventHandler(this.btnTravel_Click);
            // 
            // TSP
            // 
            this.AcceptButton = this.btnAddCity;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 829);
            this.Controls.Add(this.btnTravel);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.dgvDistanceList);
            this.Controls.Add(this.lsCityBox);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblCityList);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.txtNewCity);
            this.Controls.Add(this.label1);
            this.Name = "TSP";
            this.Text = "TSP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistanceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCityList;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.TextBox txtNewCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsCityBox;
        private System.Windows.Forms.DataGridView dgvDistanceList;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnTravel;
    }
}