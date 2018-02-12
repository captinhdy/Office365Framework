using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 351
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                286, // index: 286, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                368, // index: 368, string: "Key"
                372, // index: 372, string: "Value"
                2, // array length: 2
                286, // index: 286, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                286, // index: 286, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                406, // index: 406, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                1198, // index: 1198, string: "key"
                1202, // index: 1202, string: "value"
                2, // array length: 2
                406, // index: 406, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                406, // index: 406, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                481, // index: 481, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                8, // array length: 8
                1208, // index: 1208, string: "home_oid"
                1217, // index: 1217, string: "iss"
                1221, // index: 1221, string: "name"
                1226, // index: 1226, string: "oid"
                1230, // index: 1230, string: "preferred_username"
                1249, // index: 1249, string: "sub"
                1253, // index: 1253, string: "tid"
                1257, // index: 1257, string: "ver"
                8, // array length: 8
                481, // index: 481, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                481, // index: 481, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                481, // index: 481, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                481, // index: 481, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                481, // index: 481, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                481, // index: 481, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                481, // index: 481, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                481, // index: 481, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                10, // array length: 10
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                10, // array length: 10
                1261, // index: 1261, string: "client_id"
                1271, // index: 1271, string: "client_info"
                1257, // index: 1257, string: "ver"
                1283, // index: 1283, string: "access_token"
                1296, // index: 1296, string: "authority"
                1306, // index: 1306, string: "expires_on"
                1317, // index: 1317, string: "id_token"
                1326, // index: 1326, string: "scope"
                1332, // index: 1332, string: "token_type"
                1343, // index: 1343, string: "user_assertion_hash"
                10, // array length: 10
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                3, // array length: 3
                1261, // index: 1261, string: "client_id"
                1271, // index: 1271, string: "client_info"
                1257, // index: 1257, string: "ver"
                3, // array length: 3
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                8, // array length: 8
                1261, // index: 1261, string: "client_id"
                1271, // index: 1271, string: "client_info"
                1257, // index: 1257, string: "ver"
                1363, // index: 1363, string: "displayable_id"
                1378, // index: 1378, string: "environment"
                1390, // index: 1390, string: "identity_provider"
                1221, // index: 1221, string: "name"
                1408, // index: 1408, string: "refresh_token"
                8, // array length: 8
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                577, // index: 577, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                286, // index: 286, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                368, // index: 368, string: "Key"
                372, // index: 372, string: "Value"
                2, // array length: 2
                286, // index: 286, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                286, // index: 286, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                -1, // string: null
                286, // index: 286, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                406, // index: 406, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                1198, // index: 1198, string: "key"
                1202, // index: 1202, string: "value"
                2, // array length: 2
                406, // index: 406, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                406, // index: 406, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                481, // index: 481, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                2, // array length: 2
                1422, // index: 1422, string: "uid"
                1426, // index: 1426, string: "utid"
                2, // array length: 2
                481, // index: 481, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                481, // index: 481, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                12, // array length: 12
                -1, // string: null
                -1, // string: null
                -1, // string: null
                286, // index: 286, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                12, // array length: 12
                1431, // index: 1431, string: "claims"
                1438, // index: 1438, string: "correlation_id"
                1453, // index: 1453, string: "error"
                1459, // index: 1459, string: "error_codes"
                1471, // index: 1471, string: "error_description"
                1283, // index: 1283, string: "access_token"
                1271, // index: 1271, string: "client_info"
                1489, // index: 1489, string: "expires_in"
                1317, // index: 1317, string: "id_token"
                1408, // index: 1408, string: "refresh_token"
                1326, // index: 1326, string: "scope"
                1332, // index: 1332, string: "token_type"
                12, // array length: 12
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                286, // index: 286, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                1, // array length: 1
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                5, // array length: 5
                1431, // index: 1431, string: "claims"
                1438, // index: 1438, string: "correlation_id"
                1453, // index: 1453, string: "error"
                1459, // index: 1459, string: "error_codes"
                1471, // index: 1471, string: "error_description"
                5, // array length: 5
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                286, // index: 286, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                7, // array length: 7
                1431, // index: 1431, string: "claims"
                1438, // index: 1438, string: "correlation_id"
                1453, // index: 1453, string: "error"
                1459, // index: 1459, string: "error_codes"
                1471, // index: 1471, string: "error_description"
                1083, // index: 1083, string: "links"
                1500, // index: 1500, string: "subject"
                7, // array length: 7
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                2, // array length: 2
                1508, // index: 1508, string: "href"
                1513, // index: 1513, string: "rel"
                2, // array length: 2
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                286, // index: 286, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                8, // array length: 8
                1431, // index: 1431, string: "claims"
                1438, // index: 1438, string: "correlation_id"
                1453, // index: 1453, string: "error"
                1459, // index: 1459, string: "error_codes"
                1471, // index: 1471, string: "error_description"
                1517, // index: 1517, string: "authorization_endpoint"
                1540, // index: 1540, string: "issuer"
                1547, // index: 1547, string: "token_endpoint"
                8, // array length: 8
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                286, // index: 286, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                6, // array length: 6
                1431, // index: 1431, string: "claims"
                1438, // index: 1438, string: "correlation_id"
                1453, // index: 1453, string: "error"
                1459, // index: 1459, string: "error_codes"
                1471, // index: 1471, string: "error_description"
                1562, // index: 1562, string: "tenant_discovery_endpoint"
                6, // array length: 6
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                286, // index: 286, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                6, // array length: 6
                1431, // index: 1431, string: "claims"
                1438, // index: 1438, string: "correlation_id"
                1453, // index: 1453, string: "error"
                1459, // index: 1459, string: "error_codes"
                1471, // index: 1471, string: "error_description"
                1159, // index: 1159, string: "IdentityProviderService"
                6, // array length: 6
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                863, // index: 863, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2"
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                986, // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
                1, // array length: 1
                1588, // index: 1588, string: "PassiveAuthEndpoint"
                1, // array length: 1
                986  // index: 986, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=64
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.IdToken, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neutral, PublicK" +
                                "eyToken=0a613f4dd989e8ae")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.AccessTokenCacheItem, Microsoft.Identity.Client, Version=1.1.0.0, Cultu" +
                                "re=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.BaseTokenCacheItem, Microsoft.Identity.Client, Version=1.1.0.0, Culture" +
                                "=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.RefreshTokenCacheItem, Microsoft.Identity.Client, Version=1.1.0.0, Cult" +
                                "ure=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutra" +
                                "l, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.ClientInfo, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neutral, Publ" +
                                "icKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.OAuth2.TokenResponse, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neu" +
                                "tral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.OAuth2.OAuth2ResponseBase, Microsoft.Identity.Client, Version=1.1.0.0, Cultur" +
                                "e=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.AdfsWebFingerResponse, Microsoft.Identity.Client, Version=1.1.0.0, C" +
                                "ulture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neutral, PublicKeyToken=0a613f4dd989e8ae]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neutr" +
                                "al, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.TenantDiscoveryResponse, Microsoft.Identity.Client, Version=1.1.0.0," +
                                " Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.InstanceDiscoveryResponse, Microsoft.Identity.Client, Version=1.1.0." +
                                "0, Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.DrsMetadataResponse, Microsoft.Identity.Client, Version=1.1.0.0, Cul" +
                                "ture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.IdentityProviderService, Microsoft.Identity.Client, Version=1.1.0.0," +
                                " Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 82, // 0x52
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=17
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 344, // KeyValueOfstringanyType
                        NamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 344, // KeyValueOfstringanyType
                        StableNameNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 344, // KeyValueOfstringanyType
                        TopLevelElementNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.1.1.0, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type3.ReadKeyValueOfstringanyTypeFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type4.WriteKeyValueOfstringanyTypeToXml),
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 4,
                    MemberNamesListIndex = 6,
                    MemberNamespacesListIndex = 9,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 378, // KeyValuePairOfstringanyType
                        NamespaceIndex = 406, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 378, // KeyValuePairOfstringanyType
                        StableNameNamespaceIndex = 406, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 378, // KeyValuePairOfstringanyType
                        TopLevelElementNamespaceIndex = 406, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type5.ReadKeyValuePairOfstringanyTypeFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type6.WriteKeyValuePairOfstringanyTypeToXml),
                    ChildElementNamespacesListIndex = 12,
                    ContractNamespacesListIndex = 15,
                    MemberNamesListIndex = 17,
                    MemberNamespacesListIndex = 20,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 473, // IdToken
                        NamespaceIndex = 481, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 473, // IdToken
                        StableNameNamespaceIndex = 481, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 473, // IdToken
                        TopLevelElementNamespaceIndex = 481, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.IdToken, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neutral, PublicK" +
                                    "eyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.IdToken, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neutral, PublicK" +
                                    "eyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 23,
                    ContractNamespacesListIndex = 32,
                    MemberNamesListIndex = 34,
                    MemberNamespacesListIndex = 43,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 556, // AccessTokenCacheItem
                        NamespaceIndex = 577, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        StableNameIndex = 556, // AccessTokenCacheItem
                        StableNameNamespaceIndex = 577, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        TopLevelElementNameIndex = 556, // AccessTokenCacheItem
                        TopLevelElementNamespaceIndex = 577, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.AccessTokenCacheItem, Microsoft.Identity.Client, Version=1.1.0.0, Cultu" +
                                    "re=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.AccessTokenCacheItem, Microsoft.Identity.Client, Version=1.1.0.0, Cultu" +
                                    "re=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 52,
                    ContractNamespacesListIndex = 63,
                    MemberNamesListIndex = 66,
                    MemberNamespacesListIndex = 77,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 658, // BaseTokenCacheItem
                        NamespaceIndex = 577, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        StableNameIndex = 658, // BaseTokenCacheItem
                        StableNameNamespaceIndex = 577, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        TopLevelElementNameIndex = 658, // BaseTokenCacheItem
                        TopLevelElementNamespaceIndex = 577, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.BaseTokenCacheItem, Microsoft.Identity.Client, Version=1.1.0.0, Culture" +
                                    "=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.BaseTokenCacheItem, Microsoft.Identity.Client, Version=1.1.0.0, Culture" +
                                    "=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 88,
                    ContractNamespacesListIndex = 92,
                    MemberNamesListIndex = 94,
                    MemberNamespacesListIndex = 98,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 677, // RefreshTokenCacheItem
                        NamespaceIndex = 577, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        StableNameIndex = 677, // RefreshTokenCacheItem
                        StableNameNamespaceIndex = 577, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        TopLevelElementNameIndex = 677, // RefreshTokenCacheItem
                        TopLevelElementNamespaceIndex = 577, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Cache
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.RefreshTokenCacheItem, Microsoft.Identity.Client, Version=1.1.0.0, Cult" +
                                    "ure=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Cache.RefreshTokenCacheItem, Microsoft.Identity.Client, Version=1.1.0.0, Cult" +
                                    "ure=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 102,
                    ContractNamespacesListIndex = 111,
                    MemberNamesListIndex = 114,
                    MemberNamespacesListIndex = 123,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 744, // KeyValueOfstringArrayOfstringty7Ep6D1
                        NamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 744, // KeyValueOfstringArrayOfstringty7Ep6D1
                        StableNameNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 744, // KeyValueOfstringArrayOfstringty7Ep6D1
                        TopLevelElementNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.1.1.0, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 132,
                    ContractNamespacesListIndex = 135,
                    MemberNamesListIndex = 137,
                    MemberNamespacesListIndex = 140,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 796, // KeyValuePairOfstringArrayOfstringty7Ep6D1
                        NamespaceIndex = 406, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 796, // KeyValuePairOfstringArrayOfstringty7Ep6D1
                        StableNameNamespaceIndex = 406, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 796, // KeyValuePairOfstringArrayOfstringty7Ep6D1
                        TopLevelElementNamespaceIndex = 406, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    ChildElementNamespacesListIndex = 143,
                    ContractNamespacesListIndex = 146,
                    MemberNamesListIndex = 148,
                    MemberNamespacesListIndex = 151,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 838, // ClientInfo
                        NamespaceIndex = 481, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 838, // ClientInfo
                        StableNameNamespaceIndex = 481, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 838, // ClientInfo
                        TopLevelElementNamespaceIndex = 481, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.ClientInfo, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.ClientInfo, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 154,
                    ContractNamespacesListIndex = 157,
                    MemberNamesListIndex = 159,
                    MemberNamespacesListIndex = 162,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 849, // TokenResponse
                        NamespaceIndex = 863, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2
                        StableNameIndex = 849, // TokenResponse
                        StableNameNamespaceIndex = 863, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2
                        TopLevelElementNameIndex = 849, // TokenResponse
                        TopLevelElementNamespaceIndex = 863, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.OAuth2.TokenResponse, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neu" +
                                    "tral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.OAuth2.TokenResponse, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neu" +
                                    "tral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 165,
                    ContractNamespacesListIndex = 178,
                    MemberNamesListIndex = 181,
                    MemberNamespacesListIndex = 194,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 945, // OAuth2ResponseBase
                        NamespaceIndex = 863, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2
                        StableNameIndex = 945, // OAuth2ResponseBase
                        StableNameNamespaceIndex = 863, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2
                        TopLevelElementNameIndex = 945, // OAuth2ResponseBase
                        TopLevelElementNamespaceIndex = 863, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.OAuth2
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.OAuth2.OAuth2ResponseBase, Microsoft.Identity.Client, Version=1.1.0.0, Cultur" +
                                    "e=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.OAuth2.OAuth2ResponseBase, Microsoft.Identity.Client, Version=1.1.0.0, Cultur" +
                                    "e=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 207,
                    ContractNamespacesListIndex = 213,
                    MemberNamesListIndex = 215,
                    MemberNamespacesListIndex = 221,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 964, // AdfsWebFingerResponse
                        NamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 964, // AdfsWebFingerResponse
                        StableNameNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 964, // AdfsWebFingerResponse
                        TopLevelElementNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.AdfsWebFingerResponse, Microsoft.Identity.Client, Version=1.1.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.AdfsWebFingerResponse, Microsoft.Identity.Client, Version=1.1.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 227,
                    ContractNamespacesListIndex = 235,
                    MemberNamesListIndex = 238,
                    MemberNamespacesListIndex = 246,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1083, // links
                        NamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 1083, // links
                        StableNameNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 1083, // links
                        TopLevelElementNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neutr" +
                                    "al, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neutr" +
                                    "al, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 254,
                    ContractNamespacesListIndex = 257,
                    MemberNamesListIndex = 259,
                    MemberNamespacesListIndex = 262,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1089, // TenantDiscoveryResponse
                        NamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 1089, // TenantDiscoveryResponse
                        StableNameNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 1089, // TenantDiscoveryResponse
                        TopLevelElementNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.TenantDiscoveryResponse, Microsoft.Identity.Client, Version=1.1.0.0," +
                                    " Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.TenantDiscoveryResponse, Microsoft.Identity.Client, Version=1.1.0.0," +
                                    " Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 265,
                    ContractNamespacesListIndex = 274,
                    MemberNamesListIndex = 277,
                    MemberNamespacesListIndex = 286,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1113, // InstanceDiscoveryResponse
                        NamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 1113, // InstanceDiscoveryResponse
                        StableNameNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 1113, // InstanceDiscoveryResponse
                        TopLevelElementNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.InstanceDiscoveryResponse, Microsoft.Identity.Client, Version=1.1.0." +
                                    "0, Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.InstanceDiscoveryResponse, Microsoft.Identity.Client, Version=1.1.0." +
                                    "0, Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 295,
                    ContractNamespacesListIndex = 302,
                    MemberNamesListIndex = 305,
                    MemberNamespacesListIndex = 312,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1139, // DrsMetadataResponse
                        NamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 1139, // DrsMetadataResponse
                        StableNameNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 1139, // DrsMetadataResponse
                        TopLevelElementNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.DrsMetadataResponse, Microsoft.Identity.Client, Version=1.1.0.0, Cul" +
                                    "ture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.DrsMetadataResponse, Microsoft.Identity.Client, Version=1.1.0.0, Cul" +
                                    "ture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 319,
                    ContractNamespacesListIndex = 326,
                    MemberNamesListIndex = 329,
                    MemberNamespacesListIndex = 336,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1159, // IdentityProviderService
                        NamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 1159, // IdentityProviderService
                        StableNameNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 1159, // IdentityProviderService
                        TopLevelElementNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.IdentityProviderService, Microsoft.Identity.Client, Version=1.1.0.0," +
                                    " Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.IdentityProviderService, Microsoft.Identity.Client, Version=1.1.0.0," +
                                    " Culture=neutral, PublicKeyToken=0a613f4dd989e8ae")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 343,
                    ContractNamespacesListIndex = 345,
                    MemberNamesListIndex = 347,
                    MemberNamespacesListIndex = 349,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=6
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 255, // ArrayOfKeyValueOfstringanyType
                        NamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 255, // ArrayOfKeyValueOfstringanyType
                        StableNameNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 255, // ArrayOfKeyValueOfstringanyType
                        TopLevelElementNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IDictionary`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type0.ReadArrayOfKeyValueOfstringanyTypeFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type1.WriteArrayOfKeyValueOfstringanyTypeToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type2.ReadArrayOfKeyValueOfstringanyTypeFromXmlIsGetOnly),
                    CollectionItemNameIndex = 344, // KeyValueOfstringanyType
                    KeyNameIndex = 368, // Key
                    ItemNameIndex = 344, // KeyValueOfstringanyType
                    ValueNameIndex = 372, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 699, // ArrayOfKeyValueOfstringArrayOfstringty7Ep6D1
                        NamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 699, // ArrayOfKeyValueOfstringArrayOfstringty7Ep6D1
                        StableNameNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 699, // ArrayOfKeyValueOfstringArrayOfstringty7Ep6D1
                        TopLevelElementNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 744, // KeyValueOfstringArrayOfstringty7Ep6D1
                    KeyNameIndex = 368, // Key
                    ItemNameIndex = 744, // KeyValueOfstringArrayOfstringty7Ep6D1
                    ValueNameIndex = 372, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 782, // ArrayOfstring
                        NamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 782, // ArrayOfstring
                        StableNameNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 782, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericEnumerable,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 782, // ArrayOfstring
                        NamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 782, // ArrayOfstring
                        StableNameNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 782, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1070, // ArrayOflinks
                        NamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        StableNameIndex = 1070, // ArrayOflinks
                        StableNameNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        TopLevelElementNameIndex = 1070, // ArrayOflinks
                        TopLevelElementNamespaceIndex = 986, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal.Instance
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neutral, PublicKeyToken=0a613f4dd989e8ae]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neutral, PublicKeyToken=0a613f4dd989e8ae]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 1083, // links
                    KeyNameIndex = -1,
                    ItemNameIndex = 1083, // links
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.Instance.LinksList, Microsoft.Identity.Client, Version=1.1.0.0, Culture=neutr" +
                                "al, PublicKeyToken=0a613f4dd989e8ae")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1183, // ArrayOfanyType
                        NamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1183, // ArrayOfanyType
                        StableNameNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1183, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 286, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static readonly byte[] s_jsonDelegatesList_Hashtable = null;
        // Count=20
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 42,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type10.WriteIdTokenToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type9.ReadIdTokenFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type14.WriteAccessTokenCacheItemToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type13.ReadAccessTokenCacheItemFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type18.WriteBaseTokenCacheItemToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type17.ReadBaseTokenCacheItemFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type22.WriteRefreshTokenCacheItemToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type21.ReadRefreshTokenCacheItemFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type27.WriteArrayOfKeyValueOfstringArrayOfstringty7Ep6D1ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type26.ReadArrayOfKeyValueOfstringArrayOfstringty7Ep6D1FromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type28.ReadArrayOfKeyValueOfstringArrayOfstringty7Ep6D1FromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type32.WriteKeyValueOfstringArrayOfstringty7Ep6D1ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type31.ReadKeyValueOfstringArrayOfstringty7Ep6D1FromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 49,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type36.WriteArrayOfstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type35.ReadArrayOfstringFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type40.WriteKeyValuePairOfstringArrayOfstringty7Ep6D1ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type39.ReadKeyValuePairOfstringArrayOfstringty7Ep6D1FromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type44.WriteClientInfoToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type43.ReadClientInfoFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 53,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type48.WriteTokenResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type47.ReadTokenResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 54,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type52.WriteOAuth2ResponseBaseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type51.ReadOAuth2ResponseBaseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 55,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type57.WriteArrayOfstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type56.ReadArrayOfstringFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type58.ReadArrayOfstringFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 56,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type62.WriteAdfsWebFingerResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type61.ReadAdfsWebFingerResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 57,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type67.WriteArrayOflinksToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type66.ReadArrayOflinksFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type68.ReadArrayOflinksFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 58,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type72.WritelinksToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type71.ReadlinksFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 59,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type76.WriteTenantDiscoveryResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type75.ReadTenantDiscoveryResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 60,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type80.WriteInstanceDiscoveryResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type79.ReadInstanceDiscoveryResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 61,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type84.WriteDrsMetadataResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type83.ReadDrsMetadataResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 62,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type88.WriteIdentityProviderServiceToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type87.ReadIdentityProviderServiceFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 63,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type93.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type92.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type94.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','A','r','r','a','y','O','f','K','e','y','V','a','l','u','e',
            'O','f','s','t','r','i','n','g','a','n','y','T','y','p','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s',
            '.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i',
            'z','a','t','i','o','n','/','A','r','r','a','y','s','\0','K','e','y','V','a','l','u','e','O','f','s','t','r','i','n','g',
            'a','n','y','T','y','p','e','\0','K','e','y','\0','V','a','l','u','e','\0','K','e','y','V','a','l','u','e','P','a','i','r',
            'O','f','s','t','r','i','n','g','a','n','y','T','y','p','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s',
            '.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','S','y','s','t',
            'e','m','.','C','o','l','l','e','c','t','i','o','n','s','.','G','e','n','e','r','i','c','\0','I','d','T','o','k','e','n',
            '\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o',
            'r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','I','d','e','n','t','i','t','y','.',
            'C','l','i','e','n','t','.','I','n','t','e','r','n','a','l','\0','A','c','c','e','s','s','T','o','k','e','n','C','a','c',
            'h','e','I','t','e','m','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t',
            'r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','I','d','e',
            'n','t','i','t','y','.','C','l','i','e','n','t','.','I','n','t','e','r','n','a','l','.','C','a','c','h','e','\0','B','a',
            's','e','T','o','k','e','n','C','a','c','h','e','I','t','e','m','\0','R','e','f','r','e','s','h','T','o','k','e','n','C',
            'a','c','h','e','I','t','e','m','\0','A','r','r','a','y','O','f','K','e','y','V','a','l','u','e','O','f','s','t','r','i',
            'n','g','A','r','r','a','y','O','f','s','t','r','i','n','g','t','y','7','E','p','6','D','1','\0','K','e','y','V','a','l',
            'u','e','O','f','s','t','r','i','n','g','A','r','r','a','y','O','f','s','t','r','i','n','g','t','y','7','E','p','6','D',
            '1','\0','A','r','r','a','y','O','f','s','t','r','i','n','g','\0','K','e','y','V','a','l','u','e','P','a','i','r','O','f',
            's','t','r','i','n','g','A','r','r','a','y','O','f','s','t','r','i','n','g','t','y','7','E','p','6','D','1','\0','C','l',
            'i','e','n','t','I','n','f','o','\0','T','o','k','e','n','R','e','s','p','o','n','s','e','\0','h','t','t','p',':','/','/',
            's','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/',
            '0','7','/','M','i','c','r','o','s','o','f','t','.','I','d','e','n','t','i','t','y','.','C','l','i','e','n','t','.','I',
            'n','t','e','r','n','a','l','.','O','A','u','t','h','2','\0','O','A','u','t','h','2','R','e','s','p','o','n','s','e','B',
            'a','s','e','\0','A','d','f','s','W','e','b','F','i','n','g','e','r','R','e','s','p','o','n','s','e','\0','h','t','t','p',
            ':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0',
            '0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','I','d','e','n','t','i','t','y','.','C','l','i','e','n',
            't','.','I','n','t','e','r','n','a','l','.','I','n','s','t','a','n','c','e','\0','A','r','r','a','y','O','f','l','i','n',
            'k','s','\0','l','i','n','k','s','\0','T','e','n','a','n','t','D','i','s','c','o','v','e','r','y','R','e','s','p','o','n',
            's','e','\0','I','n','s','t','a','n','c','e','D','i','s','c','o','v','e','r','y','R','e','s','p','o','n','s','e','\0','D',
            'r','s','M','e','t','a','d','a','t','a','R','e','s','p','o','n','s','e','\0','I','d','e','n','t','i','t','y','P','r','o',
            'v','i','d','e','r','S','e','r','v','i','c','e','\0','A','r','r','a','y','O','f','a','n','y','T','y','p','e','\0','k','e',
            'y','\0','v','a','l','u','e','\0','h','o','m','e','_','o','i','d','\0','i','s','s','\0','n','a','m','e','\0','o','i','d','\0',
            'p','r','e','f','e','r','r','e','d','_','u','s','e','r','n','a','m','e','\0','s','u','b','\0','t','i','d','\0','v','e','r',
            '\0','c','l','i','e','n','t','_','i','d','\0','c','l','i','e','n','t','_','i','n','f','o','\0','a','c','c','e','s','s','_',
            't','o','k','e','n','\0','a','u','t','h','o','r','i','t','y','\0','e','x','p','i','r','e','s','_','o','n','\0','i','d','_',
            't','o','k','e','n','\0','s','c','o','p','e','\0','t','o','k','e','n','_','t','y','p','e','\0','u','s','e','r','_','a','s',
            's','e','r','t','i','o','n','_','h','a','s','h','\0','d','i','s','p','l','a','y','a','b','l','e','_','i','d','\0','e','n',
            'v','i','r','o','n','m','e','n','t','\0','i','d','e','n','t','i','t','y','_','p','r','o','v','i','d','e','r','\0','r','e',
            'f','r','e','s','h','_','t','o','k','e','n','\0','u','i','d','\0','u','t','i','d','\0','c','l','a','i','m','s','\0','c','o',
            'r','r','e','l','a','t','i','o','n','_','i','d','\0','e','r','r','o','r','\0','e','r','r','o','r','_','c','o','d','e','s',
            '\0','e','r','r','o','r','_','d','e','s','c','r','i','p','t','i','o','n','\0','e','x','p','i','r','e','s','_','i','n','\0',
            's','u','b','j','e','c','t','\0','h','r','e','f','\0','r','e','l','\0','a','u','t','h','o','r','i','z','a','t','i','o','n',
            '_','e','n','d','p','o','i','n','t','\0','i','s','s','u','e','r','\0','t','o','k','e','n','_','e','n','d','p','o','i','n',
            't','\0','t','e','n','a','n','t','_','d','i','s','c','o','v','e','r','y','_','e','n','d','p','o','i','n','t','\0','P','a',
            's','s','i','v','e','A','u','t','h','E','n','d','p','o','i','n','t','\0'};
    }
}
