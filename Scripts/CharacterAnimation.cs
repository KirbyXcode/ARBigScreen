using UnityEngine;
using System.Collections;

public class CharacterAnimation : MonoBehaviour
{
    [HideInInspector]
    public Animator anim;
    [HideInInspector]
    public AudioClip[] clips;
    private AudioSource audio;
    void Start ()
    {
        Screen.SetResolution(1920, 1080, true);
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    private void MoveAnimation()
    {
        anim.SetFloat("Horizontal",Input.GetAxis("Horizontal"));
        anim.SetFloat("Vertical",Input.GetAxis("Vertical"));
    }

    private void SmellAnimation()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Blend Tree"))
            anim.SetBool("Smell", Input.GetKeyDown(KeyCode.X)); 
    }

    private void EatAnimation()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Blend Tree"))
            anim.SetBool("Eat", Input.GetKeyDown(KeyCode.Z));
    }

    private void BarkAnimation()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Blend Tree"))
            anim.SetBool("Bark", Input.GetKeyDown(KeyCode.Space));
    }

    public void PlaySmell()
    {
        audio.pitch = 1.5f;
        audio.PlayOneShot(clips[1]);
    }

    public void PlayBark()
    {
        //加快音频播放速度
        audio.pitch = 1.5f;
        audio.PlayOneShot(clips[0]);
    }

    void Update ()
    {
        MoveAnimation();
        SmellAnimation();
        EatAnimation();
        BarkAnimation();
    }
}
