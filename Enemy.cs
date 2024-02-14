public class playerScript : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

       transform.LookAt(target.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        player.TakeDamage(playerDamage);
    }
}
