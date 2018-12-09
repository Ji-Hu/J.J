using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pose = Thalmic.Myo.Pose;

public class ui : MonoBehaviour {
  
    public GameObject myo = null;
    public Image image;
    public Image fist;
    public Image wave;
    public Image more;
    public int flag = 0;
    //public GameObject imageprefab;

    public Text timeLabel;
    public float timeCount = 0;

    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo>();
       //imageprefab.SetActive(true);

        if (thalmicMyo.pose == Pose.DoubleTap)
        {
            image.gameObject.SetActive(false);
            timeCount = 1;
            fist.gameObject.SetActive(true);
        }
        if (thalmicMyo.pose == Pose.Fist && flag==0)
        {
            fist.gameObject.SetActive(false);
            flag++;
            wave.gameObject.SetActive(true);
        }
        if (thalmicMyo.pose == Pose.WaveIn)
        {
            wave.gameObject.SetActive(false);
            more.gameObject.SetActive(false);
            flag++;

        }
        /*if(timeCount!=0)iocx
        {
            timeCount += timeCount.deltaTime;
            timeLabel.text = timeCoount.ToString();
        }
*/
	}
}
