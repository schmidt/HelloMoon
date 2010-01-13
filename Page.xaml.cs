/*
 * Based on the work of Michael Hutchinson
 * http://mjhutchinson.com/journal/2009/05/07/moonlight_development_mac_using_monodevelop
 */
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HelloMoon
{


	public partial class Page : UserControl
	{

		public Page ()
		{
			this.InitializeComponent ();
			
			block.MouseEnter += delegate {
				block.Foreground = new SolidColorBrush (Colors.Red);
			};

			block.MouseLeave += delegate {
				block.Foreground = new SolidColorBrush (Colors.Green);
			};

		}
	}
}
