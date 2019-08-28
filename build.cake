var target = Argument("target", "Default");

var mySetting = Argument("performance", false);


Task("Default")
  .Does(() =>
{
	Information($"Performance: {mySetting}");
	DotNetCoreBuild("./source/CarRentify.sln");
	//DotNetCorePack("./src/*");
});

RunTarget(target);