﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18408
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Spike.Resources", GetType(Resources).Assembly)
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
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property about() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("about", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property analytics() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("analytics", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property closedeye() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("closedeye", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property counter() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("counter", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You can quickly add an item by double clicking it..
        '''</summary>
        Friend ReadOnly Property CounterTip1() As String
            Get
                Return ResourceManager.GetString("CounterTip1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You can edit the quantity of the item on the receipt.
        '''</summary>
        Friend ReadOnly Property CounterTip2() As String
            Get
                Return ResourceManager.GetString("CounterTip2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property dbSpike() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("dbSpike", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property dj() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("dj", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property DOTMATRI() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("DOTMATRI", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property edit() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("edit", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property employees() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("employees", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Failed.
        '''</summary>
        Friend ReadOnly Property Failed() As String
            Get
                Return ResourceManager.GetString("Failed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property imgError() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imgError", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property imgUserDefault() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imgUserDefault", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid quantity.
        '''</summary>
        Friend ReadOnly Property InvalidQuantity() As String
            Get
                Return ResourceManager.GetString("InvalidQuantity", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Failed to edit quantity.
        '''</summary>
        Friend ReadOnly Property InvalidQuantityTitle() As String
            Get
                Return ResourceManager.GetString("InvalidQuantityTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property inventory() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("inventory", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property kiosk() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("kiosk", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property openeye() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("openeye", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property paper() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("paper", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property question() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("question", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property questioncanvass() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("questioncanvass", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property samplefood() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("samplefood", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property sirbrent() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("sirbrent", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Spike is a POS software with a metro-based UI designed to work with a local database.  It offers different features such as Kiosk mode to display your products on screen, analytics, inventory system, and user management system. .
        '''</summary>
        Friend ReadOnly Property SpikeInfo() As String
            Get
                Return ResourceManager.GetString("SpikeInfo", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Password can&apos;t be empty.
        '''</summary>
        Friend ReadOnly Property StrEmptyPassword() As String
            Get
                Return ResourceManager.GetString("StrEmptyPassword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Username can&apos;t be empty.
        '''</summary>
        Friend ReadOnly Property StrEmptyUsername() As String
            Get
                Return ResourceManager.GetString("StrEmptyUsername", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Incorrect Password.
        '''</summary>
        Friend ReadOnly Property StrIncorrectPassword() As String
            Get
                Return ResourceManager.GetString("StrIncorrectPassword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Username not found.
        '''</summary>
        Friend ReadOnly Property StrUsernameNotFound() As String
            Get
                Return ResourceManager.GetString("StrUsernameNotFound", resourceCulture)
            End Get
        End Property
    End Module
End Namespace