using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camsysteM : MonoBehaviour
{
    public Camera[] Cameras; //array of cameras in the scene
    public KeyCode NextCameraKey; //next cam shortcut
    public KeyCode PreviousCameraKey; //prev cam Scut
    private int selectedCameraIndex; //index of cams in array 
    public Text tx; //text box UI for the selected cams
    int i = 0; 

    void Start()
    {
        DisableCameras();
        SelectCamera(0);
        tx.text = string.Format("{0}", Cameras[0].name);

    }
    //common camera control system 
    void Update()
    {
        var indexx = selectedCameraIndex;
        if (Input.GetKeyDown(NextCameraKey))
        {
            SelectNextCamera();
            tx.text = string.Format("{0}", Cameras[indexx + 1].name);

        }
        if (Input.GetKeyDown(PreviousCameraKey))
            SelectPreviousCamera();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DisableCameras();
            Cameras[5].enabled = true;
            tx.text = Cameras[5].name;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DisableCameras();
            Cameras[6].enabled = true;
            tx.text = Cameras[6].name;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            DisableCameras();
            Cameras[7].enabled = true;
            tx.text = Cameras[7].name;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            DisableCameras();
            Cameras[8].enabled = true;
            tx.text = Cameras[8].name;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            DisableCameras();
            Cameras[9].enabled = true;
            tx.text = Cameras[9].name;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            DisableCameras();
            Cameras[10].enabled = true;
            tx.text = Cameras[10].name;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            DisableCameras();
            Cameras[1].enabled = true;
            tx.text = Cameras[1].name;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            DisableCameras();
            Cameras[0].enabled = true;
            tx.text = Cameras[0].name;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            DisableCameras();
            Cameras[2].enabled = true;
            tx.text = Cameras[2].name;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            DisableCameras();
            Cameras[3].enabled = true;
            tx.text = Cameras[3].name;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            DisableCameras();
            Cameras[4].enabled = true;
            tx.text = Cameras[4].name;
        }
    }
    public void SelectNextCamera()
    {
        selectedCameraIndex = (selectedCameraIndex + 1) % Cameras.Length;
        SelectCamera(selectedCameraIndex);
    }
    public void SelectPreviousCamera()
    {
        selectedCameraIndex = (selectedCameraIndex - 1 + Cameras.Length) % Cameras.Length;
        SelectCamera(selectedCameraIndex);
    }
    //camera selector
    public void SelectCamera(int cameraIndex)
    {
        if (cameraIndex >= 0 && cameraIndex < Cameras.Length)
        {
            Cameras[selectedCameraIndex].enabled = false;
            selectedCameraIndex = cameraIndex;
            Cameras[selectedCameraIndex].enabled = true;
        }
    }

    private void DisableCameras()
    {
        for (int i = 0; i < Cameras.Length; i++)
            Cameras[i].enabled = false;
    }
    //private void Update()
    //{
    //    Debug.Log(Cameras[i].name);
    //    if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        for (i = 0; i <= Cameras.Length; i++)
    //        {
    //            Cameras[i].enabled = false;
    //        }
    //        Cameras[0].enabled = true;
    //    }
    //    if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha2))
    //    {
    //        for (int i = 0; i <= Cameras.Length; i++)
    //        {
    //            Cameras[i].enabled = false;
    //        }
    //        Cameras[1].enabled = true;
    //    }
    //    if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha3))
    //    {
    //        for (int i = 0; i <= Cameras.Length; i++)
    //        {
    //            Cameras[i].enabled = false;
    //        }
    //        Cameras[2].enabled = true;
    //    }
    //    if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha4))
    //    {
    //        for (int i = 0; i <= Cameras.Length; i++)
    //        {
    //            Cameras[i].enabled = false;
    //        }
    //        Cameras[3].enabled = true;
    //    }
    //    if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha5))
    //    {
    //        for (int i = 0; i <= Cameras.Length; i++)
    //        {
    //            Cameras[i].enabled = false;
    //        }
    //        Cameras[4].enabled = true;
    //    }
    //    if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha6))
    //    {
    //        for (int i = 0; i <= Cameras.Length; i++)
    //        {
    //            Cameras[i].enabled = false;
    //        }
    //        Cameras[5].enabled = true;
    //    }
    //    if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha7))
    //    {
    //        for (int i = 0; i <= Cameras.Length; i++)
    //        {
    //            Cameras[i].enabled = false;
    //        }
    //        Cameras[6].enabled = true;
    //    }
    //    if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha8))
    //    {
    //        for (int i = 0; i <= Cameras.Length; i++)
    //        {
    //            Cameras[i].enabled = false;
    //        }
    //        Cameras[7].enabled = true;
    //    }
    //    if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha9))
    //    {
    //        for (int i = 0; i <= Cameras.Length; i++)
    //        {
    //            Cameras[i].enabled = false;
    //        }
    //        Cameras[8].enabled = true;
    //    }
    //    if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.LeftShift))
    //    {
    //        for (int i = 0; i <= Cameras.Length; i++)
    //        {
    //            Cameras[i].enabled = false;
    //        }
    //        Cameras[9].enabled = true;
    //    }
    //    if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha2) && Input.GetKeyDown(KeyCode.LeftShift))
    //    {
    //        for (int i = 0; i <= Cameras.Length; i++)
    //        {
    //            Cameras[i].enabled = false;
    //        }
    //        Cameras[10].enabled = true;
    //    }
    //}
}

