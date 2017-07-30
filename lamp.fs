#version 330 core
out vec4 FragColor;
in vec2 TexCoord;

uniform vec3 objectColor;
uniform vec3 lightColor;

void main()
{
	//Make light bright.
	FragColor = vec4(1.0);
}