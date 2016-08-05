using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using KeyboardEnabledControls;

namespace KeyboardEnabledControlsTest
{
    public partial class SortForm : KeyboardEnabledControls.BaseForm
    {
        public SortForm()
        {
            InitializeComponent();
        }

        private void SortForm_Load( object sender, EventArgs e )
        {
            //List<SortFieldDescriptor> list =


        }

        public void PrepareData()
        {
            sortClauseControl.SourceFieldList = new List<SortFieldDescriptor>();

            sortClauseControl.SourceFieldList.Add( new SortFieldDescriptor( "Var", "Variedad", "Var" ) );
            sortClauseControl.SourceFieldList.Add( new SortFieldDescriptor( "Sel", "Selección", "Sel" ) );
            sortClauseControl.SourceFieldList.Add( new SortFieldDescriptor( "Env", "Envase", "Env" ) );
            sortClauseControl.SourceFieldList.Add( new SortFieldDescriptor( "Fecha", "Fecha", "Date" ) );

        }
    }
}
