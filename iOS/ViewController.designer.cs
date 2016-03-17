// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton _send { get; set; }

		[Outlet]
		UIKit.UITextField _textField { get; set; }

		[Outlet]
		UIKit.UITextView _textView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (_textView != null) {
				_textView.Dispose ();
				_textView = null;
			}

			if (_textField != null) {
				_textField.Dispose ();
				_textField = null;
			}

			if (_send != null) {
				_send.Dispose ();
				_send = null;
			}
		}
	}
}
