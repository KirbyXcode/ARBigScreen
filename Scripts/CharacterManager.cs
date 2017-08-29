using UnityEngine;
using System.Collections;

public class CharacterManager : MonoBehaviour
{
    private Transform startPoint;

    public GameObject character;

    private GameObject go;

    void Start ()
    {
        Screen.SetResolution(1920, 1080, true);
        startPoint = transform.GetChild(0);
        CreateCharacter();
    }

    void CreateCharacter()
    {
        go = Instantiate(character, startPoint.position, Quaternion.identity) as GameObject;
    }

    void Update ()
    {
        if (go == null)
            CreateCharacter();
    }
}
