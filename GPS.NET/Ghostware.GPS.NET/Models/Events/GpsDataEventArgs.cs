﻿using System;
using System.Device.Location;
using Ghostware.GPS.NET.Models.GpsdModels;
using Ghostware.NMEAParser.NMEAMessages;

namespace Ghostware.GPS.NET.Models.Events
{
    public class GpsDataEventArgs : EventArgs
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public double Speed { get; set; }

        public GpsDataEventArgs(GpsLocation gpsLocation)
        {
            Latitude = gpsLocation.Latitude;
            Longitude = gpsLocation.Longitude;
            Speed = gpsLocation.Speed;
        }

        public GpsDataEventArgs(GprmcMessage gpsLocation)
        {
            Latitude = gpsLocation.Latitude;
            Longitude = gpsLocation.Longitude;
            Speed = gpsLocation.Speed;
        }

        public GpsDataEventArgs(GeoCoordinate gpsLocation)
        {
            Latitude = gpsLocation.Latitude;
            Longitude = gpsLocation.Longitude;
            Speed = gpsLocation.Speed;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude} - Longitude: {Longitude} - Speed: {Speed}";
        }
    }
}