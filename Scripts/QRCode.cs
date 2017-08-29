using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Antares.QRCode;
using UnityEngine.UI;

public class QRCode : MonoBehaviour
{
    public Image img;
    public Text text;
    private Texture2D tex2D;

	// Use this for initialization
	void Start () 
    {
        string content = "apslkdjfpasdjf;alksdjf;alskdjfopwijf;askldkjf;laskdjf;laksjdf;lasfkda;sdkfj";
        tex2D = QRCodeProcessor.Encode(content, 128, 128, ErrorCorrectionLevel.Q, "dude");
        Sprite sprite = Sprite.Create(tex2D, new Rect(0, 0, 128, 128), Vector2.zero);
        img.sprite = sprite;
	}
	
	// Update is called once per frame
	void Update () 
    {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            Result result = QRCodeProcessor.Decode(tex2D);
            text.text = result.Text;
        }
	}
}
