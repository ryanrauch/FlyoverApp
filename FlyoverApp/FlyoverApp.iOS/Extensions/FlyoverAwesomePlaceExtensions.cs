using CoreLocation;

namespace FlyoverApp.iOS.Extensions
{
    public static class FlyoverAwesomePlaceExtensions
    {
        public static CLLocationCoordinate2D GetCoordinates(this FlyoverAwesomePlace place)
        {
            switch(place)
            {
                case FlyoverAwesomePlace.NewYorkStatueOfLiberty:
                    return new CLLocationCoordinate2D(40.689249, -74.044500);
                case FlyoverAwesomePlace.NewYork:
                    return new CLLocationCoordinate2D(40.702749, -74.014120);
                case FlyoverAwesomePlace.SanFranciscoGoldenGateBridge:
                    return new CLLocationCoordinate2D(37.826040, -122.479448);
                default:
                    return new CLLocationCoordinate2D(40.689249, -74.044500);
            }
        }
    }
}