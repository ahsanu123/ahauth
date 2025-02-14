using FluentMigrator;

namespace Ahauth.Model;

public interface MigrationBase
{
    public abstract void MigrationUp(Migration migration);
    public abstract void MigrationDown(Migration migration);
    public abstract void GenerateForeignKey(Migration migration);
}
