using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    public static int liveTimes = 2;
    public static int coins = 0;
    public Text liveText;

    void Update(){
        liveText.text = "X " + liveTimes;
    }

}
