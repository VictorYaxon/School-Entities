Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations

    Public Class OnsiteCourseService
        Implements IOnlineCourseService

        Public Function GetAllOnlineCourses() As IQueryable(Of OnlineCourse) Implements IOnlineCourseService.GetAllOnlineCourses
            Return DataContext.DBEntities.OnsiteCourses
        End Function
    End Class

End Namespace




