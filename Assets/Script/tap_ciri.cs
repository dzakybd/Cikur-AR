using UnityEngine;
using UnityEngine.UI;

// This script will spawn a prefab when you tap the screen
public class tap_ciri : MonoBehaviour
{
	// This stores the layers we want the raycast to hit (make sure this GameObject's layer is included!)
	public LayerMask LayerMask = UnityEngine.Physics.DefaultRaycastLayers;
	public GameObject detail;
	public Text txt;
    public Text deskrip;
    public Image imagetut;

    public string deskripsi;
    public string image_path;
	// This stores the finger that's currently dragging this GameObject
	private Lean.LeanFinger draggingFinger;
	
	protected virtual void OnEnable()
	{
		// Hook into the OnFingerDown event
		Lean.LeanTouch.OnFingerDown += OnFingerDown;
		
		// Hook into the OnFingerUp event
		Lean.LeanTouch.OnFingerUp += OnFingerUp;
	}
	
	protected virtual void OnDisable()
	{
		// Unhook the OnFingerDown event
		Lean.LeanTouch.OnFingerDown -= OnFingerDown;
		
		// Unhook the OnFingerUp event
		Lean.LeanTouch.OnFingerUp -= OnFingerUp;
	}
	
	protected virtual void LateUpdate()
	{
		// If there is an active finger, move this GameObject based on it
		if (draggingFinger != null)
		{
            
            imagetut.sprite = Resources.Load<Sprite>(image_path);
            deskrip.text = deskripsi;
            detail.SetActive(true);
            txt.text = "Close";
			// Lean.LeanTouch.MoveObject(transform, draggingFinger.DeltaScreenPosition);
		}
	}
	
	public void OnFingerDown(Lean.LeanFinger finger)
	{
		// Raycast information
		var ray = finger.GetRay();
		var hit = default(RaycastHit);
		
		// Was this finger pressed down on a collider?
		if (Physics.Raycast(ray, out hit, float.PositiveInfinity, LayerMask) == true)
		{
			// Was that collider this one?
			if (hit.collider.gameObject == gameObject)
			{
				// Set the current finger to this one
				draggingFinger = finger;
			}
		}
	}
	
	public void OnFingerUp(Lean.LeanFinger finger)
	{
		// Was the current finger lifted from the screen?
		if (finger == draggingFinger)
		{
			// Unset the current finger
			draggingFinger = null;
		}
	}
}
