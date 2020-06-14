using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoMenu : MonoBehaviour {
    // Sun Image
    public Texture marioImage;
    public Texture coinImage;
    public float currentTime = 0f;
    

    public float startTime = 300f; 

    void Start(){
        currentTime = startTime;
    }

    void Update(){
        currentTime -= 1f * Time.deltaTime;
    }

    void OnGUI() {
        // Begin Gui
        GUILayout.BeginArea(new Rect(0, 0, 400, 100));
        GUILayout.BeginHorizontal("box");

        // Draw the Sun
        GUILayout.Box(new GUIContent(" x " + Info.liveTimes.ToString(), marioImage));
        GUILayout.Box(new GUIContent(" score = " + Info.coins.ToString()));
        GUILayout.Box(new GUIContent(" time = " + currentTime.ToString("0")));

        // End Gui
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
