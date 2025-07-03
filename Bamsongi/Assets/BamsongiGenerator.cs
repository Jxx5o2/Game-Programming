using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            bamsongi.GetComponent<BamsongiController>().Shoot(worldDir.normalized * 2000);
        }
    }
}
