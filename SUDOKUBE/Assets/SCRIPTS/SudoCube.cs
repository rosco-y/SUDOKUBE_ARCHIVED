using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SudoCube : MonoBehaviour
{
    // Start is called before the first frame update
    Transform _camera;
    int _sudoValue;
    bool _sudoHole = false;
    int _sudoSolution;
    void Start()
    {
        _camera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(_camera);
        transform.rotation = _camera.rotation;
    }

    public void ButtonPressed(UnityEngine.UI.Button button)
    {
        try
        {
            print(button.transform.name);
            //do the stuffs you want todo based on the button that was pressed
            TMP_Text txt = button.GetComponent<TMP_Text>();
            txt.color = Color.black; //btw the button would automatically replace the color when pressed..
                                     //Debug.Log($"button {button.transform.name} was pressed");

        }
        catch (System.Exception x)
        {

            throw;
        }
    }
    //public void OnClick1() 
    //{
    //    Button btn = (Button)GameObject.FindWithTag("cmd1").GetComponent<Button>();
    //    TMP_Text txt = btn.GetComponent<TMP_Text>();
    //    txt.color = Color.black;
    //}
    //public void OnClick2() { }
    //public void OnClick3() { }
    //public void OnClick4() { }
    //public void OnClick5() { }
    //public void OnClick6() { }
    //public void OnClick7() { }
    //public void OnClick8() { }
    //public void OnClick9() { }

    public int SudoValue
    {
        set 
        { 
            _sudoValue = value;
            _sudoHole = (value < 0);
            _sudoSolution = Mathf.Abs(value);
        }
        get 
        {
            return _sudoValue;
        }
    }

    public int SudoSolution
    {
        get
        {
            return _sudoSolution;
        }
    }

    /// <summary>
    /// true if this was a cell that the user needed to solve.
    /// </summary>
    public bool SudoHole
    {
        get
        {
            return _sudoHole;
        }
    }


}
