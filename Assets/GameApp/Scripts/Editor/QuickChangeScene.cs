using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;

public class QuickChangeScene : EditorWindow
{
    private static string developeSceneName = "game1_1";

    [MenuItem("Tools/ChangeSceneLogo %t")]
    public static void ChangeSceneLogo()
    {
        if (EditorApplication.isPlaying == true)
        {
            ChangeSceneDevelopment();
        }else
        {
            ChangeScene("logo");
            EditorApplication.ExecuteMenuItem("Edit/Play");
        }
    }

    [MenuItem("Tools/ChangeSceneDevelopment %g")]
    public static void ChangeSceneDevelopment()
    {
       EditorApplication.isPlaying = false;//加上不会报错
        StartSceneSwitch();
    }

    private static void ChangeScene(string sceneName)
    {
        string scenePath = $"Assets/GameApp/Scenes/{sceneName}.unity"; // 替换为你想要切换的场景路径
        EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo(); //好像是一个弹窗啥的
        EditorSceneManager.OpenScene(scenePath);
    }



    private static bool isDelaying = false;
    private static float delayDuration = 0.017f; // 延时时间（单位：秒）延迟一帧以上，不然SaveCurrentModifiedScenesIfUserWantsTo会报错，这个咱真不懂
    private static float startTime;
    private static void StartSceneSwitch()
    {
        isDelaying = true;
        startTime = (float)EditorApplication.timeSinceStartup;
        EditorApplication.update += UpdateDelay;
    }
    private static void UpdateDelay()
    {
        //Debug.Log("aaa"); 执行两次问题不大
        float currentTime = (float)EditorApplication.timeSinceStartup;
        float elapsedTime = currentTime - startTime;

        if (isDelaying && elapsedTime >= delayDuration)
        {
           ChangeScene(developeSceneName); // 延时结束后打开新场景

            isDelaying = false;   // 结束延时
            EditorApplication.update -= UpdateDelay;//allen认为这个结束有点多余，因为没有update自然也不用if判断了，加上update是用了就扔的。
        }
    }
}
