namespace KeyboardEnabledControlsTest
{
    partial class SortForm
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
            this.sortClauseControl1 = new KeyboardEnabledControls.SortClauseControl();
            this.sortClauseControl = new KeyboardEnabledControls.SortClauseControl();
            this.SuspendLayout();
            // 
            // sortClauseControl1
            // 
            this.sortClauseControl1.Location = new System.Drawing.Point( 0, 0 );
            this.sortClauseControl1.Name = "sortClauseControl1";
            this.sortClauseControl1.Size = new System.Drawing.Size( 562, 318 );
            this.sortClauseControl1.TabIndex = 0;
            // 
            // sortClauseControl
            // 
            this.sortClauseControl.Location = new System.Drawing.Point( 27, 13 );
            this.sortClauseControl.Name = "sortClauseControl";
            this.sortClauseControl.Size = new System.Drawing.Size( 562, 318 );
            this.sortClauseControl.TabIndex = 1;
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.ClientSize = new System.Drawing.Size( 633, 324 );
            this.Controls.Add( this.sortClauseControl );
            this.Name = "SortForm";
            this.StatusStripVisible = true;
            this.Load += new System.EventHandler( this.SortForm_Load );
            this.Controls.SetChildIndex( this.sortClauseControl, 0 );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private KeyboardEnabledControls.SortClauseControl sortClauseControl1;
        private KeyboardEnabledControls.SortClauseControl sortClauseControl;
    }
}
