param (
	[Parameter(Mandatory=$False)]
    [string]$UmbracoLicensesPath = "C:\UmbracoLicenses\*"
)

$octopusActionName = $OctopusParameters["Octopus.Action.Name"]
$destination = $OctopusParameters["Octopus.Action[" + $octopusActionName + "].Output.Package.InstallationDirectoryPath"]

Copy-Item -Path $UmbracoLicensesPath -Destination $destination -Recurse -Force -Verbose