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
    public partial class MainForm : KeyboardEnabledControls.BaseForm
    {
        public MainForm() : base()
        {
            InitializeComponent();
            //if (DesignMode)
            //    throw new Exception("DesignMode true");
        }

        private void kButton1_Click( object sender, EventArgs e )
        {
            panel1.Enabled = !panel1.Enabled;
            MessageBox.Show( "F10 " + panel1.Enabled.ToString());

            Int64? i64 = nullableInt64MaskedControl1.NilInt64MValue;

            Int32? i32 = nullableIntegerMaskedControl1.NilInt32MValue;

            BindFromControls();

            MessageBox.Show( String.Format( "{0}, {1}, {2}, {3}", bindingTest.Name, bindingTest.BDate, bindingTest.Cuil,
                bindingTest.ComboItem != null ? bindingTest.ComboItem.Abrev : "NULL" ) );

            // MessageBox.Show( String.Format( "i64: {0} i32?: {1}", i64, i32 == null? "null" : i32.Value.ToString() ) );

            //string[] temp = textBox1.Text.Split( new char[] { '|' } );
            //if ( temp.Length != 2)
            //    return;

            //Masker masker = new Masker( temp[0] );

            //string masked = masker.MaskIt( temp[1] );

            //int[] translator = masker.IndexTranslator;

            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < translator.Length; i++) {
            //    sb.AppendFormat( "{0}, ", translator[i] );
            //}

            //string raw = masker.GetString( masked );

            //MessageBox.Show( String.Format( "{0}\n{1}\n{2}\n{3}", masked, sb.ToString(), raw, masker.GetInt64( masked ) ) );
        }

        private void kButton2_Click( object sender, EventArgs e )
        {
            ComboData cd = (ComboData)comboControl1.SelectedItem;
            string result = cd == null ? "NULL" : cd.Abrev;
            MessageBox.Show( String.Format( "(F2) -> {0}", result ) );
        }


        private void kButton3_Click( object sender, EventArgs e )
        {
            if (blinkLabel == null) {
                blinkLabel = new Label();
                blinkLabel.Left = 3;
                blinkLabel.Top = 3;
                blinkLabel.Text = "Frágil";
                this.Controls.Add( blinkLabel );
            }
            else {
                if (this.Controls.Contains( blinkLabel )) {
                    this.Controls.Remove( blinkLabel );
                    blinkLabel = null;
                }
            }
            MessageBox.Show( "Ctrl-F12" );
        }

        void enablekButton1( string from )
        {
            string m = "Enabling";
            if (kButton1.Enabled)
                m = "Disabling";

            kButton1.Enabled = !kButton1.Enabled;

            MessageBox.Show( from + m ); 

        }

        Label blinkLabel = null;

        private void kButton4_Click( object sender, EventArgs e )
        {
            enablekButton1( "S-F5: " );


        }

        private void kHiddenControl1_KeyFiredEvent( object sender, EventArgs e )
        {
            enablekButton1( "Hidden Control: " );
        }

        protected void ExecEndKey( ManagedKeyEventArgs e )
        {
            kHiddenControl1_KeyFiredEvent( null, null );
            e.Consumed = true;
        }

        protected void ExecF3Key( ManagedKeyEventArgs e )
        {
            WhereForm w = new WhereForm();
            w.Show();
            // kHiddenControl1_KeyFiredEvent( null, null );
            e.Consumed = true;
        }

        protected void ExecF4Key( ManagedKeyEventArgs e )
        {
            SortForm w = new SortForm();
            w.PrepareData();
            w.Show();
            // kHiddenControl1_KeyFiredEvent( null, null );
            e.Consumed = true;
        }


        BindingTest bindingTest;
        ComboData comboItem;

        private void MainForm_Load( object sender, EventArgs e )
        {
            Requested.Add( new CommandKey( ShiftState.None, Keys.End, ExecEndKey ) );
            Requested.Add( new CommandKey( ShiftState.None, Keys.F3, ExecF3Key ) );
            Requested.Add( new CommandKey( ShiftState.None, Keys.F4, ExecF4Key ) );
            Requested.Add( new CommandKey( ShiftState.None, Keys.F10, kButton1 ) );
            Requested.Add( new CommandKey( ShiftState.None, Keys.F2, kButton2 ) );
            Requested.Add( new CommandKey( ShiftState.Control, Keys.F12, kButton3 ) );

            dateControl1.DateValue = DateTime.Now;
            maskedControl1.MaskedValue = "23077955909";
            //longMaskedControl1.Int64MValue = 0;
            nullableIntegerMaskedControl1.NilInt32MValue = null;

            textControl1.KControlValidateEvent += new KControlValidateEventHandler( textControl1_KControlValidateEvent );
            textControl1.KControlLeaveEvent += new KControlLeaveEventHandler( textControl1_KControlLeaveEvent );

            comboControl1.ComboLoadEvent += new ComboControlLoadEventHandler(comboControl1_ComboLoadEvent);
            comboControl1.KControlValidateEvent += new KControlValidateEventHandler( comboControl1_KControlValidateEvent );
            comboControl1.KControlLeaveEvent += new KControlLeaveEventHandler( comboControl1_KControlLeaveEvent );

            dateControl1.KControlValidateEvent += new KControlValidateEventHandler( dateControl1_KControlValidateEvent );
            dateControl1.KControlLeaveEvent += new KControlLeaveEventHandler( dateControl1_KControlLeaveEvent );

            comboControl1.InitDataSource(); // (List<IComboItem>)source;

            bindingTest = new BindingTest( "Graciela", new DateTime( 1950, 04, 24 ), 26021722966 );
            bindingTest.ComboItem = source[2];

            bindingSourceList.Add( bindingTest );
            // bindingSourceList.Add( comboItem );

            configureBinding();

            BindToControls();

            buildQfd();

            queryFieldListControl1.QueryFieldList = qfd;
        }

        void dateControl1_KControlLeaveEvent( object sender, KControlLeaveEventArgs e )
        {
            MessageBox.Show( "date.LeaveEvent!" );
        }

        void dateControl1_KControlValidateEvent( object sender, KControlValidateEventArgs e )
        {
            MessageBox.Show( "date.ValidateEvent!" );
        }

        void comboControl1_KControlLeaveEvent( object sender, KControlLeaveEventArgs e )
        {
            MessageBox.Show( "combo.LeaveEvent!" );
        }

        void comboControl1_KControlValidateEvent( object sender, KControlValidateEventArgs e )
        {
            MessageBox.Show( "combo.ValidateEvent!" );
            e.Valid = true;
        }

        void textControl1_KControlLeaveEvent( object sender, KControlLeaveEventArgs e )
        {
            MessageBox.Show( "text.LeaveEvent!" );
        }

        void textControl1_KControlValidateEvent( object sender, KControlValidateEventArgs e )
        {
            MessageBox.Show( "text.ValidateEvent!" );
        }

        protected List<ComboData> source = new List<ComboData>();

        private void populate()
        {
            if (source.Count > 0)
                return;
            source.Add( new ComboData( "MGS", "Granny" ) );
            source.Add( new ComboData( "MRD", "Red" ) );
            source.Add( new ComboData( "PWS", "Williams" ) );
            source.Add( new ComboData( "PWE", "Williams orgánica" ) );
            source.Add( new ComboData( "PPT", "Packams" ) );
            source.Add( new ComboData( "PFA", "Abate Fetel" ) );

        }

        private void comboControl1_ComboLoadEvent( object sender, ComboControlLoadEventArgs e )
        {
            populate();
            e.Combo.DataSource = source.ConvertAll( x => (IComboItem)x ); // (List<IComboItem>)source;
            //e.Combo.DisplayMember = "Display";
            //e.Combo.SelectMember = "Abrev";
            //e.Combo.SelectedValue = "PPT";
        }

        int seq = 0;

        private void comboControl1_ComboNewItemEvent( object sender, ComboControlNewItemEventArgs e )
        {
            string key = String.Format( "QQ{0}", seq );
            source.Add( new ComboData( key, String.Format( "Var QQ {0}", seq++ ) ) );
            // Delegate del = Delegate( IComboItem 
            e.IndexOfNewItem = source.FindIndex( it => it.Abrev == key ); // (x => x.Abrev == key) );
            e.Reload = true;
        }

        private List<WhereFieldDescriptor> qfd = new List<WhereFieldDescriptor>();

        private void buildQfd()
        { 
            qfd.Add( WhereFieldFactory.WhereField( "Var", "Variedad", "Variety", new Wrapper( "-", null, true), false ) );
            qfd.Add( WhereFieldFactory.WhereField( "Sel", "Selección", "Grase", new Wrapper( "-", null ), false ) );
            qfd.Add( WhereFieldFactory.WhereField( "Env", "Envase", "BoxType", new Wrapper( "-", null, true ), false ) );
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class BindingTest
    {
        public string Name { get; set; }
        public DateTime BDate { get; set; }
        public Int64? Cuil { get; set; }
        public ComboData ComboItem { get; set; }

        public BindingTest( string n, DateTime bd, Int64? cuil )
        {
            Name = n;
            BDate = bd;
            Cuil = cuil;
        }
    }

    public class ComboData : IComboItem
    {
        public string Abrev { get; set; }
        public string FullName { get; set; }
        public string ComboDisplay
        {
            get { return String.Format( "{0} ({1})", Abrev, FullName ); } 
        }

        public ComboData( string ab, string fn )
        {
            Abrev = ab;
            FullName = fn;
        }
    }
}
