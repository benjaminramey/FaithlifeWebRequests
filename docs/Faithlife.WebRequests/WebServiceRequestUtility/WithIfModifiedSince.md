# WebServiceRequestUtility.WithIfModifiedSince&lt;TWebServiceRequest&gt; method

Sets the IfModifiedSince of the WebServiceRequest.

```csharp
public static TWebServiceRequest WithIfModifiedSince<TWebServiceRequest>(
    this TWebServiceRequest request, DateTime? ifModifiedSince)
    where TWebServiceRequest : WebServiceRequestBase
```

| parameter | description |
| --- | --- |
| TWebServiceRequest | The type of the web service request. |
| request | The request. |
| ifModifiedSince | The ifModifiedSince. |

## Return Value

The request.

## See Also

* class [WebServiceRequestBase](../WebServiceRequestBase.md)
* class [WebServiceRequestUtility](../WebServiceRequestUtility.md)
* namespace [Faithlife.WebRequests](../../Faithlife.WebRequests.md)

<!-- DO NOT EDIT: generated by xmldocmd for Faithlife.WebRequests.dll -->
