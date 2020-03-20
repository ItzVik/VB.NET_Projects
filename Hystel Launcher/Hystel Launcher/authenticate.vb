Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization

Module authenticate
    Public Function Authenticate(ByRef username As String, ByRef password As String) As String

        Dim UUID As String = Guid.NewGuid.ToString()
        Dim Request As HttpWebRequest = DirectCast(WebRequest.Create("https://authserver.mojang.com/authenticate"), HttpWebRequest)
        Request.ContentType = "application/json"
        Request.Method = "POST"

        Using Writer = New StreamWriter(Request.GetRequestStream())

            Dim Json As String = ("{ 'agent': {'name': 'Minecraft', 'version': 1}, 'username': '" + username + "', 'password': '" + password + "', 'clientToken': '" + UUID + "', 'requestUser': true }").Replace("'", Chr(34))

            Writer.Write(Json)
            Writer.Flush()
            Writer.Close()

            Dim Response = DirectCast(Request.GetResponse(), HttpWebResponse)
            Using Reader = New StreamReader(Response.GetResponseStream())
                Return Reader.ReadToEnd()
            End Using

        End Using

    End Function

    Sub Main()

        Dim Response As String = Authenticate("username", "password")
        Dim Serializer As JavaScriptSerializer = New JavaScriptSerializer()

        Dim Dictionary As Dictionary(Of String, Object) = Serializer.Deserialize(Of Dictionary(Of String, Object))(Response)

        Dim AccessToken As String = Dictionary("accessToken")
        Dim ClientToken As String = Dictionary("clientToken")

        Console.WriteLine(AccessToken)
        Console.WriteLine(ClientToken)
        Console.Read()

    End Sub
    Public Sub LaunchMinecraft(ByRef AccessToken As String, ByRef ClientToken As String)

        Dim Xmx As String = "4G"
        Dim Xms As String = "2G"
        Dim Title As String = "My Minecraft Instance"
        Dim Version As String = "1.7.10"
        Dim AssetIndex As String = "..." ' AssetIndex obtained from mojang server
        Dim Username As String = "..." ' Minecraft username obtained from mojang server
        Dim Libraries As String = "..." ' Paths to all libraries separated by ;

        Dim JavaProcess As Process = New Process()
        JavaProcess.StartInfo.UseShellExecute = False
        JavaProcess.StartInfo.CreateNoWindow = False
        JavaProcess.StartInfo.FileName = "..." ' Path to javaw.exe or java.exe
        JavaProcess.StartInfo.Arguments = "-XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump" +
                                " -Xmx" + Xmx +
                                " -Xms" + Xms +
                                " -Djava.library.path=.//bin/natives" +
                                " -Dminecraft.client.jar=.//bin/modpack.jar" +
                                " -Dminecraft.applet.TargetDirectory=.//" +
                                " -cp .//bin/modpack.jar;" + Libraries + ";.//bin/minecraft.jar" +
                                " -XX:+UnlockExperimentalVMOptions" +
                                " -XX:+UseG1GC -XX:G1NewSizePercent=20" +
                                " -XX:G1ReservePercent=20" +
                                " -XX:MaxGCPauseMillis=50" +
                                " -XX:G1HeapRegionSize=16M" +
                                " net.minecraft.launchwrapper.Launch" +
                                " --gameDir .//" +
                                " --username " + Username +
                                " --assetsDir ..//..//..//cache/assets" +
                                " --assetIndex " + AssetIndex +
                                " --version " + Version +
                                " --uuid " + ClientToken +
                                " --accessToken " + AccessToken +
                                " --userProperties {}" +
                                " --userType mojang" +
                                " --tweakClass cpw.mods.fml.common.launcher.FMLTweaker" +
                                " --title " + Title
        JavaProcess.Start()

    End Sub
End Module
