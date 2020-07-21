using log4net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    private static readonly ILog log = LogManager.GetLogger("Test");

    void Update()
    {
        log.Debug(Time.frameCount);
    }
}
