Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim odbcLoggingSection As ConfigurationSection = config.GetSection("system.webServer/odbcLogging", "Default Web Site")
      odbcLoggingSection("dataSource") = "InternetDb"
      odbcLoggingSection("tableName") = "InternetLog"
      odbcLoggingSection("userName") = "InternetAdmin"
      odbcLoggingSection("password") = "P@ssw0rd"

      Dim sitesSection As ConfigurationSection = config.GetSection("system.applicationHost/sites")
      Dim sitesCollection As ConfigurationElementCollection = sitesSection.GetCollection
      Dim siteElement As ConfigurationElement = FindElement(sitesCollection, "site", "name", "Default Web Site")
      If (siteElement Is Nothing) Then
         Throw New InvalidOperationException("Element not found!")
      End If

      Dim logFileElement As ConfigurationElement = siteElement.GetChildElement("logFile")
      logFileElement("customLogPluginClsid") = "{FF16065B-DE82-11CF-BC0A-00AA006111E0}"
      logFileElement("logFormat") = "Custom"

      serverManager.CommitChanges()
   End Sub

   Private Function FindElement(ByVal collection As ConfigurationElementCollection, ByVal elementTagName As String, ByVal ParamArray keyValues() As String) As ConfigurationElement
      For Each element As ConfigurationElement In collection
         If String.Equals(element.ElementTagName, elementTagName, StringComparison.OrdinalIgnoreCase) Then
            Dim matches As Boolean = True
            Dim i As Integer
            For i = 0 To keyValues.Length - 1 Step 2
               Dim o As Object = element.GetAttributeValue(keyValues(i))
               Dim value As String = Nothing
               If (Not (o) Is Nothing) Then
                  value = o.ToString
               End If
               If Not String.Equals(value, keyValues((i + 1)), StringComparison.OrdinalIgnoreCase) Then
                  matches = False
                  Exit For
               End If
            Next
            If matches Then
               Return element
            End If
         End If
      Next
      Return Nothing
   End Function


End Module