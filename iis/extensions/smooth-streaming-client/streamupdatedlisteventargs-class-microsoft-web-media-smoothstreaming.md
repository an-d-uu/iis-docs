---
title: StreamUpdatedListEventArgs Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StreamUpdatedListEventArgs Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streamupdatedlisteventargs(v=VS.90)
ms:contentKeyID: 31469191
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StreamUpdatedListEventArgs Class

A list of [StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md).

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  [System. . :: . .EventArgs](https://msdn.microsoft.com/en-us/library/118wxtk3\(v=vs.90\))  
    [System.ComponentModel. . :: . .AsyncCompletedEventArgs](https://msdn.microsoft.com/en-us/library/2tde67e9\(v=vs.90\))  
      Microsoft.Web.Media.SmoothStreaming..::..StreamUpdatedListEventArgs  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Class StreamUpdatedListEventArgs _
    Inherits AsyncCompletedEventArgs
'Usage

  Dim instance As StreamUpdatedListEventArgs
```

``` csharp
  public class StreamUpdatedListEventArgs : AsyncCompletedEventArgs
```

``` c++
  public ref class StreamUpdatedListEventArgs : public AsyncCompletedEventArgs
```

``` jscript
  public class StreamUpdatedListEventArgs extends AsyncCompletedEventArgs
```

The StreamUpdatedListEventArgs type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[StreamUpdatedListEventArgs(Exception, Object)](streamupdatedlisteventargs-constructor-exception-object-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the StreamUpdatedListEventArgs class.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[StreamUpdatedListEventArgs(List< (Of < <' (StreamUpdatedEventArgs> ) > > ), Object)](streamupdatedlisteventargs-constructor-list-streamupdatedeventargs-object-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the StreamUpdatedListEventArgs class.|


Top

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Cancelled](https://msdn.microsoft.com/en-us/library/hhb0kte8(v=vs.90))|(Inherited from [AsyncCompletedEventArgs](https://msdn.microsoft.com/en-us/library/2tde67e9(v=vs.90)).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Error](https://msdn.microsoft.com/en-us/library/zye0z486(v=vs.90))|(Inherited from [AsyncCompletedEventArgs](https://msdn.microsoft.com/en-us/library/2tde67e9(v=vs.90)).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[StreamUpdatedEvents](streamupdatedlisteventargs-streamupdatedevents-property-microsoft-web-media-smoothstreaming_1.md)|Gets the list of stream updated events.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[UserState](https://msdn.microsoft.com/en-us/library/9b3wa0x3(v=vs.90))|(Inherited from [AsyncCompletedEventArgs](https://msdn.microsoft.com/en-us/library/2tde67e9(v=vs.90)).)|

Top

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Equals](https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Finalize](https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetHashCode](https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetType](https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[RaiseExceptionIfNecessary](https://msdn.microsoft.com/en-us/library/69w1sf5e(v=vs.90))|(Inherited from [AsyncCompletedEventArgs](https://msdn.microsoft.com/en-us/library/2tde67e9(v=vs.90)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ToString](https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|


Top

## Remarks

A single notification can convey a number of stream updates.

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
