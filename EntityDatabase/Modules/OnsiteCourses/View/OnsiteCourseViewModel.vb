﻿Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel

Namespace Modules.OnsiteCourses.ViewModel
    Public Class OnsiteCourseViewModel
        Inherits ViewModelBase

        Private _OnsiteCourses As ObservableCollection(Of OnsiteCourse)
        Private dataAccess As IOnsiteCourseService

        Public Property OnsiteCourses As ObservableCollection(Of OnsiteCourse)
            Get
                Return Me._OnsiteCourses
            End Get
            Set(value As ObservableCollection(Of OnsiteCourse))
                Me._OnsiteCourses = value
                OnPropertyChanged("OnsiteCourses")
            End Set
        End Property

        Private Function GetAllOnsiteCourses() As IQueryable(Of OnsiteCourse)
            Return Me.dataAccess.GetAllOnsiteCourses
        End Function

        Sub New()

            Me._OnsiteCourses = New ObservableCollection(Of OnsiteCourse)

            ServiceLocator.RegisterService(Of IOnsiteCourseService)(New OnsiteCourseService)

            Me.dataAccess = GetService(Of IOnsiteCourseService)()

            For Each element In Me.GetAllOnsiteCourses
                Me._OnsiteCourses.Add(element)
            Next
        End Sub
    End Class
End Namespace