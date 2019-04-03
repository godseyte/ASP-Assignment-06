/*
 * Tucker Godsey
 * Assignment 6
 * Due 3/13/2019
 * Web Server Application Development IT3047 001
 * 
 * Use AJAX (WebRequest) to get weather information and display it on Labels after accepting an input
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;

namespace godseyte_Assignment06
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // When the button is clicked, verify the ZIP code and, if it's a proper zip code, call on the GetWeather() Method
            // If ZIP is Wrong, Inform the User
            if (Regex.IsMatch(txtZipInput.Text, "^[0-9]{5}(?:-[0-9]{4})?$")) {
                lblZipError.Visible = false;
                GetWeather(Int32.Parse(txtZipInput.Text));
            }
            else
            {
                lblZipError.Visible = true;
            }

            
        }

        public void GetWeather(int zip)
        {
            // Create our URL
            string WEBSERVICE_URL = "http://api.weatherunlocked.com/api/current/us." + zip + "?app_id=46871c17&app_key=105253c9ac3c7dc9a24dbfd161a3421d";


            try
            {
                // Create a WebRequest
                var webRequest = WebRequest.Create(WEBSERVICE_URL);

                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.ContentType = "application/json";

                    //Get the response
                    WebResponse wr = webRequest.GetResponseAsync().Result;
                    Stream receiveStream = wr.GetResponseStream();
                    StreamReader reader = new StreamReader(receiveStream);

                    string content = reader.ReadToEnd(); // String made from the JSON

                    // Create new CurrentWeather Object
                    CurrentWeather curWeather = new CurrentWeather();


                    // Deserialize JSON data recieved and add it to curWeather
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    curWeather = (CurrentWeather)serializer.Deserialize(content, typeof(CurrentWeather));

                    // Make the Table that displays results visible
                    tblResults.Visible = true;

                    // Temperature
                    lblTemp.Text = curWeather.temp_f.ToString() + "°F";

                    // Weather Condition
                    lblWeather.Text = curWeather.wx_desc;
                    imgCondition.ImageUrl = "icons/" + curWeather.wx_icon;

                    // Cloud Cover Percentage
                    lblCloud.Text = curWeather.cloudtotal_pct + "%";

                    // Humidity
                    lblHumidity.Text = curWeather.humid_pct + "%";
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                //Response.Write(ex.ToString());
                lblZipError.Visible = true;
            }
        }
    }
}