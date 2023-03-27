using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void startPlay() {
        GameData.shareInstance.score = 0;
        SceneManager.LoadScene("Playing");
    }
}
