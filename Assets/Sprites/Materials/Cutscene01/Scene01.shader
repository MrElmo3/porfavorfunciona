// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "SceneShader/Cutscene01"
{
    Properties
    {
        // we have removed support for texture tiling/offset,
        // so make them not be displayed in material inspector
        [NoScaleOffset] _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Pass
        {
            CGPROGRAM
            // use "vert" function as the vertex shader
            #pragma vertex vert
            // use "frag" function as the pixel (fragment) shader
            #pragma fragment frag

            // vertex shader inputs
            struct appdata
            {
                float4 vertex : POSITION; // vertex position
                float2 uv : TEXCOORD0; // texture coordinate
            };

            // vertex shader outputs ("vertex to fragment")
            struct v2f
            {
                float2 uv : TEXCOORD0; // texture coordinate
                float4 vertex : SV_POSITION; // clip space position
            };

            // vertex shader
            v2f vert (appdata v)
            {
                v2f o;
                // transform position to clip space
                // (multiply with model*view*projection matrix)
                o.vertex = UnityObjectToClipPos(v.vertex);
                // just pass the texture coordinate
                o.uv = v.uv;
                return o;
            }
            
            // texture we will sample
            sampler2D _MainTex;

            // pixel shader; returns low precision ("fixed4" type)
            // color ("SV_Target" semantic)
            
            float3 mod(float3 uv, float res){
                return uv-res*floor(uv/res);
            }

            float snoise(float3 uv, float res)
            {
                static float3 s = float3(1e0, 1e2, 1e3);
                
                uv *= res;
                
                float3 uv0 = floor(mod(uv, res))*s;
                float3 uv1 = floor(mod(uv+float3(1,1,1), res))*s;
                
                float3 f = frac(uv); f = f*f*(3.0-2.0*f);

                float4 v = float4(uv0.x+uv0.y+uv0.z, uv1.x+uv0.y+uv0.z,
                            uv0.x+uv1.y+uv0.z, uv1.x+uv1.y+uv0.z);

                float4 r = frac(sin(v*1e-1)*1e3);
                float r0 = lerp(lerp(r.x, r.y, f.x), lerp(r.z, r.w, f.x), f.y);
                
                r = frac(sin((v + uv1.z - uv0.z)*1e-1)*1e3);
                float r1 = lerp(lerp(r.x, r.y, f.x), lerp(r.z, r.w, f.x), f.y);
                
                return lerp(r0, r1, f.z)*2.-1.;
            }

    

            fixed4 frag (v2f i) : SV_Target
            {
                // sample texture and return it
                // fixed4 col = lerp( tex2D(_MainTex, i.uv) , abs(sin(_Time.y)) , 0.3 ) ;
                float2 p = -.5 + i.uv;
                // p.x *= iResolution.x/iResolution.y;
                
                float color = 3.0 - (3.*length(2.*p));
                
                float3 coord = float3(atan2(p.y,p.x)/6.2832+.5, length(p)*.4, .5);
                
                for(int i = 1; i <= 7; i++)
                {
                    float power = pow(2.0, float(i));
                    color += (1.5 / power) * snoise(coord + float3(0.,-_Time.y*.05, _Time.y*.01), power*16.);
                }
                return float4( color, pow(max(color,0.),2.)*0.4, pow(max(color,0.),3.)*0.15 , 1.0);
                
            }
            ENDCG
        }
    }

}
