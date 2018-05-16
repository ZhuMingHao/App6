
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
           // CrossFilePicker.Current.PickFile
           
        }

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            var file = DependencyService.Get<IFileAccess>().GetFileStreamFormPath(@"C:\logdata.dat");
        }
    }
}
