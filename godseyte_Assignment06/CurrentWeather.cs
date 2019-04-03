/*
 * Tucker Godsey
 * Assignment 6
 * Due 3/13/2019
 * Web Server Application Development IT3047 001
 * 
 * Code created by http://json2csharp.com/
 * 
 * Models the current weather
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace godseyte_Assignment06
{
    public class CurrentWeather
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public double alt_m { get; set; }
        public double alt_ft { get; set; }
        public string wx_desc { get; set; }
        public int wx_code { get; set; }
        public string wx_icon { get; set; }
        public double temp_c { get; set; }
        public double temp_f { get; set; }
        public double feelslike_c { get; set; }
        public double feelslike_f { get; set; }
        public double humid_pct { get; set; }
        public double windspd_mph { get; set; }
        public double windspd_kmh { get; set; }
        public double windspd_kts { get; set; }
        public double windspd_ms { get; set; }
        public double winddir_deg { get; set; }
        public string winddir_compass { get; set; }
        public double cloudtotal_pct { get; set; }
        public double vis_km { get; set; }
        public double vis_mi { get; set; }
        public object vis_desc { get; set; }
        public double slp_mb { get; set; }
        public double slp_in { get; set; }
        public double dewpoint_c { get; set; }
        public double dewpoint_f { get; set; }
    }
}