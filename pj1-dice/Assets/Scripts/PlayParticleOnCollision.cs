using UnityEngine;

public class PlayParticleOnCollision : MonoBehaviour
{
	public ParticleSystem[] particles;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    private void OnCollisionEnter( Collision collision )
	{
		foreach( var particle in particles )
		{
			particle.Play();
		}
	}
}
