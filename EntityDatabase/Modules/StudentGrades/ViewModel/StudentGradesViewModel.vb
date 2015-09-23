﻿Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel

Namespace Modules.StudentGrades.ViewModel
    Public Class StudentGradesViewModel
        Inherits ViewModelBase

        Private _studentGrades As ObservableCollection(Of StudentGrade)
        Private dataAccess As IStudentGradeService

        Public Property StudentGrades As ObservableCollection(Of StudentGrade)
            Get
                Return Me._studentGrades
            End Get
            Set(value As ObservableCollection(Of StudentGrade))
                Me._studentGrades = value
                OnPropertyChanged("StudentGrades")
            End Set
        End Property

        ' Function to get all StudentGrades from service
        Private Function GetAllStudentGrades() As IQueryable(Of StudentGrade)
            Return Me.dataAccess.GetAllStudentGrades
        End Function

        Sub New()
            Me._studentGrades = New ObservableCollection(Of StudentGrade)
            ServiceLocator.RegisterService(Of IStudentGradeService)(New StudentGrade)
            Me.dataAccess = GetService(Of IStudentGradeService)()

            For Each element In Me.GetAllStudentGrades
                Me._studentGrades.Add(element)
            Next
        End Sub
    End Class
End Namespace