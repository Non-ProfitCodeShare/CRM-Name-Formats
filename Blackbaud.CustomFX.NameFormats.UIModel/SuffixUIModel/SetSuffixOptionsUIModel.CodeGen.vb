﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  4.0.165.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Set Suffix Options' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Edit, "8722545d-bf8c-4254-8a03-b8f4ea760ab0", "1eece55d-5f1b-4fc1-a592-857b5055d0df", "", "http://localhost/BBInfinity/browser/htmlforms/custom/blackbaud.customfx.nameformats/SuffixUIModel/SetSuffixOptionsHelp.html")>
Partial Public Class [SetSuffixOptionsUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _suffixcolfield As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of SetSuffixOptionsSUFFIXCOLFIELDUIModel)

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.165.0")> _
    Public Sub New()
        MyBase.New()

        _suffixcolfield = New Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of SetSuffixOptionsSUFFIXCOLFIELDUIModel)

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Edit
        MyBase.DataFormTemplateId = New System.Guid("8722545d-bf8c-4254-8a03-b8f4ea760ab0")
        MyBase.DataFormInstanceId = New System.Guid("1eece55d-5f1b-4fc1-a592-857b5055d0df")
        MyBase.RecordType = ""
        MyBase.HelpKey = "http://localhost/BBInfinity/browser/htmlforms/custom/blackbaud.customfx.nameformats/SuffixUIModel/SetSuffixOptionsHelp.html"
        MyBase.FORMHEADER.Value = "Set Suffix Options"
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/blackbaud.customfx.nameformats/SetSuffixOptions.html"

        '
        '_suffixcolfield
        '
        _suffixcolfield.Name = "SUFFIXCOLFIELD"
        _suffixcolfield.Caption = "Suffix Collection"
        _suffixcolfield.EnablePaging = True
        _suffixcolfield.ItemsPerPage = 100
        Me.Fields.Add(_suffixcolfield)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Suffix Collection
    ''' </summary>
    <System.ComponentModel.Description("Suffix Collection")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.165.0")> _
    Public ReadOnly Property [SUFFIXCOLFIELD]() As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of SetSuffixOptionsSUFFIXCOLFIELDUIModel)
        Get
            Return _suffixcolfield
        End Get
    End Property
    
End Class
