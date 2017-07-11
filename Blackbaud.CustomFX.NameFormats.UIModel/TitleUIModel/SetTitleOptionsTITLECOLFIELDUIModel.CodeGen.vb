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
''' Represents the UI model for the 'SetTitleOptionsTITLECOLFIELD' data form
''' </summary>
Partial Public Class [SetTitleOptionsTITLECOLFIELDUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.UIModel

#Region "Enums"

    ''' <summary>
    ''' Enumerated values for use with the GENDER property
    ''' </summary>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.165.0")> _
    Public Enum GENDERS As Integer
        [Unisex] = 0
        [Male] = 1
        [Female] = 2
    End Enum

#End Region

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _titlecodeid As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
    Private WithEvents _isspecial As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
    Private WithEvents _ismarital As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
    Private WithEvents _isreligious As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
    Private WithEvents _gender As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of GENDERS))

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.165.0")> _
    Public Sub New()
        MyBase.New()

        _titlecodeid = New Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        _isspecial = New Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        _ismarital = New Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        _isreligious = New Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        _gender = New Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of GENDERS))

        '
        '_titlecodeid
        '
        _titlecodeid.Name = "TITLECODEID"
        _titlecodeid.Caption = "Title"
        _titlecodeid.CodeTableName = "TITLECODE"
        _titlecodeid.IncludeInactive = True
        Me.Fields.Add(_titlecodeid)
        '
        '_isspecial
        '
        _isspecial.Name = "ISSPECIAL"
        _isspecial.Caption = "Is Title Special? (Dr.)"
        Me.Fields.Add(_isspecial)
        '
        '_ismarital
        '
        _ismarital.Name = "ISMARITAL"
        _ismarital.Caption = "Treat As Unmarried? (Mrs.)"
        Me.Fields.Add(_ismarital)
        '
        '_isreligious
        '
        _isreligious.Name = "ISRELIGIOUS"
        _isreligious.Caption = "Is Title Religious? (Fr.)"
        Me.Fields.Add(_isreligious)
        '
        '_gender
        '
        _gender.Name = "GENDER"
        _gender.Caption = "Gender Of Title"
        _gender.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of GENDERS)) With {.Value = GENDERS.[Unisex], .Translation = "Unisex"})
        _gender.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of GENDERS)) With {.Value = GENDERS.[Male], .Translation = "Male"})
        _gender.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of GENDERS)) With {.Value = GENDERS.[Female], .Translation = "Female"})
        Me.Fields.Add(_gender)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Title
    ''' </summary>
    <System.ComponentModel.Description("Title")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.165.0")> _
    Public ReadOnly Property [TITLECODEID]() As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        Get
            Return _titlecodeid
        End Get
    End Property
    
    ''' <summary>
    ''' Is Title Special? (Dr.)
    ''' </summary>
    <System.ComponentModel.Description("Is Title Special? (Dr.)")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.165.0")> _
    Public ReadOnly Property [ISSPECIAL]() As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        Get
            Return _isspecial
        End Get
    End Property
    
    ''' <summary>
    ''' Treat As Unmarried? (Mrs.)
    ''' </summary>
    <System.ComponentModel.Description("Treat As Unmarried? (Mrs.)")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.165.0")> _
    Public ReadOnly Property [ISMARITAL]() As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        Get
            Return _ismarital
        End Get
    End Property
    
    ''' <summary>
    ''' Is Title Religious? (Fr.)
    ''' </summary>
    <System.ComponentModel.Description("Is Title Religious? (Fr.)")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.165.0")> _
    Public ReadOnly Property [ISRELIGIOUS]() As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        Get
            Return _isreligious
        End Get
    End Property
    
    ''' <summary>
    ''' Gender Of Title
    ''' </summary>
    <System.ComponentModel.Description("Gender Of Title")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.165.0")> _
    Public ReadOnly Property [GENDER]() As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of GENDERS))
        Get
            Return _gender
        End Get
    End Property
    
End Class
