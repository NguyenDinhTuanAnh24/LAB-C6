using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    
    // Tối ưu hóa: Chuyển tên tham số sang mã băm (Hash) để máy đọc nhanh hơn
    private int speedHash = Animator.StringToHash("Speed");
    private int attackHash = Animator.StringToHash("Attack");

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Đọc phím mũi tên
        float move = Mathf.Abs(Input.GetAxisRaw("Horizontal"));
        
        // Cập nhật Speed vào Animator
        anim.SetFloat(speedHash, move);

        // Nhấn Space để kích hoạt Attack
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger(attackHash);
        }
    }
}