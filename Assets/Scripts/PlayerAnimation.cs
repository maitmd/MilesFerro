using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    [SerializeField] private Sprite[] idleAnimate;
    [SerializeField] private Sprite[] moveAnimate;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}

	public void walkAnimation(Vector2 direction){
        spriteRenderer.sprite = moveAnimate[VectorToArray(direction, moveAnimate.Length)];
    }

    public void idleAnimation(Vector2 direction) {
        spriteRenderer.sprite = idleAnimate[VectorToArray(direction, idleAnimate.Length)];
    }

    public int VectorToArray(Vector2 direction, int slices){ 
        float step = 360 / slices;
        float halfStep = step / 2;
        float angle = Vector2.SignedAngle(Vector2.up, direction);
        angle += halfStep;
        
        if(angle < 0) {
            angle += 360;
        }

        float stepCount = angle / step;
        return Mathf.FloorToInt(stepCount);
    }
}
