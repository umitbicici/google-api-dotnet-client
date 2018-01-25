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
 *   Google Cloud Speech API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://cloud.google.com/speech/'>Google Cloud Speech API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20180123 (1118)
 *      <tr><th>API Docs
 *          <td><a href='https://cloud.google.com/speech/'>
 *              https://cloud.google.com/speech/</a>
 *      <tr><th>Discovery Name<td>speech
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Google Cloud Speech API can be found at
 * <a href='https://cloud.google.com/speech/'>https://cloud.google.com/speech/</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.Speech.v1
{
    /// <summary>The Speech Service.</summary>
    public class SpeechService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SpeechService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SpeechService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            operations = new OperationsResource(this);
            speech = new SpeechResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "speech"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://speech.googleapis.com/"; }
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
            get { return "https://speech.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Cloud Speech API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }



        private readonly OperationsResource operations;

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations
        {
            get { return operations; }
        }

        private readonly SpeechResource speech;

        /// <summary>Gets the Speech resource.</summary>
        public virtual SpeechResource Speech
        {
            get { return speech; }
        }
    }

    ///<summary>A base abstract class for Speech requests.</summary>
    public abstract class SpeechBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new SpeechBaseServiceRequest instance.</summary>
        protected SpeechBaseServiceRequest(Google.Apis.Services.IClientService service)
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

        /// <summary>Initializes Speech parameter list.</summary>
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

    /// <summary>The "operations" collection of methods.</summary>
    public class OperationsResource
    {
        private const string Resource = "operations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OperationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets the latest state of a long-running operation.  Clients can use this method to poll the
        /// operation result at intervals as recommended by the API service.</summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets the latest state of a long-running operation.  Clients can use this method to poll the
        /// operation result at intervals as recommended by the API service.</summary>
        public class GetRequest : SpeechBaseServiceRequest<Google.Apis.Speech.v1.Data.Operation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>The name of the operation resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "get"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/operations/{+name}"; }
            }

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
            }

        }
    }

    /// <summary>The "speech" collection of methods.</summary>
    public class SpeechResource
    {
        private const string Resource = "speech";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SpeechResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Performs asynchronous speech recognition: receive results via the google.longrunning.Operations
        /// interface. Returns either an `Operation.error` or an `Operation.response` which contains a
        /// `LongRunningRecognizeResponse` message.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual LongrunningrecognizeRequest Longrunningrecognize(Google.Apis.Speech.v1.Data.LongRunningRecognizeRequest body)
        {
            return new LongrunningrecognizeRequest(service, body);
        }

        /// <summary>Performs asynchronous speech recognition: receive results via the google.longrunning.Operations
        /// interface. Returns either an `Operation.error` or an `Operation.response` which contains a
        /// `LongRunningRecognizeResponse` message.</summary>
        public class LongrunningrecognizeRequest : SpeechBaseServiceRequest<Google.Apis.Speech.v1.Data.Operation>
        {
            /// <summary>Constructs a new Longrunningrecognize request.</summary>
            public LongrunningrecognizeRequest(Google.Apis.Services.IClientService service, Google.Apis.Speech.v1.Data.LongRunningRecognizeRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Speech.v1.Data.LongRunningRecognizeRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "longrunningrecognize"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/speech:longrunningrecognize"; }
            }

            /// <summary>Initializes Longrunningrecognize parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Performs synchronous speech recognition: receive results after all audio has been sent and
        /// processed.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual RecognizeRequest Recognize(Google.Apis.Speech.v1.Data.RecognizeRequest body)
        {
            return new RecognizeRequest(service, body);
        }

        /// <summary>Performs synchronous speech recognition: receive results after all audio has been sent and
        /// processed.</summary>
        public class RecognizeRequest : SpeechBaseServiceRequest<Google.Apis.Speech.v1.Data.RecognizeResponse>
        {
            /// <summary>Constructs a new Recognize request.</summary>
            public RecognizeRequest(Google.Apis.Services.IClientService service, Google.Apis.Speech.v1.Data.RecognizeRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Speech.v1.Data.RecognizeRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "recognize"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/speech:recognize"; }
            }

            /// <summary>Initializes Recognize parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }
}

namespace Google.Apis.Speech.v1.Data
{    

    /// <summary>The top-level message sent by the client for the `LongRunningRecognize` method.</summary>
    public class LongRunningRecognizeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>*Required* The audio data to be recognized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audio")]
        public virtual RecognitionAudio Audio { get; set; } 

        /// <summary>*Required* Provides information to the recognizer that specifies how to process the
        /// request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual RecognitionConfig Config { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the value is `false`, it means the operation is still in progress. If `true`, the operation is
        /// completed, and either `error` or `response` is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; } 

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; } 

        /// <summary>Service-specific metadata associated with the operation.  It typically contains progress
        /// information and common metadata such as create time. Some services might not provide such metadata.  Any
        /// method that returns a long-running operation should document the metadata type, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string,object> Metadata { get; set; } 

        /// <summary>The server-assigned name, which is only unique within the same service that originally returns it.
        /// If you use the default HTTP mapping, the `name` should have the format of
        /// `operations/some/unique/name`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The normal response of the operation in case of success.  If the original method returns no data on
        /// success, such as `Delete`, the response is `google.protobuf.Empty`.  If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource.  For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name.  For example, if the original method name
        /// is `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string,object> Response { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Contains audio data in the encoding specified in the `RecognitionConfig`. Either `content` or `uri`
    /// must be supplied. Supplying both or neither returns google.rpc.Code.INVALID_ARGUMENT. See [audio
    /// limits](https://cloud.google.com/speech/limits#content).</summary>
    public class RecognitionAudio : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The audio data bytes encoded as specified in `RecognitionConfig`. Note: as with all bytes fields,
        /// protobuffers use a pure binary representation, whereas JSON representations use base64.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; } 

        /// <summary>URI that points to a file that contains audio data bytes as specified in `RecognitionConfig`.
        /// Currently, only Google Cloud Storage URIs are supported, which must be specified in the following format:
        /// `gs://bucket_name/object_name` (other URI formats return google.rpc.Code.INVALID_ARGUMENT). For more
        /// information, see [Request URIs](https://cloud.google.com/storage/docs/reference-uris).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Provides information to the recognizer that specifies how to process the request.</summary>
    public class RecognitionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>*Optional* If `true`, the top result includes a list of words and the confidence for those words.
        /// If `false`, no word-level confidence information is returned. The default is `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableWordConfidence")]
        public virtual System.Nullable<bool> EnableWordConfidence { get; set; } 

        /// <summary>*Optional* If `true`, the top result includes a list of words and the start and end time offsets
        /// (timestamps) for those words. If `false`, no word-level time offset information is returned. The default is
        /// `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableWordTimeOffsets")]
        public virtual System.Nullable<bool> EnableWordTimeOffsets { get; set; } 

        /// <summary>*Required* Encoding of audio data sent in all `RecognitionAudio` messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; } 

        /// <summary>*Required* The language of the supplied audio as a [BCP-47](https://www.rfc-
        /// editor.org/rfc/bcp/bcp47.txt) language tag. Example: "en-US". See [Language
        /// Support](https://cloud.google.com/speech/docs/languages) for a list of the currently supported language
        /// codes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>*Optional* Maximum number of recognition hypotheses to be returned. Specifically, the maximum
        /// number of `SpeechRecognitionAlternative` messages within each `SpeechRecognitionResult`. The server may
        /// return fewer than `max_alternatives`. Valid values are `0`-`30`. A value of `0` or `1` will return a maximum
        /// of one. If omitted, will return a maximum of one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAlternatives")]
        public virtual System.Nullable<int> MaxAlternatives { get; set; } 

        /// <summary>*Optional* If set to `true`, the server will attempt to filter out profanities, replacing all but
        /// the initial character in each filtered word with asterisks, e.g. "f***". If set to `false` or omitted,
        /// profanities won't be filtered out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profanityFilter")]
        public virtual System.Nullable<bool> ProfanityFilter { get; set; } 

        /// <summary>*Required* Sample rate in Hertz of the audio data sent in all `RecognitionAudio` messages. Valid
        /// values are: 8000-48000. 16000 is optimal. For best results, set the sampling rate of the audio source to
        /// 16000 Hz. If that's not possible, use the native sample rate of the audio source (instead of re-
        /// sampling).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleRateHertz")]
        public virtual System.Nullable<int> SampleRateHertz { get; set; } 

        /// <summary>*Optional* A means to provide context to assist the speech recognition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechContexts")]
        public virtual System.Collections.Generic.IList<SpeechContext> SpeechContexts { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The top-level message sent by the client for the `Recognize` method.</summary>
    public class RecognizeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>*Required* The audio data to be recognized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audio")]
        public virtual RecognitionAudio Audio { get; set; } 

        /// <summary>*Required* Provides information to the recognizer that specifies how to process the
        /// request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual RecognitionConfig Config { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The only message returned to the client by the `Recognize` method. It contains the result as zero or
    /// more sequential `SpeechRecognitionResult` messages.</summary>
    public class RecognizeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>*Output-only* Sequential list of transcription results corresponding to sequential portions of
        /// audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<SpeechRecognitionResult> Results { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Provides "hints" to the speech recognizer to favor specific words and phrases in the results.</summary>
    public class SpeechContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>*Optional* A list of strings containing words and phrases "hints" so that the speech recognition is
        /// more likely to recognize them. This can be used to improve the accuracy for specific words and phrases, for
        /// example, if specific commands are typically spoken by the user. This can also be used to add additional
        /// words to the vocabulary of the recognizer. See [usage
        /// limits](https://cloud.google.com/speech/limits#content).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phrases")]
        public virtual System.Collections.Generic.IList<string> Phrases { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Alternative hypotheses (a.k.a. n-best list).</summary>
    public class SpeechRecognitionAlternative : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>*Output-only* The confidence estimate between 0.0 and 1.0. A higher number indicates an estimated
        /// greater likelihood that the recognized words are correct. This field is set only for the top alternative of
        /// a non-streaming result or, of a streaming result where `is_final=true`. This field is not guaranteed to be
        /// accurate and users should not rely on it to be always provided. The default of 0.0 is a sentinel value
        /// indicating `confidence` was not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; } 

        /// <summary>*Output-only* Transcript text representing the words that the user spoke.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcript")]
        public virtual string Transcript { get; set; } 

        /// <summary>*Output-only* A list of word-specific information for each recognized word.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<WordInfo> Words { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A speech recognition result corresponding to a portion of the audio.</summary>
    public class SpeechRecognitionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>*Output-only* May contain one or more recognition hypotheses (up to the maximum specified in
        /// `max_alternatives`). These alternatives are ordered in terms of accuracy, with the top (first) alternative
        /// being the most probable, as ranked by the recognizer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternatives")]
        public virtual System.Collections.Generic.IList<SpeechRecognitionAlternative> Alternatives { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The `Status` type defines a logical error model that is suitable for different programming
    /// environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). The error model
    /// is designed to be:
    ///
    /// - Simple to use and understand for most users - Flexible enough to meet unexpected needs
    ///
    /// # Overview
    ///
    /// The `Status` message contains three pieces of data: error code, error message, and error details. The error code
    /// should be an enum value of google.rpc.Code, but it may accept additional error codes if needed.  The error
    /// message should be a developer-facing English message that helps developers *understand* and *resolve* the error.
    /// If a localized user-facing error message is needed, put the localized message in the error details or localize
    /// it in the client. The optional error details may contain arbitrary information about the error. There is a
    /// predefined set of error detail types in the package `google.rpc` that can be used for common error conditions.
    ///
    /// # Language mapping
    ///
    /// The `Status` message is the logical representation of the error model, but it is not necessarily the actual wire
    /// format. When the `Status` message is exposed in different client libraries and different wire protocols, it can
    /// be mapped differently. For example, it will likely be mapped to some exceptions in Java, but more likely mapped
    /// to some error codes in C.
    ///
    /// # Other uses
    ///
    /// The error model and the `Status` message can be used in a variety of environments, either with or without APIs,
    /// to provide a consistent developer experience across different environments.
    ///
    /// Example uses of this error model include:
    ///
    /// - Partial errors. If a service needs to return partial errors to the client, it may embed the `Status` in the
    /// normal response to indicate the partial errors.
    ///
    /// - Workflow errors. A typical workflow has multiple steps. Each step may have a `Status` message for error
    /// reporting.
    ///
    /// - Batch operations. If a client uses batch request and batch response, the `Status` message should be used
    /// directly inside batch response, one for each error sub-response.
    ///
    /// - Asynchronous operations. If an API call embeds asynchronous operation results in its response, the status of
    /// those operations should be represented directly using the `Status` message.
    ///
    /// - Logging. If some API errors are stored in logs, the message `Status` could be used directly after any
    /// stripping needed for security/privacy reasons.</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; } 

        /// <summary>A list of messages that carry the error details.  There is a common set of message types for APIs
        /// to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string,object>> Details { get; set; } 

        /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should
        /// be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Word-specific information for recognized words.</summary>
    public class WordInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>*Output-only* Time offset relative to the beginning of the audio, and corresponding to the end of
        /// the spoken word. This field is only set if `enable_word_time_offsets=true` and only in the top hypothesis.
        /// This is an experimental feature and the accuracy of the time offset can vary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; } 

        /// <summary>*Output-only* Time offset relative to the beginning of the audio, and corresponding to the start of
        /// the spoken word. This field is only set if `enable_word_time_offsets=true` and only in the top hypothesis.
        /// This is an experimental feature and the accuracy of the time offset can vary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; } 

        /// <summary>*Output-only* The word corresponding to this set of information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("word")]
        public virtual string Word { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
