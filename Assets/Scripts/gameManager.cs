using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    public Text currentTimeText; // ���� �ð��� ǥ���� Text ������Ʈ�� ����
    

    void Start()
    {
        
    }

    void Update()
    {
        // �� �����Ӹ��� ���� �ð��� ������Ʈ�մϴ�.
        DateTime now = DateTime.Now;
        currentTimeText.text = "Time " + now.ToString("HH:mm");
    }
}
