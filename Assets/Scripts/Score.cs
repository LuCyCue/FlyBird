using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    TMP_Text textMesh;

    void Start() {
        textMesh = GetComponent<TMP_Text>();
    }
    public void goal() {
        GameData.shareInstance.score += 1;
        textMesh.text = "Score: " + GameData.shareInstance.score.ToString();
    }

    public void reset() {
        GameData.shareInstance.score = 0;
        textMesh.text = "Score: " + GameData.shareInstance.score.ToString();
    }
}
