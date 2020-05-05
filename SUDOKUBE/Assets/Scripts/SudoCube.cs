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

    public void ButtonClick(Button button)
    {

    }

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