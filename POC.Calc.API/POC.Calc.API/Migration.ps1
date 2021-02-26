$MIGRATION_NAME = "InitialCreate"
$CONTEXT1 = "APIContext"
$CONTEXT2 = "APIContext2"

dotnet ef migrations add $MIGRATION_NAME --context $CONTEXT1
dotnet ef migrations add $MIGRATION_NAME --context $CONTEXT2

dotnet ef database update --context $CONTEXT1
dotnet ef database update --context $CONTEXT2