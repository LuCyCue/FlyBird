using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text textMesh; 
    int score;

    void Start() {
        textMesh = GetComponent<TMP_Text>();
    }
    public void goal() {
        score += 1;
        textMesh.text = "Score: " + score.ToString();
    }

    public void reset() {
        score = 0;
        textMesh.text = "Score: " + score.ToString();
    }
}
