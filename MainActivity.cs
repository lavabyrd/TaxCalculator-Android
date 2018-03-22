using Android.App;
using Android.Widget;
using Android.OS;

namespace Marksapp
{
    [Activity(Label = "My Tax Calculator", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        
        private Button btn1;
        private Button btn2;
        private TextView txtview;
        private EditText eview;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            btn1 = FindViewById<Button>(Resource.Id.button1);
            btn2 = FindViewById<Button>(Resource.Id.button2);
            txtview = FindViewById<TextView>(Resource.Id.txtviewOutput);
            eview = FindViewById<EditText>(Resource.Id.editText1);

            btn1.Click += (o, e) => {
                try
                {
                    txtview.Text = taxCheck(float.Parse(eview.Text)).ToString();

                }
                catch (System.Exception)
                {
                    Toast.MakeText(this, "Invalid value", ToastLength.Short).Show();
                }
            };
            btn2.Click += (o, e) => {
                txtview.Text = reset();
                eview.Text = reset();
            };
        }

        private float taxCheck(float inp) {

            float outp;
            outp = inp / 100 * 123;
            return outp;
        }
        private string reset() {
            return "";
        }

    }
}

