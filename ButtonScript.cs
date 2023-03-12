using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {
	
//deklarasi

	public GameObject karakter;
	public int idButton;

	public float moveSpeed = 0.05f;
	private Animator anim;

	public bool atas, bawah, kanan, kiri;

	// Use this for initialization
	void Start () {
		anim = karakter.GetComponent<Animator>();
		atas = false;
		bawah = false;
		kanan = false;
		kiri = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (atas){
			karakter.transform.position = karakter.transform.position 
											+ new Vector3(0, moveSpeed, 0);
		}
		else if (bawah){
			karakter.transform.position = karakter.transform.position 
											- new Vector3(0, moveSpeed, 0);
		}
		else if (kanan){
			karakter.transform.position = karakter.transform.position 
											+ new Vector3(moveSpeed, 0, 0);
		}
		else if (kiri){
			karakter.transform.position = karakter.transform.position 
											- new Vector3(moveSpeed, 0, 0);
		}


	}

	private void OnMouseDown (){
		if (idButton == 1){
			atas = true;
			anim.SetBool("KeAtas", true);
		}
		else if (idButton == 2){
			bawah = true;
			anim.SetBool("KeBawah", true);
		}
		else if (idButton == 3){
			kanan = true;
			anim.SetBool("KeKanan", true);
		}
		else if (idButton == 4){
			kiri = true;
			anim.SetBool("KeKiri", true);
		}
	}
//=====================================================
/*	
	private void OnMouseDrag (){
		
	}
*/
//=======================================================
	private void OnMouseUp (){
		if (idButton == 1 || idButton == 2 || idButton == 3 || idButton == 4){
			karakter.transform.position = karakter.transform.position;
			anim.SetBool("KeAtas", false);
			anim.SetBool("KeBawah", false);
			anim.SetBool("KeKanan", false);
			anim.SetBool("KeKiri", false);

			atas = false;
			bawah = false;
			kanan = false;
			kiri = false;
		}
	}
}
