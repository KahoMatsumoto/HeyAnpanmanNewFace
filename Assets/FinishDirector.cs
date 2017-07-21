using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishDirector : MonoBehaviour {

	private NanoKontrol2 nanoKontrol2;

    public string S_Button = "S1";
	// Use this for initialization
	void Start () {
		nanoKontrol2 = GameObject.Find("NanoKontrol2").GetComponent<NanoKontrol2>();
        gameObject.transform.position =new Vector3(0, 100, 0);
        //GameObject.Find("correct").gameObject.SetActive(false);
		nanoKontrol2.keyPushedFunctions.Add(nanoKontrol2_keyPushed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void nanoKontrol2_keyPushed(string keyName)
	{
		if (S_Button == keyName)
		{
            gameObject.transform.position = new Vector3(0, -0.85f, -0.06f);
            //GameObject.Find("correct").gameObject.SetActive(true);
			//renderer.material.color = Color.blue;
		}


	}
}
