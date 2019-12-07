namespace AlgorithmsHW
{
    partial class TravelResult
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
            this.lstTravelResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstTravelResult
            // 
            this.lstTravelResult.FormattingEnabled = true;
            this.lstTravelResult.ItemHeight = 25;
            this.lstTravelResult.Location = new System.Drawing.Point(12, 12);
            this.lstTravelResult.Name = "lstTravelResult";
            this.lstTravelResult.Size = new System.Drawing.Size(1131, 804);
            this.lstTravelResult.TabIndex = 0;
            // 
            // TravelResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 829);
            this.Controls.Add(this.lstTravelResult);
            this.Name = "TravelResult";
            this.Text = "TravelResult";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTravelResult;
    }
}