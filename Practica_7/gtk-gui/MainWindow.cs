
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Label label1;
	private global::Gtk.Label label2;
	private global::Gtk.ComboBox combobox1;
	private global::Gtk.Label label4;
	private global::Gtk.Entry entry1;
	private global::Gtk.Entry entry2;
	private global::Gtk.Label label5;
	private global::Gtk.Label label6;
	private global::Gtk.RadioButton radiobutton1;
	private global::Gtk.Label label7;
	private global::Gtk.Label label8;
	private global::Gtk.RadioButton radiobutton2;
	private global::Gtk.RadioButton radiobutton3;
	private global::Gtk.Label label9;
	private global::Gtk.RadioButton radiobutton4;
	private global::Gtk.Label label10;
	private global::Gtk.SpinButton spinbutton1;
	private global::Gtk.Label label11;
	private global::Gtk.CheckButton checkbutton1;
	private global::Gtk.Label label12;
	private global::Gtk.Calendar calendar1;
	private global::Gtk.CheckButton checkbutton2;
	private global::Gtk.CheckButton checkbutton3;
	private global::Gtk.CheckButton checkbutton4;
	private global::Gtk.Button button2;
	private global::Gtk.Entry calificacion;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Nombre");
		this.fixed1.Add (this.label1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
		w1.X = 9;
		w1.Y = 11;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Codigo");
		this.fixed1.Add (this.label2);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label2]));
		w2.X = 9;
		w2.Y = 41;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.combobox1 = global::Gtk.ComboBox.NewText ();
		this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("A"));
		this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("B"));
		this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("C"));
		this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("D"));
		this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("E"));
		this.combobox1.Name = "combobox1";
		this.fixed1.Add (this.combobox1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.combobox1]));
		w3.X = 448;
		w3.Y = 16;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Grupo");
		this.fixed1.Add (this.label4);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label4]));
		w4.X = 406;
		w4.Y = 21;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.fixed1.Add (this.entry1);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry1]));
		w5.X = 67;
		w5.Y = 4;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '●';
		this.fixed1.Add (this.entry2);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry2]));
		w6.X = 67;
		w6.Y = 36;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("1-. ¿ EN QUE AÑO DEBUTO SUPER JUNIOR?");
		this.fixed1.Add (this.label5);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label5]));
		w7.X = 37;
		w7.Y = 86;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("A)");
		this.fixed1.Add (this.label6);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label6]));
		w8.X = 36;
		w8.Y = 111;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radiobutton1 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("2003"));
		this.radiobutton1.CanFocus = true;
		this.radiobutton1.Name = "radiobutton1";
		this.radiobutton1.DrawIndicator = true;
		this.radiobutton1.UseUnderline = true;
		this.radiobutton1.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.fixed1.Add (this.radiobutton1);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.radiobutton1]));
		w9.X = 52;
		w9.Y = 110;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("B)");
		this.fixed1.Add (this.label7);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label7]));
		w10.X = 121;
		w10.Y = 111;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("C)");
		this.fixed1.Add (this.label8);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label8]));
		w11.X = 206;
		w11.Y = 111;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radiobutton2 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("2005"));
		this.radiobutton2.CanFocus = true;
		this.radiobutton2.Name = "radiobutton2";
		this.radiobutton2.DrawIndicator = true;
		this.radiobutton2.UseUnderline = true;
		this.radiobutton2.Group = this.radiobutton1.Group;
		this.fixed1.Add (this.radiobutton2);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.radiobutton2]));
		w12.X = 134;
		w12.Y = 110;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radiobutton3 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("2009"));
		this.radiobutton3.CanFocus = true;
		this.radiobutton3.Name = "radiobutton3";
		this.radiobutton3.DrawIndicator = true;
		this.radiobutton3.UseUnderline = true;
		this.radiobutton3.Group = this.radiobutton1.Group;
		this.fixed1.Add (this.radiobutton3);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.radiobutton3]));
		w13.X = 221;
		w13.Y = 110;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("D)");
		this.fixed1.Add (this.label9);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label9]));
		w14.X = 289;
		w14.Y = 110;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radiobutton4 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("2007"));
		this.radiobutton4.CanFocus = true;
		this.radiobutton4.Name = "radiobutton4";
		this.radiobutton4.DrawIndicator = true;
		this.radiobutton4.UseUnderline = true;
		this.radiobutton4.Group = this.radiobutton1.Group;
		this.fixed1.Add (this.radiobutton4);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.radiobutton4]));
		w15.X = 304;
		w15.Y = 109;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label10 = new global::Gtk.Label ();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("2-.¿ CUANTOS ES 2+2?");
		this.fixed1.Add (this.label10);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label10]));
		w16.X = 39;
		w16.Y = 139;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.spinbutton1 = new global::Gtk.SpinButton (0D, 100D, 1D);
		this.spinbutton1.CanFocus = true;
		this.spinbutton1.Name = "spinbutton1";
		this.spinbutton1.Adjustment.PageIncrement = 10D;
		this.spinbutton1.ClimbRate = 1D;
		this.spinbutton1.Numeric = true;
		this.fixed1.Add (this.spinbutton1);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.spinbutton1]));
		w17.X = 45;
		w17.Y = 162;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label11 = new global::Gtk.Label ();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("3-. ¿ QUE ACTORES SALDRAN EN EL NUEVO  DORAMA THE HEIRS?");
		this.fixed1.Add (this.label11);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label11]));
		w18.X = 40;
		w18.Y = 195;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton1 = new global::Gtk.CheckButton ();
		this.checkbutton1.CanFocus = true;
		this.checkbutton1.Name = "checkbutton1";
		this.checkbutton1.Label = global::Mono.Unix.Catalog.GetString ("LEE MIN HO");
		this.checkbutton1.DrawIndicator = true;
		this.checkbutton1.UseUnderline = true;
		this.fixed1.Add (this.checkbutton1);
		global::Gtk.Fixed.FixedChild w19 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.checkbutton1]));
		w19.X = 43;
		w19.Y = 217;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label12 = new global::Gtk.Label ();
		this.label12.Name = "label12";
		this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("4-.¿CUAL ES LA FECHA DE NACIMIENTO DE KIM HYUNG JOONG?");
		this.fixed1.Add (this.label12);
		global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label12]));
		w20.X = 38;
		w20.Y = 239;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.calendar1 = new global::Gtk.Calendar ();
		this.calendar1.CanFocus = true;
		this.calendar1.Name = "calendar1";
		this.calendar1.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.fixed1.Add (this.calendar1);
		global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.calendar1]));
		w21.X = 113;
		w21.Y = 260;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton2 = new global::Gtk.CheckButton ();
		this.checkbutton2.CanFocus = true;
		this.checkbutton2.Name = "checkbutton2";
		this.checkbutton2.Label = global::Mono.Unix.Catalog.GetString ("YOUNG JOONG HWA");
		this.checkbutton2.DrawIndicator = true;
		this.checkbutton2.UseUnderline = true;
		this.fixed1.Add (this.checkbutton2);
		global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.checkbutton2]));
		w22.X = 133;
		w22.Y = 216;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton3 = new global::Gtk.CheckButton ();
		this.checkbutton3.CanFocus = true;
		this.checkbutton3.Name = "checkbutton3";
		this.checkbutton3.Label = global::Mono.Unix.Catalog.GetString ("PARK SHIN HYE");
		this.checkbutton3.DrawIndicator = true;
		this.checkbutton3.UseUnderline = true;
		this.fixed1.Add (this.checkbutton3);
		global::Gtk.Fixed.FixedChild w23 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.checkbutton3]));
		w23.X = 271;
		w23.Y = 214;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton4 = new global::Gtk.CheckButton ();
		this.checkbutton4.CanFocus = true;
		this.checkbutton4.Name = "checkbutton4";
		this.checkbutton4.Label = global::Mono.Unix.Catalog.GetString ("CHOI MIN HO");
		this.checkbutton4.DrawIndicator = true;
		this.checkbutton4.UseUnderline = true;
		this.fixed1.Add (this.checkbutton4);
		global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.checkbutton4]));
		w24.X = 385;
		w24.Y = 214;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button2 = new global::Gtk.Button ();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("TERMINAR");
		this.fixed1.Add (this.button2);
		global::Gtk.Fixed.FixedChild w25 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button2]));
		w25.X = 346;
		w25.Y = 438;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.calificacion = new global::Gtk.Entry ();
		this.calificacion.CanFocus = true;
		this.calificacion.Name = "calificacion";
		this.calificacion.IsEditable = true;
		this.calificacion.InvisibleChar = '●';
		this.fixed1.Add (this.calificacion);
		global::Gtk.Fixed.FixedChild w26 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.calificacion]));
		w26.X = 423;
		w26.Y = 438;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 605;
		this.DefaultHeight = 524;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
	}
}
