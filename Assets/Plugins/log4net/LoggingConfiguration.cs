using System.IO;
using log4net.Appender;
using log4net.Config;
using UnityEngine;

public static class LoggingConfiguration
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Configure()
    {
        RollingFileAppender.SetLogFileDir(Application.dataPath);

        XmlConfigurator.Configure(new FileInfo($"{Application.dataPath}/Plugins/log4net/log4net.xml"));
    }
}