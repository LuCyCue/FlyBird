using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData shareInstance;
    public int score = 0;
    // Start is called before the first frame update
    private void Awake() {
        if (shareInstance == null) {
            DontDestroyOnLoad(gameObject);
            shareInstance = this;
        } else if (shareInstance != null) {
            Destroy(gameObject);
        }
    }
}
