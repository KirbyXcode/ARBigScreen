using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour 
{
    [HideInInspector]
    public Animator anim;

    [HideInInspector]
    public AudioClip[] clips;

    private AudioSource audio;

    private Transform[] points;

    public float speed = 5;

    private bool isPlayingAnim = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        InitRoutePoints();
        anim.SetFloat("Vertical", 1);
        StartCoroutine(MoveToPath());
    }

    void InitRoutePoints()
    {
        points = new Transform[3];
        GameObject go = GameObject.Find("RoutePoint");
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = go.transform.GetChild(i);
        }
    }

    public void IsEat()
    {
        anim.SetBool("Eat", false);
    }

    private IEnumerator MoveToTarget(Vector3 target)
    {
        while(Vector3.Distance(transform.position, target) > 0.1)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            transform.LookAt(target);
            yield return new WaitForFixedUpdate();
        }
    }

    private IEnumerator MoveToPath()
    {
        for (int i = 1; i < points.Length; i++)
        {
            yield return StartCoroutine(MoveToTarget(points[i].position));

            if (i == points.Length - 1) 
            {
                StopAllCoroutines();
                Destroy(gameObject);
            }

            anim.SetBool("Eat", true);
            yield return new WaitForSeconds(6.9f);
            anim.SetFloat("Vertical", 1);
        }
    }
}
