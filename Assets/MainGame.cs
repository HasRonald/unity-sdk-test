using UnityEngine;
using System.Collections;
using TuneSDK;

public class MainGame : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Tune.Init ("190163", "198dacaee0fd940d83ad259a27ec6fd5", true);
		Tune.MeasureSession ();

		Tune.SetPushNotificationRegistrationId ("677592355023");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			if (hit) {
				if (hitInfo.transform.gameObject.name == "Cube") {
					Debug.LogError ("+++++++++++++++++++++++");
					Tune.MeasureEvent ("cube_clicked");

					TuneEvent te = new TuneEvent ("cube_clicked");
				}
			}
		} 
	}
}
