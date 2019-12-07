namespace AlgorithmsHW
{
    partial class BubbleSort
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
            this.txtNewNumber = new System.Windows.Forms.TextBox();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.lblNumberList = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSortedNumbers = new System.Windows.Forms.Label();
            this.btnRecSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please, add numbers to the array:";
            // 
            // txtNewNumber
            // 
            this.txtNewNumber.Location = new System.Drawing.Point(627, 233);
            this.txtNewNumber.Name = "txtNewNumber";
            this.txtNewNumber.Size = new System.Drawing.Size(229, 31);
            this.txtNewNumber.TabIndex = 2;
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(932, 233);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(155, 39);
            this.btnAddNumber.TabIndex = 3;
            this.btnAddNumber.Text = "Add Number!";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // lblNumberList
            // 
            this.lblNumberList.AutoSize = true;
            this.lblNumberList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberList.Location = new System.Drawing.Point(195, 9);
            this.lblNumberList.Name = "lblNumberList";
            this.lblNumberList.Size = new System.Drawing.Size(264, 37);
            this.lblNumberList.TabIndex = 4;
            this.lblNumberList.Text = "Numbers added: ";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(932, 363);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(155, 39);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1151, 764);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(155, 39);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSortedNumbers
            // 
            this.lblSortedNumbers.AutoSize = true;
            this.lblSortedNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortedNumbers.Location = new System.Drawing.Point(195, 540);
            this.lblSortedNumbers.Name = "lblSortedNumbers";
            this.lblSortedNumbers.Size = new System.Drawing.Size(318, 37);
            this.lblSortedNumbers.TabIndex = 7;
            this.lblSortedNumbers.Text = "Sorted numbers are: ";
            // 
            // btnRecSort
            // 
            this.btnRecSort.Location = new System.Drawing.Point(932, 434);
            this.btnRecSort.Name = "btnRecSort";
            this.btnRecSort.Size = new System.Drawing.Size(155, 39);
            this.btnRecSort.TabIndex = 8;
            this.btnRecSort.Text = "Rec Sort";
            this.btnRecSort.UseVisualStyleBackColor = true;
            this.btnRecSort.Click += new System.EventHandler(this.btnRecSort_Click);
            // 
            // BubbleSort
            // 
            this.AcceptButton = this.btnAddNumber;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 829);
            this.Controls.Add(this.btnRecSort);
            this.Controls.Add(this.lblSortedNumbers);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblNumberList);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.txtNewNumber);
            this.Controls.Add(this.label1);
            this.Name = "BubbleSort";
            this.Text = "Bubble Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewNumber;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Label lblNumberList;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSortedNumbers;
        private System.Windows.Forms.Button btnRecSort;
    }
}