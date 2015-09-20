Imports Modules.Courses.ViewModels
Imports Modules.Departments.ViewModels
Imports Modules.OfficeAssignmets.ViewModel
Imports Modules.OnlineCourses.ViewModel
Imports Modules.OnsiteCourses.ViewModel
Imports Modules.Persons.ViewModel
Imports Modules.StudentGrades.ViewModel
Class MainWindow
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DepartmenstUserControl.MainGrid.DataContext = New DepartmentsViewModel()

    End Sub

    

End Class
