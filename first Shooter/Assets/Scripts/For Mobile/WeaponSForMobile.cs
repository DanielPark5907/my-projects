using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSForMobile : MonoBehaviour {
	public int weaponSwitch = 0;
	public int openWeapon =1;
	public Text ChamberText;
	private WeaponForMobile wp;

	void Start () {
		SelectWeapon ();
		StartCoroutine (Recharge ());
	}

	void Update () {
		//int currentWeapon = weaponSwitch;

		if (weaponSwitch > openWeapon - 1) {
			weaponSwitch = 0;
		}

		ChamberText.text = wp.bulletsChamber + "/" + wp.bulletsMax;
		if(weaponSwitch==0)
			SelectWeapon ();
	}



	void SelectWeapon(){
		int i = 0;
		foreach (Transform weapon in transform) {
			if (i == weaponSwitch) {
				weapon.gameObject.SetActive (true);
				wp = weapon.gameObject.GetComponent<WeaponForMobile> ();
			}else
				weapon.gameObject.SetActive (false);
			i++;
		}
	}

	public void SwitchButton(){
		weaponSwitch++;
		Debug.Log ("wpSwith:"+weaponSwitch);
		SelectWeapon ();
	}

	public void ShootButtonDown(){
		if (wp.bulletsChamber > 0) {
			if (Time.time > wp.nextFire) {
				wp.bulletsChamber--;
				wp.nextFire = Time.time + 1f / wp.fireRate;
				wp.Shoot ();
			}
		}
	}

	public void RechargeButton(){
		StartCoroutine (WaitASeconds (wp.seconds));
	}

	IEnumerator WaitASeconds(float wait){
		if (wp.bulletsChamber != wp.bulletsMax) {
			Debug.Log ("перезарядка...");
			wp.AS.PlayOneShot (wp.RechargeSound);
			yield return new WaitForSeconds (wait);
			wp.bulletsChamber = wp.bulletsMax;
		}
	}

	IEnumerator Recharge(){
		if (wp.bulletsChamber > 0) {
			yield return new WaitForSeconds (0.5f);
			StartCoroutine (Recharge ());
			Debug.Log ("Все ок");
		}else {
			Debug.Log ("перезарядка...");
			wp.AS.PlayOneShot (wp.RechargeSound);
			yield return new WaitForSeconds (wp.seconds);
			wp.bulletsChamber = wp.bulletsMax;
			StartCoroutine (Recharge ());
		}
	}
}
