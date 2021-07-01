public class WallBump : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
    }

    // コライダーとの接触時に呼ばれるコールバック
    void OnCollisionEnter(Collision hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
            Debug.Log("bbb");
        }
    }
}
