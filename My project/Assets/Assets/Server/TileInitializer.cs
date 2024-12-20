using UnityEngine;

public class TileInitializer : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError($"[TileInitializer] {gameObject.name}에 SpriteRenderer가 없습니다!");
        }
    }

    public void SetSprite(Sprite sprite, Vector2 targetSize)
    {
        if (spriteRenderer == null || sprite == null)
        {
            Debug.LogError($"[TileInitializer] 스프라이트를 설정할 수 없습니다. {gameObject.name}");
            return;
        }

        spriteRenderer.sprite = sprite;
        ResizeSpriteToTargetSize(targetSize);
    }

    private void ResizeSpriteToTargetSize(Vector2 targetSize)
    {
        if (spriteRenderer.sprite == null)
        {
            Debug.LogWarning($"[TileInitializer] {gameObject.name}의 스프라이트가 없습니다.");
            return;
        }

        Vector2 spriteSize = spriteRenderer.sprite.bounds.size;
        Vector3 scale = transform.localScale;
        scale.x = targetSize.x / spriteSize.x;
        scale.y = targetSize.y / spriteSize.y;
        transform.localScale = scale;

        Debug.Log($"[TileInitializer] {gameObject.name} 스프라이트 크기를 {targetSize}에 맞게 조정했습니다.");
    }
}
