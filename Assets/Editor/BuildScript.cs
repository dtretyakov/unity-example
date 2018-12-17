public class BuildScript {

    [MenuItem("Build Android")]
    public static void BuildAndroid()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.target = BuildTarget.Android;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
	
	[MenuItem("Build Windows")]
    public static void BuildWindows()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.target = BuildTarget.StandaloneWindows;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}