namespace KeyboardEnabledControlsTest
{
    partial class MainForm
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
            this.kTextBox1 = new KeyboardEnabledControls.KTextBox();
            this.kTextBox2 = new KeyboardEnabledControls.KTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kTextBox7 = new KeyboardEnabledControls.KTextBox();
            this.kTextBox6 = new KeyboardEnabledControls.KTextBox();
            this.textControl1 = new KeyboardEnabledControls.TextControl();
            this.kButton1 = new System.Windows.Forms.Button();
            this.kButton2 = new System.Windows.Forms.Button();
            this.kButton3 = new System.Windows.Forms.Button();
            this.numericControl1 = new KeyboardEnabledControls.NumericControl();
            this.dateControl1 = new KeyboardEnabledControls.DateControl();
            this.nullableDateControl1 = new KeyboardEnabledControls.NullableDateControl();
            this.maskedControl1 = new KeyboardEnabledControls.MaskedControl();
            this.nullableIntegerMaskedControl1 = new KeyboardEnabledControls.NullableInt32MaskedControl();
            this.nullableInt64MaskedControl1 = new KeyboardEnabledControls.NullableInt64MaskedControl();
            this.queryFieldListControl1 = new KeyboardEnabledControls.QueryFieldListControl();
            this.comboControl1 = new KeyboardEnabledControls.ComboControl();
            this.decimalControl1 = new KeyboardEnabledControls.DecimalControl();
            this.textControl3 = new KeyboardEnabledControls.TextControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kTextBox1
            // 
            this.kTextBox1.Active = true;
            this.kTextBox1.Location = new System.Drawing.Point(8, 54);
            this.kTextBox1.Name = "kTextBox1";
            this.kTextBox1.Size = new System.Drawing.Size(100, 20);
            this.kTextBox1.TabIndex = 6;
            // 
            // kTextBox2
            // 
            this.kTextBox2.Active = true;
            this.kTextBox2.Location = new System.Drawing.Point(8, 93);
            this.kTextBox2.Name = "kTextBox2";
            this.kTextBox2.Size = new System.Drawing.Size(100, 20);
            this.kTextBox2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kTextBox7);
            this.panel1.Controls.Add(this.kTextBox6);
            this.panel1.Location = new System.Drawing.Point(235, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 11;
            // 
            // kTextBox7
            // 
            this.kTextBox7.Active = true;
            this.kTextBox7.Location = new System.Drawing.Point(50, 50);
            this.kTextBox7.Name = "kTextBox7";
            this.kTextBox7.Size = new System.Drawing.Size(100, 20);
            this.kTextBox7.TabIndex = 12;
            // 
            // kTextBox6
            // 
            this.kTextBox6.Active = true;
            this.kTextBox6.Location = new System.Drawing.Point(50, 18);
            this.kTextBox6.Name = "kTextBox6";
            this.kTextBox6.Size = new System.Drawing.Size(100, 20);
            this.kTextBox6.TabIndex = 11;
            // 
            // textControl1
            // 
            this.textControl1.Active = true;
            this.textControl1.CursorColor = System.Drawing.Color.Blue;
            this.textControl1.DefaultText = ".";
            this.textControl1.Designing = false;
            this.textControl1.DestinationProperty = null;
            this.textControl1.LabelColor = System.Drawing.Color.Black;
            this.textControl1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textControl1.LabelOffset = 5;
            this.textControl1.LabelText = "Acá";
            this.textControl1.Location = new System.Drawing.Point(285, 13);
            this.textControl1.Name = "textControl1";
            this.textControl1.NullCommandKey = System.Windows.Forms.Keys.Home;
            this.textControl1.NullString = "~";
            this.textControl1.OptCommandKey1 = System.Windows.Forms.Keys.None;
            this.textControl1.OptCommandKey2 = System.Windows.Forms.Keys.None;
            this.textControl1.OptCommandKey3 = System.Windows.Forms.Keys.None;
            this.textControl1.RectangleColor = System.Drawing.Color.Black;
            this.textControl1.Size = new System.Drawing.Size(126, 20);
            this.textControl1.SourceProperty = null;
            this.textControl1.SourcePropertyName = "Name";
            this.textControl1.SourceTypeFullName = null;
            this.textControl1.TabIndex = 12;
            this.textControl1.Text = "TE";
            this.textControl1.TextValue = "TE";
            this.textControl1.ToLower = false;
            this.textControl1.TotalPlaces = 30;
            this.textControl1.ToUpper = false;
            this.textControl1.ValidCharacters = "[A-Z]|[a-z]|[0-9]|_|\\.|,|-|+";
            // 
            // kButton1
            // 
            this.kButton1.Location = new System.Drawing.Point(131, 68);
            this.kButton1.Name = "kButton1";
            this.kButton1.Size = new System.Drawing.Size(75, 23);
            this.kButton1.TabIndex = 20;
            this.kButton1.Text = "button1";
            this.kButton1.UseVisualStyleBackColor = true;
            this.kButton1.Click += new System.EventHandler(this.kButton1_Click);
            // 
            // kButton2
            // 
            this.kButton2.Location = new System.Drawing.Point(131, 118);
            this.kButton2.Name = "kButton2";
            this.kButton2.Size = new System.Drawing.Size(75, 23);
            this.kButton2.TabIndex = 21;
            this.kButton2.Text = "button1";
            this.kButton2.UseVisualStyleBackColor = true;
            this.kButton2.Click += new System.EventHandler(this.kButton2_Click);
            // 
            // kButton3
            // 
            this.kButton3.Location = new System.Drawing.Point(131, 168);
            this.kButton3.Name = "kButton3";
            this.kButton3.Size = new System.Drawing.Size(75, 23);
            this.kButton3.TabIndex = 22;
            this.kButton3.Text = "button1";
            this.kButton3.UseVisualStyleBackColor = true;
            this.kButton3.Click += new System.EventHandler(this.kButton3_Click);
            // 
            // numericControl1
            // 
            this.numericControl1.Active = true;
            this.numericControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericControl1.CursorColor = System.Drawing.Color.Blue;
            this.numericControl1.DecimalPlaces = 0;
            this.numericControl1.DefaultText = ".";
            this.numericControl1.DestinationProperty = null;
            this.numericControl1.IntegerPlaces = 7;
            this.numericControl1.LabelColor = System.Drawing.Color.Black;
            this.numericControl1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericControl1.LabelOffset = 5;
            this.numericControl1.LabelText = "";
            this.numericControl1.Location = new System.Drawing.Point(13, 172);
            this.numericControl1.Mask = "";
            this.numericControl1.Name = "numericControl1";
            this.numericControl1.NullCommandKey = System.Windows.Forms.Keys.Home;
            this.numericControl1.NullString = "~";
            this.numericControl1.OptCommandKey1 = System.Windows.Forms.Keys.None;
            this.numericControl1.OptCommandKey2 = System.Windows.Forms.Keys.None;
            this.numericControl1.OptCommandKey3 = System.Windows.Forms.Keys.None;
            this.numericControl1.RectangleColor = System.Drawing.Color.Black;
            this.numericControl1.Signed = false;
            this.numericControl1.Size = new System.Drawing.Size(100, 20);
            this.numericControl1.SourceProperty = null;
            this.numericControl1.SourcePropertyName = null;
            this.numericControl1.SourceTypeFullName = null;
            this.numericControl1.TabIndex = 24;
            this.numericControl1.Text = "0";
            this.numericControl1.TextValue = "0";
            this.numericControl1.ToLower = false;
            this.numericControl1.TotalPlaces = 2147483647;
            this.numericControl1.ToUpper = false;
            this.numericControl1.ValidCharacters = "[0-9]|[ .,+\\-]";
            // 
            // dateControl1
            // 
            this.dateControl1.Active = true;
            this.dateControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateControl1.CursorColor = System.Drawing.Color.Blue;
            this.dateControl1.DateValue = new System.DateTime(2014, 8, 7, 0, 0, 0, 0);
            this.dateControl1.DefaultText = ".";
            this.dateControl1.DestinationProperty = null;
            this.dateControl1.Format = KeyboardEnabledControls.DateFormat.YMD;
            this.dateControl1.LabelColor = System.Drawing.Color.Black;
            this.dateControl1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateControl1.LabelOffset = 5;
            this.dateControl1.LabelText = "";
            this.dateControl1.Location = new System.Drawing.Point(13, 120);
            this.dateControl1.Name = "dateControl1";
            this.dateControl1.NullCommandKey = System.Windows.Forms.Keys.Home;
            this.dateControl1.NullString = "~";
            this.dateControl1.OptCommandKey1 = System.Windows.Forms.Keys.None;
            this.dateControl1.OptCommandKey2 = System.Windows.Forms.Keys.None;
            this.dateControl1.OptCommandKey3 = System.Windows.Forms.Keys.None;
            this.dateControl1.RectangleColor = System.Drawing.Color.Black;
            this.dateControl1.Size = new System.Drawing.Size(75, 20);
            this.dateControl1.SourceProperty = null;
            this.dateControl1.SourcePropertyName = "BDate";
            this.dateControl1.SourceTypeFullName = null;
            this.dateControl1.TabIndex = 27;
            this.dateControl1.Text = "2014-08-07";
            this.dateControl1.ToLower = false;
            this.dateControl1.TotalPlaces = 10;
            this.dateControl1.ToUpper = false;
            this.dateControl1.ValidCharacters = "[0-9]";
            // 
            // nullableDateControl1
            // 
            this.nullableDateControl1.Active = true;
            this.nullableDateControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nullableDateControl1.CursorColor = System.Drawing.Color.Blue;
            this.nullableDateControl1.DateValue = new System.DateTime(2016, 8, 1, 0, 0, 0, 0);
            this.nullableDateControl1.DefaultText = ".";
            this.nullableDateControl1.DestinationProperty = null;
            this.nullableDateControl1.Format = KeyboardEnabledControls.DateFormat.YMD;
            this.nullableDateControl1.LabelColor = System.Drawing.Color.Black;
            this.nullableDateControl1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nullableDateControl1.LabelOffset = 5;
            this.nullableDateControl1.LabelText = "";
            this.nullableDateControl1.Location = new System.Drawing.Point(13, 146);
            this.nullableDateControl1.Name = "nullableDateControl1";
            this.nullableDateControl1.NilDateValue = new System.DateTime(2016, 8, 1, 0, 0, 0, 0);
            this.nullableDateControl1.NullCommandKey = System.Windows.Forms.Keys.Home;
            this.nullableDateControl1.NullString = "~";
            this.nullableDateControl1.OptCommandKey1 = System.Windows.Forms.Keys.None;
            this.nullableDateControl1.OptCommandKey2 = System.Windows.Forms.Keys.None;
            this.nullableDateControl1.OptCommandKey3 = System.Windows.Forms.Keys.None;
            this.nullableDateControl1.RectangleColor = System.Drawing.Color.Black;
            this.nullableDateControl1.Size = new System.Drawing.Size(75, 20);
            this.nullableDateControl1.SourceProperty = null;
            this.nullableDateControl1.SourcePropertyName = null;
            this.nullableDateControl1.SourceTypeFullName = null;
            this.nullableDateControl1.TabIndex = 31;
            this.nullableDateControl1.Text = "nullableDateControl1";
            this.nullableDateControl1.ToLower = false;
            this.nullableDateControl1.TotalPlaces = 10;
            this.nullableDateControl1.ToUpper = false;
            this.nullableDateControl1.ValidCharacters = "[0-9]";
            // 
            // maskedControl1
            // 
            this.maskedControl1.Active = true;
            this.maskedControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maskedControl1.CursorColor = System.Drawing.Color.Blue;
            this.maskedControl1.DefaultText = ".";
            this.maskedControl1.DestinationProperty = null;
            this.maskedControl1.LabelColor = System.Drawing.Color.Black;
            this.maskedControl1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedControl1.LabelOffset = 5;
            this.maskedControl1.LabelText = "";
            this.maskedControl1.Location = new System.Drawing.Point(285, 188);
            this.maskedControl1.Mask = "##-##/##.##";
            this.maskedControl1.MaskedValue = "maskedControl1";
            this.maskedControl1.Name = "maskedControl1";
            this.maskedControl1.NullCommandKey = System.Windows.Forms.Keys.Home;
            this.maskedControl1.NullString = "~";
            this.maskedControl1.OptCommandKey1 = System.Windows.Forms.Keys.None;
            this.maskedControl1.OptCommandKey2 = System.Windows.Forms.Keys.None;
            this.maskedControl1.OptCommandKey3 = System.Windows.Forms.Keys.None;
            this.maskedControl1.RectangleColor = System.Drawing.Color.Black;
            this.maskedControl1.Size = new System.Drawing.Size(100, 20);
            this.maskedControl1.SourceProperty = null;
            this.maskedControl1.SourcePropertyName = null;
            this.maskedControl1.SourceTypeFullName = null;
            this.maskedControl1.TabIndex = 36;
            this.maskedControl1.Text = "maskedControl1";
            this.maskedControl1.ToLower = false;
            this.maskedControl1.TotalPlaces = 2147483647;
            this.maskedControl1.ToUpper = false;
            this.maskedControl1.ValidCharacters = "[A-Z]|[a-z]|[0-9]|[\\[\\]\\(\\)]|[ Ññáéíóú_.,:;+\\-]";
            // 
            // nullableIntegerMaskedControl1
            // 
            this.nullableIntegerMaskedControl1.Active = true;
            this.nullableIntegerMaskedControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nullableIntegerMaskedControl1.CursorColor = System.Drawing.Color.Blue;
            this.nullableIntegerMaskedControl1.DefaultText = ".";
            this.nullableIntegerMaskedControl1.DestinationProperty = null;
            this.nullableIntegerMaskedControl1.Int32MValue = 0;
            this.nullableIntegerMaskedControl1.LabelColor = System.Drawing.Color.Black;
            this.nullableIntegerMaskedControl1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nullableIntegerMaskedControl1.LabelOffset = 5;
            this.nullableIntegerMaskedControl1.LabelText = "";
            this.nullableIntegerMaskedControl1.Location = new System.Drawing.Point(285, 242);
            this.nullableIntegerMaskedControl1.Mask = "##-##/##.##";
            this.nullableIntegerMaskedControl1.MaskedValue = "nullableIntegerMaskedControl1";
            this.nullableIntegerMaskedControl1.Name = "nullableIntegerMaskedControl1";
            this.nullableIntegerMaskedControl1.NilInt32MValue = null;
            this.nullableIntegerMaskedControl1.NullCommandKey = System.Windows.Forms.Keys.Home;
            this.nullableIntegerMaskedControl1.NullString = "~";
            this.nullableIntegerMaskedControl1.OptCommandKey1 = System.Windows.Forms.Keys.None;
            this.nullableIntegerMaskedControl1.OptCommandKey2 = System.Windows.Forms.Keys.None;
            this.nullableIntegerMaskedControl1.OptCommandKey3 = System.Windows.Forms.Keys.None;
            this.nullableIntegerMaskedControl1.RectangleColor = System.Drawing.Color.Black;
            this.nullableIntegerMaskedControl1.Size = new System.Drawing.Size(100, 20);
            this.nullableIntegerMaskedControl1.SourceProperty = null;
            this.nullableIntegerMaskedControl1.SourcePropertyName = null;
            this.nullableIntegerMaskedControl1.SourceTypeFullName = null;
            this.nullableIntegerMaskedControl1.TabIndex = 49;
            this.nullableIntegerMaskedControl1.Text = "nullableIntegerMaskedControl1";
            this.nullableIntegerMaskedControl1.ToLower = false;
            this.nullableIntegerMaskedControl1.TotalPlaces = 2147483647;
            this.nullableIntegerMaskedControl1.ToUpper = false;
            this.nullableIntegerMaskedControl1.ValidCharacters = "[A-Z]|[a-z]|[0-9]|[\\[\\]\\(\\)]|[ Ññáéíóú_.,:;+\\-]";
            // 
            // nullableInt64MaskedControl1
            // 
            this.nullableInt64MaskedControl1.Active = true;
            this.nullableInt64MaskedControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nullableInt64MaskedControl1.CursorColor = System.Drawing.Color.Blue;
            this.nullableInt64MaskedControl1.DefaultText = ".";
            this.nullableInt64MaskedControl1.DestinationProperty = null;
            this.nullableInt64MaskedControl1.Int64MValue = ((long)(0));
            this.nullableInt64MaskedControl1.LabelColor = System.Drawing.Color.Black;
            this.nullableInt64MaskedControl1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nullableInt64MaskedControl1.LabelOffset = 5;
            this.nullableInt64MaskedControl1.LabelText = "";
            this.nullableInt64MaskedControl1.Location = new System.Drawing.Point(285, 215);
            this.nullableInt64MaskedControl1.Mask = "##-####.####.#";
            this.nullableInt64MaskedControl1.MaskedValue = "nullableInt64MaskedControl1";
            this.nullableInt64MaskedControl1.Name = "nullableInt64MaskedControl1";
            this.nullableInt64MaskedControl1.NilInt64MValue = null;
            this.nullableInt64MaskedControl1.NullCommandKey = System.Windows.Forms.Keys.Home;
            this.nullableInt64MaskedControl1.NullString = "~";
            this.nullableInt64MaskedControl1.OptCommandKey1 = System.Windows.Forms.Keys.None;
            this.nullableInt64MaskedControl1.OptCommandKey2 = System.Windows.Forms.Keys.None;
            this.nullableInt64MaskedControl1.OptCommandKey3 = System.Windows.Forms.Keys.None;
            this.nullableInt64MaskedControl1.RectangleColor = System.Drawing.Color.Black;
            this.nullableInt64MaskedControl1.Size = new System.Drawing.Size(100, 20);
            this.nullableInt64MaskedControl1.SourceProperty = null;
            this.nullableInt64MaskedControl1.SourcePropertyName = "Cuil";
            this.nullableInt64MaskedControl1.SourceTypeFullName = null;
            this.nullableInt64MaskedControl1.TabIndex = 57;
            this.nullableInt64MaskedControl1.Text = "nullableInt64MaskedControl1";
            this.nullableInt64MaskedControl1.ToLower = false;
            this.nullableInt64MaskedControl1.TotalPlaces = 2147483647;
            this.nullableInt64MaskedControl1.ToUpper = false;
            this.nullableInt64MaskedControl1.ValidCharacters = "[A-Z]|[a-z]|[0-9]|[\\[\\]\\(\\)]|[ Ññáéíóú_.,:;+\\-]";
            // 
            // queryFieldListControl1
            // 
            this.queryFieldListControl1.Active = true;
            this.queryFieldListControl1.FormattingEnabled = true;
            this.queryFieldListControl1.Location = new System.Drawing.Point(13, 247);
            this.queryFieldListControl1.Name = "queryFieldListControl1";
            this.queryFieldListControl1.QueryFieldList = null;
            this.queryFieldListControl1.Size = new System.Drawing.Size(119, 69);
            this.queryFieldListControl1.TabIndex = 65;
            // 
            // comboControl1
            // 
            this.comboControl1.Active = true;
            this.comboControl1.CursorColor = System.Drawing.Color.Blue;
            this.comboControl1.DataSource = null;
            this.comboControl1.DefaultText = ".";
            this.comboControl1.DestinationProperty = null;
            this.comboControl1.DropDownHeight = 0;
            this.comboControl1.DropDownWidth = 0;
            this.comboControl1.EnableNewItem = true;
            this.comboControl1.LabelColor = System.Drawing.Color.Black;
            this.comboControl1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboControl1.LabelOffset = 5;
            this.comboControl1.LabelText = "";
            this.comboControl1.Location = new System.Drawing.Point(131, 215);
            this.comboControl1.Name = "comboControl1";
            this.comboControl1.NewItemListItem = "<nuevo>";
            this.comboControl1.Nullable = false;
            this.comboControl1.NullString = "~";
            this.comboControl1.RectangleColor = System.Drawing.Color.Black;
            this.comboControl1.SelectedItem = null;
            this.comboControl1.SelectedValue = "t";
            this.comboControl1.Size = new System.Drawing.Size(126, 24);
            this.comboControl1.SourceProperty = null;
            this.comboControl1.SourcePropertyName = null;
            this.comboControl1.SourceTypeFullName = null;
            this.comboControl1.TabIndex = 83;
            this.comboControl1.ToLower = false;
            this.comboControl1.ToUpper = false;
            // 
            // decimalControl1
            // 
            this.decimalControl1.Active = true;
            this.decimalControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.decimalControl1.CursorColor = System.Drawing.Color.Blue;
            this.decimalControl1.DecimalPlaces = 0;
            this.decimalControl1.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.decimalControl1.DefaultText = ".";
            this.decimalControl1.DestinationProperty = null;
            this.decimalControl1.IntegerPlaces = 7;
            this.decimalControl1.LabelColor = System.Drawing.Color.Black;
            this.decimalControl1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalControl1.LabelOffset = 5;
            this.decimalControl1.LabelText = "";
            this.decimalControl1.Location = new System.Drawing.Point(105, 13);
            this.decimalControl1.Mask = "";
            this.decimalControl1.Name = "decimalControl1";
            this.decimalControl1.NullCommandKey = System.Windows.Forms.Keys.Home;
            this.decimalControl1.NullString = "~";
            this.decimalControl1.OptCommandKey1 = System.Windows.Forms.Keys.None;
            this.decimalControl1.OptCommandKey2 = System.Windows.Forms.Keys.None;
            this.decimalControl1.OptCommandKey3 = System.Windows.Forms.Keys.None;
            this.decimalControl1.RectangleColor = System.Drawing.Color.Black;
            this.decimalControl1.Signed = false;
            this.decimalControl1.Size = new System.Drawing.Size(100, 20);
            this.decimalControl1.SourceProperty = null;
            this.decimalControl1.SourcePropertyName = null;
            this.decimalControl1.SourceTypeFullName = null;
            this.decimalControl1.TabIndex = 92;
            this.decimalControl1.Text = "decimalControl1";
            this.decimalControl1.TextValue = "decimalControl1";
            this.decimalControl1.ToLower = false;
            this.decimalControl1.TotalPlaces = 2147483647;
            this.decimalControl1.ToUpper = false;
            this.decimalControl1.ValidCharacters = "[0-9]|[ .,+\\-]";
            // 
            // textControl3
            // 
            this.textControl3.Active = true;
            this.textControl3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textControl3.CursorColor = System.Drawing.Color.Blue;
            this.textControl3.DefaultText = ".";
            this.textControl3.Designing = false;
            this.textControl3.DestinationProperty = null;
            this.textControl3.LabelColor = System.Drawing.Color.Black;
            this.textControl3.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textControl3.LabelOffset = 5;
            this.textControl3.LabelText = "";
            this.textControl3.Location = new System.Drawing.Point(285, 40);
            this.textControl3.Name = "textControl3";
            this.textControl3.NullCommandKey = System.Windows.Forms.Keys.Home;
            this.textControl3.NullString = "~";
            this.textControl3.OptCommandKey1 = System.Windows.Forms.Keys.None;
            this.textControl3.OptCommandKey2 = System.Windows.Forms.Keys.None;
            this.textControl3.OptCommandKey3 = System.Windows.Forms.Keys.None;
            this.textControl3.RectangleColor = System.Drawing.Color.Black;
            this.textControl3.Size = new System.Drawing.Size(100, 20);
            this.textControl3.SourceProperty = null;
            this.textControl3.SourcePropertyName = null;
            this.textControl3.SourceTypeFullName = null;
            this.textControl3.TabIndex = 94;
            this.textControl3.Text = "textControl3";
            this.textControl3.TextValue = "textControl3";
            this.textControl3.ToLower = false;
            this.textControl3.TotalPlaces = 2147483647;
            this.textControl3.ToUpper = false;
            this.textControl3.ValidCharacters = "[A-Z]|[a-z]|[0-9]|[\\[\\]\\(\\)]|[ Ññáéíóú_.,:;+\\-]";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(440, 359);
            this.Controls.Add(this.textControl3);
            this.Controls.Add(this.decimalControl1);
            this.Controls.Add(this.comboControl1);
            this.Controls.Add(this.queryFieldListControl1);
            this.Controls.Add(this.nullableInt64MaskedControl1);
            this.Controls.Add(this.nullableIntegerMaskedControl1);
            this.Controls.Add(this.maskedControl1);
            this.Controls.Add(this.nullableDateControl1);
            this.Controls.Add(this.dateControl1);
            this.Controls.Add(this.numericControl1);
            this.Controls.Add(this.kButton3);
            this.Controls.Add(this.kButton2);
            this.Controls.Add(this.kButton1);
            this.Controls.Add(this.textControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kTextBox2);
            this.Controls.Add(this.kTextBox1);
            this.Name = "MainForm";
            this.StatusStripVisible = true;
            this.Text = "Testing Keyb Controls";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.kTextBox1, 0);
            this.Controls.SetChildIndex(this.kTextBox2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.textControl1, 0);
            this.Controls.SetChildIndex(this.kButton1, 0);
            this.Controls.SetChildIndex(this.kButton2, 0);
            this.Controls.SetChildIndex(this.kButton3, 0);
            this.Controls.SetChildIndex(this.numericControl1, 0);
            this.Controls.SetChildIndex(this.dateControl1, 0);
            this.Controls.SetChildIndex(this.nullableDateControl1, 0);
            this.Controls.SetChildIndex(this.maskedControl1, 0);
            this.Controls.SetChildIndex(this.nullableIntegerMaskedControl1, 0);
            this.Controls.SetChildIndex(this.nullableInt64MaskedControl1, 0);
            this.Controls.SetChildIndex(this.queryFieldListControl1, 0);
            this.Controls.SetChildIndex(this.comboControl1, 0);
            this.Controls.SetChildIndex(this.decimalControl1, 0);
            this.Controls.SetChildIndex(this.textControl3, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KeyboardEnabledControls.KTextBox kTextBox1;
        private KeyboardEnabledControls.KTextBox kTextBox2;
        private System.Windows.Forms.Panel panel1;
        private KeyboardEnabledControls.KTextBox kTextBox7;
        private KeyboardEnabledControls.KTextBox kTextBox6;
        private KeyboardEnabledControls.TextControl textControl1;
        private System.Windows.Forms.Button kButton1;
        private System.Windows.Forms.Button kButton2;
        private System.Windows.Forms.Button kButton3;
        private KeyboardEnabledControls.NumericControl numericControl1;
        private KeyboardEnabledControls.DateControl dateControl1;
        private KeyboardEnabledControls.NullableDateControl nullableDateControl1;
        private KeyboardEnabledControls.MaskedControl maskedControl1;
        private KeyboardEnabledControls.NullableInt32MaskedControl nullableIntegerMaskedControl1;
        private KeyboardEnabledControls.NullableInt64MaskedControl nullableInt64MaskedControl1;
        private KeyboardEnabledControls.QueryFieldListControl queryFieldListControl1;
        private KeyboardEnabledControls.ComboControl comboControl1;
        private KeyboardEnabledControls.DecimalControl decimalControl1;
        private KeyboardEnabledControls.TextControl textControl3;
    }
}
