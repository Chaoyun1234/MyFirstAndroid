using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace HelloAndroid
{
    [Activity(Label = "HelloAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 0;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // 加载布局
            SetContentView(Resource.Layout.Main);
            // 获取布局中的控件
            Button say = FindViewById<Button>(Resource.Id.sayHello);
            TextView show = FindViewById<TextView>(Resource.Id.showHello);
            // 绑定 Click 事件
            say.Click += (sender, e) =>
            {
                count++;
                show.Text = "Hello, Android";
                say.Text = $"You Clicked {count}";
                // Toast 通知
                Toast.MakeText(this, $"You Clicked {count}", ToastLength.Short).Show();
            };


           MobileCenter.Start("667f0dc5-7c80-4a31-a851-78c2fc4abd93",
                    typeof(Analytics), typeof(Crashes));
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

