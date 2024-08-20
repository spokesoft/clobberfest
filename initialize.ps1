$SolutionRoot = Resolve-Path "./"
$Vendor = "Spokesoft"
$Project = "Clobberfest"
$CommonProject = "$Vendor.$Project.Common"
$ConsoleProject = "$Vendor.$Project.Console"
$DataProject = "$Vendor.$Project.Data"
$DatabaseProject = "$Vendor.$Project.Database"
$RestProject = "$Vendor.$Project.Rest"
$WebProject = "$Vendor.$Project.Web"

# dotnet new sln --name "$Vendor.$Project" --force

# if (Test-Path "src/client") { Remove-Item -Path "src/client" -Recurse -Force }
# # if (Test-Path "src/codegen") { Remove-Item -Path "src/codegen" -Recurse -Force }
# if (Test-Path "src/common") { Remove-Item -Path "src/common" -Recurse -Force }
# if (Test-Path "src/console") { Remove-Item -Path "src/console" -Recurse -Force }
# if (Test-Path "src/data") { Remove-Item -Path "src/data" -Recurse -Force }
# if (Test-Path "src/database") { Remove-Item -Path "src/database" -Recurse -Force }
# if (Test-Path "src/rest") { Remove-Item -Path "src/rest" -Recurse -Force }
# if (Test-Path "src/services") { Remove-Item -Path "src/services" -Recurse -Force }
# if (Test-Path "src/web") { Remove-Item -Path "src/web" -Recurse -Force }

# New-Item -Path "$SolutionRoot\src\Client\README.md" -ItemType File -Value "### Client Project" -Force
# # New-Item -Path "$SolutionRoot\src\Codegen\README.md" -ItemType File -Value "## Whisper Codegen Project" -Force
# New-Item -Path "$SolutionRoot\src\Common\README.md" -ItemType File -Value "## Whisper Common Project" -Force
# New-Item -Path "$SolutionRoot\src\Console\README.md" -ItemType File -Value "## Whisper Console Project" -Force
# New-Item -Path "$SolutionRoot\src\Data\README.md" -ItemType File -Value "## Whisper Data Project" -Force
# New-Item -Path "$SolutionRoot\src\Database\README.md" -ItemType File -Value "## Whisper Database Project" -Force
# New-Item -Path "$SolutionRoot\src\Rest\README.md" -ItemType File -Value "## Whisper Rest Project" -Force
# New-Item -Path "$SolutionRoot\src\Services\README.md" -ItemType File -Value "## Whisper Services" -Force
# New-Item -Path "$SolutionRoot\src\Services\src\Abyss\README.md" -ItemType File -Value "## Whisper Services: Abyss" -Force
# New-Item -Path "$SolutionRoot\src\Services\src\Atlas\README.md" -ItemType File -Value "## Whisper Services: Atlas" -Force
# New-Item -Path "$SolutionRoot\src\Services\src\Forge\README.md" -ItemType File -Value "## Whisper Services: Forge" -Force
# New-Item -Path "$SolutionRoot\src\Services\src\Horn\README.md" -ItemType File -Value "## Whisper Services: Horn" -Force
# New-Item -Path "$SolutionRoot\src\Services\src\Warstrike\README.md" -ItemType File -Value "## Whisper Services: Warstrike" -Force
# New-Item -Path "$SolutionRoot\src\Web\README.md" -ItemType File -Value "## Whisper Web Project" -Force

# dotnet new classlib --name $CommonProject --output "src/common"
# dotnet new console --name $ConsoleProject --output "src/console"
# dotnet new classlib --name $DataProject --output "src/data"
# dotnet new sqlproj --name $DatabaseProject --output "src/database" --force
# dotnet new webapi --name $RestProject --output "src/rest"
# dotnet new mvc --name $WebProject --output "src/web"

# if (Test-Path "src/common/Class1.cs") { Remove-Item -Path "src/common/Class1.cs" -Recurse -Force }
# if (Test-Path "src/data/Class1.cs") { Remove-Item -Path "src/data/Class1.cs" -Recurse -Force }

# dotnet new grpc --name "$Vendor.$Project.Services.Abyss" --output "src/services/src/Abyss"
# dotnet new grpc --name "$Vendor.$Project.Services.Atlas" --output "src/services/src/Atlas"
# dotnet new grpc --name "$Vendor.$Project.Services.Forge" --output "src/services/src/Forge"
# dotnet new grpc --name "$Vendor.$Project.Services.Horn" --output "src/services/src/Horn"
# dotnet new grpc --name "$Vendor.$Project.Services.Warstrike" --output "src/services/src/Warstrike"

# dotnet sln add "src/common"
# dotnet sln add "src/console"
# dotnet sln add "src/data"
# dotnet sln add "src/database"
# dotnet sln add "src/rest"
# dotnet sln add "src/web"
# dotnet sln add "src/services/src/Abyss"
# dotnet sln add "src/services/src/Atlas"
# dotnet sln add "src/services/src/Forge"
# dotnet sln add "src/services/src/Horn"
# dotnet sln add "src/services/src/Warstrike"

# mkdir "src/Client"
# mkdir "src/Client/src"
# mkdir "src/Client/src/images"
# mkdir "src/Client/src/models"
# mkdir "src/Client/src/styles"

# try {
#     cd "src/client"
#     npm init -y
# } catch {
#     Write-Error "npm init failed"
# } finally {
#     cd $CurrentPath
# }

