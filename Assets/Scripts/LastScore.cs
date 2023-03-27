using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LastScore : MonoBehaviour
{
    TMP_Text textMesh;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TMP_Text>();
        textMesh.text = "Last Score: " + GameData.shareInstance.score.ToString();
    }
}
