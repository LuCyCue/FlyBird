using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    public float clickUpY = 0.5f;
    public AudioClip flyAudio;
    public AudioClip hitAudio;
    public AudioClip scoreAudio;
    public AudioClip dieAudio;
    public bool disableInteract;
    Rigidbody2D rigidbody2d;
    Animator animator;
    AudioSource audioSource;
    float animationTime;
    bool isLoseControl;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (disableInteract) {
            return;
        }
        if (!isLoseControl && Input.GetMouseButtonDown(0)) {
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
        audioSource.PlayOneShot(flyAudio);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag.CompareTo("pipe") == 0 ||
            other.gameObject.tag.CompareTo("floor") == 0) {
            audioSource.PlayOneShot(hitAudio);
            isLoseControl = true;
            rigidbody2d.gravityScale = 0.8f;
            animator.SetFloat("isFly",2.1f);
        }  
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.tag.CompareTo("score") == 0) {
            audioSource.PlayOneShot(scoreAudio);
            //find score gameobject
            GameObject score = GameObject.Find("Canvas/Score");
            if (score != null) {
                Score s = score.GetComponent<Score>();
                if (s != null) {
                    s.goal();
                }
            }
        }
    }

    private void OnBecameInvisible() {
        if (disableInteract) return;
        audioSource.PlayOneShot(dieAudio);
        Invoke("jump2Waitting", 1);
    }

    private void jump2Waitting() {
        SceneManager.LoadScene("Waiting");
    }
}
