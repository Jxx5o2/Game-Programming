using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;

        GetComponent<ParticleSystem>().Play();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        // Shoot(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
