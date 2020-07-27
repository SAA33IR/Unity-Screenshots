using UnityEngine;
using UnityEditor;
using System.IO;
public class Screenshots : MonoBehaviour
{
#if UNITY_EDITOR
    private static string path = "Screenshots";
    private static string fileName;

    [MenuItem("Screenshot/ Capture #s")]

    static public void Screenshot()
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        fileName = "Screenshot_" + System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss-ms-ms") + ".png";
        ScreenCapture.CaptureScreenshot(System.IO.Path.Combine(path, fileName));
    }
#endif
}
