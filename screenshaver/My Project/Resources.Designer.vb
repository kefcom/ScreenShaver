﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("screenshaver.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!DOCTYPE HTML&gt;
        '''&lt;html&gt;
        '''&lt;head&gt;
        '''&lt;meta http-equiv=&quot;Content-Type&quot; content=&quot;text/html; charset=UTF-8&quot;&gt;
        '''&lt;title&gt;jSlots Slot Machine - Matthew Lein&lt;/title&gt;
        '''
        '''
        '''&lt;link href=&apos;http://fonts.googleapis.com/css?family=Gravitas+One&amp;text=1234567&apos; rel=&apos;stylesheet&apos; type=&apos;text/css&apos;&gt;
        '''
        '''&lt;style type=&quot;text/css&quot;&gt;
        '''    	html, body {
        '''    		height: 100%;
        '''    		margin: 0;
        '''    	}
        '''
        '''ul {
        '''    padding: 0;
        '''    margin: 0;
        '''    list-style: none;
        '''}
        '''
        '''.jSlots-wrapper {
        '''    overflow: hidden;
        '''    height: 100%;
        '''    width: 100%; /* to size correctly, can  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property fancy() As String
            Get
                Return ResourceManager.GetString("fancy", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to By default, the Webbrowser control uses IE7 emulation.
        '''
        '''This describes how it works: http://msdn.microsoft.com/en-us/library/ie/ee330730%28v=vs.85%29.aspx#browser_emulation
        '''
        '''What you need to do is add a new DWord value to these keys with the name of your .exe and give it the value of the browser version you want to emulate:
        '''
        '''
        '''HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION
        '''
        '''HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureContr [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property website_not_showing_correctly() As String
            Get
                Return ResourceManager.GetString("website_not_showing_correctly", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
