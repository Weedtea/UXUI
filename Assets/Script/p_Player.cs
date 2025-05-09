using UnityEngine;

public class p_Player : MonoBehaviour
{
    public float torquePower = 10f;
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        if (Mathf.Abs(h) > 0.1f)
            rigid.AddTorque(-h * 0.01f * torquePower, ForceMode2D.Impulse);
    }
}
