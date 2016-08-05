using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Infrastructure;
using KeyboardEnabledControls;

namespace KeyboardEnabledControlsTest
{
    public partial class WhereForm : KeyboardEnabledControls.BaseForm
    {
        public WhereForm()
        {
            InitializeComponent();
        }

        private void WhereForm_Load( object sender, EventArgs e )
        {
            buildQfd();
            whereClauseControl1.QueryFieldList = qfd;
        }

        private List<WhereFieldDescriptor> qfd = new List<WhereFieldDescriptor>();

        private void buildQfd()
        {
            qfd.Add( WhereFieldFactory.WhereField( "Var", "Variedad", "Variety", new Wrapper( "-", null, true ), false ) );
            qfd.Add( WhereFieldFactory.WhereField( "Sel", "Selección", "Grase", new Wrapper( "-", null ), false ) );
            qfd.Add( WhereFieldFactory.WhereField( "Env", "Envase", "BoxType", new Wrapper( "-", null, true) , false ) );
        }
    }
}
