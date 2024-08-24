# TODO: Write better version of this
dotnet build -c Release
SqlPackage /Action:Publish /SourceFile:"bin\release\Spokesoft.Clobberfest.Database.dacpac" /TargetConnectionString:"Data Source=localhost;Database=Clobberfest_Development;Integrated Security=sspi;Encrypt=true;TrustServerCertificate=true;"
