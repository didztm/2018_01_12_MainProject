using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTool : MonoBehaviour {

    [SerializeField]
    private Transform m_myObject;
    private Transform originalPosition;
    // Use this for initialization
    void Start () {
        RotationAngle(m_myObject);
        originalPosition = m_myObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    static Vector3 DistanceBetweenObject(Vector3 _from, Vector3 _to)
    {
        return _from - _to;
    }

    public static bool CheckDistance(Vector3 _from, Vector3 _to, float _maxdistance = 15f)
    {
        float maxRange = _maxdistance;
        Vector3 distanceVect = DistanceBetweenObject(_from, _to);
        Debug.DrawRay(_from, distanceVect, Color.green);
        bool result = Physics.Raycast(_from, distanceVect, maxRange);
        if (result)
        {
            return true;
        }
        return false;
    }
    private void RotationAngle( Transform objectToSearch )
    {
        Vector3 rotationRef = originalPosition.up;
        Vector3 myObjectRef = m_myObject.up;
        Vector3 axeRotation = objectToSearch.transform.forward;
        float angle = Mathf.Abs(-180 + Vector3.SignedAngle(rotationRef, myObjectRef, axeRotation));
        Debug.Log(angle);
    }

}
