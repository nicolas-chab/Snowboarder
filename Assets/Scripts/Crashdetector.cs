using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class Crashdetector : MonoBehaviour
{
    [SerializeField] float timetorestart=1f;
    [SerializeField] ParticleSystem crasheffect;
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
        if (collision.tag == "Ground")
        {
            crasheffect.Play();
            Invoke("reloadscene",timetorestart);
        }

    }
    void reloadscene()
    {
        SceneManager.LoadScene(0);
    }
}
