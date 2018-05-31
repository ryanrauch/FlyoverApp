using CoreLocation;
using MapKit;

namespace FlyoverApp.iOS.Extensions
{
    public static class MKMapPointExtensions
    {
        public static CLLocationCoordinate2D ToCLLocationCoordinate(this MKMapPoint mapPoint)
        {
            return new CLLocationCoordinate2D(mapPoint.X, mapPoint.Y);
        }
    }
}