﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MonoDroidXamlSample
{
    [Activity(Label = "My Activity", MainLauncher = true)]
    public class Activity1 : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.layout.main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.id.myButton);

            button.Click += delegate { 
                button.Text = string.Format("{0} clicks!", count++);
                try
                {
                    Android.Util.Log.D("MonoDroidXamlSample", System.Xaml.XamlServices.Save(this));
                }
                catch (Exception ex)
                {
                    Android.Util.Log.D("MonoDroidXamlSample", ex.ToString());
                }
            };
        }
    }
}

