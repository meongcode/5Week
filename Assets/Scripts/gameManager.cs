using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    public Text currentTimeText; // 현재 시간을 표시할 Text 컴포넌트의 참조
    

    void Start()
    {
        
    }

    void Update()
    {
        // 매 프레임마다 현재 시간을 업데이트합니다.
        DateTime now = DateTime.Now;
        currentTimeText.text = "Time " + now.ToString("HH:mm");
    }
}
