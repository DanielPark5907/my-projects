using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class TextOfMusic : MonoBehaviour {
	[SerializeField] private Text Music;
	private IEnumerator rutine;
	public float TextSpeed;
	public AudioSource AudioMusic;


	private void Start(){
		rutine = TextMusic (TextSpeed);
	}

	private void Update(){
		if (Input.GetKeyUp (KeyCode.M)) {
			Debug.Log ("Music text started");
			StartCoroutine (rutine);
		} else if (Input.GetKeyUp (KeyCode.K)) {
			StopCoroutine (rutine);
			Debug.Log ("Music text stopped");
		} else if (Input.GetKey (KeyCode.UpArrow)){
			AudioMusic.volume = AudioMusic.volume + 0.1f;;
			Debug.Log ("+Звук:" + AudioMusic.volume);
		}else if (Input.GetKey (KeyCode.DownArrow)) {
			AudioMusic.volume = AudioMusic.volume - 0.1f;
			Debug.Log ("-Звук:"+ AudioMusic.volume);
		}
			
			
	}

	private IEnumerator TextMusic(float Wait){
		while (true) {
			yield return new WaitForSeconds (Wait);
			Music.text = "У тебя самые обычные глаза...";
			yield return new WaitForSeconds (Wait);
			Music.text = "И твой ебучий красный шарф меня только душит...";
			yield return new WaitForSeconds (Wait);
			Music.text = "А твоя душа очень глубокая душа...";
			yield return new WaitForSeconds (Wait);
			Music.text = "Оказалась не глубжи лужи";
			yield return new WaitForSeconds (10f);
			Music.text = "У тебя самые красивые глаза";
			yield return new WaitForSeconds (Wait);
			Music.text = "И твой ебучий красный шарф совсем не ебучий";
			yield return new WaitForSeconds (Wait);
			Music.text = "Твоя не очень-то глубокая душа";
			yield return new WaitForSeconds (Wait);
			Music.text = "Навреное,была самой лучшей";
			yield return new WaitForSeconds (15f);
		}
	}
}
