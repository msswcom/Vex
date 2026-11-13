namespace Vex.Models.Exceptions;

public class NotFoundException(string entity, string id)
    : Exception($"The requested {entity} with id {id} was not found in the database.")
{
}
