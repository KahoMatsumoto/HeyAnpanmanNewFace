using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsController : MonoBehaviour {

	public string SliderName = "Slider1";
	public string KnobName = "Knob1";
	//public string S_Button = "S1";
	//public string M_Button = "M1";
	//public string R_Button = "R1";

	//nanoKontrol2を宣言
	private NanoKontrol2 nanoKontrol2;
    float posX, posY, posZ;
    float rotX,rotY,rotZ;

	void Start()
	{
		this.posX = transform.position.x;
		this.posY = transform.position.y;
		this.posZ = transform.position.z;
		this.rotX = transform.rotation.x;
		this.rotY = transform.rotation.y;
		this.rotZ = transform.rotation.z;
		//Start()の中でコールバック関数の設定を行う
		nanoKontrol2 = GameObject.Find("NanoKontrol2").GetComponent<NanoKontrol2>();
		nanoKontrol2.valueChangedFunctions.Add(nanoKontrol2_valueChanged);
	}


	//キー（スライダー・ノブ）の値が変更された場合に呼び出される関数
	public void nanoKontrol2_valueChanged(string keyName, int keyValue)
	{

		if (keyName == SliderName)
		{
			transform.position = new Vector3(transform.position.x, keyValue * 0.02f -2.5f , transform.position.z);
		}

		if (keyName == KnobName)
		{
            transform.rotation = Quaternion.Euler(rotX+keyValue*200/128-45, rotY,rotZ);
		}




	}



	//スライダーやノブの値の取得
	void Update()
	{
		//Debug.Log (nanoKontrol2.Slider1);
		//Debug.Log (nanoKontrol2.Slider2);
		//Debug.Log (nanoKontrol2.knob1);
		//Debug.Log (nanoKontrol2.knob2);
        Debug.Log(rotY);
	}




}
