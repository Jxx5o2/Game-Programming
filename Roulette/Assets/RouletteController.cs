using Unity.VisualScripting;
using UnityEngine;

public class RouletteController : MonoBehaviour
{

    float rotSpeed = 0; //회전속도
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 프레임레이트를 60으로 고정한다
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // 클릭하면 회전 속도를 설정한다.
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // 회전 속도만큼 룰렛을 회전시킨다.
        transform.Rotate(0, 0, this.rotSpeed);

        //룰렛을 감속시킨다. (추가)
        this.rotSpeed *= 0.992f;
    }
}
