Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations

    Public Class PersonService
        Implements IPersonsService

        Public Function GetAllperson() As IQueryable(Of Person) Implements IPersonsService.GetAllperson
            Return DataContext.DBEntities.People
        End Function
    End Class

End Namespace


