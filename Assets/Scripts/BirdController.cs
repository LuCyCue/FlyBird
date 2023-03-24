using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float clickUpY = 0.5f;
    Rigidbody2D rigidbody2d;
    Animator animator;
    float animationTime;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            //up
            Debug.Log("click enter");
            clickAction();
        }
        animationTime = animationTime - Time.deltaTime;
        if (animationTime <= 0) {
            animator.SetFloat("isFly",0.0f);
        }
    }

    void clickAction() {
        rigidbody2d.velocity = new Vector2(0, clickUpY);
        animator.SetFloat("isFly",1.0f);
        animationTime = 0.5f;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Fail");
    }

    private void OnTriggerExit2D(Collider2D other) {
        Debug.Log("Goal");
    }
}
