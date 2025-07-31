using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class Crashdetector : MonoBehaviour
{
    [SerializeField] float timetorestart=1f;
    [SerializeField] ParticleSystem crasheffect;
    [SerializeField] AudioClip crashSFX;
    bool hascrashed = false;
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
        if (collision.tag == "Ground"&& !hascrashed)
        {
            hascrashed = true;
            FindFirstObjectByType<PlayerController>().disablecontrols();
            crasheffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("reloadscene", timetorestart);
        }

    }
    public void reloadscene()
    {
        SceneManager.LoadScene(0);
    }
}
