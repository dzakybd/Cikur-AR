using UnityEngine;
using UnityEngine.UI;

// This script will spawn a prefab when you tap the screen
public class tap_ciri1 : MonoBehaviour
{
	public GameObject detail;
	public Text txt;
    public Text deskrip;
    public Image imagetut;

    protected virtual void OnEnable()
	{
		// Hook into the OnFingerTap event
		Lean.LeanTouch.OnFingerTap += OnFingerTap;
	}
	
	protected virtual void OnDisable()
	{
		// Unhook into the OnFingerTap event
		Lean.LeanTouch.OnFingerTap -= OnFingerTap;
	}
	
	public void OnFingerTap(Lean.LeanFinger finger)
	{

		// Make sure the finger isn't over any GUI elements
		if (finger.IsOverGui == false)
		{
            imagetut.sprite = Resources.Load<Sprite>("tut1");
            deskrip.text = "ewdwedwedwedw";
            detail.SetActive(true);
    
			txt.text = "Close";
		}
	}
}
