﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Spatial
{
    public class GetGeofenceRequest : SpatialRequestBase
    {
        /// <summary>
        /// ID of the device
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// The latitude of the location being passed. Example: 48.36.
        /// </summary>
        public double Lat { get; set; }

        /// <summary>
        /// The longitude of the location being passed. Example: -124.63.
        /// </summary>
        public double Lon { get; set; }

        /// <summary>
        /// The user request time. If not presented in the request, the default value is DateTime.Now.
        /// </summary>
        public string UserTime { get; set; }

        /// <summary>
        /// The radius of the buffer around the geofence in meters that defines how far to search inside and outside the border of the fence against the coordinate that was provided when calculating the result. The minimum value is 0, and the maximum is 500. The default value is 50.
        /// </summary>
        public double SearchBuffer { get; set; }

        /// <summary>
        /// If true, the request will use async event mechanism; if false, the request will be synchronized and do not trigger any event. The default value is false.
        /// </summary>
        public bool IsAsync { get; set; } = false;

        /// <summary>
        /// Mode of the geofencing async event mechanism.
        /// </summary>
        public Mode Mode { get; set; }
    }
}
