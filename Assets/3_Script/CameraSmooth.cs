using UnityEngine;
using System.Collections;

public class CameraSmooth : MonoBehaviour
{

    public GameObject _target;
    private Vector3 _iniPos;
    private Vector3 _charPos;

    // Use this for initialization
    void Start()
    {

        _iniPos = transform.position;
        _charPos = _target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = _iniPos + _target.transform.position - _charPos;

    }
}
