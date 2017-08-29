using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using Antares.QRCode;
using System;

public class UIManager : MonoBehaviour
{
    public MovieTexture movie;
    private RawImage rawImage;
    private AudioSource audio;
    private GameObject movieScreen;
    private GameObject photoPanel;
    private GameObject presentPanel;
    private GameObject faceToCamera;
    private Text countDown;
    private GameObject scanQRCode;
    private Text num;
    private GameObject[] withGirls;
    private GameObject mButton_StartPhoto;
    private GameObject mButton_Right;
    private GameObject mButton_Left;
    private GameObject presentWindow;
    private GameObject keyboard;
    private Image mImage_QRCode;
    private Texture2D mTex2D_QRCode;
    private InputField inputField;
    private Text toName;
    private Text mText_Num;
    private int index = 0;
    private string uploadURL = "http://47.92.102.137/UploadImage.aspx";
    private string uploadARURL = "http://47.92.102.137/UploadAR.aspx";

    void Start ()
    {
        movieScreen = transform.Find("Background/MovieScreen").gameObject;
        rawImage = movieScreen.GetComponent<RawImage>();
        audio = Camera.main.GetComponent<AudioSource>();
        photoPanel = transform.Find("Panel_Photo").gameObject;
        presentPanel = transform.Find("Panel_Present").gameObject;
        faceToCamera = transform.Find("Panel_Photo/FaceToCam").gameObject;
        countDown = faceToCamera.GetComponentInChildren<Text>();
        scanQRCode = transform.Find("Panel_Photo/ScanQRCode").gameObject;
        num = scanQRCode.GetComponentInChildren<Text>();
        mButton_Right = transform.Find("Panel_Photo/Button_Right").gameObject;
        mButton_Left = transform.Find("Panel_Photo/Button_Left").gameObject;
        mButton_StartPhoto = transform.Find("Panel_Photo/Button_StartPhoto").gameObject;
        mButton_StartPhoto.GetComponent<Button>().onClick.AddListener(StartPhoto);
        presentWindow = transform.Find("Panel_Present/PresentWindow").gameObject;
        toName = transform.Find("Panel_Present/Card/ToName").GetComponent<Text>();
        inputField = transform.Find("Panel_Present/PresentWindow/InputField").GetComponent<InputField>();
        mImage_QRCode = transform.Find("Panel_Present/QRCodeWindow").GetComponent<Image>();
        keyboard = transform.Find("Panel_Keyboard").gameObject;
        mText_Num = transform.Find("Panel_Photo/ScanQRCode/Num").GetComponent<Text>();

        FindWithGirlsObjs();

        Hide(photoPanel);
        Hide(presentPanel);

        MovieInit();
        ToNameClear();
    }

    private void MovieInit()
    {
        audio.clip = movie.audioClip;
        audio.Play();
        rawImage.texture = movie;
        movie.loop = true;
        movie.Play();
    }

    private void StopMovie()
    {
        movie.Stop();
        audio.Stop();
    }

    private void PlayMovie()
    {
        movie.Play();
        audio.Play();
    }
    private void StartPhoto()
    {
        Hide(mButton_StartPhoto);
        Hide(mButton_Left);
        Hide(mButton_Right);
        StartCoroutine(CountDown());
        //Show(faceToCamera);
    }

    private IEnumerator CountDown()
    {
        yield return null;
        PhotoShot();
        Show(faceToCamera);
        for (int i = 3; i >= 0; i--)
        { 
            TextFormat(countDown, i);
            yield return new WaitForSeconds(1);
        }
        Hide(faceToCamera);
        Show(scanQRCode);
        //num.text = "";
    }

    public void PhotoBack()
    {
        Hide(scanQRCode);
        Show(mButton_StartPhoto);
        Show(mButton_Right);
        Show(mButton_Left);
    }

    public void PhotoShot()
    {
        //申请Texture2d的内存空间
        Texture2D tex2D = new Texture2D(1590, 900, TextureFormat.RGB24, true);

        //读取指定大小的屏幕截图
        tex2D.ReadPixels(new Rect(161, 142, 1590, 900), 0, 0, true);

        //把Texture2d的截图保存到内存中
        tex2D.Apply();

        //把Texture2d转成PNG格式
        byte[] bytes = tex2D.EncodeToJPG();

        //WWWForm是网络表单，用来生成表单数据，使用WWW类传递到Web服务器
        WWWForm wwwForm = new WWWForm();

        //将转化为二进制数组的图片以及服务器接口添加至网络表单之中
        wwwForm.AddBinaryData("post", bytes);

        //使用WWW来与Web服务器进行交互 参数为服务器地址和网络表单
        WWW www = new WWW(uploadARURL, wwwForm);

        //调用获取下载地址的协程函数 并且将www作为参数传入
        StartCoroutine(PostAR(www));
    }

    private IEnumerator PostAR(WWW www)
    {
        yield return www;

        mText_Num.text = www.text;
    }

