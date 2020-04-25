using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace ListView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : ListActivity
    {
        static readonly string[] countries = new String[] {"Albania", "Belarus","Guam", "Democratic Republic of the Congo",
"Italy","Jamaica", "Japan","Russia", "United Arab Emirates","United Kingdom", "United States",
"Yugoslavia","Zambia","Zimbabwe"};
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.list_item, countries);
            ListView.TextFilterEnabled = true;
            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}