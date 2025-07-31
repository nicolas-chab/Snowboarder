using UnityEngine;

public class Dusttrail : MonoBehaviour
{
    [SerializeField] ParticleSystem SlideEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            SlideEffect.Play();
        }
        
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        SlideEffect.Stop();
    }
}
