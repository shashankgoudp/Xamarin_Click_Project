
using System;

using Foundation;
using UIKit;

namespace DemoOfXamarin
{
	public partial class MainViewController : UIViewController
	{
		public MainViewController () : base ("MainViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			MyButton.TouchUpInside += (object sender, EventArgs e) => {
			
				MyLabel.Text = "Clicked";
			}
				;
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

