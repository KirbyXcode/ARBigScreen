using UnityEngine;
using System.Collections;

public class CharacterMotor : MonoBehaviour
{
    private CharacterAnimation chAnim;
    public float speed = 5f;
    public float rotSpeed = 10;
    void Start ()
    {
        chAnim = GetComponent<CharacterAnimation>();
    }

    private void Movement()
    {
        if(chAnim.anim.GetCurrentAnimatorStateInfo(0).IsName("Blend Tree"))
            transform.Translate(-Input.GetAxis("Vertical") * speed * Time.deltaTime, 0, Input.GetAxis("Horizontal") * speed * Time.deltaTime);
    }

    private void Rotate(float rotSpeed)
    {
        if (chAnim.anim.GetCurrentAnimatorStateInfo(0).IsName("Blend Tree"))
            transform.Rotate(0, 15 * rotSpeed * Time.deltaTime, 0);
    }
    void Update ()
    {
        Movement();
        if (Input.GetKey(KeyCode.Q))
            Rotate(-rotSpeed);
        if (Input.GetKey(KeyCode.E))
            Rotate(rotSpeed);
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
