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
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.32.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Firebase Remote Config API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://firebase.google.com/docs/remote-config/'>Firebase Remote Config API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20180122 (1117)
 *      <tr><th>API Docs
 *          <td><a href='https://firebase.google.com/docs/remote-config/'>
 *              https://firebase.google.com/docs/remote-config/</a>
 *      <tr><th>Discovery Name<td>firebaseremoteconfig
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Firebase Remote Config API can be found at
 * <a href='https://firebase.google.com/docs/remote-config/'>https://firebase.google.com/docs/remote-config/</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.FirebaseRemoteConfig.v1
{
    /// <summary>The FirebaseRemoteConfig Service.</summary>
    public class FirebaseRemoteConfigService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseRemoteConfigService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseRemoteConfigService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "firebaseremoteconfig"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://firebaseremoteconfig.googleapis.com/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://firebaseremoteconfig.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif





        private readonly ProjectsResource projects;

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects
        {
            get { return projects; }
        }
    }

    ///<summary>A base abstract class for FirebaseRemoteConfig requests.</summary>
    public abstract class FirebaseRemoteConfigBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new FirebaseRemoteConfigBaseServiceRequest instance.</summary>
        protected FirebaseRemoteConfigBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>OAuth bearer token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("bearer_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string BearerToken { get; set; }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Pretty-print response.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("pp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> Pp { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes FirebaseRemoteConfig parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "bearer_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "bearer_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "pp", new Google.Apis.Discovery.Parameter
                {
                    Name = "pp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Get the latest version Remote Configuration for a project. Returns the RemoteConfig as the payload,
        /// and also the eTag as a response header.</summary>
        /// <param name="project">The GMP project identifier. Required. See note at the beginning of this file regarding project
        /// ids.</param>
        public virtual GetRemoteConfigRequest GetRemoteConfig(string project)
        {
            return new GetRemoteConfigRequest(service, project);
        }

        /// <summary>Get the latest version Remote Configuration for a project. Returns the RemoteConfig as the payload,
        /// and also the eTag as a response header.</summary>
        public class GetRemoteConfigRequest : FirebaseRemoteConfigBaseServiceRequest<Google.Apis.FirebaseRemoteConfig.v1.Data.RemoteConfig>
        {
            /// <summary>Constructs a new GetRemoteConfig request.</summary>
            public GetRemoteConfigRequest(Google.Apis.Services.IClientService service, string project)
                : base(service)
            {
                Project = project;
                InitParameters();
            }


            /// <summary>The GMP project identifier. Required. See note at the beginning of this file regarding project
            /// ids.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "getRemoteConfig"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/{+project}/remoteConfig"; }
            }

            /// <summary>Initializes GetRemoteConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
            }

        }

        /// <summary>Update a RemoteConfig. We treat this as an always-existing resource (when it is not found in our
        /// data store, we treat it as version 0, a template with zero conditions and zero parameters). Hence there are
        /// no Create or Delete operations. Returns the updated template when successful (and the updated eTag as a
        /// response header), or an error if things go wrong. Possible error messages: * VALIDATION_ERROR (HTTP status
        /// 400) with additional details if the template being passed in can not be validated. * AUTHENTICATION_ERROR
        /// (HTTP status 401) if the request can not be authenticate (e.g. no access token, or invalid access token). *
        /// AUTHORIZATION_ERROR (HTTP status 403) if the request can not be authorized (e.g. the user has no access to
        /// the specified project id). * VERSION_MISMATCH (HTTP status 412) when trying to update when the expected eTag
        /// (passed in via the "If-match" header) is not specified, or is specified but does does not match the current
        /// eTag. * Internal error (HTTP status 500) for Database problems or other internal errors.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The GMP project identifier. Required. See note at the beginning of this file regarding project
        /// ids.</param>
        public virtual UpdateRemoteConfigRequest UpdateRemoteConfig(Google.Apis.FirebaseRemoteConfig.v1.Data.RemoteConfig body, string project)
        {
            return new UpdateRemoteConfigRequest(service, body, project);
        }

        /// <summary>Update a RemoteConfig. We treat this as an always-existing resource (when it is not found in our
        /// data store, we treat it as version 0, a template with zero conditions and zero parameters). Hence there are
        /// no Create or Delete operations. Returns the updated template when successful (and the updated eTag as a
        /// response header), or an error if things go wrong. Possible error messages: * VALIDATION_ERROR (HTTP status
        /// 400) with additional details if the template being passed in can not be validated. * AUTHENTICATION_ERROR
        /// (HTTP status 401) if the request can not be authenticate (e.g. no access token, or invalid access token). *
        /// AUTHORIZATION_ERROR (HTTP status 403) if the request can not be authorized (e.g. the user has no access to
        /// the specified project id). * VERSION_MISMATCH (HTTP status 412) when trying to update when the expected eTag
        /// (passed in via the "If-match" header) is not specified, or is specified but does does not match the current
        /// eTag. * Internal error (HTTP status 500) for Database problems or other internal errors.</summary>
        public class UpdateRemoteConfigRequest : FirebaseRemoteConfigBaseServiceRequest<Google.Apis.FirebaseRemoteConfig.v1.Data.RemoteConfig>
        {
            /// <summary>Constructs a new UpdateRemoteConfig request.</summary>
            public UpdateRemoteConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseRemoteConfig.v1.Data.RemoteConfig body, string project)
                : base(service)
            {
                Project = project;
                Body = body;
                InitParameters();
            }


            /// <summary>The GMP project identifier. Required. See note at the beginning of this file regarding project
            /// ids.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Optional. Defaults to false (UpdateRemoteConfig call should update the backend if there are no
            /// validation/interal errors). May be set to true to indicate that, should no validation errors occur, the
            /// call should return a "200 OK" instead of performing the update. Note that other error messages (500
            /// Internal Error, 412 Version Mismatch, etc) may still result after flipping to false, even if getting a
            /// "200 OK" when calling with true.</summary>
            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ValidateOnly { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FirebaseRemoteConfig.v1.Data.RemoteConfig Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "updateRemoteConfig"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "PUT"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/{+project}/remoteConfig"; }
            }

            /// <summary>Initializes UpdateRemoteConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                RequestParameters.Add(
                    "validateOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "validateOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.FirebaseRemoteConfig.v1.Data
{    

    /// <summary>* The RemoteConfig consists of a list of conditions (which can be thought of as named "if" statements)
    /// and a map of parameters (parameter key to a structure containing an optional default value, as well as a
    /// optional submap of (condition name to value when that condition is true).</summary>
    public class RemoteConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of named conditions. The order *does* affect the semantics. The condition_name values of
        /// these entries must be unique.
        ///
        /// The resolved value of a config parameter P is determined as follow: * Let Y be the set of values from the
        /// submap of P that refer to conditions that evaluate to true. * If Y is non empty, the value is taken from the
        /// specific submap in Y whose condition_name is the earliest in this condition list. * Else, if P has a default
        /// value option (condition_name is empty) then the value is taken from that option. * Else, parameter P has no
        /// value and is omitted from the config result.
        ///
        /// Example: parameter key "p1", default value "v1", submap specified as {"c1": v2, "c2": v3} where "c1" and
        /// "c2" are names of conditions in the condition list (where "c1" in this example appears before "c2").  The
        /// value of p1 would be v2 as long as c1 is true.  Otherwise, if c2 is true, p1 would evaluate to v3, and if c1
        /// and c2 are both false, p1 would evaluate to v1.  If no default value was specified, and c1 and c2 were both
        /// false, no value for p1 would be generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<RemoteConfigCondition> Conditions { get; set; } 

        /// <summary>Map of parameter keys to their optional default values and optional submap of (condition name :
        /// value). Order doesn't affect semantics, and so is sorted by the server. The 'key' values of the params must
        /// be unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string,RemoteConfigParameter> Parameters { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single RemoteConfig Condition.  A list of these (because order matters) are part of a single
    /// RemoteConfig template.</summary>
    public class RemoteConfigCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DO NOT USE. Implementation removed and will not be added unless requested. A description for this
        /// Condition. Length must be less than or equal to 100 characters (or more precisely, unicode code points,
        /// which is defined in java/com/google/wireless/android/config/ConstsExporter.java). A description may contain
        /// any Unicode characters</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; } 

        /// <summary>Required. A non empty and unique name of this condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Optional. The display (tag) color of this condition. This serves as part of a tag (in the future,
        /// we may add tag text as well as tag color, but that is not yet implemented in the UI). This value has no
        /// affect on the semantics of the delivered config and it is ignored by the backend, except for passing it
        /// through write/read requests. Not having this value or having the "CONDITION_DISPLAY_COLOR_UNSPECIFIED" value
        /// (0) have the same meaning:  Let the UI choose any valid color when displaying the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagColor")]
        public virtual string TagColor { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>While default_value and conditional_values are each optional, at least one of the two is required -
    /// otherwise, the parameter is meaningless (and an exception will be thrown by the validation logic).</summary>
    public class RemoteConfigParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional - a map of (condition_name, value). The condition_name of the highest priority (the one
        /// listed first in the conditions array) determines the value of this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionalValues")]
        public virtual System.Collections.Generic.IDictionary<string,RemoteConfigParameterValue> ConditionalValues { get; set; } 

        /// <summary>Optional - value to set the parameter to, when none of the named conditions evaluate to
        /// true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual RemoteConfigParameterValue DefaultValue { get; set; } 

        /// <summary>Optional. A description for this Parameter. Length must be less than or equal to 100 characters (or
        /// more precisely, unicode code points, which is defined in
        /// java/com/google/wireless/android/config/ConstsExporter.java). A description may contain any Unicode
        /// characters</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A RemoteConfigParameter's "value" (either the default value, or the value associated with a condition
    /// name) is either a string, or the "use_in_app_default" indicator (which means to leave out the parameter from the
    /// returned  map that is the output of the parameter fetch). We represent the "use_in_app_default" as a bool, but
    /// (when using the boolean instead of the string) it should always be true.</summary>
    public class RemoteConfigParameterValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>if true, omit the parameter from the map of fetched parameter values</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useInAppDefault")]
        public virtual System.Nullable<bool> UseInAppDefault { get; set; } 

        /// <summary>the string to set the parameter to</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
