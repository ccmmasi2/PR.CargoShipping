namespace PR.CargoShipping
{
    partial class frmTrips
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
            btnSearchByTripNumber = new Button();
            txtTripNumber = new TextBox();
            gvTrips = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvTrips).BeginInit();
            SuspendLayout();
            // 
            // btnSearchByTripNumber
            // 
            btnSearchByTripNumber.Location = new Point(228, 27);
            btnSearchByTripNumber.Name = "btnSearchByTripNumber";
            btnSearchByTripNumber.Size = new Size(94, 29);
            btnSearchByTripNumber.TabIndex = 0;
            btnSearchByTripNumber.Text = "Search";
            btnSearchByTripNumber.UseVisualStyleBackColor = true;
            btnSearchByTripNumber.Click += btnSearchByTripNumber_Click;
            // 
            // txtTripNumber
            // 
            txtTripNumber.Location = new Point(83, 29);
            txtTripNumber.Name = "txtTripNumber";
            txtTripNumber.Size = new Size(125, 27);
            txtTripNumber.TabIndex = 1;
            // 
            // gvTrips
            // 
            gvTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvTrips.Location = new Point(31, 109);
            gvTrips.Name = "gvTrips";
            gvTrips.RowHeadersWidth = 51;
            gvTrips.Size = new Size(750, 185);
            gvTrips.TabIndex = 2;
            gvTrips.CellPainting += gvTrips_CellPainting;
            gvTrips.DataBindingComplete += gvTrips_DataBindingComplete;
            // 
            // frmTrips
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gvTrips);
            Controls.Add(txtTripNumber);
            Controls.Add(btnSearchByTripNumber);
            Name = "frmTrips";
            Text = "frmTrips";
            ((System.ComponentModel.ISupportInitialize)gvTrips).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchByTripNumber;
        private TextBox txtTripNumber;
        private DataGridView gvTrips;
    }
}