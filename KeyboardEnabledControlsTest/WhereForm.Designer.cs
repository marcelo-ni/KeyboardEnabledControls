namespace KeyboardEnabledControlsTest
{
    partial class WhereForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.whereClauseControl1 = new KeyboardEnabledControls.WhereClauseControl();
            this.SuspendLayout();
            // 
            // whereClauseControl1
            // 
            this.whereClauseControl1.Location = new System.Drawing.Point( 22, 4 );
            this.whereClauseControl1.Name = "whereClauseControl1";
            this.whereClauseControl1.QueryFieldList = null;
            this.whereClauseControl1.Size = new System.Drawing.Size( 595, 301 );
            this.whereClauseControl1.TabIndex = 1;
            // 
            // WhereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.ClientSize = new System.Drawing.Size( 831, 356 );
            this.Controls.Add( this.whereClauseControl1 );
            this.Name = "WhereForm";
            this.StatusStripVisible = true;
            this.Load += new System.EventHandler( this.WhereForm_Load );
            this.Controls.SetChildIndex( this.whereClauseControl1, 0 );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private KeyboardEnabledControls.WhereClauseControl whereClauseControl1;
    }
}
