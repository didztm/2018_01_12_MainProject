using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    [Header("Players attribute")]
    [SerializeField]
    private GameObject m_mainCam;
    [SerializeField]
    private List<GameObject> m_player;
    [Header("Main Cam Attribute")]
    [SerializeField]
    private bool m_withUpView;
    [SerializeField]
    private bool m_withFaceView;
    [SerializeField]
    private float m_CamHeight;
    [SerializeField]
    private float m_CamRecoil;
    [SerializeField]
    private float m_CamYAngle;
    [SerializeField]
    private float m_CamXAngle;
    [SerializeField]
    private float m_CamZAngle;
    [Header("Debug (don't touch!)")]
    [SerializeField]
    private float anglePlayerCam;


    [SerializeField]
    private float m_maxdistance = 15f;
    private List<Camera> _playerCam;
    private Camera _main_cam;
    private Transform _mainCamTr;
    private bool testChangeCam = true;

    private void Start()
    {
        InitiateCameras();

    }
    // Update is called once per frame
    void Update()
    {
    }


    private void ViewSplit(int numberToSplit )
    {
       // player.rect = new Rect(0, 0, 0.5f, 1f);
       // player.rect = new Rect(0.5f, 0, 0.5f, 0);
        _main_cam.enabled = false;
    }
    /*
    private void CamPlayerLookNormal()
    {
        CenterView(_player1Tr, _player2Tr);
        Quaternion playerViews = _player1Cam.transform.rotation * Quaternion.Inverse(_player2Cam.transform.rotation);
        //float angle = Vector3.SignedAngle(_mainCamTr.position, playerViews , DistanceBetweenPlayer() / 2);
        RotateCam(_mainCamTr, playerViews);
        _player1Cam.enabled = false;
        _player2Cam.enabled = false;
        _main_cam.enabled = true;
        //Debug.Log("normal"); 
    }
    private void CamNormal()
    {
        CenterView(_player1Tr, _player2Tr);
        // Quaternion playerViews = _player1Cam.transform.rotation * Quaternion.Inverse(_player2Cam.transform.rotation);
        //float angle = Vector3.SignedAngle(_mainCamTr.position, playerViews , DistanceBetweenPlayer() / 2);
        // RotateCam(_mainCamTr, playerViews);
        _player1Cam.enabled = false;
        _player2Cam.enabled = false;
        _main_cam.enabled = true;
        // Debug.Log("normal");
    }


    private void CenterView(Transform t1, Transform t2)
    {
        angleP1 = Vector3.Angle(_player1Cam.transform.position, Vector3.up);
        angleP2 = Vector3.Angle(_player1Cam.transform.position, Vector3.up);
        Vector3 camDist = t1.position - (t1.position - t2.position) / 2;
        Vector3 withObj;
        withObj = new Vector3(camDist.x, m_CamHeight, camDist.z + m_CamRecoil);
        _mainCamTr.position = withObj;
        Quaternion angleCameraPos =
            Quaternion.AngleAxis(m_CamYAngle, Vector3.right)
            * (Quaternion.AngleAxis(m_CamXAngle, Vector3.up))
            * (Quaternion.AngleAxis(m_CamZAngle, Vector3.forward));
        _mainCamTr.rotation = angleCameraPos;
        t1 = null;
        t2 = null;
    }
    */


    private void RotateCam(Transform objToRotate, Quaternion rot)
    {
        // Debug.Log(angle + "-----" + objToRotate.position);
        // objToRotate.rotation = Quaternion.AngleAxis(angle, Vector3.up);
        objToRotate.rotation = rot;
    }

    // à sortir
    
    // à sortir
    
    private void InitiateCameras()
    {

        //_mainCamTr.position = new Vector3(0f,0f,0f);
        //Demander pourquoi bug ???

        //_main_cam.rect = new Rect(0, 0, 1f, 1f);
        // Debug.Log(_player2Cam.name);
    }

}
