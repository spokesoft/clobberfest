$ConnectionString = "Data Source=localhost;Database=Clobberfest_Development;Integrated Security=sspi;Encrypt=true;TrustServerCertificate=true;";
$ContextDir = Resolve-Path "./Contexts"
$AuthModelsDir = Resolve-Path "./Models/Auth"
$BlogModelsDir = Resolve-Path "./Models/Blog"
$GameModelsDir = Resolve-Path "./Models/Game"
$WikiModelsDir = Resolve-Path "./Models/Wiki"

dotnet ef dbcontext scaffold $ConnectionString Microsoft.EntityFrameworkCore.SqlServer -d -c AuthDbContext --context-dir $ContextDir -f -o $AuthModelsDir --schema Auth
dotnet ef dbcontext scaffold $ConnectionString Microsoft.EntityFrameworkCore.SqlServer -d -c BlogDbContext --context-dir $ContextDir -f -o $BlogModelsDir --schema Blog
dotnet ef dbcontext scaffold $ConnectionString Microsoft.EntityFrameworkCore.SqlServer -d -c GameDbContext --context-dir $ContextDir -f -o $GameModelsDir --schema Game
dotnet ef dbcontext scaffold $ConnectionString Microsoft.EntityFrameworkCore.SqlServer -d -c WikiDbContext --context-dir $ContextDir -f -o $WikiModelsDir --schema Wiki