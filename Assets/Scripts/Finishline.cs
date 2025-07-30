using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour
{
    [SerializeField] float timetorestart = 1f;
    [SerializeField] ParticleSystem finisheffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == ("Player"))
        {
            finisheffect.Play();
            Invoke("reloadscene", timetorestart);
            
        }


    }
    void reloadscene()
    {
        SceneManager.LoadScene(0);
    }
}
