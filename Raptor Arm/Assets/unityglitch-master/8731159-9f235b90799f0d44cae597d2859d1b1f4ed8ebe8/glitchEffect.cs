using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
[AddComponentMenu("Image Effects/GlitchEffect")]
public class glitchEffect {
	public Texture2D displacementMap;
	public Material target;
	float glitchup, glitchdown, flicker,
			glitchupTime = 0.05f, glitchdownTime = 0.05f, flickerTime = 0.5f;
	
	public float intensity;
	
	// Called by camera to apply image effect
	void OnRenderImage (RenderTexture source, RenderTexture destination) {
		
		target.SetFloat("_Intensity", intensity);
		target.SetTexture("_DispTex", displacementMap);
		
		glitchup += Time.deltaTime * intensity;
		glitchdown += Time.deltaTime * intensity;
		flicker += Time.deltaTime * intensity;
		
		if(flicker > flickerTime){
			target.SetFloat("filterRadius", Random.Range(-3f, 3f) * intensity);
			flicker = 0;
			flickerTime = Random.value;
		}
		
		if(glitchup > glitchupTime){
			if(Random.value < 0.1f * intensity)
				target.SetFloat("flip_up", Random.Range(0, 1f) * intensity);
			else
				target.SetFloat("flip_up", 0);
			
			glitchup = 0;
			glitchupTime = Random.value/10f;
		}
		
		if(glitchdown > glitchdownTime){
			if(Random.value < 0.1f * intensity)
				target.SetFloat("flip_down", 1-Random.Range(0, 1f) * intensity);
			else
				target.SetFloat("flip_down", 1);
			
			glitchdown = 0;
			glitchdownTime = Random.value/10f;
		}
		
		if(Random.value < 0.05 * intensity){
			target.SetFloat("displace", Random.value * intensity);
			target.SetFloat("scale", 1-Random.value * intensity);
		}else
			target.SetFloat("displace", 0);
		
		Graphics.Blit (source, destination, target);
	}
}