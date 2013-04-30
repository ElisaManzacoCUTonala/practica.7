using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton2Clicked (object sender, EventArgs e)
	{

		int Puntos = 0; 
		if(this.2005.Active)
			Puntos++;
			     
		
		f (this.Suma.Text == "4")
			Puntos++;
		         
		
		
		if(this.LEEMINHO.Active && this.PARKSHINYE.Active)
			Puntos++;
	           
		
		DateTime fecha = this.calendario.GetDate();
		string fechaseleccionada = fecha.ToShortDateString();
		if(fechaseleccionada == "6/06/1986")
			Puntos++;
		this.entry3calificacion.Text=Puntos.ToString();
		
		



	}
}
