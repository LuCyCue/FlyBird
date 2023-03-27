using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public GameObject pipePrefab;
    public float minCreateTime = 1.0f;
    public float maxCreateTime = 2.0f;
    public float minRandomY = -1.0f;
    public float maxRandomY = 1.0f;
    public float timer;
    int lastScale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0) {
            createPipe();
            int scale = GameData.shareInstance.score / 20;
            if (lastScale < scale && minCreateTime > 0.8f && maxCreateTime > 1.8f) {
                minCreateTime = minCreateTime - (float)scale / 10.0f;
                maxCreateTime = maxCreateTime - (float)scale / 10.0f;
                lastScale = scale;
            }
            timer = Random.Range(minCreateTime, maxCreateTime);
        }
    }

    void createPipe() {
        float y = Random.Range(minRandomY, maxRandomY);
        Vector3 positon = pipePrefab.transform.position;
        Vector3 targetPosition = new Vector3(positon.x+2, positon.y+y, positon.z);
        GameObject pipe = Instantiate(pipePrefab, targetPosition, Quaternion.identity);
    }
}
