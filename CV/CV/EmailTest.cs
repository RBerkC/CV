using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CV
{
    public class EmailTest
    {
        private void WebUrl_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var label = sender as Label;

            string url = "http://" + label.Text;

            var address = "merk68b@gmail.com";
            Device.OpenUri(new Uri($"mailto:{address}"));
        }
    }
}
