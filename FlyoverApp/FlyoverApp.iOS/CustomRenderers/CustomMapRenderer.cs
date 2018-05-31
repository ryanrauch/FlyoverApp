using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreLocation;
using FlyoverApp.Controls;
using FlyoverApp.iOS.Camera;
using FlyoverApp.iOS.CustomRenderers;
using FlyoverApp.iOS.Extensions;
using FlyoverApp.iOS.MapView;
using Foundation;
using MapKit;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Maps.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomMap), typeof(CustomMapRenderer))]
namespace FlyoverApp.iOS.CustomRenderers
{
    public class CustomMapRenderer : MapRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if(e.OldElement != null)
            {
                var nativeMap = Control as MKMapView;
            }

            if(e.NewElement != null)
            {
                var formsMap = (CustomMap)e.NewElement;
                var nativeMap = Control as MKMapView;

                FlyoverMapView flyoverMapView = new FlyoverMapView(MKMapType.Satellite, 
                                                                   new FlyoverCameraConfiguration(FlyoverCameraConfigurationTheme.Default));
                SetNativeControl(flyoverMapView);
                flyoverMapView.Start(new Flyover(FlyoverAwesomePlace.NewYorkStatueOfLiberty.GetCoordinates()));
            }
        }
    }
}