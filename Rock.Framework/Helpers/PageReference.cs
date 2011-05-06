﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Routing;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;


namespace Rock.Helpers
{
    /// <summary>
    /// Helper class to work with the PageReference field type
    /// </summary>
    public class PageReference : System.Web.UI.UserControl
    {
        // private members
        private int _pageId = -1;
        private int _routeId = -1;
        private string _routeUrl = "empty";
        
        // public properties
        public int PageId 
        {
            get
            {
                return _pageId;
            }            
        }

        public int RouteId
        {
            get
            {
                return _routeId;
            }
        }

        public string RouteUrl
        {
            get
            {
                if ( _routeUrl == "empty" )
                {
                    _routeUrl = string.Empty;

                    //RouteCollection routes = RouteDataRouteTable.Routes;

                    /*foreach ( Route route in routes )
                    {
                        if ( route.DataTokens["RouteId"] == _routeId.ToString() )
                            _routeUrl = route.Url;
                    }*/
                }
                
                return _routeUrl;
            }
        }
        
        // constructors
        public PageReference(){}

        public PageReference( string reference )
        {
            string[] items = reference.Split( ',' );

            Int32.TryParse( items[0], out _pageId );
            Int32.TryParse( items[1], out _routeId );

            //RouteCollection routes = RouteDataRouteTable.Routes;
        }
        
    }
}