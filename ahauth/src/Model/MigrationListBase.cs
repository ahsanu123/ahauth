using Ahauth.Builder.Application;
using Ahauth.Function;
using FluentMigrator;

namespace Ahauth.Model;

public class MigrationListBase : MigrationBase
{
    private List<Type> listModel = new List<Type> { };

    public static List<string> listExcludedType = new List<string> { nameof(System.Collections) };

    public void MigrationDown(Migration migration)
    {
        this.listModel.ForEach((type) => migration.DeleteTableIfExists(type));
    }

    public void MigrationUp(Migration migration)
    {
        this.listModel.ForEach((type) => migration.ConvertModelToMigration(type, listExcludedType));
    }

    public void GenerateForeignKey(Migration migration)
    {
        this.listModel.ForEach((type) => migration.GenerateForeignKey(type));
    }
}
