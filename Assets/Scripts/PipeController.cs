using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float speed = 2.0f;
    public float limit_x;
    public GameObject pipePrefab;
    float timer;

    // Update is called once per frame
    void Update()
    {
        Vector2 position = gameObject.transform.position;
        position.x = (-speed * Time.deltaTime) + position.x;
        if (position.x <= -limit_x) {
            Destroy(gameObject);
        } else {
            gameObject.transform.position = position;
        }
    }

    public void createPipe() {
        Vector3 posiztion = new Vector3(1,0);
        GameObject pipeObject = Instantiate(pipePrefab, posiztion, Quaternion.identity);
    }
}