    private void TextFormat(Text textContent, int time)
    {
        textContent.text = time.ToString();
    }
    private void Hide(GameObject go)
    {
        go.SetActive(false);    
    }

    private void Show(GameObject go)
    {
        go.SetActive(true);
    }

    private void FindWithGirlsObjs()
    {
        withGirls = new GameObject[3];
        for (int i = 0; i < 3; i++)
        {
            withGirls[i] = transform.Find("Panel_Photo/WithGirls").GetChild(i).gameObject;
        }
        for (int i = 0; i < withGirls.Length; i++)
        {
            if(i == index)
            {
                withGirls[i].SetActive(true);
            }
            else
            {
                withGirls[i].SetActive(false);
            }
        }
    }

    public void SwitchRight()
    {
        index++;
        if (index == 3)
        {
            index = 0;
        }
        for (int i = 0; i < withGirls.Length; i++)
        {
            if(i == index)
            {
                withGirls[i].SetActive(true);
            }
            else
            {
                withGirls[i].SetActive(false);
            }
        }
    }

    public void SwitchLeft()
    {
        index--;
        if(index == -1)
        {
            index = 2;
        }
        for (int i = 0; i < withGirls.Length; i++)
        {
            if (i == index)
            {
                withGirls[i].SetActive(true);
            }
            else
            {
                withGirls[i].SetActive(false);
            }
        }
    }

    private void ToNameClear()
    {
        toName.text = "";
    }

    /// <summary>
    /// 奇幻旅程
    /// </summary>
    public void WatchMovie()
    {
        Show(movieScreen);
        Hide(photoPanel);
        Hide(presentPanel);
        PlayMovie();
        keyboard.SetActive(false);
    }

    /// <summary>
    /// 拍照
    /// </summary>
    public void TakePhoto()
    {
        Show(photoPanel);
        Hide(movieScreen);
        Hide(presentPanel);
        Hide(faceToCamera);
        Hide(scanQRCode);
        StopMovie();
        Hide(keyboard);
        Show(mButton_StartPhoto);
        Show(mButton_Right);
        Show(mButton_Left);
    }

    /// <summary>
    /// 虚拟礼物
    /// </summary>
    public void VistualPresent()
    {
        Hide(movieScreen);
        Hide(photoPanel);
        Show(presentPanel);
        Show(presentWindow);
        inputField.text = "";
        StopMovie();
        keyboard.SetActive(true);
    }

    /// <summary>
    /// 返回
    /// </summary>
    public void Back()
    {
        WatchMovie();
    }

    public void InputNameBack()
    {
        Hide(presentWindow);
        inputField.text = "";
        Hide(keyboard);
    }

    public void CardNameBuiltIn()
    {
        string inputText = inputField.text;
        if (inputText == "") return;
        toName.text = inputText;
        Hide(presentWindow);
        Hide(keyboard);
    }

    public void Shot()
    {
        string inputText = inputField.text;
        if (inputText == "") return;
        StartCoroutine(ScreenShot());
    }

    /// <summary>
    /// 截屏功能
    /// </summary>
    private IEnumerator ScreenShot()
    {
        yield return null;

        //申请Texture2d的内存空间
        Texture2D tex2D = new Texture2D(596, 795, TextureFormat.RGB24, true);

        //读取指定大小的屏幕截图
        tex2D.ReadPixels(new Rect(253, 192, 596, 795), 0, 0, true);

        //把Texture2d的截图保存到内存中
        tex2D.Apply();

        //把Texture2d转成PNG格式
        byte[] bytes = tex2D.EncodeToJPG();

        //将转换的PNG保存在指定目录
        //string picPath = Application.dataPath + "/ScreenShot/" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
        //File.WriteAllBytes(picPath, bytes);

        //WWWForm是网络表单，用来生成表单数据，使用WWW类传递到Web服务器
        WWWForm wwwForm = new WWWForm();

        //将转化为二进制数组的图片以及服务器接口添加至网络表单之中
        wwwForm.AddBinaryData("post", bytes);

        //使用WWW来与Web服务器进行交互 参数为服务器地址和网络表单
        WWW www = new WWW(uploadURL, wwwForm);

        //调用获取下载地址的协程函数 并且将www作为参数传入
        StartCoroutine(PostImage(www));
    }

    //获取图片下载地址
    private IEnumerator PostImage(WWW www)
    {
        yield return www;

        EncodeQRCode(www.text);
    }

    //生成二维码
    private void EncodeQRCode(string picAddress)
    {
        //生成二维码Texture2D
        mTex2D_QRCode = QRCodeProcessor.Encode(picAddress, 256, 256, ErrorCorrectionLevel.H, "Dude");
        
        //将二维码Texture2D转为Sprite
        Sprite mSprite_QRCode = Sprite.Create(mTex2D_QRCode, new Rect(0, 0, 256, 256), new Vector2(0, 0));

        mImage_QRCode.sprite = mSprite_QRCode;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
