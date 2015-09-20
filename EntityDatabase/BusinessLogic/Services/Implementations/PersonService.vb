Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations

    Public Class PersonService
        Implements IPersonsService

        Public Function GetAllpersons() As IQueryable(Of Person) Implements IPersonsService.GetAllpersons
            Return DataContext.DBEntities.persons
        End Function
    End Class

End Namespace


