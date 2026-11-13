namespace Vex.Database.Services.Adapters;

internal partial class VexAdapter
{
    public async Task<T> InsertAsync<T>(T t) where T : class
    {
        await context.AddAsync(t);

        await context.SaveChangesAsync();

        return t;
    }
}
