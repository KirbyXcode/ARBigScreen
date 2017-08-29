using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;
using UnityEngine.UI;

public class KeyboardController : MonoBehaviour 
{
    public InputField mInput_Present;

	void Start () 
    {
        gameObject.SetActive(false);
	}

    public void OnButtonOne()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyOne());
    }
    private IEnumerator OnKeyOne()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_1);
    }

    public void OnButtonTwo()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyTwo());
    }
    private IEnumerator OnKeyTwo()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_2);
    }

    public void OnButtonThree()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyThree());
    }
    private IEnumerator OnKeyThree()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_3);
    }

    public void OnButtonFour()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyFour());
    }
    private IEnumerator OnKeyFour()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_4);
    }

    public void OnButtonFive()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyFive());
    }
    private IEnumerator OnKeyFive()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_5);
    }

    public void OnButtonSix()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeySix());
    }
    private IEnumerator OnKeySix()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_6);
    }

    public void OnButtonSeven()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeySeven());
    }
    private IEnumerator OnKeySeven()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_7);
    }

    public void OnButtonEight()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyEight());
    }
    private IEnumerator OnKeyEight()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_8);
    }

    public void OnButtonNine()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyNine());
    }
    private IEnumerator OnKeyNine()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_9);
    }

    public void OnButtonZero()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyZero());
    }
    private IEnumerator OnKeyZero()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_0);
    }

    public void OnButtonQ()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyQ());
    }
    private IEnumerator OnKeyQ()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_Q);
    }

    public void OnButtonW()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyW());
    }
    private IEnumerator OnKeyW()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_W);
    }

    public void OnButtonE()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyE());
    }
    private IEnumerator OnKeyE()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_E);
    }

    public void OnButtonR()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyR());
    }
    private IEnumerator OnKeyR()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_R);
    }

    public void OnButtonT()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyT());
    }
    private IEnumerator OnKeyT()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_T);
    }

    public void OnButtonY()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyY());
    }
    private IEnumerator OnKeyY()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_Y);
    }

    public void OnButtonU()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyU());
    }
    private IEnumerator OnKeyU()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_U);
    }

    public void OnButtonI()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyI());
    }
    private IEnumerator OnKeyI()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_I);
    }

    public void OnButtonO()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyO());
    }
    private IEnumerator OnKeyO()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_O);
    }

    public void OnButtonP()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyP());
    }
    private IEnumerator OnKeyP()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_P);
    }

    public void OnButtonA()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyA());
    }
    private IEnumerator OnKeyA()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_A);
    }

    public void OnButtonS()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyS());
    }
    private IEnumerator OnKeyS()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_S);
    }

    public void OnButtonD()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyD());
    }
    private IEnumerator OnKeyD()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_D);
    }

    public void OnButtonF()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyF());
    }
    private IEnumerator OnKeyF()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_F);
    }

    public void OnButtonG()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyG());
    }
    private IEnumerator OnKeyG()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_G);
    }

    public void OnButtonH()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyH());
    }
    private IEnumerator OnKeyH()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_H);
    }

    public void OnButtonJ()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyJ());
    }
    private IEnumerator OnKeyJ()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_J);
    }

    public void OnButtonK()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyK());
    }
    private IEnumerator OnKeyK()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_K);
    }

    public void OnButtonL()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyL());
    }
    private IEnumerator OnKeyL()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_L);
    }

    public void OnButtonSemicolon()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeySemicolon());
    }
    private IEnumerator OnKeySemicolon()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.OEM_1);
    }

    public void OnButtonZ()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyZ());
    }
    private IEnumerator OnKeyZ()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_Z);
    }

    public void OnButtonX()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyX());
    }
    private IEnumerator OnKeyX()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_X);
    }

    public void OnButtonC()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyC());
    }
    private IEnumerator OnKeyC()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_C);
    }

    public void OnButtonV()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyV());
    }
    private IEnumerator OnKeyV()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_V);
    }

    public void OnButtonB()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyB());
    }
    private IEnumerator OnKeyB()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_B);
    }

    public void OnButtonN()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyN());
    }
    private IEnumerator OnKeyN()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_N);
    }

    public void OnButtonM()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyM());
    }
    private IEnumerator OnKeyM()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_M);
    }

    public void OnButtonBack()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyBack());
    }
    private IEnumerator OnKeyBack()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.BACK);
    }

    public void OnButtonEnter()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyEnter());
    }
    private IEnumerator OnKeyEnter()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
    }

    public void OnButtonLanguageSwitch()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyLanguageSwitch());
    }
    private IEnumerator OnKeyLanguageSwitch()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.SHIFT);
    }

    public void OnButtonCapsLock()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeyCapsLockh());
    }
    private IEnumerator OnKeyCapsLockh()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.CAPITAL);
    }

    public void OnButtonSpace()
    {
        mInput_Present.ActivateInputField();

        StartCoroutine(OnKeySpace());
    }
    private IEnumerator OnKeySpace()
    {
        yield return null;
        mInput_Present.MoveTextEnd(false);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.SPACE);
    }

}
