using Unity.VisualScripting;
using UnityEngine;

public class RouletteController : MonoBehaviour
{

    float rotSpeed = 0; //ȸ���ӵ�
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // �����ӷ���Ʈ�� 60���� �����Ѵ�
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // Ŭ���ϸ� ȸ�� �ӵ��� �����Ѵ�.
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // ȸ�� �ӵ���ŭ �귿�� ȸ����Ų��.
        transform.Rotate(0, 0, this.rotSpeed);

        //�귿�� ���ӽ�Ų��. (�߰�)
        this.rotSpeed *= 0.992f;
    }
}
