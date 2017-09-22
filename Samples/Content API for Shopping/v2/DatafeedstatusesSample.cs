﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 2017-09-22
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Shoppingcontent v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages product items, inventory, and Merchant Center accounts for Google Shopping.
// API Documentation Link https://developers.google.com/shopping-content
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Shoppingcontent/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Shoppingcontent.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Shoppingcontent.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Shoppingcontent.v2;
using Google.Apis.Shoppingcontent.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Shoppingcontentv2.Methods
{
  
    public static class DatafeedstatusesSample
    {


        /// <summary>
        /// NA 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/datafeedstatuses/custombatch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <returns>DatafeedstatusesCustomBatchResponseResponse</returns>
        public static DatafeedstatusesCustomBatchResponse Custombatch(ShoppingcontentService service, DatafeedstatusesCustomBatchRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Datafeedstatuses.Custombatch(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Datafeedstatuses.Custombatch failed.", ex);
            }
        }
        public class DatafeedstatusesGetOptionalParms
        {
            /// The country for which to get the datafeed status. If this parameter is provided then language must also be provided. Note that this parameter is required for feeds targeting multiple countries and languages, since a feed may have a different status for each target.
            public string Country { get; set; }  
            /// The language for which to get the datafeed status. If this parameter is provided then country must also be provided. Note that this parameter is required for feeds targeting multiple countries and languages, since a feed may have a different status for each target.
            public string Language { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves the status of a datafeed from your Merchant Center account. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/datafeedstatuses/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">NA</param>
        /// <param name="datafeedId">NA</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>DatafeedStatusResponse</returns>
        public static DatafeedStatus Get(ShoppingcontentService service, string merchantId, string datafeedId, DatafeedstatusesGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (datafeedId == null)
                    throw new ArgumentNullException(datafeedId);

                // Building the initial request.
                var request = service.Datafeedstatuses.Get(merchantId, datafeedId);

                // Applying optional parameters to the request.                
                request = (DatafeedstatusesResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Datafeedstatuses.Get failed.", ex);
            }
        }
        public class DatafeedstatusesListOptionalParms
        {
            /// The maximum number of products to return in the response, used for paging.
            public int? MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the statuses of the datafeeds in your Merchant Center account. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/datafeedstatuses/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>DatafeedstatusesListResponseResponse</returns>
        public static DatafeedstatusesListResponse List(ShoppingcontentService service, string merchantId, DatafeedstatusesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);

                // Building the initial request.
                var request = service.Datafeedstatuses.List(merchantId);

                // Applying optional parameters to the request.                
                request = (DatafeedstatusesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Datafeedstatuses.List failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}