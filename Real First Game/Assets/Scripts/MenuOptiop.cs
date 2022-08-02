using UnityEngine;

public class MenuOptiop : MonoBehaviour {

	public void SetQuality(int qualityIndex){
		QualitySettings.SetQualityLevel (qualityIndex);
	}
}
