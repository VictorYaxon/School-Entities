Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel

Namespace Modules.StudentGrades.ViewModel
    Public Class StudentGradeViewModel
        Inherits ViewModelBase

        Private _StudentGrades As ObservableCollection(Of StudentGrade)
        Private dataAccess As IStudentGradeService

        Public Property StudentGrades As ObservableCollection(Of StudentGrade)
            Get
                Return Me._StudentGrades
            End Get
            Set(value As ObservableCollection(Of StudentGrade))
                Me._StudentGrades = value
                OnPropertyChanged("StudentGrades")
            End Set
        End Property

        Private Function GetAllStudentGrades() As IQueryable(Of StudentGrade)
            Return Me.dataAccess.GetAllStudentGrades
        End Function

        Sub New()

            Me._StudentGrades = New ObservableCollection(Of StudentGrade)

            ServiceLocator.RegisterService(Of IStudentGradeService)(New StudentGrade)

            Me.dataAccess = GetService(Of IStudentGradeService)()

            For Each element In Me.GetAllStudentGrades
                Me._StudentGrades.Add(element)
            Next
        End Sub
    End Class
End Namespace
