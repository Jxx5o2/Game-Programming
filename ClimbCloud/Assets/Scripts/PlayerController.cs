using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        // �����Ѵ�.
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.linearVelocity.y == 0)
        {
            this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        // �¿� �̵�
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }

        // �÷��̾��� �ӵ�
        float speedx = Mathf.Abs(this.rigid2D.linearVelocity.x);

        // ���ǵ� ����
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        // �����̴� ���⿡ ���� �����Ѵ�.
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // �÷��̾� �ӵ��� ���� �ִϸ��̼� �ӵ��� �ٲ۴�.
        if (this.rigid2D.linearVelocity.y == 0)
        {
            this.animator.speed = speedx / 2.0f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }

        // �÷��̾ ȭ�� ������ �����ٸ� ó������
        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("��");
        SceneManager.LoadScene("ClearScene");
    }
}
