using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangentCircles : CircleTangent
{

    public GameObject _circlePrefab;
    private GameObject _innerCircleGO, _outterCircleGO, _tangentCircleGO;
    public Vector4 _innerCircle, _outterCircle;
    public float _tangentCircleRadius;
    public float _degree; 
    // Start is called before the first frame update
    void Start()
    {
        _innerCircleGO = (GameObject)Instantiate(_circlePrefab);
        _outterCircleGO = (GameObject)Instantiate(_circlePrefab);
        _tangentCircleGO = (GameObject)Instantiate(_circlePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        _innerCircleGO.transform.position = new Vector3(_innerCircle.x, _innerCircle.y, _innerCircle.z);
        _innerCircleGO.transform.localScale = new Vector3(_innerCircle.w, _innerCircle.w, _innerCircle.w) * 2;
        _outterCircleGO.transform.position = new Vector3(_outterCircle.x, _outterCircle.y, _outterCircle.z);
        _outterCircleGO.transform.localScale = new Vector3(_outterCircle.w, _outterCircle.w, _outterCircle.w) * 2;
        _tangentCircleGO.transform.position = GetRotatedTangent(_degree, _outterCircle.w) + _outterCircleGO.transform.position;
        _tangentCircleGO.transform.localScale = new Vector3(_tangentCircleRadius, _tangentCircleRadius, _tangentCircleRadius) * 2;
    }
}
